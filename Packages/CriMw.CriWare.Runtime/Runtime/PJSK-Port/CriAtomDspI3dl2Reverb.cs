using System;
using static CriWare.CriAtomDspMath;

namespace CriWare
{
    // CRIWARE/I3DL2Reverb, 0x1647fc/0x164fb0/0x1658b4. Stereo original ACF configuration.
    internal sealed class CriAtomDspI3dl2Reverb : CriAtomDsp
    {
        private readonly SmoothDelay early, late;
        private readonly Delay[] leftDelays = new Delay[5], rightDelays = new Delay[5], feedback = new Delay[4], diffusion = new Delay[4];
        private readonly Biquad[] inputFilters = { new Biquad(), new Biquad() };
        private readonly Biquad[] tailFilters = { new Biquad(), new Biquad(), new Biquad(), new Biquad() };
        private readonly float[][] scratch = new float[8][];
        private readonly float[] leftWeights = { -.83216f, .75346f, -.6367f, -.8763f, .7876f };
        private readonly float[] rightWeights = { .85346f, -.8763f, .75346f, -.83216f, -.6367f };
        private float earlyGain, lateGain, feedbackGain, inputGain, outputGain;
        private uint silentSamples, tailSamples;

        internal CriAtomDspI3dl2Reverb(int rate, int blockSize, float[] config) : base(rate, blockSize)
        {
            RequireValues(config, 0);
            early = new SmoothDelay(Samples(rate, 300)); late = new SmoothDelay(Samples(rate, 100));
            float[] left = { 5.4322f, 8.4535f, 12.437f, 21.546f, 34.388f };
            float[] right = { 4.7322f, 9.2345f, 13.437f, 22.546f, 33.388f };
            float[] tail = { 60f, 71.935f, 86.755f, 95.945f }, allpass = { 7.8f, 1.31f, 6.53f, 3.75f };
            for (int i = 0; i < 5; i++) { leftDelays[i] = FixedDelay(rate, left[i]); rightDelays[i] = FixedDelay(rate, right[i]); }
            for (int i = 0; i < 4; i++) { feedback[i] = FixedDelay(rate, tail[i]); diffusion[i] = FixedDelay(rate, allpass[i]); }
            for (int i = 0; i < scratch.Length; i++) scratch[i] = new float[256];
            SetParameters(new[] { -1000f, -100f, 1.49f, .83f, -2602f, .007f, 200f, .011f, 100f, 100f, 5000f,
                0f, 0f, -10000f, 0f, 0f, -10000f });
        }
        private static Delay FixedDelay(int rate, float ms) { var d = new Delay(Samples(rate, ms)); d.SetLength(d.Maximum); return d; }
        private static float Millibels(float value) { return value <= -10000 ? 0 : value >= 0 ? 1 : Pow(10, (float)((float)(value * .01f) / 20)); }
        internal override void SetParameters(float[] p)
        {
            RequireValues(p, 17);
            float room = Clamp(p[0], -10000, 0), hf = Clamp(p[1], -10000, 0), decay = Clamp(p[2], .1f, 20), ratio = Clamp(p[3], .1f, 2);
            float reflections = Clamp(p[4], -10000, 1000), earlyTime = Clamp(p[5], 0, .3f);
            float reverb = Clamp(p[6], -10000, 2000), lateTime = Clamp(p[7], 0, .1f);
            float diffuse = (float)(Clamp(p[8], 0, 100) * .81f), density = (float)(Clamp(p[9], 0, 100) * .01f), frequency = Clamp(p[10], 20, 20000);
            earlyGain = Millibels((float)(room + reflections)); lateGain = Millibels((float)(room + reverb)); feedbackGain = (float)(Pow(.001f, (float)(.1f / decay)) * .5f);
            for (int i = 0; i < 2; i++) Shelf(inputFilters[i], Rate, frequency, 1, Millibels(hf), false);
            early.Desired = Math.Min(early.StorageLength, (int)(float)(earlyTime * Rate));
            late.Desired = Math.Min(late.StorageLength, (int)(float)(lateTime * Rate));
            foreach (Delay d in diffusion) { d.SetLength(Math.Max(16, d.Maximum)); d.Gain = Clamp((float)(diffuse / 100), -.99f, .99f); }
            leftWeights[0] = (float)(-.83216f * density); leftWeights[1] = (float)(.75346f * density);
            rightWeights[0] = (float)(.85346f * density); rightWeights[1] = (float)(-.8763f * density);
            float[] gains = { .9528517127037048f, .8707224130630493f, .9733840227127075f, .855513334274292f };
            for (int i = 0; i < 4; i++) Shelf(tailFilters[i], Rate, frequency, .8f, ratio >= 1 ? (float)(gains[i] / ratio) : (float)(ratio * gains[i]), ratio >= 1);
            inputGain = Millibels(p[11]); outputGain = Millibels(p[14]);
            tailSamples = (uint)(float)((float)(decay + (float)(earlyTime + lateTime)) * Rate);
        }
        internal override void Reset()
        {
            early.Reset(); late.Reset();
            foreach (Delay d in leftDelays) d.Reset(); foreach (Delay d in rightDelays) d.Reset();
            foreach (Delay d in feedback) d.Reset(); foreach (Delay d in diffusion) d.Reset();
            foreach (Biquad f in inputFilters) f.Reset(); foreach (Biquad f in tailFilters) f.Reset();
            foreach (float[] b in scratch) Array.Clear(b, 0, b.Length);
        }
        protected override void ProcessBlock(float[][] input, float[][] output, int n, bool silent, out bool outputSilent)
        {
            if (silent && silentSamples > tailSamples) { outputSilent = true; return; }
            if (silent) silentSamples += (uint)n;
            else { if (silentSamples > tailSamples) Reset(); silentSamples = 0; }
            outputSilent = false; if (n == 0) return;
            float[] left = scratch[0], right = scratch[1], a = scratch[2], b = scratch[3], swapLeft = scratch[4], swapRight = scratch[6];
            Scale(left, input[0], n, inputGain); Scale(right, input[1], n, inputGain);
            left[0] = (float)(left[0] + (0.00000095367431640625f)); left[1] = (float)(left[1] - (0.00000095367431640625f));
            right[0] = (float)(right[0] + (0.00000095367431640625f)); right[1] = (float)(right[1] - (0.00000095367431640625f));
            inputFilters[0].Process(left, n); inputFilters[1].Process(right, n);
            early.Process(left, right, n);
            Scale(a, left, n, leftWeights[0]); Scale(b, right, n, rightWeights[0]);
            leftDelays[0].Process(a, n); rightDelays[0].Process(b, n);
            for (int stage = 1; stage < 5; stage++)
            {
                for (int i = 0; i < n; i++)
                {
                    swapLeft[i] = (float)(left[i] + a[i]); a[i] = (float)(leftWeights[stage] * (float)(left[i] - a[i]));
                    swapRight[i] = (float)(right[i] + b[i]); b[i] = (float)(rightWeights[stage] * (float)(right[i] - b[i]));
                }
                leftDelays[stage].Process(a, n); rightDelays[stage].Process(b, n);
                float[] old = left; left = swapLeft; swapLeft = old; old = right; right = swapRight; swapRight = old;
            }
            // 0x165ecc: the final reflection taps cross to the opposite channel.
            for (int i = 0; i < n; i++) { left[i] = (float)(b[i] + left[i]); right[i] = (float)(a[i] + right[i]); }
            late.Process(left, right, n);
            for (int c = 0; c < 4; c++) feedback[c].ReadBlock(scratch[c + 4], n);
            for (int i = 0; i < n; i++)
            {
                float sum0 = (float)(scratch[4][i] + scratch[5][i]), difference0 = (float)(scratch[4][i] - scratch[5][i]);
                float sum1 = (float)(scratch[6][i] + scratch[7][i]), difference1 = (float)(scratch[6][i] - scratch[7][i]);
                scratch[4][i] = (float)(sum0 + sum1); scratch[5][i] = (float)(difference0 + difference1);
                scratch[6][i] = (float)(sum0 - sum1); scratch[7][i] = (float)(difference0 - difference1);
            }
            for (int c = 0; c < 4; c++) { tailFilters[c].Process(scratch[c + 4], n); diffusion[c].AllPass(scratch[c + 4], n); Scale(scratch[c + 4], scratch[c + 4], n, feedbackGain); }
            if (outputGain <= 0) { Array.Clear(output[0], 0, n); Array.Clear(output[1], 0, n); }
            else
            {
                Scale(output[0], scratch[4], n, (float)(outputGain * lateGain)); Scale(output[1], scratch[5], n, (float)(lateGain * outputGain));
                Add(output[0], left, n, (float)(earlyGain * outputGain)); Add(output[1], right, n, (float)(earlyGain * outputGain));
            }
            for (int i = 0; i < n; i++) { scratch[4][i] = (float)(left[i] + scratch[4][i]); scratch[5][i] = (float)(right[i] + scratch[5][i]); }
            for (int c = 0; c < 4; c++) feedback[c].WriteBlock(scratch[c + 4], n);
        }

