using System;

namespace CriWare
{
    // The float libm calls the original Atom DSP and panner import (sincosf, sinf,
    // exp2f), ported from glibc 2.41 sysdeps/ieee754/flt-32 (s_sincosf.c, s_sinf.c,
    // sincosf_poly.h, e_exp2f.c; the Arm optimized-routines algorithms Android
    // Bionic also ships). They evaluate in double and round once, so these ports
    // reproduce the original float bits, unlike (float)Math.Sin.
    internal static class CriAtomLibm
    {
        private struct Poly
        {
            internal double C0, C1, C2, C3, C4;
        }
        private static readonly double[] Sign = { 1.0, -1.0, -1.0, 1.0 };
        private static readonly double HpiInv = BitConverter.Int64BitsToDouble(0x41645F306DC9C883L); // 2/PI * 2^24
        private static readonly double Hpi = BitConverter.Int64BitsToDouble(0x3FF921FB54442D18L);
        private static readonly double Pi63 = BitConverter.Int64BitsToDouble(0x3C1921FB54442D18L);
        private static readonly double S1 = BitConverter.Int64BitsToDouble(unchecked((long)0xBFC555545995A603UL));
        private static readonly double S2 = BitConverter.Int64BitsToDouble(0x3F81107605230BC4L);
        private static readonly double S3 = BitConverter.Int64BitsToDouble(unchecked((long)0xBF2994EB3774CF24UL));
        // The second entry negates the cosine polynomial.
        private static readonly Poly[] Table =
        {
            new Poly { C0 = 1.0, C1 = BitConverter.Int64BitsToDouble(unchecked((long)0xBFDFFFFFFD0C621CUL)),
                C2 = BitConverter.Int64BitsToDouble(0x3FA55553E1068F19L), C3 = BitConverter.Int64BitsToDouble(unchecked((long)0xBF56C087E89A359DUL)),
                C4 = BitConverter.Int64BitsToDouble(0x3EF99343027BF8C3L) },
            new Poly { C0 = -1.0, C1 = BitConverter.Int64BitsToDouble(0x3FDFFFFFFD0C621CL),
                C2 = BitConverter.Int64BitsToDouble(unchecked((long)0xBFA55553E1068F19UL)), C3 = BitConverter.Int64BitsToDouble(0x3F56C087E89A359DL),
                C4 = BitConverter.Int64BitsToDouble(unchecked((long)0xBEF99343027BF8C3UL)) },
        };
        private static readonly uint[] InvPio4 =
        {
            0xa2, 0xa2f9, 0xa2f983, 0xa2f9836e, 0xf9836e4e, 0x836e4e44, 0x6e4e4415, 0x4e441529,
            0x441529fc, 0x1529fc27, 0x29fc2757, 0xfc2757d1, 0x2757d1f5, 0x57d1f534, 0xd1f534dd, 0xf534ddc0,
            0x34ddc0db, 0xddc0db62, 0xc0db6295, 0xdb629599, 0x6295993c, 0x95993c43, 0x993c4390, 0x3c439041,
        };
        private const uint Pio4Top12 = (0x3f490fdbu >> 20) & 0x7ff, TinyTop12 = (0x39800000u >> 20) & 0x7ff;
        private const uint ReduceFastTop12 = (0x42f00000u >> 20) & 0x7ff, InfinityTop12 = (0x7f800000u >> 20) & 0x7ff;

        private static uint AbsTop12(float x) => ((uint)BitConverter.SingleToInt32Bits(x) >> 20) & 0x7ff;

        // Hpi split so n * HpiHigh and n * HpiLow are exact for the |n| <= 77 of ReduceFast.
        private static readonly double HpiHigh = BitConverter.Int64BitsToDouble(0x3FF921FB54442D18L & ~0x7FFFFFFL);
        private static readonly double HpiLow = Hpi - HpiHigh;

        // TOINT_INTRINSICS == 0 (generic): the quadrant lands in bits 24..31. The
        // compilers contract x - n * hpi into one fused multiply-subtract (x86-64 FMA
        // multiarch, AArch64 fmsub); near multiples of PI/2 that cancellation is exact,
        // so it is evaluated as (x - n*hi) - n*lo with both products exact.
        private static double ReduceFast(double x, out int n)
        {
            double r = x * HpiInv;
            n = ((int)r + 0x800000) >> 24;
            return (x - n * HpiHigh) - n * HpiLow;
        }

        private static double ReduceLarge(uint xi, out int np)
        {
            int index = (int)((xi >> 26) & 15);
            int shift = (int)((xi >> 23) & 7);
            xi = (xi & 0xffffff) | 0x800000;
            xi <<= shift;
            ulong res0 = unchecked(xi * InvPio4[index]);
            ulong res1 = (ulong)xi * InvPio4[index + 4];
            ulong res2 = (ulong)xi * InvPio4[index + 8];
            res0 = unchecked((res2 >> 32) | (res0 << 32));
            res0 = unchecked(res0 + res1);
            ulong n = unchecked(res0 + (1UL << 61)) >> 62;
            res0 = unchecked(res0 - (n << 62));
            np = (int)n;
            return (long)res0 * Pi63;
        }

