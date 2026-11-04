using System;
using System.IO;

namespace CriWare.CriMana
{
    // MPEG-1 elementary video. Integer dequantization/IDCT follow JP 7.0.0 MPV
    // (libcri_ware_unity 6.8.1: 0x76190, 0x77c54, 0x79c00).
    internal sealed partial class CriManaMpeg1Decoder
    {
        internal sealed class Frame
        {
            internal byte[] Y, U, V;
            internal int Width, Height, YStride, ChromaStride, PictureType, TemporalReference;
        }

        private readonly byte[] stream;
        private int bit, width, height, mbWidth, mbHeight, pictureType, dcPrecision, headerLevel;
        private int mbAddress, quantizer, forwardX, forwardY, backwardX, backwardY;
        private int forwardBits, backwardBits, forwardFull, backwardFull;
        private bool forwardSet, backwardSet, hasReference, flushed, skipReconstruction;
        private Frame current, forward, backward;
        private readonly int[] dc = new int[3];
        private readonly int[] block = new int[64];
        private readonly byte[] intraMatrix = new byte[64], interMatrix = new byte[64];

        internal CriManaMpeg1Decoder(byte[] elementaryStream)
        {
            stream = elementaryStream ?? throw new ArgumentNullException(nameof(elementaryStream));
            Reset();
        }

        internal void Reset() => Reset(0);

        // USM seek entries point to sequence headers. Start there and let the
        // player discard the GOP preroll while preserving reference pictures.
        internal void Reset(int byteOffset)
        {
            if (byteOffset < 0 || byteOffset > stream.Length) throw new ArgumentOutOfRangeException(nameof(byteOffset));
            bit = checked(byteOffset * 8);
            hasReference = flushed = false;
            forwardSet = backwardSet = false;
            dcPrecision = 0;
            int code;
            while ((code = NextStartCode()) >= 0 && code != 0xb3) { }
            if (code != 0xb3) throw new InvalidDataException("MPEG-1 sequence header is missing.");
            ReadSequence();
        }

        // Frames are returned in presentation order. Their buffers remain valid
        // until the next call; only three decoded pictures are kept in memory.
        internal bool TryDecodeNext(out Frame frame)
        {
            while (TryDecodePicture(out _, out frame))
                if (frame != null) return true;
            frame = null;
            return false;
        }

        // One encoded picture at a time lets Mana keep the delayed I/P picture
        // in the same physical pool as ready and renderer-owned pictures.
        // Skipped B pictures retain metadata and validation, but their pixels must be discarded.
        internal bool TryDecodePicture(out Frame decoded, out Frame presentation, bool skipNonReference = false)
        {
            decoded = presentation = null;
            if (flushed) return false;
            while (true)
            {
                int code = NextStartCode();
                if (code < 0 || code == 0xb7)
                {
                    flushed = true;
                    if (hasReference) { presentation = backward; return true; }
                    return false;
                }
                if (code == 0xb3) { ReadSequence(); continue; }
                if (code == 0xb2) { ReadUserData(); continue; }
                if (code == 0xb8) { headerLevel = 2; continue; }
                if (code != 0) continue;
                DecodePicture(skipNonReference);
                if (pictureType == 3) decoded = presentation = current;
                else
                {
                    decoded = backward;
                    if (hasReference) presentation = forward;
                    hasReference = true;
                }
                return true;
            }
        }

        private int Read(int count)
        {
            if (count < 0 || count > 24 || bit > stream.Length * 8L - count)
                throw new InvalidDataException("Truncated MPEG-1 bitstream.");
            int value = 0;
            while (count > 0)
            {
                int take = Math.Min(count, 8 - (bit & 7));
                value = (value << take) | ((stream[bit >> 3] >> (8 - (bit & 7) - take)) & ((1 << take) - 1));
                bit += take;
                count -= take;
            }
            return value;
        }

        private int NextStartCode()
        {
            for (int i = (bit + 7) >> 3; i + 3 < stream.Length; i++)
            {
                if (stream[i] == 0 && stream[i + 1] == 0 && stream[i + 2] == 1)
                {
                    bit = (i + 4) * 8;
                    return stream[i + 3];
                }
            }
            bit = stream.Length * 8;
            return -1;
        }

        private int Vlc(int[] table)
        {
            int node = 0;
            do
            {
                int entry = node + Read(1);
                if (entry < 0 || entry * 2 + 1 >= table.Length)
                    throw new InvalidDataException("Invalid MPEG-1 VLC.");
                node = table[entry * 2];
                if (node == 0) return table[entry * 2 + 1];
            } while (node > 0);
            throw new InvalidDataException("Invalid MPEG-1 VLC.");
        }

