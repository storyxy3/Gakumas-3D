using System;
using System.Collections.Generic;
using System.IO;
using CriWare.CriMana;
using ManaStatus = CriWare.CriMana.Player.Status;
using ManaTimer = CriWare.CriMana.Player.TimerType;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class ManaEntry
        {
            internal string Path;
            internal bool Repeat;
        }

        private sealed partial class ManaPlayer
        {
            internal ManaStatus Status;
            internal string Path, CurrentPath, NextPath;
            internal ManaEntry RetainedEntry;
            internal bool HasNextFile;
            internal readonly Queue<ManaEntry> Entries = new Queue<ManaEntry>();
            internal readonly IntPtr[] Tracks = new IntPtr[3];
            internal readonly Queue<ManaFrame> Ready = new Queue<ManaFrame>();
            internal readonly Queue<ManaFrame> Free = new Queue<ManaFrame>();
            internal readonly CriManaClock Clock = new CriManaClock();
            internal CriManaUsm.VideoInfo Video;
            internal CriManaUsm.AudioInfo Audio;
            internal MovieInfo Info;
            internal CriManaMpeg1Decoder Decoder;
            internal int DecodedFrame, FrameBase, SeekFrame, MaxPath;
            internal uint Concatenated, Skipped, SkipRequests, TimeCompensation;
            internal bool Paused, Loop, StartRequested, Attached, Stopping, EndOfVideo, AudioConcatenation;
            internal ulong FileTime, FileTimeUnit = 1;
            internal double FileStartSeconds => FileTime / (double)FileTimeUnit;
            internal ulong TimeCount, TimeUnit = 1000;
            internal ManaFrame Pending, Displayed;
            internal CriMana.Player.CuePointCallbackFromNativeDelegate CueCallback;
            internal ManaTimer Timer = ManaTimer.Audio;
        }

        private readonly ManaPlayer[] manaPlayers = new ManaPlayer[256];
        private bool manaInitialized, manaBufferH264;
        private int manaMaximumDecoders = 32, manaMaximumEntries = 8;
        private int manaRenderingEventOffset = 1129775104;

        public void CRIWARE61D25984(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries)
        {
            if (manaInitialized) { Report("E:Mana library is already initialized."); return; }
            if (num_decoders < 1 || num_decoders >= 256 || num_of_max_entries < 0)
                throw new ArgumentOutOfRangeException(nameof(num_decoders));
            manaMaximumDecoders = num_decoders;
            manaMaximumEntries = num_of_max_entries;
        }

        public void CRIWARECF1918FA()
        {
            if (manaInitialized) { Report("E:Mana library is already initialized."); return; }
            if (!fileSystemInitialized || !atomInitialized)
                throw new InvalidOperationException("Mana requires initialized CRI Fs and Atom.");
            manaInitialized = true;
        }

        public void CRIWAREEA336D77()
        {
            for (int i = 0; i < manaPlayers.Length; i++)
                if (manaPlayers[i] != null) CRIWARE0554C38E(i);
            manaTextures.Clear();
            manaInitialized = false;
        }

        public bool CRIWARE39B9723F() => manaInitialized;
        public uint CRIWARE747D292C() => 32;
        public void criManaUnity_SetConfigAdditionalParameters_ANDROID(bool buffer_h264, bool buffer_vp9)
            => manaBufferH264 = buffer_h264;
        public bool criManaUnity_IsBufferOutputForH264Enabled_ANDROID() => manaBufferH264;
        public bool criManaUnity_IsMediaCodecSupported_ANDROID(int device_type) => false;
        public uint criManaUnity_MediaCodecCreateTexture_ANDROID() => throw ManaHardwareCodecUnavailable();
        public void criManaUnity_MediaCodecDeleteTexture_ANDROID(uint oes_texture) => throw ManaHardwareCodecUnavailable();
        public bool criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(int player_id, uint oes_texture) => throw ManaHardwareCodecUnavailable();
        public void criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(int player_id, uint oes_texture) => throw ManaHardwareCodecUnavailable();
        private static NotSupportedException ManaHardwareCodecUnavailable() =>
            new NotSupportedException("Android MediaCodec textures are unavailable in the managed Mana host.");
        // Cached files use the host resolver; no Android streaming worker is needed.
        public void criMana_UseStreamerManager(bool flag) { }
        public IntPtr criWareUnity_GetRenderEventFunc() => IntPtr.Zero;

        public int CRIWARE069A61A1() => CRIWARED0162744(false, 0);
        public int CRIWARED0162744(bool useAtomExPlayer, uint maxPathLength)
        {
            if (!manaInitialized) { Report("E:Mana library is not initialized."); return -1; }
            int count = 0, free = -1;
            for (int i = 0; i < manaPlayers.Length; i++)
                if (manaPlayers[i] != null) count++;
                else if (free < 0) free = i;
            if (free < 0 || count >= manaMaximumDecoders) return -1;
            var p = new ManaPlayer { MaxPath = Math.Max(256, checked((int)maxPathLength)) };
            p.Clock.SetMode((int)p.Timer);
            if (useAtomExPlayer)
            {
                var config = new CriAtomExPlayer.Config { updatesTime = true, enableAudioSyncedTimer = true, maxAisacs = 8 };
                for (int i = 0; i < p.Tracks.Length; i++)
                    p.Tracks[i] = criAtomExPlayer_Create(ref config, IntPtr.Zero, 0);
            }
            manaPlayers[free] = p;
            return free;
        }

        private ManaPlayer GetMana(int id)
        {
            if (id >= 0 && id < manaPlayers.Length && manaPlayers[id] != null) return manaPlayers[id];
            Report("E2021021622:Could not found the player handle");
            return null;
        }

        public IntPtr criManaUnityPlayer_GetAtomExPlayerByTrackId(int player_id, uint track_id)
        {
            var p = GetMana(player_id);
            return p != null && track_id < p.Tracks.Length ? p.Tracks[track_id] : IntPtr.Zero;
        }

        public void CRIWARE0554C38E(int player_id)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            StopManaAudio(p, true);
            foreach (var track in p.Tracks)
                if (track != IntPtr.Zero) criAtomExPlayer_Destroy(track);
            manaPlayers[player_id] = null;
        }

        public void CRIWARE8F47EE33(int player_id, CriMana.Player.CuePointCallbackFromNativeDelegate cbfunc)
        { var p = GetMana(player_id); if (p != null) p.CueCallback = cbfunc; }

        private bool ValidateManaPath(ManaPlayer p, IntPtr binder, string path)
        {
            if (p == null) return false;
            if (binder != IntPtr.Zero && Get<Binder>(binder) == null) return false;
            return true;
        }

        public void CRIWAREF4FAFD40(int player_id, IntPtr binder, string path)
        {
            var p = GetMana(player_id);
            if (!ValidateManaPath(p, binder, path)) return;
            if (path == null) throw new ArgumentNullException(nameof(path));
            int length = System.Text.Encoding.UTF8.GetByteCount(path);
            if (length > p.MaxPath) { Report("E:Mana movie path exceeds the player path capacity."); return; }
            if (length == p.MaxPath) return;
            ClearManaEntries(p); p.Path = path;
        }

        public bool CRIWARE97D4A74F(int player_id, IntPtr binder, string path, bool repeat)
        {
            var p = GetMana(player_id);
            if (!ValidateManaPath(p, binder, path)) return false;
            if (path != null && System.Text.Encoding.UTF8.GetByteCount(path) >= 256)
            { Report("E2013012108"); return false; }
            int entries = 0;
            foreach (var player in manaPlayers)
                if (player != null) entries += player.Entries.Count + (player.RetainedEntry == null ? 0 : 1);
            if (entries >= manaMaximumEntries) return false;
            p.Entries.Enqueue(new ManaEntry { Path = path, Repeat = repeat });
            return true;
        }

        public void CRIWARE45230ACB(int player_id, int sw)
        { var p = GetMana(player_id); if (p != null) p.Loop = sw != 0; }
        public void CRIWAREBF4EA6F4(int player_id, int seek_frame_no)
        { var p = GetMana(player_id); if (p != null) p.SeekFrame = Math.Max(0, seek_frame_no); }
        public void CRIWAREAE6A37FE(int player_id, bool flag)
        { var p = GetMana(player_id); if (p != null) p.AudioConcatenation = flag; }

        public void CRIWARE1A89BB84(int player_id)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            if (p.Status == ManaStatus.Error || p.Status == ManaStatus.Prep) return;
            if (p.Status == ManaStatus.Playing || p.Status == ManaStatus.Ready)
            { FailMana(p, "Prepare called after the movie was prepared."); return; }
            StopManaAudio(p);
            p.Decoder = null; p.Info = null;
            p.Pending = p.Displayed = null; p.Ready.Clear(); p.Free.Clear();
            p.StartRequested = p.Attached = p.Stopping = p.EndOfVideo = false;
            p.DecodedFrame = p.FrameBase = 0; p.FileTime = 0; p.FileTimeUnit = 1;
            p.Concatenated = p.Skipped = p.SkipRequests = p.TimeCompensation = 0;
            p.Status = ManaStatus.Dechead;
        }

        public void CRIWARE38F608E1(int player_id)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            if (p.Status == ManaStatus.Playing) { FailMana(p, "Start called while the movie is playing."); return; }
            if (p.Status == ManaStatus.Stop || p.Status == ManaStatus.PlayEnd) CRIWARE1A89BB84(player_id);
            p.StartRequested = true; p.Stopping = false;
            if (p.Status == ManaStatus.Ready) StartMana(p);
        }

        public void CRIWAREA6273B3C(int player_id)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            p.Stopping = true; p.StartRequested = false;
            ClearManaEntries(p);
            p.Decoder = null; p.Ready.Clear(); p.Free.Clear(); p.Pending = p.Displayed = null;
            StopManaAudio(p);
            p.Clock.Stop((ulong)audioTimestampUs);
        }

        public void CRIWARE10F14332(int player_id, int sw)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            p.Paused = sw != 0;
            p.Clock.Pause(p.Paused, (ulong)audioTimestampUs);
            PauseManaAudio(p, p.Paused);
        }
        public bool CRIWARE8F9064CB(int player_id) => GetMana(player_id)?.Paused ?? false;
        public void CRIWARE2A9F70F6(int player_id, int timer_type)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            p.Timer = (ManaTimer)timer_type; p.Clock.SetMode(timer_type);
        }
        public void CRIWARE91A28C68(int player_id, ulong user_count, ulong user_unit)
        {
            var p = GetMana(player_id);
            if (p == null) return;
            if (user_unit == 0) { Report("E2019082000M"); return; }
            if (p.Status == ManaStatus.Playing) p.Clock.SetUserTime(user_count, user_unit);
        }
        public void CRIWAREFA328494(int player_id) { }

        public int CRIWARE64FBEFB2(int player_id)
        {
            var p = GetMana(player_id);
            if (p == null) return (int)ManaStatus.Error;
            // Native GetStatus services this handle. Advancing peers here can
            // skip their managed player's WaitPrep renderer-creation handshake.
            ServiceMana(p);
            return (int)p.Status;
        }

        private void ServiceMana(ManaPlayer p)
        {
            if (p.Stopping) { p.Status = ManaStatus.Stop; p.Stopping = p.Paused = false; return; }
            try
            {
                if (p.Status == ManaStatus.Dechead)
                {
                    if (p.Info == null) LoadManaFile(p, p.Path);
                    else p.Status = ManaStatus.WaitPrep;
                }
                else if (p.Status == ManaStatus.WaitPrep) p.Status = ManaStatus.Prep;
                else if (p.Status == ManaStatus.Prep)
                {
                    if (p.Ready.Count >= 3 || p.EndOfVideo)
                    {
                        p.Status = ManaStatus.Ready;
                        if (p.StartRequested) StartMana(p);
                    }
                    else PumpManaFrames(p);
                }
                else if (p.Status == ManaStatus.Playing)
                {
                    ReadManaClock(p);
                    PumpManaFrames(p);
                    if (p.EndOfVideo && p.Ready.Count == 0 && (p.Timer == ManaTimer.None ||
                        ManaSeconds(p) >= p.FileStartSeconds + p.Video.TotalFrames * (double)p.Video.FrameRateDenominator / p.Video.FrameRateNumerator))
                        if (!NextManaFile(p)) { p.Status = ManaStatus.PlayEnd; StopManaAudio(p); }
                }
            }
            catch (Exception error) when (error is IOException || error is InvalidDataException ||
                error is NotSupportedException || error is ArgumentException || error is OverflowException)
            {
                FailMana(p, "Movie could not be decoded: " + error.Message);
            }
        }

        private void FailMana(ManaPlayer p, string reason)
        {
            p.Status = ManaStatus.Error; p.Decoder = null; p.Ready.Clear();
            StopManaAudio(p);
            Report("E:Mana " + reason);
        }

        private void LoadManaFile(ManaPlayer p, string path)
        {
            if (string.IsNullOrEmpty(path)) throw new InvalidDataException("Movie path is not set.");
            var file = CriManaUsm.Parse(readFile(path));
            p.CurrentPath = path;
            p.Video = file.Video; p.Audio = file.Audio;
            if (p.SeekFrame >= file.Video.TotalFrames) p.SeekFrame = 0;
            p.Info = new MovieInfo
            {
                _reserved1 = 1,
                width = (uint)file.Video.Width, height = (uint)file.Video.Height,
                dispWidth = (uint)file.Video.DisplayWidth, dispHeight = (uint)file.Video.DisplayHeight,
                framerateN = (uint)file.Video.FrameRateNumerator, framerateD = (uint)file.Video.FrameRateDenominator,
                totalFrames = (uint)file.Video.TotalFrames, codecType = (CodecType)file.Video.Codec,
                numAudioStreams = file.Audio == null ? 0u : 1u, audioPrm = new CriMana.AudioInfo[32],
                maxChunkSize = (uint)file.MaxChunkSize
            };
            if (file.Audio != null)
                p.Info.audioPrm[0] = new CriMana.AudioInfo { samplingRate = (uint)file.Audio.SamplingRate,
                    numChannels = (uint)file.Audio.Channels, totalSamples = (uint)file.Audio.TotalSamples };
            p.Decoder = new CriManaMpeg1Decoder(file.CopyVideoStream());
            p.DecodedFrame = 0;
            int seek = p.Concatenated == 0 ? p.SeekFrame : 0;
            if (seek != 0)
            {
                int anchor = 0;
                foreach (var entry in file.SeekEntries)
                {
                    if (entry.FrameIndex > seek) break;
                    anchor = entry.FrameIndex;
                }
                int offset = 0;
                for (int i = 0; i < anchor; i++) offset = checked(offset + file.VideoPackets[i].Data.Count);
                p.Decoder.Reset(offset);
                p.DecodedFrame = anchor;
            }
            InitializeManaFrames(p);
            LoadManaAudio(p, file, seek);
            p.EndOfVideo = false;
            SelectManaNextInput(p);
            PrimeManaNextAudio(p);
        }

        private static void ClearManaEntries(ManaPlayer p)
        {
            p.Entries.Clear(); p.RetainedEntry = null;
            p.NextPath = null; p.HasNextFile = false;
        }

        private static void SelectManaNextInput(ManaPlayer p)
        {
            // Native 5C3A4/3A318 resolve continuation at input EOF. This host
            // reads the cached file in one operation, so freeze that choice here.
            p.HasNextFile = true;
            if (p.Loop) p.NextPath = p.CurrentPath;
            else if (p.Entries.Count != 0)
            {
                p.RetainedEntry = p.Entries.Dequeue();
                p.NextPath = p.RetainedEntry.Path;
            }
            else if (p.RetainedEntry?.Repeat == true) p.NextPath = p.RetainedEntry.Path;
            else
            {
                p.RetainedEntry = null;
                p.NextPath = null; p.HasNextFile = false;
            }
        }

        private void StartMana(ManaPlayer p)
        {
            p.Status = ManaStatus.Playing;
            p.Clock.Start((ulong)audioTimestampUs);
            p.Clock.Pause(p.Paused, (ulong)audioTimestampUs);
            StartManaAudio(p);
            ReadManaClock(p);
        }

        private void ReadManaClock(ManaPlayer p)
        {
            if (p.Timer == ManaTimer.Audio && TryReadManaAudioClock(p, out p.TimeCount, out p.TimeUnit)) return;
            p.Clock.Read((ulong)audioTimestampUs, out p.TimeCount, out p.TimeUnit);
            if (p.SeekFrame > 0)
            {
                uint rate = (uint)((long)p.Video.FrameRateNumerator * 1000 / p.Video.FrameRateDenominator);
                float seconds = (float)((float)p.SeekFrame * 1000f) / (float)rate;
                p.TimeCount += (ulong)(float)(seconds * (float)p.TimeUnit);
            }
        }

        private static double ManaSeconds(ManaPlayer p) => p.TimeCount / (double)p.TimeUnit;

        private bool NextManaFile(ManaPlayer p)
        {
            if (!p.HasNextFile) return false;
            string path = p.NextPath;
            if (p.AudioConcatenation && p.Audio != null)
                AdvanceManaFileTime(p, (ulong)p.Audio.TotalSamples, (ulong)p.Audio.SamplingRate);
            else
                AdvanceManaFileTime(p, (ulong)p.Video.TotalFrames * (ulong)p.Video.FrameRateDenominator,
                    (ulong)p.Video.FrameRateNumerator);
            p.FrameBase += p.Video.TotalFrames; p.Concatenated++;
            LoadManaFile(p, path);
            PumpManaFrames(p);
            return true;
        }

        private static void AdvanceManaFileTime(ManaPlayer p, ulong count, ulong unit)
        {
            // Keep concatenation rational: repeated 20/24-second movies must
            // reach exactly 180000/24000, while ADX bases truncate fractional ticks.
            ulong common = ManaGcd(p.FileTimeUnit, unit);
            p.FileTime = checked(p.FileTime * (unit / common) + count * (p.FileTimeUnit / common));
            p.FileTimeUnit = checked(p.FileTimeUnit * (unit / common));
            common = ManaGcd(p.FileTime, p.FileTimeUnit);
            p.FileTime /= common; p.FileTimeUnit /= common;
        }

        private static ulong ManaGcd(ulong a, ulong b)
        {
            while (b != 0) { ulong remainder = a % b; a = b; b = remainder; }
            return a;
        }

        public void CRIWAREC91B6C0D(int player_id, MovieInfo movie_info)
        {
            var p = GetMana(player_id);
            if (p?.Info == null || movie_info == null) return;
            var source = p.Info;
            movie_info._reserved1 = source._reserved1;
            movie_info.numAlphaStreams = source.numAlphaStreams;
            movie_info.width = source.width; movie_info.height = source.height;
            movie_info.dispWidth = source.dispWidth; movie_info.dispHeight = source.dispHeight;
            movie_info.framerateN = source.framerateN; movie_info.framerateD = source.framerateD;
            movie_info.totalFrames = source.totalFrames; movie_info.codecType = source.codecType;
            movie_info.alphaCodecType = source.alphaCodecType; movie_info.numAudioStreams = source.numAudioStreams;
            movie_info.audioPrm = (CriMana.AudioInfo[])source.audioPrm.Clone();
            movie_info.numSubtitleChannels = source.numSubtitleChannels;
            movie_info.maxSubtitleSize = source.maxSubtitleSize; movie_info.maxChunkSize = source.maxChunkSize;
        }
    }
}
