using System;

namespace CriWare
{
    internal static class CriAtomDspMath
    {
        // Explicit float casts preserve each native ARM float32 operation on Mono.
        internal static float Clamp(float x, float a, float b)
        {
            float result = Math.Max(a, Math.Min(b, x));
            return result == 0f ? 0f : result;
        }
        internal static float Pow(float a, float b) { return (float)Math.Pow(a, b); }
        internal static int Samples(int rate, float ms) { return (int)(float)((float)(rate * ms) / 1000f); }
        internal static int Prime(int value)
        {
            if (value < 3) return 2;
            if ((value & 1) == 0) value++;
            for (;; value += 2)
            {
                bool prime = true;
                for (int divisor = 3; divisor * divisor <= value; divisor += 2)
                    if (value % divisor == 0) { prime = false; break; }
                if (prime) return value;
            }
        }
        internal static void Scale(float[] output, float[] input, int n, float gain)
        { for (int i = 0; i < n; i++) output[i] = (float)(gain * input[i]); }
        internal static void Add(float[] output, float[] input, int n, float gain)
        { for (int i = 0; i < n; i++) output[i] = (float)((float)(gain * input[i]) + output[i]); }

        // 0x1700f8/0x17014c. Storage padding and positions matter to the native vector-filter grouping.
        internal sealed class Delay
        {
            internal readonly float[] Data;
            internal readonly int Maximum;
            internal int Length, Write, Read;
            internal float Gain;
            internal Delay(int maximum)
            {
                Maximum = maximum; Data = new float[(maximum + 271) & ~15];
                Length = Write = maximum >> 1;
            }
            internal void SetLength(int length) { Length = Math.Min(Maximum, length); Read = (Write - Length + Data.Length) % Data.Length; }
            internal void Reset() { Array.Clear(Data, 0, Data.Length); Write = Length; Read = 0; }
            internal void ReadBlock(float[] output, int n)
            { for (int i = 0; i < n; i++) { output[i] = Data[Read]; Read = (Read + 1) % Data.Length; } }
            internal void WriteBlock(float[] input, int n)
            { for (int i = 0; i < n; i++) { Data[Write] = input[i]; Write = (Write + 1) % Data.Length; } }
            internal void Process(float[] values, int n) { WriteBlock(values, n); ReadBlock(values, n); }
            internal void AllPass(float[] values, int n)
            {
                float dry = (float)(1 - (float)(Gain * Gain));
                for (int i = 0; i < n; i++)
                {
                    float delayed = Data[Read], input = values[i];
                    Data[Write] = (float)((float)(Gain * delayed) + input);
                    values[i] = (float)((float)(dry * delayed) - (float)(Gain * input));
                    Write = (Write + 1) % Data.Length; Read = (Read + 1) % Data.Length;
                }
            }
        }

