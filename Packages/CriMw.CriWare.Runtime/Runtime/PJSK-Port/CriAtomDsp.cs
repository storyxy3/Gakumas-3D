using System;

namespace CriWare
{
    // JP7 libcri_ware_unity.so effect interface. Planar blocks match the original ASR ABI.
    internal abstract class CriAtomDsp
    {
        protected readonly int Rate, BlockSize;
        protected CriAtomDsp(int rate, int blockSize) { Rate = rate; BlockSize = blockSize; }

        internal static CriAtomDsp Create(string name, int inputChannels, int outputChannels, int sampleRate,
            int maxBlockSize, float[] config, float[] parameters, Action<string> warning = null)
        {
            if (inputChannels != 2 || outputChannels != 2)
                throw new NotSupportedException("Only the original stereo ASR effect configuration is supported.");
            if (sampleRate < 8000 || sampleRate > 192000) throw new ArgumentOutOfRangeException(nameof(sampleRate));
            if (maxBlockSize < 16 || maxBlockSize > 256 || (maxBlockSize & 15) != 0)
                throw new ArgumentOutOfRangeException(nameof(maxBlockSize));
            CriAtomDsp effect;
            switch (name)
            {
                case "CRIWARE/Limiter":
                    RequireValues(config, 2);
                    if (config[0] != 0 || config[1] != 0) throw new NotSupportedException("External limiter sidechain configuration is unsupported.");
                    effect = new Limiter(sampleRate, maxBlockSize); break;
                case "CRIWARE/MultiTapDelay":
                    RequireValues(config, 1);
                    warning?.Invoke("W2021040245:ASR needs to be set at least 6 ch to use Multitap Delay Effect.");
                    effect = new StereoMultiTap(sampleRate, maxBlockSize); break;
                case "CRIWARE/Reverb":
                    effect = new CriAtomDspReverb(sampleRate, maxBlockSize, config); break;
                case "CRIWARE/I3DL2Reverb":
                    effect = new CriAtomDspI3dl2Reverb(sampleRate, maxBlockSize, config); break;
                default: throw new NotSupportedException("Unsupported native DSP effect: " + name);
            }
            // Native attachment resets constructor defaults before applying the authored ACF
            // parameters. Reversing these calls changes delay positions and initial crossfades.
            effect.Reset();
            effect.SetParameters(parameters);
            return effect;
        }

        internal abstract void SetParameters(float[] parameters);
        internal abstract void Reset();
        internal void Process(float[][] input, float[][] output, int sampleCount, bool inputSilent, out bool outputSilent)
        {
            if (sampleCount < 0 || sampleCount > BlockSize || (sampleCount & 15) != 0)
                throw new ArgumentOutOfRangeException(nameof(sampleCount));
            RequireBuffers(input, sampleCount); RequireBuffers(output, sampleCount);
            ProcessBlock(input, output, sampleCount, inputSilent, out outputSilent);
        }
        protected abstract void ProcessBlock(float[][] input, float[][] output, int count, bool silent, out bool outputSilent);
        private static void RequireBuffers(float[][] buffers, int count)
        {
            if (buffers == null || buffers.Length != 2 || buffers[0] == null || buffers[1] == null ||
                buffers[0].Length < count || buffers[1].Length < count) throw new ArgumentException("Stereo planar buffers are required.");
        }
        protected static void RequireValues(float[] values, int count)
        {
            if (values == null || values.Length != count) throw new ArgumentException("Unexpected DSP parameter count.");
            foreach (float value in values)
                if (float.IsNaN(value) || float.IsInfinity(value)) throw new ArgumentException("DSP parameters must be finite.");
        }
        protected static float Clamp(float value, float low, float high)
        {
            float result = Math.Max(low, Math.Min(high, value));
            return result == 0f ? 0f : result;
        }