        private static void SinCosPoly(double x, double x2, Poly p, int n, out float sin, out float cos)
        {
            double x4 = x2 * x2, x3 = x2 * x;
            double c2 = p.C3 + x2 * p.C4, s1 = S2 + x2 * S3;
            double c1 = p.C0 + x2 * p.C1;
            double x5 = x3 * x2, x6 = x4 * x2;
            double s = x + x3 * S1, c = c1 + x4 * p.C2;
            float first = (float)(s + x5 * s1), second = (float)(c + x6 * c2);
            if ((n & 1) != 0) { sin = second; cos = first; }
            else { sin = first; cos = second; }
        }

        private static float SinPoly(double x, double x2, Poly p, int n)
        {
            if ((n & 1) == 0)
            {
                double x3 = x * x2, s1 = S2 + x2 * S3, x7 = x3 * x2, s = x + x3 * S1;
                return (float)(s + x7 * s1);
            }
            double x4 = x2 * x2, c2 = p.C3 + x2 * p.C4, c1 = p.C0 + x2 * p.C1, x6 = x4 * x2, c = c1 + x4 * p.C2;
            return (float)(c + x6 * c2);
        }

        internal static void SinCosF(float y, out float sin, out float cos)
        {
            double x = y;
            uint top = AbsTop12(y);
            if (top < Pio4Top12)
            {
                if (top < TinyTop12) { sin = y; cos = 1f; return; }
                SinCosPoly(x, x * x, Table[0], 0, out sin, out cos);
            }
            else if (top < ReduceFastTop12)
            {
                x = ReduceFast(x, out int n);
                double s = Sign[n & 3];
                SinCosPoly(x * s, x * x, Table[(n & 2) != 0 ? 1 : 0], n, out sin, out cos);
            }
            else if (top < InfinityTop12)
            {
                uint xi = (uint)BitConverter.SingleToInt32Bits(y);
                int sign = (int)(xi >> 31);
                x = ReduceLarge(xi, out int n);
                double s = Sign[(n + sign) & 3];
                SinCosPoly(x * s, x * x, Table[((n + sign) & 2) != 0 ? 1 : 0], n, out sin, out cos);
            }
            else sin = cos = y - y;
        }

        internal static float SinF(float y)
        {
            double x = y;
            uint top = AbsTop12(y);
            if (top < Pio4Top12) return top < TinyTop12 ? y : SinPoly(x, x * x, Table[0], 0);
            if (top < ReduceFastTop12)
            {
                x = ReduceFast(x, out int n);
                double s = Sign[n & 3];
                return SinPoly(x * s, x * x, Table[(n & 2) != 0 ? 1 : 0], n);
            }
            if (top < InfinityTop12)
            {
                uint xi = (uint)BitConverter.SingleToInt32Bits(y);
                int sign = (int)(xi >> 31);
                x = ReduceLarge(xi, out int n);
                double s = Sign[(n + sign) & 3];
                return SinPoly(x * s, x * x, Table[((n + sign) & 2) != 0 ? 1 : 0], n);
            }
            return float.NaN;
        }

        private static readonly ulong[] Exp2Table =
        {
            0x3ff0000000000000, 0x3fefd9b0d3158574, 0x3fefb5586cf9890f, 0x3fef9301d0125b51,
            0x3fef72b83c7d517b, 0x3fef54873168b9aa, 0x3fef387a6e756238, 0x3fef1e9df51fdee1,
            0x3fef06fe0a31b715, 0x3feef1a7373aa9cb, 0x3feedea64c123422, 0x3feece086061892d,
            0x3feebfdad5362a27, 0x3feeb42b569d4f82, 0x3feeab07dd485429, 0x3feea47eb03a5585,
            0x3feea09e667f3bcd, 0x3fee9f75e8ec5f74, 0x3feea11473eb0187, 0x3feea589994cce13,
            0x3feeace5422aa0db, 0x3feeb737b0cdc5e5, 0x3feec49182a3f090, 0x3feed503b23e255d,
            0x3feee89f995ad3ad, 0x3feeff76f2fb5e47, 0x3fef199bdd85529c, 0x3fef3720dcef9069,
            0x3fef5818dcfba487, 0x3fef7c97337b9b5f, 0x3fefa4afa2a490da, 0x3fefd0765b6e4540,
        };
        private static readonly double Exp2Shift = BitConverter.Int64BitsToDouble(0x42E8000000000000L); // 0x1.8p+52 / 32
        private static readonly double E0 = BitConverter.Int64BitsToDouble(0x3FAC6AF84B912394L);
        private static readonly double E1 = BitConverter.Int64BitsToDouble(0x3FCEBFCE50FAC4F3L);
        private static readonly double E2 = BitConverter.Int64BitsToDouble(0x3FE62E42FF0C52D6L);

        internal static float Exp2F(float x)
        {
            uint abstop = ((uint)BitConverter.SingleToInt32Bits(x) >> 20) & 0x7ff;
            if (abstop >= ((0x43000000u >> 20) & 0x7ff))
            {
                if (float.IsNegativeInfinity(x)) return 0f;
                if (abstop >= InfinityTop12) return x + x;
                if (x > 0f) return float.PositiveInfinity;
                if (x <= -150f) return 0f;
            }
            double xd = x;
            double kd = xd + Exp2Shift;
            ulong ki = (ulong)BitConverter.DoubleToInt64Bits(kd);
            kd -= Exp2Shift;
            double r = xd - kd;
            ulong t = unchecked(Exp2Table[ki % 32] + (ki << 47));
            double s = BitConverter.Int64BitsToDouble((long)t);
            double z = E0 * r + E1, r2 = r * r, y = E2 * r + 1;
            y = z * r2 + y;
            return (float)(y * s);
        }
    }
}