        // 0x139654 pre-expands a biquad into four SIMD lanes. Preserve that evaluation order;
        // a mathematically equivalent scalar recurrence has different float rounding.
        internal sealed class Biquad
        {
            internal readonly float[] Coefficients = new float[32];
            private readonly float[] first = new float[4], second = new float[4];
            internal float X2, X1, Y2, Y1;
            private float a1, a2, b0, b1, b2;
            internal void Set(float[] a, float[] b)
            {
                a1 = (float)(a[1] / a[0]); a2 = (float)(a[2] / a[0]); b0 = (float)(b[0] / a[0]); b1 = (float)(b[1] / a[0]); b2 = (float)(b[2] / a[0]);
                float neg = -a1, ab = (float)(a1 * a2);
                float c = (float)(b1 - (float)(b0 * a1)), d = (float)(b2 - (float)(b1 * a1));
                float e = (float)((float)(b2 * (float)(a1 * a1)) - (float)(b2 * a2));
                float f = (float)((float)(a2 * a2) - (float)((float)(a1 * a1) * a2));
                float g = (float)((float)(a1 * a1) - a2);
                float h = (float)((float)(d * neg) - (float)(b1 * a2));
                float k = (float)(b2 + (float)((float)(c * neg) - (float)(b0 * a2)));
                float j = (float)(ab - (float)(g * a1));
                float[] v = Coefficients;
                Array.Clear(v, 0, v.Length);
                v[3] = b0; v[6] = b0; v[7] = c; v[9] = b0; v[10] = c; v[11] = k;
                v[12] = b0; v[13] = c; v[14] = k; v[15] = (float)((float)(k * neg) - (float)(a2 * c));
                v[16] = b2; v[17] = (float)(b2 * neg); v[18] = e; v[19] = (float)((float)(b2 * ab) - (float)(e * a1));
                v[20] = b1; v[21] = d; v[22] = h; v[23] = (float)((float)(h * neg) - (float)(a2 * d));
                v[24] = -a2; v[25] = ab; v[26] = f; v[27] = (float)((float)(f * neg) - (float)(a2 * ab));
                v[28] = neg; v[29] = g; v[30] = j; v[31] = (float)((float)(j * neg) - (float)(a2 * g));
            }
            internal void Reset() { X2 = X1 = Y2 = Y1 = 0; }
            internal void Eight(float[] input, int offset, float[] output, int outputOffset)
            {
                float[] c = Coefficients;
                float x0 = input[offset], x1 = input[offset + 1], x2 = input[offset + 2], x3 = input[offset + 3];
                float x4 = input[offset + 4], x5 = input[offset + 5], x6 = input[offset + 6], x7 = input[offset + 7];
                for (int lane = 0; lane < 4; lane++)
                {
                    float value = (float)((float)(c[12 + lane] * x0) + (float)(c[8 + lane] * x1));
                    value = (float)((float)(c[4 + lane] * x2) + value);
                    value = (float)((float)(c[lane] * x3) + value);
                    value = (float)((float)(c[16 + lane] * X2) + value);
                    value = (float)((float)(c[20 + lane] * X1) + value);
                    value = (float)((float)(c[24 + lane] * Y2) + value);
                    first[lane] = (float)((float)(c[28 + lane] * Y1) + value);
                    value = (float)((float)(c[12 + lane] * x4) + (float)(c[8 + lane] * x5));
                    value = (float)((float)(c[4 + lane] * x6) + value);
                    value = (float)((float)(c[lane] * x7) + value);
                    value = (float)((float)(c[16 + lane] * x2) + value);
                    second[lane] = (float)((float)(c[20 + lane] * x3) + value);
                }
                for (int lane = 0; lane < 4; lane++)
                {
                    second[lane] = (float)((float)(c[28 + lane] * first[3]) + (float)(second[lane] + (float)(c[24 + lane] * first[2])));
                    output[outputOffset + lane] = first[lane]; output[outputOffset + lane + 4] = second[lane];
                }
                X2 = x6; X1 = x7; Y2 = second[2]; Y1 = second[3];
            }
            internal float Scalar(float x)
            {
                float y = (float)((float)((float)((float)(x * b0) + (float)(b1 * X1)) + (float)(b2 * X2)) - (float)(a1 * Y1));
                y = (float)(y - (float)(a2 * Y2)); X2 = X1; X1 = x; Y2 = Y1; Y1 = y; return y;
            }
            internal void Process(float[] values, int n) { for (int i = 0; i + 8 <= n; i += 8) Eight(values, i, values, i); }
        }

        internal static void Shelf(Biquad filter, int rate, float frequency, float q, float gain, bool lowShelf)
        {
            frequency = Clamp(frequency, 10, (float)((float)(rate * .5f) - 100));
            q = Math.Max(q, .001f);
            float angle = (float)((float)(frequency * 6.283185307179586f) / rate);
            CriAtomLibm.SinCosF(angle, out float sin, out float cos);
            float root = (float)Math.Sqrt(Math.Max(gain, 0.0000152587890625f));
            float root2 = (float)Math.Sqrt(root);
            float minus = (float)((float)(root - 1) * cos), plus = (float)((float)(root + 1) * cos);
            float alpha = (float)((float)(root2 + root2) * (float)(sin / (float)(q + q)));
            float[] a = new float[3], b = new float[3];
            if (lowShelf)
            {
                float numerator = (float)((float)(root + 1) - minus), denominator = (float)((float)(root + 1) + minus);
                b[0] = (float)(root * (float)(numerator + alpha)); b[1] = (float)((float)(root + root) * (float)((float)(root - 1) - plus)); b[2] = (float)(root * (float)(numerator - alpha));
                a[0] = (float)(denominator + alpha); a[1] = (float)((float)((float)(root - 1) + plus) * -2); a[2] = (float)(denominator - alpha);
            }
            else
            {
                float numerator = (float)((float)(root + 1) + minus), denominator = (float)((float)(root + 1) - minus);
                b[0] = (float)(root * (float)(numerator + alpha)); b[1] = (float)((float)(root * -2) * (float)((float)(root - 1) + plus)); b[2] = (float)(root * (float)(numerator - alpha));
                a[0] = (float)(denominator + alpha); a[1] = (float)((float)((float)(root - 1) - plus) + (float)((float)(root - 1) - plus)); a[2] = (float)(denominator - alpha);
            }
            filter.Set(a, b);
        }