        private void ReadSequence()
        {
            headerLevel = 1;
            int nextWidth = Read(12), nextHeight = Read(12);
            if (nextWidth == 0 || nextHeight == 0)
                throw new InvalidDataException("Invalid MPEG-1 picture dimensions.");
            Read(8); Read(18); Read(1); Read(10); Read(1);
            if (Read(1) != 0)
                for (int i = 0; i < 64; i++) intraMatrix[ZigZag[i]] = (byte)Read(8);
            else Array.Copy(DefaultIntraMatrix, intraMatrix, 64);
            if (Read(1) != 0)
                for (int i = 0; i < 64; i++) interMatrix[ZigZag[i]] = (byte)Read(8);
            else for (int i = 0; i < 64; i++) interMatrix[i] = 16;
            if (current != null && width == nextWidth && height == nextHeight) return;
            if (hasReference) throw new InvalidDataException("MPEG-1 picture dimensions changed within a sequence.");
            width = nextWidth; height = nextHeight;
            mbWidth = (width + 15) >> 4; mbHeight = (height + 15) >> 4;
            current = NewFrame(); forward = NewFrame(); backward = NewFrame();
        }

        private void ReadUserData()
        {
            if (headerLevel != 1) return;
            int start = bit >> 3, end = start;
            while (end + 3 < stream.Length && !(stream[end] == 0 && stream[end + 1] == 0 && stream[end + 2] == 1)) end++;
            // TMPGEnc's IDCPREC user-data extension selects CRI's 11-bit DC path.
            for (int i = start; i + 24 <= end; i++)
            {
                if (stream[i] != 'I' || stream[i + 1] != 'D' || stream[i + 2] != 'C' || stream[i + 3] != 'P' ||
                    stream[i + 4] != 'R' || stream[i + 5] != 'E' || stream[i + 6] != 'C') continue;
                int value = 0;
                for (int j = i + 16; j < end && stream[j] >= '0' && stream[j] <= '9'; j++) value = value * 10 + stream[j] - '0';
                dcPrecision = value == 0 ? 0 : 3;
            }
        }

        private Frame NewFrame()
        {
            int ys = (width + 31) & ~31, cs = ((mbWidth * 8) + 31) & ~31;
            return new Frame { Width = width, Height = height, YStride = ys, ChromaStride = cs,
                Y = new byte[ys * mbHeight * 16], U = new byte[cs * mbHeight * 8], V = new byte[cs * mbHeight * 8] };
        }

        private void DecodePicture(bool skipNonReference)
        {
            headerLevel = 3;
            int temporalReference = Read(10);
            pictureType = Read(3); Read(16);
            skipReconstruction = skipNonReference && pictureType == 3;
            if (pictureType < 1 || pictureType > 3)
                throw new InvalidDataException("Unsupported MPEG-1 picture type.");
            if (pictureType != 1)
            {
                forwardFull = Read(1); forwardBits = Read(3) - 1;
                if (forwardBits < 0) throw new InvalidDataException("Invalid forward motion f_code.");
            }
            if (pictureType == 3)
            {
                backwardFull = Read(1); backwardBits = Read(3) - 1;
                if (backwardBits < 0) throw new InvalidDataException("Invalid backward motion f_code.");
            }
            Frame spare = forward;
            if (pictureType != 3) forward = backward;
            current.PictureType = pictureType; current.TemporalReference = temporalReference;
            bool hasSlice = false;
            int code;
            while ((code = NextStartCode()) >= 0)
            {
                if (code == 0xb2 || code == 0xb5) continue;
                if (code < 1 || code > 0xaf) { bit -= 32; break; }
                DecodeSlice(code);
                hasSlice = true;
                if (mbAddress >= mbWidth * mbHeight - 1) break;
            }
            if (!hasSlice) throw new InvalidDataException("MPEG-1 picture has no slices.");
            if (pictureType != 3) { backward = current; current = spare; }
        }

        private void ResetDc() { dc[0] = dc[1] = dc[2] = 128 << dcPrecision; }

