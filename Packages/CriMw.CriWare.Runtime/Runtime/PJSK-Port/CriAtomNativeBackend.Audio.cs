using System;
using System.Collections.Generic;
using System.IO;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class Voice
        {
            private sealed class PcmBlock
            {
                internal readonly float[][] Samples;
                internal int Count, Offset;
                internal PcmBlock(int channels, int capacity)
                {
                    Samples = new float[channels][];
                    for (int i = 0; i < channels; i++) Samples[i] = new float[capacity];
                }
            }

            internal readonly Playback Playback;
            internal readonly AudioGroup Group;
            internal readonly CriAtomAcbData.WaveEvent Event;
            internal HcaFileDecoder Decoder;
            internal CriAtomResampler Resampler;
            internal readonly Dictionary<int, float> Sends;
            internal float[][] Output;
            internal readonly bool Looping;
            internal int Available, SourceRate;
            internal long StartOutputFrame, SourceStartSample, Rendered, SourceConsumed;
            internal long FirstSourceOutputFrame = -1;
            internal long AllocationOrder;
            internal long SourceOrder = -1;
            internal int Slot = -1;
            internal float LastGain, Gain, Pitch;
            internal bool ReleaseRequested, Releasing, Finished, ParametersDirty;
            internal bool RendererEnded, SoundEnded, AllocationReleased;
            internal bool DecoderReady;
            // Sound pause byte (+776) sampled from the group (+58) on the
            // renderer pass; the first paused block ramps to zero, later
            // paused blocks consume no source.
            internal bool SoundPaused, PauseRamped;
            internal float ServicedGain;
            internal bool HasServicedGain;
            internal long PlayedSourceSamples;
            internal VoiceFilter Filter;
            internal CriAtomAcbData.BiquadSetting PendingBiquad;
            // Pan3d angle of the ACB layers; the matrix is built once the channel count is known.
            internal float PanAngle;
            internal float[,] Pan;
            private struct SourceProgress { internal long OutputFrame, SourceSamples; }
            private readonly Queue<SourceProgress> sourceProgress = new Queue<SourceProgress>();
            private readonly long sourceStartUs;
            private readonly int outputRate;
            private readonly ulong key;
            private readonly Queue<PcmBlock> ready = new Queue<PcmBlock>();
            private readonly Queue<PcmBlock> free = new Queue<PcmBlock>();
            private float[][] decoded;
            private int quantum;
            private bool endedInput;

            internal Voice(Playback playback, AudioGroup group, CriAtomAcbData.WaveEvent wave, long sourceStartUs, long startOutputFrame,
                int outputRate, ulong key, float gain, float pitch, Dictionary<int, float> sends)
            {
                Playback = playback; Group = group; Event = wave; Sends = sends; StartOutputFrame = startOutputFrame; LastGain = Gain = gain;
                this.sourceStartUs = sourceStartUs; this.outputRate = outputRate; this.key = key; Pitch = pitch;
                int loop = (int)playback.Snapshot.Get(156, -1);
                // Finite LimitLoopCount values are not rendered; the backend
                // reports them (QueueVoice) and plays as CRIATOMEX_IGNORE_LOOP.
                if (loop >= 0) loop = -2;
                Looping = loop == -3 || loop != -2 && wave.Waveform.Loop;
            }

            internal void OpenDecoder(VoiceSlot slot, float serverFrequency, int maximumSamplingRate)
            {
                var bytes = Event.Waveform.Data;
                if (bytes.Count < 8) throw new InvalidDataException("Truncated HCA wave.");
                int headerSize = bytes.Array[bytes.Offset + 6] << 8 | bytes.Array[bytes.Offset + 7];
                if (headerSize > bytes.Count) throw new InvalidDataException("Truncated HCA header.");
                var header = new byte[headerSize]; Array.Copy(bytes.Array, bytes.Offset, header, 0, headerSize);
                Decoder = new HcaFileDecoder(header, key, slot.Decoder, 2);
                slot.Decoder = Decoder;
                if (Decoder.Info.Channels < 1 || Decoder.Info.Channels > 2)
                    throw new NotSupportedException("The original archive HCA waves are mono or stereo.");
                long start = sourceStartUs * Decoder.Info.SampleRate / 1000000;
                SourceStartSample = start;
                if (Looping && !Decoder.Info.HasLoop && Decoder.Info.SampleCount != 0) start %= Decoder.Info.SampleCount;
                if (!Looping) start = Math.Min(start, Decoder.Info.SampleCount);
                Decoder.Seek(start, Looping);
                int channels = Decoder.Info.Channels;
                Resampler = new CriAtomResampler(channels);
                Output = new float[channels][]; decoded = new float[channels][];
                for (int channel = 0; channel < channels; channel++)
                { Output[channel] = new float[256]; decoded[channel] = new float[128]; }
                SetPitch(Pitch, outputRate);
                if (PendingBiquad != null) Filter = new VoiceFilter(channels, outputRate, PendingBiquad);
                Pan = PanMatrix(channels, PanAngle);
                // DB5A0 allocates the physical PCM block pool; DB9D8 selects a
                // 128-aligned quantum for the current source rate.
                int frequency = (int)serverFrequency;
                int unit = ((96000 / frequency / 4 + 127) / 128) * 128;
                int blocks = (2 * unit + 7199) / unit;
                int capacity = DecodeQuantum(maximumSamplingRate, 2, frequency, blocks);
                quantum = Math.Min(DecodeQuantum(Decoder.Info.SampleRate, channels, frequency, blocks), capacity);
                for (int i = 0; i < blocks; i++) free.Enqueue(new PcmBlock(channels, capacity));
            }

            private static int DecodeQuantum(int rate, int channels, int frequency, int blocks)
            {
                int size = ((unchecked(8 * channels * rate) / frequency / channels / 16 + 127) / 128) * 128;
                return unchecked(rate * (blocks - 1) * size) < 345600000 ? size + 128 : size;
            }

            internal void RecordSourceProgress(long outputFrame)
            {
                if (Playback.Owner.Config.enableAudioSyncedTimer)
                    sourceProgress.Enqueue(new SourceProgress { OutputFrame = outputFrame, SourceSamples = SourceConsumed });
            }

            internal void CommitSourceProgress(long outputFrame)
            {
                while (sourceProgress.Count != 0 && sourceProgress.Peek().OutputFrame <= outputFrame)
                    PlayedSourceSamples = sourceProgress.Dequeue().SourceSamples;
            }

            internal void SetPitch(float pitch, int rate)
            {
                if (SourceRate != 0 && Pitch == pitch) return;
                Pitch = pitch;
                if (Decoder == null) return;
                float ratio = (float)Math.Pow(2.0, (float)(pitch / 1200f));
                SourceRate = Math.Max(1, (int)(float)(Decoder.Info.SampleRate * ratio));
                Resampler.SetRates(SourceRate, rate);
            }

            // meter: the owner player's level meter when FCD14 would deliver
            // this voice's PCM (playback still registered, analyzer attached).
            internal void DecodeServer(CriAtomLevelMeter meter)
            {
                // DBDDC completes at most four PCM blocks per server pass.
                // A partial consumer block still owns its physical pool entry.
                for (int block = 0; block < 4 && free.Count != 0 && !endedInput; block++)
                {
                    var pcm = free.Dequeue(); pcm.Count = pcm.Offset = 0;
                    while (quantum - pcm.Count >= 128)
                    {
                        if (Decoder.Finished)
                        {
                            if (!Looping) { endedInput = true; break; }
                            Decoder.ContinueLoop();
                        }
                        int samples = Decoder.DecodeSubframe(Event.Waveform.Data, decoded);
                        for (int channel = 0; channel < decoded.Length; channel++)
                            Array.Copy(decoded[channel], 0, pcm.Samples[channel], pcm.Count, samples);
                        pcm.Count += samples;
                    }
                    // DBDDC 0xDC1D4: one float callback per filled PCM block,
                    // decoded source PCM before resampling, gain and mixing.
                    if (meter != null && pcm.Count > 0) meter.Accumulate(decoded.Length, pcm.Count, pcm.Samples);
                    Available += pcm.Count;
                    ready.Enqueue(pcm);
                }
                DecoderReady = ready.Count != 0;
            }

            internal int Read(int count)
            {
                if (Output == null) return 0;
                foreach (var channel in Output) Array.Clear(channel, 0, count);
                if (Finished) return 0;
                int produced = 0;
                while (produced < count && ready.Count != 0)
                {
                    var pcm = ready.Peek();
                    int inputCount = Math.Min(Resampler.GetRequiredInput(count - produced), pcm.Count - pcm.Offset);
                    if (inputCount != 0)
                    {
                        int samples;
                        if (Resampler.IsActive)
                            samples = Resampler.Process(pcm.Samples, pcm.Offset, inputCount, Output, produced, count - produced);
                        else
                        {
                            samples = inputCount;
                            for (int channel = 0; channel < Output.Length; channel++)
                                Array.Copy(pcm.Samples[channel], pcm.Offset, Output[channel], produced, samples);
                        }
                        produced += samples; pcm.Offset += inputCount; Available -= inputCount; SourceConsumed += inputCount;
                    }
                    if (pcm.Offset == pcm.Count) { ready.Dequeue(); free.Enqueue(pcm); }
                    else break;
                }
                Rendered += produced;
                if (Filter != null) produced = Filter.Process(Output, produced, count);
                // Native 150FDC clears the driver only on a subsequent request
                // producing no samples, after the final partial PCM block.
                if (produced == 0 && ready.Count == 0 && endedInput) Finished = true;
                return produced;
            }
        }

        // Source biquad stage of 150FDC (flag bit 11, +224): sub_15DF1C after the
        // resampler, in place on each channel (sub_15F700, whole groups of eight
        // frames). The final short request is zero-padded to the requested length;
        // once the source produces nothing the driver ends before this stage, so the
        // drain counter never adds a ring-out block (whole-PCM oracle, long tails).
        private sealed class VoiceFilter
        {
            private readonly CriAtomDspMath.Biquad[] channels;
            internal VoiceFilter(int channelCount, int rate, CriAtomAcbData.BiquadSetting setting)
            {
                channels = new CriAtomDspMath.Biquad[channelCount];
                for (int i = 0; i < channelCount; i++)
                {
                    channels[i] = new CriAtomDspMath.Biquad();
                    CriAtomDspMath.VoiceFilter(channels[i], rate, setting.Type - 1, CriAtomDspMath.VoiceFilterFrequency(setting.Frequency), setting.Q, setting.Gain);
                }
            }
            internal int Process(float[][] planes, int available, int requested)
            {
                if (available == 0) return 0;
                // Read cleared the planes, so the padding is already zero.
                int frames = Math.Max(available, requested);
                for (int channel = 0; channel < channels.Length; channel++) channels[channel].Process(planes[channel], frames);
                return frames;
            }
        }

        // A sequencer pass binds its due waves to one native sound group.
        // Later delayed batches get separate clocks, even in one playback.
        private sealed class AudioGroup
        {
            internal readonly CriAtomAudioClock Clock;
            internal readonly List<Voice> Voices = new List<Voice>();
            internal bool Started;
            // Group +58 bit 0 (A4F34, written synchronously by pause changes)
            // and +57, the value observed on the previous A4884 pass.
            internal bool SoundPaused, PreviousPaused;
            // A4884 server-time accounting read by A14FC: +64 start, +72
            // current, +80 accumulated milliseconds, +88 initial seek.
            internal long StartMs, CurrentMs;
            internal int AccumulatedMs;
            private readonly long initialSeekUs;
            internal long PlainTimeMs => CurrentMs - StartMs + AccumulatedMs + initialSeekUs / 1000;
            internal AudioGroup(Playback playback, int rate)
            {
                Clock = new CriAtomAudioClock(playback.Owner.Config.enableAudioSyncedTimer, playback.StartTimeUs, rate);
                initialSeekUs = playback.StartTimeUs;
                SoundPaused = playback.PauseMask != 0;
            }
        }

        private sealed class VoiceSlot
        {
            // A1C30 can release/reassign Owner while its sound/renderer still
            // consumes the old source. The incoming decoder waits for Idle.
            internal Voice Owner, Current;
            internal HcaFileDecoder Decoder;
        }

        private readonly List<Voice> retiredVoices = new List<Voice>();
        private VoiceSlot[] voiceSlots;
        private readonly float[][] mixed = { new float[256], new float[256] };
        private readonly float[] pendingPcm = new float[512];
        private readonly Queue<float[]> drainedPcm = new Queue<float[]>();
        private int pendingOffset, pendingFrames;
        private long renderedFrames, playedFrames, nextServerTick;
        private long audioTimestampUs;
        private double outputClockOffsetUs;
        private double serverClockOffsetUs;
        private long nextVoiceOrder, nextSourceOrder;
        private long previousServerUs, previousAsrUs;
        private uint previousFaderMs;
        private long presentedFrames;
        private bool outputStalled;
        public bool IsPaused => paused;

        // Called by the platform sink with the number of PCM frames it actually
        // consumed. Scheduling ahead must not advance an audio-synced getter.
        public void SetPlayedFrames(long frames) => CommitPlayedFrames(frames, frames, frames * 1000000 / SampleRate, false, false);

        // Legacy form of SetOutputProgress(frames, frames, timestampUs, false).
        public void SetPlayedFrames(long frames, long timestampUs) => SetOutputProgress(frames, frames, timestampUs, false);

        // consumedFrames: PCM the sink took from the FIFO (Mana audio, bank drain).
        // presentedFrames: PCM presented to the listener; it drives the
        // audio-synced source observation (A4884) and is clamped to
        // [previous presented, consumed]. timestampUs shares the origin of the
        // constructor's nowUs. stalled: the output device is not running; the
        // audio-synced getters hold their snapshot instead of extrapolating.
        public void SetOutputProgress(long consumedFrames, long presentedFrames, long timestampUs, bool stalled)
            => CommitPlayedFrames(consumedFrames, presentedFrames, timestampUs, true, stalled);

        private void CommitPlayedFrames(long frames, long presented, long timestampUs, bool platformClock, bool stalled)
        {
            if (frames < playedFrames || frames > renderedFrames) throw new ArgumentOutOfRangeException(nameof(frames));
            if (timestampUs < audioTimestampUs) throw new ArgumentOutOfRangeException(nameof(timestampUs));
            presented = Math.Max(presentedFrames, Math.Min(presented, frames));
            if (platformClock && frames > playedFrames && frames == renderedFrames)
                outputClockOffsetUs = timestampUs - (frames - 256) * (1000000d / SampleRate);
            playedFrames = frames;
            presentedFrames = presented;
            audioTimestampUs = timestampUs;
            outputStalled = stalled;
            CommitManaAudioProgress(frames);
            foreach (var player in players)
                foreach (var playback in player.Playbacks)
                    foreach (var voice in playback.Voices) voice.CommitSourceProgress(presented);
        }

        // C11: getters read the platform clock at call time (F32D0 reads
        // sub_19FDC8), never earlier than the last committed timestamp.
        private long ClockNowUs() => nowUs == null ? audioTimestampUs : Math.Max(audioTimestampUs, nowUs());

        // The original SonicSync output graph processes 256-frame blocks,
        // independent of the platform sink's requested buffer size. The separate
        // server graph's 105% quota does not determine the audible DSP blocks.
        public void RenderPcm(float[] interleaved, int frames)
        {
            if (interleaved == null || frames < 0 || frames > interleaved.Length / 2) throw new ArgumentOutOfRangeException(nameof(frames));
            if (!atomInitialized) throw new InvalidOperationException("Atom is not initialized.");
            if (paused) { Array.Clear(interleaved, 0, frames * 2); return; }
            int written = 0;
            while (written < frames)
            {
                if (pendingFrames == 0)
                {
                    if (drainedPcm.Count != 0) Array.Copy(drainedPcm.Dequeue(), pendingPcm, pendingPcm.Length);
                    else RenderGuardedBlock();
                    pendingOffset = 0; pendingFrames = 256;
                }
                int copy = Math.Min(frames - written, pendingFrames);
                Array.Copy(pendingPcm, pendingOffset * 2, interleaved, written * 2, copy * 2);
                pendingOffset += copy; pendingFrames -= copy; written += copy;
            }
        }

        private int consecutiveRenderFailures;

        // C8 render-loop guard: an unexpected exception is reported, the block
        // is silent and the clock still advances. Three consecutive failures
        // are rethrown so the host can fault the session.
        private void RenderGuardedBlock()
        {
            long before = renderedFrames;
            try
            {
                long due = (long)((renderedFrames * (1000000d / SampleRate) + serverClockOffsetUs) * ServerFrequency / 1000000d);
                while (nextServerTick <= due) ServerTick(nextServerTick++);
                RenderBlock(256);
                consecutiveRenderFailures = 0;
            }
            catch (Exception exception)
            {
                Report("E-HARUKI-RENDER:" + exception.GetType().Name + ":" + exception.Message);
                Array.Clear(pendingPcm, 0, pendingPcm.Length);
                if (renderedFrames == before) renderedFrames += 256;
                if (++consecutiveRenderFailures >= 3) throw;
            }
        }

        private bool HasBankSounds(Bank bank)
        {
            foreach (var slot in voiceSlots)
                if (slot.Current != null && slot.Current.Playback.Bank == bank && !slot.Current.SoundEnded) return true;
            return false;
        }

        private void DrainBankSounds(Bank bank)
        {
            if (!HasBankSounds(bank))
            {
                ClearBankSounds(bank);
                return;
            }
            // 10E658 waits for low-level bank users after releasing public/group
            // ownership. Preserve every output block while advancing its server
            // and ASR work; WebGL cannot block its own audio producer in Sleep.
            var savedPending = (float[])pendingPcm.Clone();
            double period = 1000000d / ServerFrequency;
            double nextPeriodic = nextServerTick == 0 ? previousServerUs + period : nextServerTick * period;
            nextPeriodic = Math.Max(nextPeriodic, previousServerUs + period);
            double nextOutput = Math.Max(previousServerUs, renderedFrames * (1000000d / SampleRate) + outputClockOffsetUs);
            long checkUs = Math.Max(previousServerUs, Math.Min(audioTimestampUs, (long)nextOutput));
            while (nextPeriodic <= checkUs) nextPeriodic += period;
            try
            {
                while (HasBankSounds(bank))
                {
                    ServerTickAt(checkUs);
                    long wakeUs = checkUs + 10000;
                    while (nextPeriodic < wakeUs || !paused && nextOutput < wakeUs)
                    {
                        if (paused || nextPeriodic <= nextOutput)
                        {
                            ServerTickAt((long)nextPeriodic);
                            nextPeriodic += period;
                        }
                        else
                        {
                            RenderBlock(256);
                            drainedPcm.Enqueue((float[])pendingPcm.Clone());
                            nextOutput += 256 * (1000000d / SampleRate);
                        }
                    }
                    checkUs = wakeUs;
                }
            }
            finally
            {
                Array.Copy(savedPending, pendingPcm, pendingPcm.Length);
                nextServerTick = Math.Max(nextServerTick, (long)(previousServerUs / period) + 1);
                serverClockOffsetUs = Math.Max(serverClockOffsetUs, previousServerUs - renderedFrames * (1000000d / SampleRate));
            }
            ClearBankSounds(bank);
        }

        private void ClearBankSounds(Bank bank)
        {
            foreach (var slot in voiceSlots)
                if (slot.Current != null && slot.Current.Playback.Bank == bank) slot.Current = null;
            retiredVoices.RemoveAll(voice => voice.Playback.Bank == bank);
        }

        private void ServerTick(long tick)
        {
            ServerTickAt((long)(tick * (1000000d / ServerFrequency)));
        }

        private void ServerTickAt(long nowUs)
        {
            uint nowMs = unchecked((uint)(nowUs / 1000));
            uint deltaMs = unchecked((uint)((nowUs - previousServerUs) / 1000));
            long asrUs = renderedFrames * 1000000 / SampleRate;
            categories?.Tick(nowMs, deltaMs);
            var sequences = new List<Playback>();
            foreach (var player in players) sequences.AddRange(player.Playbacks);
            sequences.Sort((a, b) => a.SequenceOrder.CompareTo(b.SequenceOrder));
            // DD18C sees the previous pass's group bindings. A group released
            // later in this pass cannot retire its sequence until the next one.
            foreach (var playback in sequences)
                playback.SequenceFinished = playback.Voices.Count == 0 &&
                    (playback.Stopping || playback.Prepared && playback.NextEvent == playback.Plan.Count);
            foreach (var playback in sequences)
            {
                if (playback.SequenceFinished) continue;
                if (!playback.Prepared)
                {
                    playback.Prepared = true; playback.FirstOutputFrame = renderedFrames;
                    if (!playback.Stopping && playback.ImmediatePlan)
                    {
                        var group = NewAudioGroup(playback);
                        while (playback.NextEvent < playback.Plan.Count)
                            QueueVoice(playback, group, playback.Plan[playback.NextEvent++], renderedFrames);
                    }
                }
                if (!playback.Stopping && playback.SequenceClock != null)
                {
                    // DEDE8 takes its paused branch for any nonzero +168.
                    // DF2D0 skips E13A4 for user pause or Prepare only once the
                    // track has been serviced (track +40 nonzero): a playback
                    // started paused still queues its due waves (held).
                    bool trackActive = !playback.TrackServiced || (playback.PauseMask & (UserPauseMask | PreparePauseMask)) == 0;
                    long delta = playback.SequenceClock.Advance(asrUs, previousAsrUs, 1000000d / ServerFrequency,
                        playback.PauseMask != 0, trackActive);
                    if (trackActive)
                    {
                        playback.TrackServiced = true;
                        if (!playback.ImmediatePlan) QueueSequenceVoices(playback, delta);
                    }
                }
            }
            uint faderDelta = unchecked(nowMs - previousFaderMs);
            foreach (var player in players) player.Fader?.Tick(faderDelta);
            // 153918's group/voice service precedes ADFA0's sound service;
            // its second delta=0 pass skips playing groups. Keep the two
            // lifetimes separate from the ASR driver's audible release tail.
            var groups = new List<Voice>();
            foreach (var player in players)
                foreach (var playback in player.Playbacks) groups.AddRange(playback.Voices);
            groups.Sort((a, b) => a.AllocationOrder.CompareTo(b.AllocationOrder));
            foreach (var playback in sequences)
                foreach (var group in playback.AudioGroups)
                    if (group.Started && group.Voices.Exists(voice => !voice.AllocationReleased))
                    {
                        // A4884: +58 (paused now) or +57 (paused on the
                        // previous pass) selects the held snapshot branch.
                        bool pausedNow = group.SoundPaused;
                        long groupMs = audioTimestampUs / 1000;
                        if (pausedNow)
                        {
                            if (!group.PreviousPaused) group.AccumulatedMs = unchecked(group.AccumulatedMs + (int)(group.CurrentMs - group.StartMs));
                            group.StartMs = groupMs;
                        }
                        group.CurrentMs = groupMs;
                        var source = group.Voices.Find(voice => !voice.AllocationReleased && voice.PlayedSourceSamples > 0 && !voice.SoundEnded);
                        group.Clock.ObserveSource(audioTimestampUs, audioTimestampUs,
                            source == null ? -1 : source.SourceStartSample + source.PlayedSourceSamples,
                            source == null ? SampleRate : source.Decoder.Info.SampleRate,
                            source == null ? 0 : source.SourceStartSample, pausedNow || group.PreviousPaused);
                        group.PreviousPaused = pausedNow;
                    }
            // 9ED10 evaluates each sound's gain (D378C) inside this group
            // service, before EDB98/FCA2C publish this pass's category counts:
            // a REACT triggered by those counts reaches voices one pass later.
            foreach (var voice in groups)
            {
                voice.ServicedGain = VoiceGain(voice.Playback, voice.Event);
                voice.HasServicedGain = true;
            }
            foreach (var voice in groups)
            {
                if (voice.AllocationReleased) continue;
                if (voice.Slot < 0 && voice.ReleaseRequested)
                {
                    voice.AllocationReleased = true; voice.Finished = true;
                    voice.Playback.Voices.Remove(voice);
                    continue;
                }
                if (voice.Slot < 0 && !ReserveMemoryVoice(voice))
                {
                    voice.AllocationReleased = true;
                    voice.Playback.Voices.Remove(voice);
                    continue;
                }
                if (voice.SoundEnded)
                {
                    ReleaseVoiceAllocation(voice);
                    voice.Playback.Voices.Remove(voice);
                }
            }
            foreach (var slot in voiceSlots)
            {
                if (slot.Owner == null && slot.Current != null && slot.Current.SoundEnded) slot.Current = null;
                StartSlot(slot);
            }
            foreach (var slot in voiceSlots)
            {
                var voice = slot.Current;
                if (voice == null) continue;
                if (voice.RendererEnded) voice.SoundEnded = true;
                else if (voice.Decoder != null && !voice.Finished)
                {
                    try { voice.DecodeServer(MeterFor(voice)); }
                    catch (Exception exception) when (!(exception is OutOfMemoryException)) { FailVoice(voice, exception); }
                }
            }
            foreach (var playback in sequences)
                foreach (var group in playback.AudioGroups)
                    if (!group.Started && group.Voices.Exists(voice => voice.DecoderReady) &&
                        group.Voices.TrueForAll(voice => voice.DecoderReady || voice.AllocationReleased))
                    {
                        group.Started = true;
                        group.Clock.BeginService(audioTimestampUs);
                        group.StartMs = group.CurrentMs = audioTimestampUs / 1000;
                    }
            // An incoming group can start in the second pass when ADFA0 has
            // just made a reused sound idle. Its decoder missed this pass's
            // DBC6C service, so readiness arrives on the following server pass.
            foreach (var slot in voiceSlots) StartSlot(slot);
            // EDB98 publishes newly prepared playback/player states after the
            // fader pass. A new fader therefore observes Prep for its first tick.
            foreach (var player in players)
            {
                foreach (var playback in player.Playbacks.ToArray())
                    if (playback.SequenceFinished) RemovePlayback(playback);
                    else if (playback.Stopping) CountPlayback(playback, false);
                    else if (playback.Voices.Exists(voice => voice.DecoderReady && !voice.SoundEnded))
                    {
                        playback.Status = CriAtomExPlayback.Status.Playing;
                        CountPlayback(playback, true);
                        CountPauseTransition(playback);
                    }
                if (player.Playbacks.Count != 0)
                {
                    player.Status = CriAtomExPlayer.Status.Playing;
                    foreach (var playback in player.Playbacks)
                        if (playback.Status == CriAtomExPlayback.Status.Prep) { player.Status = CriAtomExPlayer.Status.Prep; break; }
                }
            }
            // BB2EC retains renderer creation order (memory pool, then streaming
            // pool). 1522F4 appends a source only when its driver actually starts.
            foreach (var slot in voiceSlots)
                if (slot.Current != null) ServiceRenderer(slot.Current);
            ServiceManaAudioSources();
            previousServerUs = nowUs; previousFaderMs = nowMs;
            previousAsrUs = asrUs;
        }

        private void StartSlot(VoiceSlot slot)
        {
            if (slot.Owner != null && slot.Owner != slot.Current && (slot.Current == null || slot.Current.SoundEnded))
            {
                slot.Current = slot.Owner;
                try { slot.Current.OpenDecoder(slot, ServerFrequency, maximumSamplingRate); }
                catch (Exception exception) when (!(exception is OutOfMemoryException)) { FailVoice(slot.Current, exception); }
            }
        }

        // DBDDC: "E2009051801:Decoding error occurred. (%d)"; the failing voice
        // stops on the following passes, every other voice continues.
        private void FailVoice(Voice voice, Exception exception)
        {
            Report("E2009051801:Decoding error occurred. (" + exception.GetType().Name + ": " + exception.Message + ")");
            voice.Finished = true;
            voice.RendererEnded = true;
            voice.DecoderReady = false;
        }

        // FCD14 resolves the playback by ID and calls the owner's filter
        // callback (player +552) at decode time.
        private CriAtomLevelMeter MeterFor(Voice voice)
        {
            var playback = voice.Playback;
            if (FindPlayback(playback.Id) != playback) return null;
            return playback.Owner.Analyzer?.Meter;
        }

        // FCA2C after the first count: a nonzero/zero transition of +168
        // changes only the unpaused count (+64); the total (+62) is kept.
        private void CountPauseTransition(Playback playback)
        {
            if (categories == null || !playback.Counted) return;
            bool unpaused = playback.PauseMask == 0;
            if (unpaused == playback.CountedUnpaused) return;
            foreach (int category in playback.Categories) categories.ChangePlayingCount(category, unpaused, false, true);
            playback.CountedUnpaused = unpaused;
        }

        private void ServiceRenderer(Voice voice)
        {
            // BF664/151CE0 clears the stopping driver on the renderer pass
            // following 151904. ASR can consume further zero-gain blocks after
            // its first release ramp; that ramp does not retire the driver.
            if (voice.Releasing || voice.Finished) { voice.Finished = true; voice.RendererEnded = true; }
            voice.SoundPaused = voice.Group.SoundPaused;
            if (!voice.SoundPaused) voice.PauseRamped = false;
            ApplyVoiceParameters(voice);
            if (voice.SourceOrder < 0 && voice.DecoderReady && !voice.SoundPaused && !voice.ReleaseRequested && !voice.Finished)
                voice.SourceOrder = nextSourceOrder++;
        }

        private void ApplyVoiceParameters(Voice voice)
        {
            // Update(All) copies the playback snapshot synchronously; native
            // CDEF4/D378C merges it into a voice on the next server pass.
            if (voice.ParametersDirty) { voice.SetPitch(VoicePitch(voice.Playback, voice.Event), SampleRate); voice.ParametersDirty = false; }
            voice.Releasing = voice.ReleaseRequested;
            float target = voice.HasServicedGain ? voice.ServicedGain : VoiceGain(voice.Playback, voice.Event);
            voice.HasServicedGain = false;
            voice.Gain = voice.Releasing || voice.SoundPaused ? 0f : target;
        }

        private void RenderBlock(int count)
        {
            mixer.BeginBlock(count);
            var active = new List<Voice>();
            foreach (var player in players)
                foreach (var playback in player.Playbacks)
                {
                    if (!playback.Prepared) continue;
                    active.AddRange(playback.Voices);
                }
            active.AddRange(retiredVoices);
            // Native ASR sources are appended to an intrusive list when they
            // start. Reusing a physical pool slot does not restore its old
            // mixing position; retiring sources keep their existing position.
            active.Sort((a, b) => a.SourceOrder.CompareTo(b.SourceOrder));
            int manaSource = 0;
            foreach (var voice in active)
            {
                RenderManaAudioBefore(voice.SourceOrder, count, ref manaSource);
                if (voice.Finished || voice.SourceOrder < 0) continue;
                if (voice.SoundPaused)
                {
                    // One block ramps the started sound to zero; the paused
                    // sound then consumes no source until it is resumed.
                    if (voice.PauseRamped || voice.FirstSourceOutputFrame < 0) continue;
                    voice.PauseRamped = true;
                }
                int offset = (int)Math.Max(0, voice.StartOutputFrame - renderedFrames);
                if (offset >= count) continue;
                int samples = voice.Read(count - offset);
                if (samples == 0) continue;
                if (voice.FirstSourceOutputFrame < 0) voice.FirstSourceOutputFrame = renderedFrames + offset;
                voice.RecordSourceProgress(renderedFrames + count);
                float gain = voice.Gain;
                int channels = voice.Decoder.Info.Channels;
                foreach (var send in voice.Sends)
                    for (int channel = 0; channel < 2; channel++)
                        for (int input = 0; input < channels; input++)
                        {
                            // Gain enters the pan matrix before multiplication by a bus send.
                            float pan = voice.Pan[input, channel];
                            if (pan == 0f) continue;
                            float previous = (float)(pan * voice.LastGain), current = (float)(pan * gain);
                            var pcm = voice.Output[input];
                            if (offset == 0) mixer.Add(send.Key, pcm, 0, channel, samples, (float)(send.Value * previous), (float)(send.Value * current));
                            else
                            {
                                // Native delayed voices begin inside the ASR block.
                                // Keep its zero prefix before routing that block.
                                var delayed = new float[count]; Array.Copy(pcm, 0, delayed, offset, samples);
                                mixer.Add(send.Key, delayed, 0, channel, offset + samples, (float)(send.Value * previous), (float)(send.Value * current));
                            }
                        }
                voice.LastGain = gain;
            }
            retiredVoices.RemoveAll(voice => voice.Finished);
            RenderManaAudioBefore(long.MaxValue, count, ref manaSource);
            manaAudioSources.RemoveAll(source => source.Finished && source.Movie.AudioSource != source);
            mixer.Render(mixed);
            for (int sample = 0; sample < count; sample++)
            {
                pendingPcm[sample * 2] = mixed[0][sample]; pendingPcm[sample * 2 + 1] = mixed[1][sample];
            }
            renderedFrames += count;
        }

        private void QueueSequenceVoices(Playback playback, long delta)
        {
            var clock = playback.SequenceClock;
            if (playback.NextEvent == playback.Plan.Count || playback.Plan[playback.NextEvent].TimeUs > clock.NativeClockTrack) return;
            var due = new List<CriAtomAcbData.WaveEvent>();
            while (playback.NextEvent < playback.Plan.Count)
            {
                var wave = playback.Plan[playback.NextEvent];
                if (wave.TimeUs > clock.NativeClockTrack) break;
                playback.NextEvent++;
                due.Add(wave);
            }
            // Native E13A4 traverses authored tracks in graph order. A seek can
            // make differently timed events due together; preserve that order
            // for random offsets, pool arbitration and floating-point mixing.
            due.Sort((a, b) => a.Ordinal.CompareTo(b.Ordinal));
            var group = NewAudioGroup(playback);
            foreach (var wave in due)
            {
                int delay = clock.EventDelay(wave.TimeUs, delta);
                long gate = clock.AbsoluteSample(delay, SampleRate);
                QueueVoice(playback, group, wave, gate < 0 ? renderedFrames : gate);
            }
        }

        private AudioGroup NewAudioGroup(Playback playback)
        {
            var group = new AudioGroup(playback, SampleRate);
            playback.AudioGroups.Add(group);
            return group;
        }

        private void QueueVoice(Playback playback, AudioGroup group, CriAtomAcbData.WaveEvent wave, long start)
        {
            long offset = playback.Bank.Sheet.ResolveStartOffset(wave, playback.Owner.Random);
            long seek = offset + Math.Max(0, playback.StartTimeUs - wave.TimeUs);
            if ((int)playback.Snapshot.Get(156, -1) >= 0)
                ReportOnce("W-HARUKI-LOOPCOUNT", playback.Bank, playback.Cue, "Finite loop limits are played without loops.");
            var voice = new Voice(playback, group, wave, seek, start, SampleRate, cipherKey,
                VoiceGain(playback, wave), VoicePitch(playback, wave), VoiceSends(wave));
            voice.PendingBiquad = VoiceBiquad(wave);
            voice.PanAngle = VoicePanAngle(wave);
            voice.AllocationOrder = nextVoiceOrder++;
            playback.Voices.Add(voice);
            group.Voices.Add(voice);
        }

        // The innermost layer that sets or clears the biquad block decides. The
        // shipped content sets it on one track layer only; deeper merges of the
        // parameter block (CDEF4) are not exercised.
        private static CriAtomAcbData.BiquadSetting VoiceBiquad(CriAtomAcbData.WaveEvent wave)
        {
            foreach (var layer in wave.Layers)
            {
                if (layer.Biquad != null) return layer.Biquad;
                if (layer.BiquadCleared) return null;
            }
            return null;
        }

        private bool ReserveMemoryVoice(Voice incoming)
        {
            // A27F4 prefers the first idle free sound, otherwise the last free
            // but still busy sound in that pool, before trying the next pool.
            int available = FindFreeSlot(0, memoryVoices);
            if (available < 0) available = FindFreeSlot(memoryVoices, streamingVoices);
            if (available >= 0) { AssignSlot(incoming, available); return true; }
            Voice victim = null; int minimumPriority = int.MaxValue;
            foreach (var slot in voiceSlots)
            {
                var voice = slot.Owner;
                if (voice == null) continue;
                int priority = voice.ReleaseRequested ? short.MinValue : (int)voice.Playback.Snapshot.Get(149, 0f);
                if (priority < minimumPriority || priority == minimumPriority &&
                    (victim == null || voice.AllocationOrder < victim.AllocationOrder))
                { minimumPriority = priority; victim = voice; }
            }
            if (victim == null || incoming.Playback.Snapshot.Get(149, 0f) < minimumPriority) return false;
            int stolenSlot = victim.Slot;
            DetachVoice(victim);
            victim.Playback.Voices.Remove(victim);
            AssignSlot(incoming, stolenSlot);
            return true;
        }

        private int FindFreeSlot(int first, int count)
        {
            int busy = -1;
            for (int i = first; i < first + count; i++)
                if (voiceSlots[i].Owner == null)
                {
                    var current = voiceSlots[i].Current;
                    if (current == null || current.SoundEnded) return i;
                    busy = i;
                }
            return busy;
        }

        private void AssignSlot(Voice voice, int slot)
        {
            voice.Slot = slot;
            voiceSlots[slot].Owner = voice;
        }

        private void ReleaseVoiceAllocation(Voice voice)
        {
            voice.AllocationReleased = true;
            if (voice.Slot >= 0 && voiceSlots[voice.Slot].Owner == voice) voiceSlots[voice.Slot].Owner = null;
        }

        private void DetachVoice(Voice voice)
        {
            ReleaseVoiceAllocation(voice);
            voice.ReleaseRequested = true;
            if (!voice.Finished && voice.Slot >= 0 && voiceSlots[voice.Slot].Current == voice) retiredVoices.Add(voice);
            else voice.Finished = true;
        }

        private void GetPlaybackAudioTime(Playback playback, out long timeMs, out float scale)
        {
            timeMs = 0; scale = 1f;
            var group = playback.AudioGroups.Find(value => value.Voices.Exists(voice => !voice.AllocationReleased));
            // Every bound voice released while the playback is still listed (the last few
            // ms before Removed): F32D0 reports -1, not 0 (natural-end oracle).
            if (group == null) { if (playback.AudioGroups.Count != 0) timeMs = -1; return; }
            // F32D0 extrapolates only while the playback mask +168 is zero.
            group.Clock.Read(ClockNowUs(), paused || outputStalled || playback.PauseMask != 0, out timeMs, out scale);
        }
    }
}