        // 0x17017c/0x17020c/0x170220, including its 256-sample crossfade when delay changes.
        private sealed class SmoothDelay
        {
            private readonly float[][] data;
            private readonly int maximum;
            private int length, write, read, target, progress = 256;
            internal int Desired;
            internal int StorageLength { get { return data[0].Length; } }
            internal SmoothDelay(int max)
            {
                maximum = max; length = write = Desired = target = max >> 1;
                int size = (max + 271) & ~15; data = new[] { new float[size], new float[size] };
            }
            internal void Reset()
            {
                length = Math.Min(maximum, Desired); write = length; read = 0;
                Array.Clear(data[0], 0, data[0].Length); Array.Clear(data[1], 0, data[1].Length);
            }
            internal void Process(float[] left, float[] right, int n)
            {
                int offset = 0, size = StorageLength;
                while (offset < n)
                {
                    if (Desired != target && progress == 256) { target = Desired; progress = 0; }
                    int count = Math.Min(n - offset, Math.Min(size - write, size - read));
                    bool fade = progress < 256;
                    int newRead = (write + size - target) % size;
                    if (fade) count = Math.Min(count, Math.Min(256 - progress, size - newRead));
                    float amount = (float)(progress / 256f), oldAmount = (float)(1 - amount);
                    for (int i = 0; i < count; i++)
                    {
                        data[0][write + i] = left[offset + i]; data[1][write + i] = right[offset + i];
                        left[offset + i] = fade ? (float)((float)(oldAmount * data[0][read + i]) + (float)(amount * data[0][newRead + i])) : data[0][read + i];
                        right[offset + i] = fade ? (float)((float)(oldAmount * data[1][read + i]) + (float)(amount * data[1][newRead + i])) : data[1][read + i];
                        amount = (float)(amount + (1f / 256)); oldAmount = (float)(oldAmount - (1f / 256));
                    }
                    write = (write + count) % size; read = (read + count) % size;
                    if (fade)
                    {
                        progress += count;
                        if (progress >= 256) { length = Math.Min(maximum, target); read = (write + size - length) % size; }
                    }
                    offset += count;
                }
            }
        }
    }
}