        // Voice biquad (sub_15E054): type 0 low-pass, 1 high-pass, 2 notch, 3 low shelf,
        // 4 high shelf, 5 peaking (15F858/15F914/15FA58/15FB14/15FC24/15FD34), at the
        // output rate. Q is clamped to [0, 10] and gain to [0, 5] before the type.
        internal static bool VoiceFilter(Biquad filter, int rate, float type, float frequency, float q, float gain)
        {
            q = Math.Max(Math.Min(q, 10f), 0f);
            gain = Math.Max(Math.Min(gain, 5f), 0f);
            int kind = (int)(float)(type + 0.5f);
            if (kind == 3 || kind == 4) { Shelf(filter, rate, frequency, q, gain, kind == 3); return true; }
            if ((uint)kind > 5) return false;
            frequency = Clamp(frequency, 10, (float)((float)(rate * .5f) - 100));
            q = Math.Max(q, .001f);
            CriAtomLibm.SinCosF((float)((float)(frequency * 6.283185307179586f) / rate), out float sin, out float cos);
            float alpha = (float)(sin / (float)(q + q));
            float[] a = { (float)(alpha + 1f), (float)(cos * -2f), (float)(1f - alpha) }, b = new float[3];
            switch (kind)
            {
                case 0: b[1] = (float)(1f - cos); b[0] = b[2] = (float)(b[1] * .5f); break;
                case 1: b[1] = (float)(-1f - cos); b[0] = b[2] = (float)((float)(cos + 1f) * .5f); break;
                case 2: b[0] = 1f; b[1] = a[1]; b[2] = 1f; break;
                default:
                {
                    float root = (float)Math.Sqrt(Math.Max(gain, 0.0000152587890625f));
                    float wide = (float)(root * alpha), narrow = (float)(alpha / root);
                    b[0] = (float)(wide + 1f); b[1] = a[1]; b[2] = (float)(1f - wide);
                    a[0] = (float)(narrow + 1f); a[2] = (float)(1f - narrow);
                    break;
                }
            }
            filter.Set(a, b);
            return true;
        }

        // D3E30: normalised biquad frequency to Hz, logarithmic over 24 Hz..24 kHz.
        internal static float VoiceFilterFrequency(float normalized)
        {
            if (normalized <= 1.52587890625e-05f) return 24f;
            if (normalized >= 0.9999847412109375f) return 24000f;
            float hz = CriAtomLibm.Exp2F((float)((float)((float)(normalized * 2.1735804080963135f) + 1f) * 4.584962368011475f));
            return Math.Min(Math.Max(hz, 24f), 24000f);
        }

        private struct Complex
        {
            internal double R, I;
            internal Complex(double real, double imaginary) { R = real; I = imaginary; }
            internal static Complex Multiply(Complex a, Complex b) { return new Complex(a.R * b.R - a.I * b.I, b.R * a.I + a.R * b.I); }
            internal static Complex Divide(Complex a, Complex b)
            {
                double inv = 1 / (b.R * b.R + b.I * b.I);
                return new Complex((a.R * b.R + a.I * b.I) * inv, (a.I * b.R - a.R * b.I) * inv);
            }
        }
        // 0x13bb80 -> 0x13b904 -> bilinear pole/zero transform 0x13b440.
        internal static void BandPass(Biquad filter, int rate, float low, float high)
        {
            low = Math.Max(low, 10); high = Math.Min(high, (float)((float)(rate * .5f) - 100));
            if (low > (float)(high - 1)) { filter.Set(new[] { 1f, 0, 0 }, new float[3]); return; }
            double scale = (1.0 / rate) * Math.PI;
            double upper = (1.0 / scale) * Math.Tan(scale * high);
            double lower = ((1.0 / scale) * Math.Tan(scale * low)) * (2 * Math.PI);
            double center = Math.Sqrt((upper * (2 * Math.PI)) * lower);
            double width = upper * (2 * Math.PI) - lower;
            double discriminant = width * width + center * (center * -4);
            Complex[] poles;
            if (discriminant <= 0)
            { double imaginary = Math.Sqrt(-discriminant); poles = new[] { new Complex(width * -.5, imaginary * .5), new Complex(width * -.5, imaginary * -.5) }; }
            else
            { double real = Math.Sqrt(discriminant); poles = new[] { new Complex((real - width) * .5, 0), new Complex((-width - real) * .5, 0) }; }
            double invRate = 1.0 / rate;
            Complex gain = new Complex(width, 0);
            for (int i = 0; i < 2; i++)
            {
                Complex denominator = new Complex(2 - invRate * poles[i].R, -(invRate * poles[i].I));
                gain = Complex.Multiply(gain, Complex.Divide(new Complex(invRate, 0), denominator));
                poles[i] = Complex.Divide(new Complex(invRate * poles[i].R + 2, invRate * poles[i].I), denominator);
            }
            gain = Complex.Multiply(gain, Complex.Divide(new Complex(2, 0), new Complex(invRate, 0)));
            // Original polynomial expansion, descending coefficient updates.
            Complex a1 = new Complex(-poles[0].R, -poles[0].I);
            Complex a2 = Complex.Multiply(a1, new Complex(-poles[1].R, -poles[1].I));
            a1.R += -poles[1].R; a1.I += -poles[1].I;
            filter.Set(new[] { 1f, (float)a1.R, (float)a2.R }, new[] { (float)gain.R, 0f, (float)-gain.R });
        }
    }
}