        private void DecodeSlice(int row)
        {
            mbAddress = (row - 1) * mbWidth - 1;
            forwardX = forwardY = backwardX = backwardY = 0;
            ResetDc();
            quantizer = Read(5);
            while (Read(1) != 0) Read(8);
            bool first = true;
            while (mbAddress < mbWidth * mbHeight - 1)
            {
                int saved = bit;
                if (stream.Length * 8L - bit < 23 || Read(23) == 0) { bit = saved; break; }
                bit = saved;
                int increment = 0, value;
                do { value = Vlc(MacroblockAddress); } while (value == 34);
                while (value == 35) { increment += 33; value = Vlc(MacroblockAddress); }
                increment += value;
                if (increment < 1 || mbAddress + increment >= mbWidth * mbHeight)
                    throw new InvalidDataException("MPEG-1 macroblock address is out of range.");
                if (!first && increment > 1)
                {
                    ResetDc();
                    if (pictureType == 2) forwardX = forwardY = 0;
                    while (increment-- > 1) { mbAddress++; Predict(); }
                    increment = 1;
                }
                mbAddress += increment; first = false;
                int type = Vlc(pictureType == 1 ? MacroblockIntra : pictureType == 2 ? MacroblockPredictive : MacroblockB);
                bool intra = (type & 1) != 0;
                forwardSet = (type & 8) != 0; backwardSet = (type & 4) != 0;
                if ((type & 16) != 0) quantizer = Read(5);
                if (intra) forwardX = forwardY = backwardX = backwardY = 0;
                else
                {
                    ResetDc();
                    if (forwardSet) { forwardX = Motion(forwardX, forwardBits); forwardY = Motion(forwardY, forwardBits); }
                    else if (pictureType == 2) forwardX = forwardY = 0;
                    if (backwardSet) { backwardX = Motion(backwardX, backwardBits); backwardY = Motion(backwardY, backwardBits); }
                    Predict();
                }
                int pattern = (type & 2) != 0 ? Vlc(CodedBlockPattern) : intra ? 63 : 0;
                for (int i = 0; i < 6; i++)
                    if ((pattern & (32 >> i)) != 0) DecodeBlock(i, intra);
            }
        }

        private int Motion(int previous, int residualBits)
        {
            int value = Vlc(MotionCode), scale = 1 << residualBits;
            if (value != 0 && residualBits != 0)
            {
                int magnitude = ((Math.Abs(value) - 1) << residualBits) + Read(residualBits) + 1;
                value = value < 0 ? -magnitude : magnitude;
            }
            value += previous;
            if (value > scale * 16 - 1) value -= scale * 32;
            else if (value < -scale * 16) value += scale * 32;
            return value;
        }

        private void Predict()
        {
            int fx = forwardX << forwardFull, fy = forwardY << forwardFull;
            if (pictureType != 3) { PredictFrom(forward, fx, fy, false); return; }
            if (forwardSet) PredictFrom(forward, fx, fy, false);
            if (backwardSet || !forwardSet)
                PredictFrom(backward, backwardX << backwardFull, backwardY << backwardFull, forwardSet);
        }

        private void PredictFrom(Frame source, int mx, int my, bool average)
        {
            PredictPlane(source.Y, current.Y, current.YStride, 16, mx, my, average);
            PredictPlane(source.U, current.U, current.ChromaStride, 8, mx / 2, my / 2, average);
            PredictPlane(source.V, current.V, current.ChromaStride, 8, mx / 2, my / 2, average);
        }

        private void PredictPlane(byte[] source, byte[] dest, int stride, int size, int mx, int my, bool average)
        {
            int bx = (mbAddress % mbWidth) * size, by = (mbAddress / mbWidth) * size;
            int ox = mx & 1, oy = my & 1;
            int sx = bx + (mx >> 1), sy = by + (my >> 1);
            if (sx < 0 || sy < 0 || sx + size + ox > mbWidth * size || sy + size + oy > mbHeight * size)
                throw new InvalidDataException("MPEG-1 motion vector crosses the reference picture.");
            if (skipReconstruction) return;
            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                {
                    int s = (sy + y) * stride + sx + x;
                    int value = source[s];
                    if (ox != 0 && oy != 0) value = (value + source[s + 1] + source[s + stride] + source[s + stride + 1] + 2) >> 2;
                    else if (ox != 0) value = (value + source[s + 1] + 1) >> 1;
                    else if (oy != 0) value = (value + source[s + stride] + 1) >> 1;
                    int d = (by + y) * stride + bx + x;
                    dest[d] = (byte)(average ? (dest[d] + value + 1) >> 1 : value);
                }
        }

