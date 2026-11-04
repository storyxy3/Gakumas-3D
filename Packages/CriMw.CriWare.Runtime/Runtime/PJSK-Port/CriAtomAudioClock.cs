using System;

namespace CriWare
{
    // Original A4884 sound-group timer and F32D0 getter. Source samples and both
    // clocks are supplied by the platform; rendering ahead is not elapsed audio.
    internal sealed class CriAtomAudioClock
    {
        private readonly bool enabled;
        private readonly long initialSeekUs; // group +88
        private readonly int outputRate;

        public long LastServiceUs { get; private set; }       // group +112
        public long AnchorServiceUs { get; private set; }     // group +120
        public long AnchorTimeUs { get; private set; }        // group +128
        public long SnapshotTimeUs { get; private set; }      // group +136
        public long SnapshotTimestampUs { get; private set; } // group +144, converted from platform ticks
        public long SampledTimeUs { get; private set; }       // group +152
        public long WindowUs { get; private set; } = 71428;   // group +160
        public long UpperTimeUs { get; private set; }         // group +168
        public long ScaleDenominator { get; private set; } = 1; // group +176
        public long ScaleNumerator { get; private set; } = 1; // group +184
        public int SamplingRate { get; private set; }         // group +192
        public float SampledSpeed { get; private set; } = 1f; // group +200

        public CriAtomAudioClock(bool enabled, long initialSeekUs, int outputRate)
        {
            if (initialSeekUs < 0) throw new ArgumentOutOfRangeException(nameof(initialSeekUs));
            if (outputRate < 1) throw new ArgumentOutOfRangeException(nameof(outputRate));
            this.enabled = enabled; this.initialSeekUs = initialSeekUs; this.outputRate = outputRate;
            AnchorTimeUs = SnapshotTimeUs = SampledTimeUs = UpperTimeUs = initialSeekUs;
            SamplingRate = outputRate;
        }

        // A4BE8: call once when the group enters playing phase, including a
        // fader-held group. serviceUs shares the Atom initialization origin;
        // timestampUs below uses the platform's monotonic origin instead.
        public void BeginService(long serviceUs) => LastServiceUs = serviceUs;

        // A4884's nonzero-delta playing-group pass. sourceSamples includes the
        // seek offset and actual renderer input consumption. A negative value
        // means no valid source; held combines native group flags +57 and +58.
        public void ObserveSource(long serviceUs, long timestampUs, long sourceSamples,
            int sourceRate, long sourceSeekSamples, bool held, float speed = 1f)
        {
            if (!enabled) return;
            if (sourceSamples < 0 || sourceSamples <= sourceSeekSamples)
            {
                AnchorTimeUs = SnapshotTimeUs = SampledTimeUs = UpperTimeUs = initialSeekUs;
                ScaleNumerator = ScaleDenominator = 1;
                SamplingRate = outputRate;
                return;
            }
            if (sourceRate < 1) throw new ArgumentOutOfRangeException(nameof(sourceRate));
            if (speed <= 0f) throw new ArgumentOutOfRangeException(nameof(speed));
            if (SamplingRate != sourceRate)
            {
                // This uses the original source rate, not the pitched renderer
                // increment. Authored +50 cents does not change this ratio.
                ScaleNumerator = ((long)sourceRate * 4096 / outputRate) * outputRate;
                ScaleDenominator = (long)sourceRate * 4096;
                SamplingRate = sourceRate;
            }
            long advance = (serviceUs - LastServiceUs) * ScaleNumerator / ScaleDenominator;
            LastServiceUs = serviceUs;
            float previousSpeed = SampledSpeed;
            SampledSpeed = speed;
            long sampled = sourceSamples * 1000000 / sourceRate;
            long delta = sampled - SampledTimeUs;
            if (held)
            {
                SampledTimeUs = sampled;
                AnchorServiceUs = serviceUs;
                AnchorTimeUs = SnapshotTimeUs + Math.Min(delta, advance);
                SnapshotTimeUs = AnchorTimeUs;
                SnapshotTimestampUs = timestampUs;
                return;
            }

            long window = WindowUs;
            if (window >= 1 && SnapshotTimeUs == window + SampledTimeUs)
            {
                if (delta >= 1)
                {
                    SampledTimeUs = sampled;
                    WindowUs = window -= delta;
                    AnchorServiceUs = serviceUs;
                }
                if (sampled < AnchorTimeUs) return;
                AnchorTimeUs = sampled;
                WindowUs = window = 71428;
            }
            long anchor = AnchorServiceUs;
            SampledTimeUs = sampled;
            if (anchor != 0)
            {
                if (2 * delta > window) WindowUs = window = Math.Min(71428, 2 * delta);
            }
            else
            {
                AnchorServiceUs = anchor = serviceUs;
                AnchorTimeUs = sampled;
                WindowUs = window = 2 * (sampled - initialSeekUs);
            }
            if (previousSpeed != speed)
            {
                AnchorServiceUs = anchor = serviceUs;
                AnchorTimeUs = SnapshotTimeUs + advance;
            }
            long scaled = (serviceUs - anchor) * ScaleNumerator / ScaleDenominator;
            long estimate = AnchorTimeUs + (long)(float)((float)scaled / speed);
            long radius = (long)(float)(speed * (float)window);
            long upper = sampled + radius;
            if (estimate > upper || estimate < sampled - radius)
            {
                estimate = estimate > upper ? upper : sampled;
                AnchorServiceUs = serviceUs;
                AnchorTimeUs = estimate;
            }
            SnapshotTimeUs = estimate;
            SnapshotTimestampUs = timestampUs;
            UpperTimeUs = upper;
        }

        // Caller handles missing IDs (-1) and sequences without a group (0).
        // Keep integer scaling before float32 conversion and truncation.
        public void Read(long timestampUs, bool paused, out long timeMs, out float scale, float speed = 1f)
        {
            long time = SnapshotTimeUs;
            if (time > 0 && !paused)
            {
                long elapsed = (timestampUs - SnapshotTimestampUs) * ScaleNumerator / ScaleDenominator;
                time = Math.Min(UpperTimeUs, time + (long)(float)((float)elapsed / Math.Max(SampledSpeed, speed)));
            }
            timeMs = time > 0 ? time / 1000 : time;
            scale = (float)ScaleNumerator / (float)ScaleDenominator;
        }
    }
}
