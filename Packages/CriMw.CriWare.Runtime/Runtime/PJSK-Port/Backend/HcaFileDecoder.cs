using System;
using System.IO;

// File headers/cipher/trimming recovered from JP 7.0.0 libcri_ware_unity.so
// (SHA-256 314dec236de2afde93997ddd008818992d4551c1ca8728997fd21bcae4bc5d58).
// The caller owns compressed input and PCM storage. The decoder retains only one encoded frame.
public sealed class HcaFileDecoder
{
    public sealed class Metadata
    {
        public int Version { get; internal set; }
        public int Channels { get; internal set; }
        public int SampleRate { get; internal set; }
        public int HeaderSize { get; internal set; }
        public int FrameSize { get; internal set; }
        public int FrameCount { get; internal set; }
        public int EncoderDelay { get; internal set; }
        public int EncoderPadding { get; internal set; }
        public int CipherType { get; internal set; }
        public float Volume { get; internal set; }
        public bool HasLoop { get; internal set; }
        public long LoopStartSample { get; internal set; }
        public long LoopEndSample { get; internal set; }
        public long SampleCount { get; internal set; }
    }

    private readonly CriHcaDecoderUnity.HcaDecoder decoder;
    private readonly float[][] channels;
    private int frameIndex;
    private int subframeIndex = 8;
    private bool looping;
    public Metadata Info { get; private set; }
    public bool Finished { get { return frameIndex == Info.FrameCount || decoder.FileSamplesRemaining == 0; } }

    public HcaFileDecoder(byte[] header, ulong cipherKey) : this(header, cipherKey, null, 0) { }

    // A physical Atom voice reopens its codec instead of allocating a new one.
    // Reset clears the transform/RNG but deliberately retains channel metadata.
    internal HcaFileDecoder(byte[] header, ulong cipherKey, HcaFileDecoder previous, int maximumChannels)
    {
        Metadata info;
        decoder = CriHcaDecoderUnity.HcaDecoder.CreateFile(header, cipherKey, out info, previous?.decoder, maximumChannels);
        Info = info;
        channels = new float[info.Channels][];
        for (int i = 0; i < channels.Length; i++) channels[i] = new float[128];
        Reset();
    }

    // After reset, submit encoded frames from the beginning. The native skip path warms the
    // transform before emitting startSample. Loop endpoints are exclusive sample positions.
    public void Reset(long startSample = 0, long sampleCount = -1)
    {
        if (startSample < 0 || startSample > Info.SampleCount) throw new ArgumentOutOfRangeException(nameof(startSample));
        long available = Info.SampleCount - startSample;
        if (sampleCount < -1 || sampleCount > available) throw new ArgumentOutOfRangeException(nameof(sampleCount));
        decoder.ResetFile(Info.EncoderDelay + startSample, sampleCount == -1 ? available : sampleCount);
        frameIndex = 0;
        subframeIndex = 8;
        looping = false;
    }

    // Returns the encoded frame to submit next. Native seeking starts at floor(audible
    // sample / 1024), then decodes EncoderDelay plus the intra-frame offset as warm-up.
    // Looping follows an authored loop when present, otherwise repeats the whole file.
    public int Seek(long startSample, bool looping = false)
    {
        if (startSample < 0) throw new ArgumentOutOfRangeException(nameof(startSample));
        long end = looping && Info.HasLoop ? Info.LoopEndSample : Info.SampleCount;
        if (looping && (end <= 0 || (Info.HasLoop && (Info.LoopStartSample < 0 || Info.LoopStartSample >= end || end > Info.SampleCount))))
            throw new InvalidDataException("Invalid HCA loop sample range.");
        if (looping && Info.HasLoop && startSample >= end)
            startSample = Info.LoopStartSample + (startSample - Info.LoopStartSample) % (end - Info.LoopStartSample);
        if (startSample > end) throw new ArgumentOutOfRangeException(nameof(startSample));
        decoder.ResetFile(Info.EncoderDelay + startSample % 1024, end - startSample);
        frameIndex = checked((int)(startSample / 1024));
        subframeIndex = 8;
        this.looping = looping;
        return frameIndex;
    }

    // A loop boundary retains the transform history and random state. Re-seeking would
    // reset them and changes real PCM. Submit the returned encoded frame next.
    public int ContinueLoop()
    {
        if (!looping || !Finished) throw new InvalidOperationException("The configured HCA loop has not finished.");
        frameIndex = decoder.ContinueFileLoop(Info.HasLoop, Info.SampleCount);
        subframeIndex = 8;
        return frameIndex;
    }