        // 0x1638d4: with fewer than six output channels the actual plugin is passthrough.
        private sealed class StereoMultiTap : CriAtomDsp
        {
            internal StereoMultiTap(int rate, int blockSize) : base(rate, blockSize) { }
            internal override void SetParameters(float[] values) { RequireValues(values, 16); }
            internal override void Reset() { }
            protected override void ProcessBlock(float[][] input, float[][] output, int count, bool silent, out bool outputSilent)
            {
                outputSilent = silent;
                if (!silent) for (int c = 0; c < 2; c++) Array.Copy(input[c], output[c], count);
            }
        }

        // 0x12fdec / 0x130574. The peak detector compares squared amplitudes, as shipped.
        private sealed class Limiter : CriAtomDsp
        {
            private float threshold, makeup = 1, link;
            private int attack, release, detector;
            private readonly float[] gain = new float[2], previous = new float[2], rms = new float[2], rmsLast = new float[2];
            internal Limiter(int rate, int blockSize) : base(rate, blockSize) { }
            internal override void SetParameters(float[] p)
            {
                RequireValues(p, 6);
                threshold = Clamp(p[0], 0, 1);
                attack = (int)(float)((float)(Clamp(p[1], 0, 200) * Rate) / 1000f);
                release = (int)(float)((float)(Clamp(p[2], 0, 50000) * Rate) / 1000f);
                makeup = Clamp(p[3], (float)Math.Pow(10, -50f / 20f), (float)Math.Pow(10, 50f / 20f));
                link = Clamp(p[4], 0, 1); detector = (int)p[5];
            }
            internal override void Reset()
            {
                for (int c = 0; c < 2; c++) { gain[c] = previous[c] = makeup; rms[c] = rmsLast[c] = 0; }
            }
            protected override void ProcessBlock(float[][] input, float[][] output, int n, bool silent, out bool outputSilent)
            {
                outputSilent = silent;
                if (n == 0) return;
                if (silent)
                {
                    for (int c = 0; c < 2; c++) UpdateGain(c, makeup, n);
                    return;
                }
                for (int c = 0; c < 2; c++)
                {
                    float peak = 0, sum = 0;
                    for (int i = 0; i < n; i++) { float square = (float)(input[c][i] * input[c][i]); peak = Math.Max(peak, square); sum = (float)(sum + (square)); }
                    float currentRms = (float)Math.Sqrt((float)(sum / n));
                    rms[c] = (float)((float)(currentRms + rms[c]) - rmsLast[c]); rmsLast[c] = currentRms;
                    float measure = detector == 0 ? peak : detector == 1 ? rms[c] : 0;
                    float reduction = threshold < measure && threshold > 0 ? (float)(threshold / measure) : 1;
                    UpdateGain(c, (float)(reduction * makeup), n);
                }
                float minimum = Math.Min(makeup, Math.Min(gain[0], gain[1]));
                if (link != 0) for (int c = 0; c < 2; c++)
                    if (gain[c] > minimum) gain[c] = (float)((float)(minimum * link) + (float)(gain[c] * (float)(1 - link)));
                for (int c = 0; c < 2; c++)
                {
                    float value = previous[c];
                    if (value == gain[c])
                        for (int i = 0; i < n; i++) output[c][i] = value == 0 ? 0 : (float)(input[c][i] * value);
                    else
                    {
                        float delta = (float)((float)(gain[c] - value) / n);
                        for (int i = 0; i < n; i++) { output[c][i] = (float)(input[c][i] * value); value = (float)(value + (delta)); }
                    }
                }
            }
            private void UpdateGain(int c, float target, int count)
            {
                float old = gain[c]; previous[c] = old;
                int duration = old > target ? attack : release;
                if (duration >= count && count != 0)
                {
                    float fraction = (float)((float)count / duration);
                    target = (float)((float)(target * fraction) + (float)(old * (float)(1 - fraction)));
                }
                gain[c] = target;
                if (duration == 0) previous[c] = target;
            }
        }
    }
}
