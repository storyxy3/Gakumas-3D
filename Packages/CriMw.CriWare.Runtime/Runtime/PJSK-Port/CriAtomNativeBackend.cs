using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace CriWare
{
    // Managed implementation of the JP7 Atom ABI. The host supplies original
    // files and an output clock; the recovered game classes keep their lifecycle.
    public sealed partial class CriAtomNativeBackend : ICriWareNativeBackend, IDisposable
    {
        private readonly Func<string, byte[]> readFile;
        private readonly Dictionary<IntPtr, object> objects = new Dictionary<IntPtr, object>();
        private readonly Dictionary<string, IntPtr> strings = new Dictionary<string, IntPtr>(StringComparer.Ordinal);
        private int nextHandle = 1;
        private bool fileSystemInitialized, atomInitialized, disposed, paused;
        private bool configured;
        private int virtualVoices = 32, memoryVoices = 16, streamingVoices = 8;
        private int maximumBinders = 8;
        private int maximumSamplingRate = 192000;
        private ulong cipherKey;
        private CriErrorNotifier.ErrorCallbackFunc errorCallback;
        private readonly CriErrorNotifier.ErrorCallbackFunc defaultErrorCallback;
        private readonly IntPtr defaultErrorPointer = new IntPtr(-1);
        private CriAtomUtf.Row? acf;
        private CriAtomMixer mixer;
        private string dspSetting;
        private readonly Dictionary<string, uint> aisacControls = new Dictionary<string, uint>(StringComparer.Ordinal);

        public int SampleRate { get; private set; } = 48000;
        public float ServerFrequency { get; private set; } = 120f;
        public bool IsInitialized => atomInitialized;

        // nowUs is the platform monotonic clock (microseconds) read at the time
        // of every audio-synced getter call, as F32D0 reads sub_19FDC8. It must
        // share the origin of the timestamps passed to SetOutputProgress. Without
        // it, getters use the latest committed output timestamp.
        private readonly Func<long> nowUs;

        public CriAtomNativeBackend(Func<string, byte[]> readFile, Func<long> nowUs = null)
        {
            this.readFile = readFile ?? throw new ArgumentNullException(nameof(readFile));
            this.nowUs = nowUs;
            defaultErrorCallback = (message, p1, p2, array) => CriErrorNotifier.CallEvent(Marshal.PtrToStringAnsi(message));
        }

        private IntPtr AddObject(object value)
        {
            if (disposed) throw new ObjectDisposedException(nameof(CriAtomNativeBackend));
            var handle = new IntPtr(nextHandle++);
            objects.Add(handle, value);
            return handle;
        }

        private T Get<T>(IntPtr handle) where T : class
        {
            if (objects.TryGetValue(handle, out var value) && value is T result) return result;
            Report("E:Invalid CRI Atom handle.");
            return null;
        }

        private IntPtr StringPointer(string value)
        {
            if (value == null) return IntPtr.Zero;
            if (!strings.TryGetValue(value, out var pointer))
            {
                pointer = Marshal.StringToHGlobalAnsi(value);
                strings.Add(value, pointer);
            }
            return pointer;
        }

        private void Report(string message)
        {
            if (errorCallback != null) errorCallback(StringPointer(message), 0, 0, IntPtr.Zero);
            else CriErrorNotifier.CallEvent(message);
        }

        private bool RequireAtom()
        {
            if (atomInitialized) return true;
            Report("E:Atom library is not initialized.");
            return false;
        }

        private static void RequireAutomaticWork(IntPtr work, int size)
        {
            if (work != IntPtr.Zero || size != 0)
                throw new NotSupportedException("Caller-supplied native work memory cannot be used by the managed Atom backend.");
        }

        public int CRIWARECE8DBD94() => 0x01010301;
        public void criWareUnity_SetRenderingEventOffsetForMana(int offset) => manaRenderingEventOffset = offset;

        private sealed class Binder { }
        public void CRIWARED671D92C(int num_loaders, int num_binders, int num_installers, int max_path,
            bool minimize_file_descriptor_usage, bool enable_crc_check)
        {
            if (fileSystemInitialized) { Report("E:File system is already initialized."); return; }
            maximumBinders = num_binders;
        }
        public void criFsUnity_SetConfigAdditionalParameters_ANDROID(int device_read_bps) { }
        public void CRIWARE8B8CF7AE() => fileSystemInitialized = true;
        public void CRIWARE60FEBD39() => fileSystemInitialized = false;
        public bool CRIWARE7DA1D7FD() => fileSystemInitialized;
        public bool CRIWARED4C30199(string userAgentString) => fileSystemInitialized;
        public uint criFsBinder_Create(out IntPtr binder)
        {
            binder = IntPtr.Zero;
            int count = 0;
            foreach (var value in objects.Values) if (value is Binder) count++;
            if (!fileSystemInitialized || count >= maximumBinders) return 1;
            binder = AddObject(new Binder());
            return 0;
        }
        public uint criFsBinder_Destroy(IntPtr binder) => objects.Remove(binder) ? 0u : 1u;

        public void CRIWARE893F494B(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs,
            byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame,
            int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices,
            int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate,
            int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency,
            int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch,
            CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common)
        {
            if (atomInitialized) { Report("E2014071630:Atom library is initialized."); return; }
            if (num_asr_output_channels != 0 && num_asr_output_channels != 2)
                throw new NotSupportedException("The original archive audio configuration is stereo.");
            if (num_hca_mx_memory_voices != 0 || num_hca_mx_streaming_voices != 0)
                throw new NotSupportedException("HCA-MX voice pools are outside the original archive configuration.");
            if (max_virtual_voices < 1 || max_virtual_voices > 32768)
                throw new ArgumentOutOfRangeException(nameof(max_virtual_voices));
            int sampleRate = output_sampling_rate == 0 ? 48000 : output_sampling_rate;
            if (sampleRate < 1) throw new ArgumentOutOfRangeException(nameof(output_sampling_rate));
            if (server_frequency < 1 || server_frequency > sampleRate || !float.IsFinite(server_frequency))
                throw new ArgumentOutOfRangeException(nameof(server_frequency));
            if (num_standard_memory_voices < 0 || num_standard_streaming_voices < 0)
                throw new ArgumentOutOfRangeException(nameof(num_standard_memory_voices));
            virtualVoices = max_virtual_voices; memoryVoices = num_standard_memory_voices;
            streamingVoices = num_standard_streaming_voices;
            SampleRate = sampleRate;
            maximumSamplingRate = checked((int)(float)(sampleRate * (float)Math.Pow(2, (float)(max_pitch / 1200f))));
            ServerFrequency = server_frequency;
            configured = true;
        }
        // These platform options are emitted by the Android managed wrapper on
        // every host. Device-buffer transport is supplied by the browser host.
        public void CRIWAREA1992BC3(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval) { }
        public void CRIWARE7402012B(bool enable_user_pcm_out_mode) { }
        public void CRIWARE88F0008E(long buffering_time_pc, bool use_microsoft_spatial_sound) { }
        public void CRIWAREC2F00A9B(int output, int pulse_latency_usec) { }
        public void CRIWAREA69F40B7(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios) { }
        public void CRIWAREB8664B63(bool enable_sonicsync, int num_low_delay_memory_voices,
            int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time,
            bool apply_hw_property, int stream_type)
        {
            if (num_low_delay_memory_voices != 0 || num_low_delay_streaming_voices != 0)
                throw new NotSupportedException("Android low-delay hardware voice pools are unavailable in the browser.");
        }
        public void CRIWAREB09AD891(IntPtr android_context) { }
        public void CRIWAREF27CB8CB(bool flag) { }
        public void CRIWARE2EA3E3EA()
        {
            if (atomInitialized) { Report("E2012101211:Atom library is already initialized."); return; }
            if (!fileSystemInitialized) throw new InvalidOperationException("Atom requires initialized CRI Fs.");
            if (!configured) ServerFrequency = 60f;
            InitializePlaybackPool();
            pendingOffset = pendingFrames = 0;
            drainedPcm.Clear(); outputClockOffsetUs = serverClockOffsetUs = 0;
            renderedFrames = playedFrames = nextServerTick = nextVoiceOrder = nextSourceOrder = nextSequenceOrder = previousServerUs = previousAsrUs = audioTimestampUs = 0;
            previousFaderMs = 0;
            paused = false;
            mixer = new CriAtomMixer(null, null, SampleRate);
            atomInitialized = true;
        }
        public void CRIWARE350A7D20()
        {
            if (!atomInitialized) return;
            StopAllPlaybacks();
            criAtomEx_UnregisterAcf();
            retiredVoices.Clear();
            drainedPcm.Clear();
            pendingOffset = pendingFrames = 0;
            atomInitialized = false;
        }
        public bool CRIWARE5DA58264() => atomInitialized;
        public void CRIWARE8BB08498(IntPtr cbfunc)
        {
            if (cbfunc != IntPtr.Zero) throw new NotSupportedException("Native PCM callback pointers cannot be installed in the managed Atom backend.");
        }
        public ushort CRIWARECC7FD29F(int id) => id == 0 ? (ushort)156 : ushort.MaxValue;
        public void CRIWAREF96375A3(bool pause) => paused = pause;
        public void CRIWAREB9EDC2C9() { }
        public void CRIWARE6376514D() { }
        public void CRIWARE1982DA00() { }
        public bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface)
        {
            if (afx_interface != IntPtr.Zero) throw new NotSupportedException("Native DSP plugins cannot be loaded in a managed Atom backend.");
            return false;
        }
        public void criAtomLatencyEstimator_Finalize_ANDROID() { }
        public CriAtomExLatencyEstimator.EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID() => default;

        public void criAtomEx_SetRandomSeed(uint seed) => ResetRandomSeed(seed);
        public int CRIWARE6B3B300F(bool enable_atom_decryption, bool enable_mana_decryption,
            CriWareDecrypter.CallbackFromNativeDelegate func, IntPtr obj)
        {
            cipherKey = 0;
            if (!enable_atom_decryption && !enable_mana_decryption) return 1;
            if (func == null) return 0;
            ulong key = func(obj) ^ 0xD47EB533AEF7E5UL;
            cipherKey = enable_atom_decryption ? key : 0;
            // The selected USM streams are plaintext. Accept the original
            // shared decrypter setup without treating plain video as encrypted.
            return key == 0 ? 0 : 1;
        }

        public void criErr_SetCallback(IntPtr callback)
        {
            errorCallback = callback == IntPtr.Zero ? null : callback == defaultErrorPointer ? defaultErrorCallback :
                Marshal.GetDelegateForFunctionPointer<CriErrorNotifier.ErrorCallbackFunc>(callback);
        }
        public void criErr_SetCallback(CriErrorNotifier.ErrorCallbackFunc callback) => errorCallback = callback;
        public IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2) => errmsgPtr;
        public IntPtr CRIWAREC0ED7C62()
        {
            return defaultErrorPointer;
        }

        private sealed class Spatial
        {
            internal bool Listener;
            internal CriAtomEx3dSource.Config Config;
            internal CriAtomEx.NativeVector Position, Velocity, Front = new CriAtomEx.NativeVector(0, 0, 1), Top = new CriAtomEx.NativeVector(0, 1, 0);
            internal CriAtomEx.NativeVector AppliedPosition, AppliedVelocity, AppliedFront = new CriAtomEx.NativeVector(0, 0, 1), AppliedTop = new CriAtomEx.NativeVector(0, 1, 0);
            internal CriAtomEx.Randomize3dConfig? Random;
            internal IntPtr Region;
            internal void Apply() { AppliedPosition = Position; AppliedVelocity = Velocity; AppliedFront = Front; AppliedTop = Top; }
        }
        public IntPtr criAtomEx3dSource_Create(ref CriAtomEx3dSource.Config config, IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            return RequireAtom() ? AddObject(new Spatial { Config = config }) : IntPtr.Zero;
        }
        public void criAtomEx3dSource_Destroy(IntPtr ex_3d_source) => objects.Remove(ex_3d_source);
        public void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region)
        { var source = Get<Spatial>(ex_3d_source); if (source != null) source.Region = ex_3d_region; }
        public void criAtomEx3dSource_Update(IntPtr ex_3d_source) => Get<Spatial>(ex_3d_source)?.Apply();
        public void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position)
        { var source = Get<Spatial>(ex_3d_source); if (source != null) source.Position = position; }
        public void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity)
        { var source = Get<Spatial>(ex_3d_source); if (source != null) source.Velocity = velocity; }
        public void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top)
        { var source = Get<Spatial>(ex_3d_source); if (source != null) { source.Front = front; source.Top = top; } }
        public void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config)
        { var source = Get<Spatial>(ex_3d_source); if (source != null) source.Random = config; }
        public void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config)
        {
            if (config != IntPtr.Zero) throw new NotSupportedException("A managed random-position structure is required.");
            var source = Get<Spatial>(ex_3d_source); if (source != null) source.Random = null;
        }
        public IntPtr criAtomEx3dListener_Create(ref CriAtomEx3dListener.Config config, IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            return RequireAtom() ? AddObject(new Spatial { Listener = true }) : IntPtr.Zero;
        }
        public void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener) => objects.Remove(ex_3d_listener);
        public void criAtomEx3dListener_Update(IntPtr ex_3d_listener) => Get<Spatial>(ex_3d_listener)?.Apply();
        public void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position) => criAtomEx3dSource_SetPosition(ex_3d_listener, ref position);
        public void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity) => criAtomEx3dSource_SetVelocity(ex_3d_listener, ref velocity);
        public void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top) => criAtomEx3dSource_SetOrientation(ex_3d_listener, ref front, ref top);
        public void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region) => criAtomEx3dSource_Set3dRegionHn(ex_3d_listener, ex_3d_region);

        private sealed class Analyzer
        {
            internal CriAtomExOutputAnalyzer.Config Config;
            internal CriAtomLevelMeter Meter;     // analyzer +0 (sub_12C7D8), null without enableLevelmeter
        }
        // criAtomExOutputAnalyzer_Create 0x34530. The level meter always uses
        // the fixed internal {channels=2, rate=48000} configuration.
        public IntPtr criAtomExOutputAnalyzer_Create(ref CriAtomExOutputAnalyzer.Config config)
        {
            if (!RequireAtom()) return IntPtr.Zero;
            bool spectrum = config.enableSpectrumAnalyzer && config.numSpectrumAnalyzerBands > 0;
            bool capture = config.enablePcmCapture && config.numCapturedPcmSamples != 0;
            if (!config.enableLevelmeter && !spectrum && !capture)
            {
                Report("E2018012401:Invalid output analyzer configuration.");
                return IntPtr.Zero;
            }
            return AddObject(new Analyzer { Config = config, Meter = config.enableLevelmeter ? new CriAtomLevelMeter(48000) : null });
        }
        public void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer)
        {
            if (objects.TryGetValue(analyzer, out var value) && value is Analyzer target)
                foreach (var player in players) if (player.Analyzer == target) player.Analyzer = null;
            objects.Remove(analyzer);
        }
        // AttachExPlayer 0x349F0 / DetachExPlayer 0x34A1C: sub_FA100 writes the
        // player's filter callback (+552/+560); detaching clears it whatever
        // analyzer was installed.
        public void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player)
        {
            var value = Get<Analyzer>(analyzer); var target = Get<Player>(player);
            if (value != null && target != null) target.Analyzer = value;
        }
        public void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player)
        {
            var target = Get<Player>(player);
            if (target != null) target.Analyzer = null;
        }
        public void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName) { }
        // criAtomExOutputAnalyzer_GetRms 0x34A5C.
        public float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel)
        {
            var value = Get<Analyzer>(analyzer);
            if (value == null) return 0f;
            if (value.Meter == null) { Report("E2016021501:Level Meter is not created."); return 0f; }
            return value.Meter.Read(channel);
        }

        public void Dispose()
        {
            if (disposed) return;
            CRIWAREEA336D77();
            CRIWARE350A7D20();
            objects.Clear();
            players.Clear(); banks.Clear(); retiredVoices.Clear(); drainedPcm.Clear();
            playbacks = null; generations = null; freePlaybackSlots = null;
            voiceSlots = null;
            globalRandom = null; mixer = null; acf = null;
            aisacControls.Clear(); ClearCategories(); ClearAisacs();
            foreach (var pointer in strings.Values) Marshal.FreeHGlobal(pointer);
            strings.Clear();
            errorCallback = null;
            fileSystemInitialized = false;
            disposed = true;
        }
    }
}