    // Atom's decoder server fills PCM blocks in 128-sample codec steps. Keeping
    // the partially decoded encoded frame is necessary when a voice is reused.
    internal int DecodeSubframe(ArraySegment<byte> file, float[][] output)
    {
        if (Finished) return 0;
        if (subframeIndex == 8)
        {
            int offset = checked(file.Offset + Info.HeaderSize + frameIndex * Info.FrameSize);
            if (offset > file.Offset + file.Count - Info.FrameSize) throw new InvalidDataException("Truncated HCA encoded frames.");
            long consumed;
            int status = decoder.SubmitFileFrame(file.Array, offset, Info.FrameSize, out consumed);
            if (status != 0 || consumed != Info.FrameSize) throw new InvalidDataException("Invalid HCA frame (native result " + status + ").");
            subframeIndex = 0;
        }
        int samples = decoder.DecodeFileSubframe(output);
        if (++subframeIndex == 8) frameIndex++;
        return samples;
    }

    // Returns interleaved float count (samples per channel multiplied by Channels).
    // Output must have room for a complete 1024-sample frame, even when this frame is trimmed.
    public int DecodeFrame(byte[] source, int offset, int count, float[] output, int outputOffset, out int consumed)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (offset < 0 || count < 0 || offset > source.Length - count) throw new ArgumentOutOfRangeException(nameof(offset));
        if (output == null) throw new ArgumentNullException(nameof(output));
        if (outputOffset < 0 || outputOffset > output.Length - 1024 * Info.Channels) throw new ArgumentOutOfRangeException(nameof(outputOffset));
        consumed = 0;
        if (Finished) return 0;
        long used;
        int result = decoder.SubmitFileFrame(source, offset, count, out used);
        if (result != 0) throw new InvalidDataException("Invalid HCA frame (native result " + result + ").");
        consumed = checked((int)used);
        int written = 0;
        for (int block = 0; block < 8; block++)
        {
            int samples = decoder.DecodeFileSubframe(channels);
            for (int sample = 0; sample < samples; sample++)
                for (int channel = 0; channel < channels.Length; channel++)
                    output[outputOffset + written++] = channels[channel][sample];
        }
        frameIndex++;
        return written;
    }
}

public static partial class CriHcaDecoderUnity
{
    public partial class HcaDecoder
    {
        private Config fileConfig;
        private byte[] fileCipher;
        internal long FileSamplesRemaining { get { return remainSamples; } }

        internal static HcaDecoder CreateFile(byte[] header, ulong key, out HcaFileDecoder.Metadata info,
            HcaDecoder previous = null, int maximumChannels = 0)
        {
            bool loop;
            Config config = ParseFileHeader(header, out loop);
            if (config.frameSize == 0) throw new NotSupportedException("Variable-size HCA files are unsupported.");
            HcaDecoder decoder = previous ?? Create(Math.Max(config.channels, maximumChannels));
            int status = decoder.ApplyHeader(ref config);
            if (status != 0) throw new InvalidDataException("Unsupported HCA configuration (native result " + status + ").");
            decoder.fileConfig = config;
            decoder.fileCipher = CreateFileCipher(config.cipherType, key);
            long samples = (long)config.blockCount * 1024 - config.muteHeader - config.muteFooter;
            if (samples < 0) throw new InvalidDataException("HCA encoder trim exceeds the frame sample count.");
            info = new HcaFileDecoder.Metadata
            {
                Version = config.versionMajor * 256 + config.versionMinor,
                Channels = config.channels, SampleRate = config.samplingRate,
                HeaderSize = config.headerSize, FrameSize = config.frameSize, FrameCount = config.blockCount,
                EncoderDelay = config.muteHeader, EncoderPadding = config.muteFooter,
                SampleCount = samples, CipherType = config.cipherType, Volume = config.volume,
                HasLoop = loop,
                LoopStartSample = loop ? (long)config.loopStart * 1024 + config.loopStartDelay - config.muteHeader : 0,
                LoopEndSample = loop ? ((long)config.loopEnd + 1) * 1024 - config.loopEndDelay - config.muteHeader : 0
            };
            return decoder;
        }

        internal void ResetFile(long skip, long remaining)
        {
            Reset();
            ApplyHeader(ref fileConfig);
            // 0x1a41e4: native sample-window setter.
            skipSamples = skip;
            remainSamples = remaining;
        }

        internal int ContinueFileLoop(bool authored, long samples)
        {
            // 0x1b2a7c: authored loops only set the sample window. Whole-wave repeats
            // reapply the header without calling the codec reset (0x1a3bc4).
            if (!authored) ApplyHeader(ref fileConfig);
            skipSamples = authored ? fileConfig.loopStartDelay : fileConfig.muteHeader;
            remainSamples = authored ? ((long)fileConfig.loopEnd - fileConfig.loopStart + 1) * 1024 - fileConfig.loopStartDelay - fileConfig.loopEndDelay : samples;
            return authored ? fileConfig.loopStart : 0;
        }