        private void DecodeBlock(int index, bool intra)
        {
            Array.Clear(block, 0, block.Length);
            int n = 0, first = -1, last = -1;
            byte[] matrix = intra ? intraMatrix : interMatrix;
            if (intra)
            {
                int plane = index < 4 ? 0 : index - 3;
                int size = Vlc(plane == 0 ? DcLuminance : DcChrominance);
                int diff = Read(size);
                if (size > 0 && (diff & (1 << (size - 1))) == 0) diff -= (1 << size) - 1;
                dc[plane] += diff;
                block[0] = (short)(dc[plane] << (6 - dcPrecision));
                first = last = 0; n = 1;
            }
            while (true)
            {
                int coeff = Vlc(DctCoefficient), run, level;
                if (coeff == 1 && n > 0 && Read(1) == 0) break;
                if (coeff == 65535)
                {
                    run = Read(6); level = Read(8);
                    if (level == 0) level = Read(8);
                    else if (level == 128) level = Read(8) - 256;
                    else if (level > 128) level -= 256;
                }
                else { run = coeff >> 8; level = coeff & 255; if (Read(1) != 0) level = -level; }
                n += run;
                if (n >= 64) throw new InvalidDataException("MPEG-1 coefficient run is out of range.");
                int pos = ZigZag[n++];
                if (first < 0) first = pos;
                last = pos;
                int magnitude = ((Math.Abs(level) * 2 + (intra ? 0 : 1)) * quantizer * matrix[pos]) >> 4;
                magnitude = (magnitude - 1) | 1;
                int signed = level < 0 ? -magnitude : magnitude;
                block[pos] = (short)((signed * IdctScale[pos] + 1024) >> 11);
            }
            if (skipReconstruction) return;
            Idct(block, first == last ? last : -1);
            int stride = index < 4 ? current.YStride : current.ChromaStride;
            byte[] dest = index < 4 ? current.Y : index == 4 ? current.U : current.V;
            int sizePixels = index < 4 ? 16 : 8;
            int offset = (mbAddress / mbWidth) * sizePixels * stride + (mbAddress % mbWidth) * sizePixels;
            if (index < 4) offset += (index & 1) * 8 + (index >> 1) * 8 * stride;
            for (int y = 0; y < 8; y++)
                for (int x = 0; x < 8; x++)
                {
                    int d = offset + y * stride + x;
                    int value = block[y * 8 + x] + (intra ? 0 : dest[d]);
                    dest[d] = (byte)Math.Max(0, Math.Min(255, value));
                }
        }

        private static void Idct(int[] values, int single)
        {
            if (single >= 0)
            {
                int value = values[single];
                if (single == 0)
                {
                    int dcValue = value < 0 ? -((32 - value) >> 6) : (value + 32) >> 6;
                    for (int i = 0; i < 64; i++) values[i] = dcValue;
                }
                else for (int i = 0; i < 64; i++)
                {
                    int product = SingleIdct[single * 64 + i] * value;
                    values[63 - i] = product < 0 ? -((1024 - product) >> 11) : (product + 1024) >> 11;
                }
                return;
            }
            for (int row = 0; row < 8; row++) IdctPass(values, row * 8, 1, 32768, 16);
            for (int col = 0; col < 8; col++) IdctPass(values, col, 8, 2097152, 22);
        }

        private static void IdctPass(int[] b, int start, int step, int rounding, int shift)
        {
            unchecked
            {
                int x0 = b[start], x1 = b[start + step], x2 = b[start + 2 * step], x3 = b[start + 3 * step];
                int x4 = b[start + 4 * step], x5 = b[start + 5 * step], x6 = b[start + 6 * step], x7 = b[start + 7 * step];
                int evenSum = (x2 + x6) << 16, evenDifference = 92682 * (x2 - x6) - evenSum;
                int baseSum = (x4 << 16) + (x0 << 16) + rounding;
                int baseDifference = (x0 << 16) + rounding - (x4 << 16);
                int a = baseSum + evenSum, b1 = baseDifference + evenDifference;
                int c = baseDifference - evenDifference, d = baseSum - evenSum;
                int oddDifference = x5 - x3, endDifference = x1 - x7;
                int oddSum = (x1 + x7 + x5 + x3) << 16;
                int rotation = 50159 * (oddDifference - endDifference);
                int e = 70936 * endDifference - rotation - oddSum;
                int f = 92682 * (x1 + x7 - x5 - x3) - e;
                int g = rotation - 171254 * oddDifference + f;
                b[start] = (short)((a + oddSum) >> shift);
                b[start + step] = (short)((b1 + e) >> shift);
                b[start + 2 * step] = (short)((c + f) >> shift);
                b[start + 3 * step] = (short)((d - g) >> shift);
                b[start + 4 * step] = (short)((d + g) >> shift);
                b[start + 5 * step] = (short)((c - f) >> shift);
                b[start + 6 * step] = (short)((b1 - e) >> shift);
                b[start + 7 * step] = (short)((a - oddSum) >> shift);
            }
        }
    }
}
