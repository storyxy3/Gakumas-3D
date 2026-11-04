using System;

namespace CriWare
{
    // Original OutputAnalyzer level meter of libcri_ware_unity 6.8.1.
    //   create  sub_12C7D8 (from criAtomExOutputAnalyzer_Create 0x34530 with the
    //           fixed internal config {channels=2, rate=48000}): 48 output slots,
    //           publish interval rate/20 = 2400 samples, peak hold = rate = 48000.
    //   feed    sub_12C8BC, reached through sub_34A08 -> sub_34D44 (float format
    //           only) from the decoder's per-chunk callback sub_FCD14 (DBDDC).
    //   sumsq   sub_12C648 (NEON, separate FMUL/FADD), peak sub_12C700 (sqrt of
    //           max x^2), publish sqrt sub_19C008 (FSQRT S0).
    //   read    criAtomExOutputAnalyzer_GetRms 0x34A5C.
    // All arithmetic is float32. The interval and hold are independent of the
    // source sampling rate; decay is per callback, not per time unit.
    public sealed class CriAtomLevelMeter
    {
        public const int Slots = 48;                 // meter +0x0C
        private const int Channels = 16;
        private const float HoldFloor = 1e-6f;        // dword_1E161C = 0x358637BD

        private readonly int interval;                // meter +228 (rate / 20)
        private readonly int holdSamples;             // meter +236 (rate)
        private readonly float[] output = new float[Slots];    // meter +0x10 -> +0x20
        private readonly int[] holdCounter = new int[Channels]; // meter +240
        private readonly float[] sum = new float[Channels];     // meter +304
        private readonly float[] peak = new float[Channels];    // meter +368
        private readonly float[] hold = new float[Channels];    // meter +432
        private int count;                            // meter +232

        public CriAtomLevelMeter(int sampleRate = 48000)
        {
            if (sampleRate < 20) throw new ArgumentOutOfRangeException(nameof(sampleRate));
            interval = sampleRate / 20;
            holdSamples = sampleRate;
        }

        public int Interval => interval;
        public int AccumulatedSamples => count;

        // criAtomExOutputAnalyzer_GetRms: slot < 48 returns the last published
        // value; slots 16..31 are peaks and 32..47 are peak holds, as in native.
        public float Read(int slot) => (uint)slot < Slots ? output[slot] : 0f;

        // sub_12C8BC(meter, channels, samples, planes). Each plane is read from
        // offset for samples values. aligned selects the 16-byte aligned NEON
        // path of sub_12C648/sub_12C700; unaligned planes are summed in scalar
        // order. Native decoder PCM blocks are aligned.
        public void Accumulate(int channels, int samples, float[][] planes, int offset = 0, bool aligned = true)
        {
            if (samples < 0) throw new ArgumentOutOfRangeException(nameof(samples));
            if (planes != null && channels > 0)
            {
                if (channels > Channels) throw new ArgumentOutOfRangeException(nameof(channels));
                for (int channel = 0; channel < channels; channel++)
                {
                    var plane = planes[channel];
                    float squares = aligned ? SumSquaresAligned(plane, offset, samples) : SumSquaresScalar(plane, offset, samples, 0f);
                    float blockPeak = aligned ? PeakAligned(plane, offset, samples) : PeakScalar(plane, offset, samples, 0f);
                    sum[channel] = (float)(squares + sum[channel]);
                    if (blockPeak > peak[channel])
                    {
                        peak[channel] = blockPeak;
                        if (blockPeak > hold[channel]) { holdCounter[channel] = 0; hold[channel] = blockPeak; }
                    }
                }
            }
            for (int channel = 0; channel < Channels; channel++)
            {
                if (holdCounter[channel] < holdSamples) holdCounter[channel] = unchecked(holdCounter[channel] + samples);
                else
                {
                    float value = (float)(hold[channel] + (float)(hold[channel] / -20f));
                    hold[channel] = value < HoldFloor ? 0f : value;
                }
            }
            count = unchecked(count + samples);
            if (count < interval) return;
            float scale = (float)(1f / (float)count);
            for (int channel = 0; channel < Channels; channel++)
            {
                output[channel] = (float)Math.Sqrt((float)(scale * sum[channel]));
                output[Channels + channel] = peak[channel];
                output[2 * Channels + channel] = hold[channel];
                peak[channel] = 0f; sum[channel] = 0f;
            }
            count = 0;
        }

        // sub_12C648, 16-byte aligned path: four lanes, lane j accumulates
        // samples 16k+j, 16k+4+j, 16k+8+j, 16k+12+j with separate multiply and
        // add; lanes merge as l3 + (l2 + (l0 + l1)); the tail is scalar.
        internal static float SumSquaresAligned(float[] x, int offset, int samples)
        {
            int blocks = samples & ~15;
            float l0 = 0f, l1 = 0f, l2 = 0f, l3 = 0f;
            for (int i = offset; i < offset + blocks; i += 16)
                for (int quad = 0; quad < 16; quad += 4)
                {
                    l0 = (float)(l0 + (float)(x[i + quad] * x[i + quad]));
                    l1 = (float)(l1 + (float)(x[i + quad + 1] * x[i + quad + 1]));
                    l2 = (float)(l2 + (float)(x[i + quad + 2] * x[i + quad + 2]));
                    l3 = (float)(l3 + (float)(x[i + quad + 3] * x[i + quad + 3]));
                }
            float total = (float)(l3 + (float)(l2 + (float)(l0 + l1)));
            return SumSquaresScalar(x, offset + blocks, samples - blocks, total);
        }

        internal static float SumSquaresScalar(float[] x, int offset, int samples, float total)
        {
            for (int i = offset; i < offset + samples; i++) total = (float)(total + (float)(x[i] * x[i]));
            return total;
        }

        // sub_12C700: FMAX over lanes, FCSEL GT merge, scalar tail, FSQRT.
        internal static float PeakAligned(float[] x, int offset, int samples)
        {
            int blocks = samples & ~15;
            float l0 = 0f, l1 = 0f, l2 = 0f, l3 = 0f;
            for (int i = offset; i < offset + blocks; i += 16)
                for (int quad = 0; quad < 16; quad += 4)
                {
                    l0 = Max(l0, (float)(x[i + quad] * x[i + quad]));
                    l1 = Max(l1, (float)(x[i + quad + 1] * x[i + quad + 1]));
                    l2 = Max(l2, (float)(x[i + quad + 2] * x[i + quad + 2]));
                    l3 = Max(l3, (float)(x[i + quad + 3] * x[i + quad + 3]));
                }
            float a = l0 > l1 ? l0 : l1, b = l2 > l3 ? l2 : l3;
            float merged = a > b ? a : b;
            return PeakScalar(x, offset + blocks, samples - blocks, merged);
        }

        internal static float PeakScalar(float[] x, int offset, int samples, float maximum)
        {
            for (int i = offset; i < offset + samples; i++)
            {
                float square = (float)(x[i] * x[i]);
                if (square > maximum) maximum = square;
            }
            return (float)Math.Sqrt(maximum);
        }

        // NEON FMAX: NaN propagates; otherwise the larger value.
        private static float Max(float a, float b) => float.IsNaN(a) || float.IsNaN(b) ? float.NaN : a > b ? a : b;
    }
}