        internal int SubmitFileFrame(byte[] data, int offset, int length, out long consumed)
        {
            if (length >= 4 && data[offset] == 255 && data[offset + 1] == 254 && HeaderU16(data, offset + 2) < 8)
            {
                consumed = 0;
                return 10;
            }
            // 0x1a4230 checks CRC on the stored (encrypted) bytes, then substitutes every byte.
            int status = SubmitFrame(data, offset, length, out consumed);
            // Android 0x1a4230 (sub_1B3D48): a nonzero frame CRC returns 12 and the
            // distance to the next 0xFF; the iOS core above has no frame CRC.
            if (status == 0 && Crc16(0, data, offset, (int)consumed) != 0)
            {
                consumed = ScanToSync(data, offset, length);
                return 12;
            }
            if (status == 0 && fileCipher != null)
                for (int i = 0; i < consumed; i++) frameBuffer[i] = fileCipher[frameBuffer[i]];
            return status;
        }

        internal int DecodeFileSubframe(float[][] output)
        {
            long skip = skipSamples, remaining = remainSamples;
            bool active = (uint)(state - 1) <= 9;
            int status = DecodeSubframe(output);
            if (status != 0) throw new InvalidDataException("HCA subframe decode failed (native result " + status + ").");
            // Return value written through the third argument of 0x1a4574.
            if (!active || remaining <= 0 || skip >= 128) return 0;
            return (int)(Math.Min(128, remaining + skip) - Math.Max(0, skip));
        }

        // 0x1b3da8. Bounds checks precede all native-style fixed-offset reads.
        private static Config ParseFileHeader(byte[] data, out bool loop)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            RequireHeaderBytes(data, 0, 8, data.Length);
            if (!HeaderTag(data, 0, "HCA\0")) throw new InvalidDataException("Invalid HCA signature.");
            int version = HeaderU16(data, 4), size = HeaderU16(data, 6);
            if (version < 0x102 || version > 0x300) throw new InvalidDataException("Unsupported HCA version.");
            if (size < 38 || size > data.Length) throw new InvalidDataException("Truncated HCA header.");
            if (Crc16(0, data, 0, size) != 0) throw new InvalidDataException("Invalid HCA header CRC.");
            int end = size - 2;
            RequireHeaderBytes(data, 8, 28, end);
            if (!HeaderTag(data, 8, "fmt\0")) throw new InvalidDataException("Missing HCA fmt chunk.");
            Config c = new Config
            {
                versionMajor = version >> 8, versionMinor = version & 255, headerSize = size,
                channels = data[12], samplingRate = data[13] << 16 | data[14] << 8 | data[15],
                blockCount = HeaderI32(data, 16), muteHeader = HeaderU16(data, 20), muteFooter = HeaderU16(data, 22),
                frameSize = HeaderU16(data, 28), minResolution = data[30], maxResolution = data[31],
                loopEndDelay = 1024, volume = 1f
            };
            int position;
            if (HeaderTag(data, 24, "dec\0"))
            {
                c.totalBandCount = data[32] + 1;
                c.baseBandCount = data[35] == 0 ? c.totalBandCount : data[33] + 1;
                c.stereoBandCount = c.totalBandCount - c.baseBandCount;
                c.trackCount = data[34] >> 4; c.channelConfig = data[34] & 15;
                position = 36;
            }
            else if (HeaderTag(data, 24, "comp"))
            {
                RequireHeaderBytes(data, 24, 16, end);
                c.trackCount = data[32]; c.channelConfig = data[33];
                c.totalBandCount = data[34]; c.baseBandCount = data[35]; c.stereoBandCount = data[36];
                c.bandsPerHfrGroup = data[37]; c.msStereo = data[38];
                position = 40;
            }
            else throw new InvalidDataException("Missing HCA comp/dec chunk.");
            if (c.trackCount == 0) c.trackCount = 1;
            if (OptionalHeaderTag(data, position, end, "ath\0"))
            {
                RequireHeaderBytes(data, position, 6, end);
                position += 6; // The original decoder parses but does not apply ath.
            }
            loop = OptionalHeaderTag(data, position, end, "loop");
            if (loop)
            {
                RequireHeaderBytes(data, position, 16, end);
                c.loopStart = HeaderI32(data, position + 4); c.loopEnd = HeaderI32(data, position + 8);
                c.loopStartDelay = HeaderU16(data, position + 12); c.loopEndDelay = HeaderU16(data, position + 14);
                position += 16;
            }
            if (OptionalHeaderTag(data, position, end, "ciph"))
            {
                RequireHeaderBytes(data, position, 6, end);
                c.cipherType = HeaderU16(data, position + 4); position += 6;
            }
            if (OptionalHeaderTag(data, position, end, "rva\0"))
            {
                RequireHeaderBytes(data, position, 8, end);
                byte[] bits = BitConverter.GetBytes(HeaderI32(data, position + 4));
                c.volume = BitConverter.ToSingle(bits, 0); position += 8;
            }
            if (OptionalHeaderTag(data, position, end, "comm"))
            {
                RequireHeaderBytes(data, position, 5, end);
                RequireHeaderBytes(data, position + 5, data[position + 4], end);
            }
            if (!ValidateHeader(ref c)) throw new InvalidDataException("Invalid HCA header configuration.");
            // Native channel arrays contain 128 entries; reject malformed layouts before codec math.
            if (c.totalBandCount > 128 || c.baseBandCount > c.totalBandCount || c.stereoBandCount < 0 ||
                c.baseBandCount + c.stereoBandCount > c.totalBandCount)
                throw new InvalidDataException("Invalid HCA band layout.");
            return c;
        }

