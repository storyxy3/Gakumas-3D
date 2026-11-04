using System;
using static CriWare.CriAtomDspMath;

namespace CriWare
{
    // CRIWARE/Reverb, 0x16b8d0/0x16bedc/0x16c1d4; distinct from I3DL2Reverb.
    internal sealed class CriAtomDspReverb : CriAtomDsp
    {
        private static readonly float[] Delays = { 1.0241069793701172f, .6441419124603271f, .700349748134613f, .7835373282432556f,
            .9139395356178284f, 1.1657507419586182f, 1.397326946258545f, 1.27816641330719f, 1.0926804542541504f };
        private static readonly float[] Cutoffs = { .7528517246246338f, 1.0266159772872925f, .855513334274292f, 1.3688212633132935f,
            .9923954606056213f, 1.1292775869369507f, .9239543676376343f, .7870722413063049f, 1.1634981632232666f };
        private static readonly float[] Left = { 1.6f, -1.3f, 1f, -.7692307829856873f, .625f, 1.4f, .7142857313156128f, 1.8f, .5555555820465088f };
        private static readonly float[] Right = { .625f, .7692307829856873f, 1f, 1.3f, 1.6f, .7142857313156128f, 1.4f, .5555555820465088f, 1.8f };
        private readonly Delay predelay;
        private readonly Delay[] diffusion = new Delay[5];
        private readonly Comb[] combs = new Comb[9];
        private readonly float[] mono = new float[256], delayed = new float[256], temporary = new float[256];
        private uint silentSamples, tailSamples;

        internal CriAtomDspReverb(int rate, int blockSize, float[] config) : base(rate, blockSize)
        {
            RequireValues(config, 3);
            if (config[2] != 0) throw new NotSupportedException("Only the original Reverb channel routing mode zero is supported.");
            if (config[0] < 10 || config[0] > 1000 || config[1] < 1 || config[1] > 100)
                throw new ArgumentOutOfRangeException(nameof(config));
            predelay = new Delay(Samples(rate, Math.Max(config[0], 10)));
            float[] times = { 7.8f, 1.31f, 6.53f, 9.52f, 3.75f };
            for (int i = 0; i < diffusion.Length; i++)
            {
                diffusion[i] = new Delay(Samples(rate, 20)); diffusion[i].SetLength(Math.Max(16, Samples(rate, times[i])));
                diffusion[i].Gain = BitConverter.ToSingle(BitConverter.GetBytes(1058944319), 0);
            }
            float room = (float)((float)(config[1] / 334f) * 1000);
            for (int i = 0; i < combs.Length; i++) combs[i] = new Comb(Prime((int)(float)((float)((float)(room * Delays[i]) * rate) / 1000)));
            // The native constructor applies defaults before ACF parameters; its tail limit only grows.
            SetParameters(new[] { 3000f, (float)(config[1] * .5f), (float)(config[0] * .5f), 0f, 8000f });
        }
        internal override void SetParameters(float[] p)
        {
            RequireValues(p, 5);
            int pre = Samples(Rate, Clamp(p[2], 10, 1000)); predelay.SetLength(Math.Max(16, pre));
            float decay = Clamp(p[0], 0, 20000), room = p[1] >= 100 ? 299.4f : (float)((float)(Math.Max(p[1], 1) / 334) * 1000);
            float low = Clamp(p[3], 0, 24000), high = Clamp(p[4], 8000, 24000);
            for (int i = 0; i < combs.Length; i++)
            {
                int samples = Prime((int)(float)((float)((float)(room * Delays[i]) * Rate) / 1000));
                float gain = Pow(.001f, (float)((float)((float)((float)samples / Rate) * 1000) / decay));
                combs[i].Line.SetLength(Math.Max(16, samples)); combs[i].Line.Gain = Clamp(gain, -.99f, .99f);
                BandPass(combs[i].Filter, Rate, (float)(low * Cutoffs[i]), (float)(high * Cutoffs[i]));
            }
            tailSamples = Math.Max(tailSamples, (uint)Samples(Rate, decay) + (uint)pre);
        }
        internal override void Reset()
        {
            predelay.Reset(); foreach (Delay d in diffusion) d.Reset(); foreach (Comb c in combs) { c.Line.Reset(); c.Filter.Reset(); }
            Array.Clear(mono, 0, mono.Length); Array.Clear(delayed, 0, delayed.Length);
            // Native reset leaves the silence counter untouched; Process resets it on non-silent input.
        }
        protected override void ProcessBlock(float[][] input, float[][] output, int count, bool silent, out bool outputSilent)
        {
            if (silent && silentSamples > tailSamples) { outputSilent = true; return; }
            if (silent) silentSamples += (uint)count;
            else { if (silentSamples > tailSamples) Reset(); silentSamples = 0; }
            outputSilent = false;
            if (count == 0) return;
            for (int i = 0; i < count; i++) mono[i] = (float)((float)(.07888888567686081f * input[1][i]) + (float)(.07888888567686081f * input[0][i]));
            mono[0] = (float)(mono[0] + (0.00000095367431640625f));
            delayed[1] = (float)(delayed[1] + (-0.00000095367431640625f)); // Original state update, before predelay overwrites this block.
            for (int i = 0; i < count; i++)
            {
                delayed[i] = predelay.Data[predelay.Read]; predelay.Data[predelay.Write] = mono[i];
                predelay.Read = (predelay.Read + 1) % predelay.Data.Length; predelay.Write = (predelay.Write + 1) % predelay.Data.Length;
            }
            foreach (Delay d in diffusion) d.AllPass(delayed, count);
            for (int c = 0; c < combs.Length; c++)
            {
                combs[c].Process(delayed, temporary, count);
                if (c == 0) { Scale(output[0], temporary, count, Left[c]); Scale(output[1], temporary, count, Right[c]); }
                else { Add(output[0], temporary, count, Left[c]); Add(output[1], temporary, count, Right[c]); }
            }
        }

        private sealed class Comb
        {
            internal readonly Delay Line;
            internal readonly Biquad Filter = new Biquad();
            private readonly float[] source = new float[8], filtered = new float[8];
            internal Comb(int maximum) { Line = new Delay(maximum); }
            internal void Process(float[] input, float[] output, int count)
            {
                int offset = 0;
                while (offset < count)
                {
                    int part = Math.Min(count - offset, Math.Min(Line.Data.Length - Line.Read, Line.Data.Length - Line.Write));
                    int vector = part & ~7;
                    for (int i = 0; i < vector; i += 8)
                    {
                        Array.Copy(Line.Data, Line.Read + i, source, 0, 8);
                        Filter.Eight(source, 0, filtered, 0);
                        for (int j = 0; j < 8; j++)
                        {
                            Line.Data[Line.Write + i + j] = (float)(input[offset + i + j] + (float)(Line.Gain * filtered[j]));
                            output[offset + i + j] = source[j];
                        }
                    }
                    for (int i = vector; i < part; i++)
                    {
                        float sourceValue = Line.Data[Line.Read + i];
                        Line.Data[Line.Write + i] = (float)((float)(Filter.Scalar(sourceValue) * Line.Gain) + input[offset + i]);
                        output[offset + i] = sourceValue;
                    }
                    Line.Read = (Line.Read + part) % Line.Data.Length; Line.Write = (Line.Write + part) % Line.Data.Length;
                    offset += part;
                }
            }
        }
    }
}
