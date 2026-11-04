using System;
using System.Collections.Generic;
using System.IO;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed partial class ManaPlayer
        {
            internal ManaAudioSource AudioSource;
        }

        // ManaSoundEx uses a dedicated raw-PCM source (58924/58C8C), separate
        // from the ACB/HCA pools. The advanced track borrows its Atom player.
        private sealed class ManaAudioSource
        {
            internal readonly ManaPlayer Movie;
            internal readonly Player Owner;
            internal readonly bool Advanced;
            internal float[][] Pcm, NextPcm;
            internal readonly float[][] Output = { new float[256], new float[256] };
            internal readonly CriAtomResampler Resampler = new CriAtomResampler(2);
            internal readonly CriAtomAudioClock Clock;
            internal readonly CriManaAudioClock OrdinaryClock = new CriManaAudioClock();
            internal readonly int SamplingRate;
            internal int Frames, CurrentPosition;
            internal uint QueuedFileIndex, CheckedFileIndex;
            internal string QueuedPath;
            internal readonly double TimelineOffset;
            internal readonly float SeekSeconds;
            internal Parameters Snapshot;
            internal int StartPhase;
            internal long SourceOrder = -1, PlayedSamples, Position;
            internal float Volume, LastGain;
            internal bool Requested, Paused, StopRequested, Releasing, Finished, ParametersDirty;
            private readonly Queue<(long OutputFrame, long SourceSamples)> progress = new Queue<(long, long)>();

            internal ManaAudioSource(ManaPlayer movie, Player owner, bool advanced, float[] samples,
                int samplingRate, int outputRate, double timelineOffset, float seekSeconds)
            {
                Movie = movie; Owner = owner; Advanced = advanced; SamplingRate = samplingRate;
                Frames = samples.Length / 2; TimelineOffset = timelineOffset; SeekSeconds = seekSeconds;
                Pcm = Planar(samples);
                Resampler.SetRates(samplingRate, outputRate);
                Clock = new CriAtomAudioClock(true, 0, outputRate);
                Snapshot = new Parameters(owner.Pending);
                Volume = LastGain = ManaAudioVolume(Snapshot);
            }

            internal int Read(int count)
            {
                int produced = 0;
                while (produced < count)
                {
                    if (CurrentPosition == Frames)
                    {
                        if (NextPcm == null) break;
                        Pcm = NextPcm; NextPcm = null; Frames = Pcm[0].Length; CurrentPosition = 0;
                    }
                    int available = Math.Min(Resampler.GetRequiredInput(count - produced), Frames - CurrentPosition), read;
                    if (Resampler.IsActive) read = Resampler.Process(Pcm, CurrentPosition, available, Output, produced, count - produced);
                    else
                    {
                        read = available;
                        Array.Copy(Pcm[0], CurrentPosition, Output[0], produced, read);
                        Array.Copy(Pcm[1], CurrentPosition, Output[1], produced, read);
                    }
                    Position += available; CurrentPosition += available; produced += read;
                    if (available == 0) break;
                }
                return produced;
            }

            internal static float[][] Planar(float[] samples)
            {
                int frames = samples.Length / 2;
                var pcm = new[] { new float[frames], new float[frames] };
                for (int i = 0; i < frames; i++) { pcm[0][i] = samples[2 * i]; pcm[1][i] = samples[2 * i + 1]; }
                return pcm;
            }

            internal void RecordProgress(long outputFrame) => progress.Enqueue((outputFrame, Position));
            internal void CommitProgress(long outputFrame)
            {
                while (progress.Count != 0 && progress.Peek().OutputFrame <= outputFrame)
                    PlayedSamples = progress.Dequeue().SourceSamples;
            }
        }

        private readonly List<ManaAudioSource> manaAudioSources = new List<ManaAudioSource>();

        private void LoadManaAudio(ManaPlayer p, CriManaUsm file, int seekFrame)
        {
            var continued = p.AudioSource;
            if (p.Concatenated != 0 && continued != null && !continued.StopRequested &&
                continued.QueuedFileIndex == p.Concatenated && continued.QueuedPath == p.CurrentPath)
                return;
            StopManaAudio(p);
            p.AudioSource = null;
            if (file.Audio == null) return;
            var decoder = CriManaAdxDecoder.Parse(file.CopyAudioStream());
            if (decoder.SamplingRate != file.Audio.SamplingRate || decoder.Channels != file.Audio.Channels ||
                decoder.TotalSamples != file.Audio.TotalSamples)
                throw new InvalidDataException("USM and ADX audio headers disagree.");
            int skipped = 0;
            if (seekFrame > 0)
            {
                // 48DC8 drops complete SFA packets before the requested video
                // time, then 4DEB0 resets the ADX predictor to header history.
                float seconds = (float)((float)seekFrame * 1000f) / file.Video.FrameRateNumerator;
                foreach (var packet in file.AudioPackets)
                {
                    var bytes = packet.Data;
                    if (bytes.Count < 2 || (bytes.Array[bytes.Offset] & 0x80) != 0) continue;
                    if (packet.RawRate == 0) throw new InvalidDataException("Invalid USM audio packet rate.");
                    if ((float)packet.RawTime / packet.RawRate >= seconds) break;
                    if (bytes.Count % (18 * decoder.Channels) != 0)
                        throw new InvalidDataException("ADX packet ends inside a sample block.");
                    skipped = checked(skipped + bytes.Count / (18 * decoder.Channels) * 32);
                }
            }
            bool advanced = p.Tracks[0] != IntPtr.Zero;
            var owner = advanced ? Get<Player>(p.Tracks[0]) : new Player();
            if (owner == null) throw new InvalidOperationException("Mana audio track was destroyed.");
            uint frameRate = (uint)((long)file.Video.FrameRateNumerator * 1000 / file.Video.FrameRateDenominator);
            float seekSeconds = (float)((float)(seekFrame * 1000f) / frameRate);
            var source = new ManaAudioSource(p, owner, advanced, decoder.DecodeFromBlock(skipped), decoder.SamplingRate, SampleRate,
                p.FileStartSeconds, seekSeconds) { QueuedFileIndex = p.Concatenated };
            p.AudioSource = source; owner.ManaAudio = source;
            manaAudioSources.Add(source);
            if (p.Status == CriMana.Player.Status.Playing) StartManaAudio(p);
        }

        private void PrimeManaNextAudio(ManaPlayer p)
        {
            var source = p.AudioSource;
            if (source == null || source.StopRequested || source.Finished || !p.HasNextFile ||
                source.NextPcm != null || source.QueuedFileIndex > p.Concatenated || source.CheckedFileIndex > p.Concatenated) return;
            var next = CriManaUsm.Parse(readFile(p.NextPath));
            source.CheckedFileIndex = p.Concatenated + 1;
            if (next.Audio == null) return;
            if (next.Audio.SamplingRate != source.SamplingRate || next.Audio.Channels != 2)
                throw new NotSupportedException("Concatenated Mana audio must keep the original stereo sample rate.");
            var decoder = CriManaAdxDecoder.Parse(next.CopyAudioStream());
            if (decoder.TotalSamples != next.Audio.TotalSamples)
                throw new InvalidDataException("Concatenated USM and ADX audio headers disagree.");
            source.NextPcm = ManaAudioSource.Planar(decoder.Decode());
            source.QueuedFileIndex = p.Concatenated + 1; source.QueuedPath = p.NextPath;
        }

        private void StartManaAudio(ManaPlayer p)
        {
            var source = p.AudioSource;
            if (source == null || source.Requested || source.Finished) return;
            source.Requested = true; source.Paused = p.Paused;
            source.Owner.Played = true;
            source.Snapshot = new Parameters(source.Owner.Pending);
            source.Volume = source.LastGain = ManaAudioVolume(source.Snapshot);
            if (source.Paused) source.LastGain = 0f;
        }

        private void StopManaAudio(ManaPlayer p, bool dispose = false)
        {
            var source = p.AudioSource;
            if (source == null) return;
            StopManaAudioSource(source);
            if (dispose) p.AudioSource = null;
        }

        private static void StopManaAudioSource(ManaAudioSource source)
        {
            if (source.StopRequested) return;
            source.StopRequested = true;
            source.Owner.Played = false; source.Owner.Status = CriAtomExPlayer.Status.Stop;
            if (source.Owner.ManaAudio == source) source.Owner.ManaAudio = null;
            if (!source.Requested || source.SourceOrder < 0) source.Finished = true;
        }

        private void PauseManaAudio(ManaPlayer p, bool pause)
        {
            if (p.AudioSource == null) return;
            p.AudioSource.Paused = pause;
            p.AudioSource.OrdinaryClock.Pause(pause, (ulong)audioTimestampUs);
        }

        private static void UpdateManaAudioParameters(Player player)
        {
            var source = player.ManaAudio;
            if (source == null || source.StopRequested) return;
            source.Snapshot = new Parameters(player.Pending); source.ParametersDirty = true;
        }

        private static float ManaAudioVolume(Parameters parameters)
        {
            float volume = parameters.Get(0, 1f);
            return float.IsNaN(volume) || volume <= 1f / 65536f ? 0f : volume;
        }

        private void ClearManaAudioSources()
        {
            foreach (var source in manaAudioSources)
            {
                StopManaAudioSource(source); source.Finished = true;
                if (source.Movie.AudioSource == source) source.Movie.AudioSource = null;
            }
            manaAudioSources.Clear();
        }

        private void ServiceManaAudioSources()
        {
            foreach (var source in manaAudioSources)
            {
                if (source.Finished || !source.Requested) continue;
                if (source.Releasing) { source.Finished = true; continue; }
                source.Releasing = source.StopRequested;
                if (source.ParametersDirty)
                {
                    source.Volume = ManaAudioVolume(source.Snapshot);
                    source.ParametersDirty = false;
                }
                if (source.StartPhase == 0)
                {
                    source.StartPhase = 1; source.Owner.Status = CriAtomExPlayer.Status.Prep;
                    source.OrdinaryClock.Start((ulong)audioTimestampUs);
                    source.OrdinaryClock.Pause(source.Paused, (ulong)audioTimestampUs);
                    continue;
                }
                if (source.StartPhase == 1)
                {
                    source.StartPhase = 2; source.Owner.Status = CriAtomExPlayer.Status.Playing;
                    source.SourceOrder = nextSourceOrder++; source.Clock.BeginService(audioTimestampUs);
                }
                source.Clock.ObserveSource(audioTimestampUs, audioTimestampUs,
                    source.PlayedSamples == 0 ? -1 : source.PlayedSamples, source.SamplingRate, 0, source.Paused);
                PrimeManaNextAudio(source.Movie);
            }
            manaAudioSources.Sort((left, right) => left.SourceOrder.CompareTo(right.SourceOrder));
        }

        private void CommitManaAudioProgress(long outputFrame)
        { foreach (var source in manaAudioSources) source.CommitProgress(outputFrame); }

        private bool TryReadManaAudioClock(ManaPlayer p, out ulong count, out ulong unit)
        {
            count = 0; unit = 1000;
            var source = p.AudioSource;
            if (source == null || source.StopRequested || source.Finished) return false;
            if (source.Advanced)
            {
                source.Clock.Read(audioTimestampUs, paused || source.Paused, out long milliseconds, out _);
                count = (ulong)Math.Max(0, milliseconds + (long)(source.TimelineOffset * 1000));
            }
            else
            {
                source.OrdinaryClock.Pause(paused || source.Paused, (ulong)audioTimestampUs);
                if (source.PlayedSamples != 0)
                    source.OrdinaryClock.Read((ulong)audioTimestampUs, (ulong)source.PlayedSamples,
                        (uint)source.SamplingRate, out count, out unit);
                count += (ulong)Math.Max(0, (long)(source.TimelineOffset * unit));
            }
            if (source.SeekSeconds > 0f)
            {
                float seconds = source.SeekSeconds;
                if (source.StartPhase != 0)
                {
                    // 5EDA8 / rodata 1D4374: only an active audio timer adds
                    // this float32 correction to a nonzero video seek.
                    const float quantum = 0.033366698771715164f;
                    seconds = (float)((float)((float)(seconds + quantum) / quantum) * quantum);
                }
                count += (ulong)(float)(seconds * (float)unit);
            }
            return true;
        }

        private void RenderManaAudioBefore(long order, int count, ref int index)
        {
            while (index < manaAudioSources.Count)
            {
                var source = manaAudioSources[index];
                if (source.SourceOrder >= order) break;
                index++;
                if (source.Finished || source.SourceOrder < 0) continue;
                float gain = source.Paused || source.StopRequested ? 0f : source.Volume;
                // Pausing consumes one ramp-down block; subsequent paused
                // requests return zero without moving the source cursor.
                if (source.Paused && source.LastGain == 0f && !source.StopRequested) continue;
                int samples = source.Read(count);
                if (samples == 0)
                {
                    source.Finished = true;
                    if (!source.StopRequested) source.Owner.Status = CriAtomExPlayer.Status.PlayEnd;
                    continue;
                }
                source.RecordProgress(renderedFrames + count);
                for (int channel = 0; channel < 2; channel++)
                    mixer.Add(0, source.Output[channel], 0, channel, samples, source.LastGain, gain);
                source.LastGain = gain;
            }
        }
    }

    // Ordinary CriManaSound: 569CC/56AA4, distinct from SoundEx's Atom clock.
    // Only the comparison is float32; elapsed time and rate conversion are integers.
    internal sealed class CriManaAudioClock
    {
        private ulong anchorUs, predictedCount, predictedUnit = 1000;
        private bool started, paused;

        internal void Start(ulong nowUs)
        { anchorUs = nowUs; predictedCount = 0; predictedUnit = 1000; started = true; }

        internal void Pause(bool value, ulong nowUs)
        {
            if (paused == value) return;
            if (started)
            {
                if (value) predictedCount = unchecked(predictedCount + Elapsed(nowUs));
                else anchorUs = nowUs;
            }
            paused = value;
        }

        internal void Read(ulong nowUs, ulong samples, uint rate, out ulong count, out ulong unit)
        {
            if (!started) { count = 0; unit = 1000; return; }
            if (paused) { count = predictedCount; unit = predictedUnit; return; }
            ulong before = predictedCount;
            predictedCount = unchecked(before + Elapsed(nowUs)); predictedUnit = 1000000;
            float sourceSeconds = (float)((float)samples / (float)rate);
            float predictedSeconds = (float)((float)predictedCount / (float)predictedUnit);
            if (sourceSeconds > predictedSeconds)
            {
                count = samples; unit = rate;
                predictedCount = unchecked(predictedUnit * samples) / rate;
            }
            else
            {
                if ((float)(predictedSeconds - sourceSeconds) >= 0.032f) predictedCount = before;
                count = predictedCount; unit = predictedUnit;
            }
            anchorUs = nowUs;
        }

        private ulong Elapsed(ulong nowUs) => unchecked(nowUs + (nowUs < anchorUs ? ~anchorUs : 0UL - anchorUs));
    }
}