        private static void RequireHeaderBytes(byte[] data, int position, int length, int end)
        {
            if (position < 0 || length < 0 || position > end - length || end > data.Length)
                throw new InvalidDataException("Truncated HCA header chunk.");
        }
        private static int HeaderU16(byte[] data, int p) { return data[p] << 8 | data[p + 1]; }
        private static int HeaderI32(byte[] data, int p) { return data[p] << 24 | data[p + 1] << 16 | data[p + 2] << 8 | data[p + 3]; }
        private static bool HeaderTag(byte[] data, int p, string tag)
        {
            for (int i = 0; i < 4; i++) if ((data[p + i] & 127) != tag[i]) return false;
            return true;
        }
        private static bool OptionalHeaderTag(byte[] data, int p, int end, string tag) { return p <= end - 4 && HeaderTag(data, p, tag); }

        private static byte[] CreateFileCipher(int type, ulong key)
        {
            if (type == 0) return null;
            if (type == 56) return key == 0 ? null : CreateKeyedCipher(key);
            if (type != 1) throw new NotSupportedException("Unsupported HCA cipher type " + type + ".");
            byte[] table = new byte[256];
            int value = 0;
            for (int i = 1; i < 255; i++)
            {
                value = (13 * value + 11) & 255;
                if (value == 0 || value == 255) value = (13 * value + 11) & 255;
                table[i] = (byte)value;
            }
            table[255] = 255;
            return table;
        }

        // sub_1A86E0 case 0x38 (also the public clHCA cipher_init56): the 56-bit
        // key minus one seeds a 16x16 nibble table, then a stride-17 shuffle
        // keeps the bytes other than 0 and 0xFF. A zero key is the identity.
        internal static byte[] CreateKeyedCipher(ulong key)
        {
            ulong value = key - 1;
            var kc = new byte[7];
            for (int i = 0; i < 7; i++) { kc[i] = (byte)value; value >>= 8; }
            byte[] seed =
            {
                kc[1], (byte)(kc[1] ^ kc[6]), (byte)(kc[2] ^ kc[3]), kc[2],
                (byte)(kc[2] ^ kc[1]), (byte)(kc[3] ^ kc[4]), kc[3], (byte)(kc[3] ^ kc[2]),
                (byte)(kc[4] ^ kc[5]), kc[4], (byte)(kc[4] ^ kc[3]), (byte)(kc[5] ^ kc[6]),
                kc[5], (byte)(kc[5] ^ kc[4]), (byte)(kc[6] ^ kc[1]), kc[6]
            };
            var rows = NibbleTable(kc[0]);
            var base256 = new byte[256];
            for (int r = 0; r < 16; r++)
            {
                var columns = NibbleTable(seed[r]);
                for (int c = 0; c < 16; c++) base256[r * 16 + c] = (byte)(rows[r] << 4 | columns[c]);
            }
            var table = new byte[256];
            int x = 0, position = 1;
            for (int i = 0; i < 256; i++)
            {
                x = (x + 17) & 255;
                if (base256[x] != 0 && base256[x] != 255) table[position++] = base256[x];
            }
            table[0] = 0;
            table[255] = 255;
            return table;
        }

        private static byte[] NibbleTable(byte key)
        {
            int multiplier = (key & 1) != 0 ? 13 : 5, add = (key & 14) | 1, value = key >> 4;
            var result = new byte[16];
            for (int i = 0; i < 16; i++) { value = (value * multiplier + add) & 15; result[i] = (byte)value; }
            return result;
        }
    }
}
