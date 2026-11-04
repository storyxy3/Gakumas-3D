using System;
using System.IO;

namespace CriWare
{
    // Original Mana ADX float path: 1ACB44 header, 1AC978 coefficients,
    // 1AC46C four-sample recurrence, and 4D8BC total-sample trimming.
    internal sealed class CriManaAdxDecoder
    {
        private readonly byte[] data;
        private readonly int dataOffset, highpass;
        public int SamplingRate { get; }
        public int Channels { get; }
        public int TotalSamples { get; }

        public static CriManaAdxDecoder Parse(byte[] original)
        {
            if (original == null) throw new ArgumentNullException(nameof(original));
            return new CriManaAdxDecoder(original);
        }

        private CriManaAdxDecoder(byte[] original)
        {
            data = original;
            Require(data.Length >= 32 && U16(0) == 0x8000, "Invalid ADX header.");
            dataOffset = U16(2) + 4;
            Require(dataOffset >= 38 && dataOffset <= data.Length, "Truncated ADX header.");
            string marker = System.Text.Encoding.ASCII.GetString(data, dataOffset - 6, 6);
            Require(marker == "(c)CRI", "Missing ADX header signature.");
            if (data[4] != 3 || data[5] != 18 || data[6] != 4 || data[7] != 2 || data[18] != 4 || data[19] != 0)
                throw new NotSupportedException("Unsupported Mana ADX encoding, channels, version or encryption.");
            Channels = data[7]; SamplingRate = I32(8); TotalSamples = I32(12); highpass = U16(16);
            Require(SamplingRate > 0 && TotalSamples > 0 && highpass > 0 && highpass < SamplingRate / 2,
                "Invalid ADX sample count or filter frequency.");
            if (I32(32) != 0) throw new NotSupportedException("Embedded ADX looping is not supported.");
            long encodedBytes = ((long)TotalSamples + 31) / 32 * 18 * Channels;
            Require(encodedBytes <= data.Length - dataOffset && (long)TotalSamples * Channels <= int.MaxValue,
                "Truncated ADX sample blocks.");
        }

        public float[] Decode() => DecodeFromBlock(0);

        // Mana seeks by discarding complete SFA packets before opening its
        // decoder. Initial histories restart; this is not a slice of prior PCM.
        internal float[] DecodeFromBlock(int skippedFrames)
        {
            int paddedFrames = checked((TotalSamples + 31) / 32 * 32);
            if (skippedFrames < 0 || skippedFrames > paddedFrames || skippedFrames % 32 != 0)
                throw new ArgumentOutOfRangeException(nameof(skippedFrames));
            int frames = Math.Min(TotalSamples, paddedFrames - skippedFrames);
            float[] factors = BuildFactors(), history1 = new float[Channels], history2 = new float[Channels];
            for (int ch = 0; ch < Channels; ch++)
            {
                history1[ch] = (float)((short)U16(24 + ch * 4) / 32767f);
                history2[ch] = (float)((short)U16(26 + ch * 4) / 32767f);
            }
            var output = new float[frames * Channels];
            var scaled = new float[16]; var group = new float[4];
            int position = dataOffset + skippedFrames / 32 * 18 * Channels;
            for (int frame = 0; frame < frames; frame += 32)
            {
                for (int ch = 0; ch < Channels; ch++, position += 18)
                {
                    Require((data[position] & 0x80) == 0, "Premature ADX end marker.");
                    float scale = (float)(((U16(position) & 0x1fff) + 1) * (1f / 32768f));
                    for (int i = 0; i < scaled.Length; i++) scaled[i] = (float)(factors[8 + i] * scale);
                    float previous = history1[ch], older = history2[ch];
                    for (int sample = 0; sample < 32; sample += 4)
                    {
                        int first = data[position + 2 + sample / 2], second = data[position + 3 + sample / 2];
                        int n0 = (sbyte)first >> 4, n1 = SignedNibble(first), n2 = (sbyte)second >> 4, n3 = SignedNibble(second);
                        for (int lane = 0; lane < 4; lane++)
                        {
                            // Keep the native SIMD addition order. Alternating groups
                            // add n0 before or after the two history contributions.
                            float history = (float)((float)(factors[4 + lane] * older) + (float)(factors[lane] * previous));
                            float firstTerm = (float)(scaled[lane] * n0);
                            float value = (sample & 4) == 0 ? (float)(history + firstTerm) : (float)(firstTerm + history);
                            value = (float)((float)(scaled[4 + lane] * n1) + value);
                            value = (float)((float)(scaled[8 + lane] * n2) + value);
                            group[lane] = (float)((float)(scaled[12 + lane] * n3) + value);
                            if (frame + sample + lane < frames)
                                output[(frame + sample + lane) * Channels + ch] = group[lane];
                        }
                        previous = group[3]; older = group[2];
                    }
                    // Native rodata 203CD0, float bits 0x36000100.
                    history1[ch] = (float)(previous + 1.9074068404734135e-6f);
                    history2[ch] = (float)(older + 1.9074068404734135e-6f);
                }
            }
            return output;
        }

        private float[] BuildFactors()
        {
            float angle = (float)((float)(highpass * 6.2831854820251465f) / SamplingRate);
            float a = (float)(1.4142135381698608f - MathF.Cos(angle));
            float root = MathF.Sqrt((float)((float)(a + 0.41421353816986084f) * (float)(a - 0.41421353816986084f)));
            float c = (float)((float)(a - root) / 0.41421353816986084f);
            float p = (float)((int)((float)(c + c) * 4096f) * (1f / 4096f));
            float q = (float)((int)(float)((float)(c * c) * -4096f) * (1f / 4096f));
            float ppq = (float)(q + (float)(p * p)), pq = (float)(p * q), third = (float)((float)(p * ppq) + pq);
            float qThird = (float)((float)(p * pq) + (float)(q * q));
            return new[] {
                p, ppq, third, (float)((float)(p * third) + (float)(q * ppq)),
                q, pq, qThird, (float)((float)(p * qThird) + (float)(q * pq)),
                1f, p, ppq, third,
                0f, 1f, p, (float)((float)(p * p) + q),
                0f, 0f, 1f, p,
                0f, 0f, 0f, 1f
            };
        }

        private static int SignedNibble(int value) => (value & 15) < 8 ? value & 15 : (value & 15) - 16;
        private int U16(int offset) => data[offset] << 8 | data[offset + 1];
        private int I32(int offset) => data[offset] << 24 | data[offset + 1] << 16 | data[offset + 2] << 8 | data[offset + 3];
        private static void Require(bool condition, string message)
        { if (!condition) throw new InvalidDataException(message); }
    }
}
