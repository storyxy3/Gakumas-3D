using System;

// CriHcaDecoder (global namespace, TypeDefIndex 31641; 0x669eecc..0x669f4e8). In the game it binds the native
// cri_ware_unity plugin; here the plugin's criHcaDecoderUnity_* functions and the CRI HCA decoder underneath are ported
// from libcri_ware_unity.so (arm64): decoded output is bit-identical to the native functions run under emulation.
// DecodeHcaToPcm (planar output) is not used by the game and is not ported.
public class CriHcaDecoder
{
    private CriHcaDecoderUnity.Handle nativeHandle;

    // 0x669eecc
    public CriHcaDecoder(int maxChannels = 8)
    {
        CriHcaDecoderUnity.Initialize();
        nativeHandle = CriHcaDecoderUnity.Create(maxChannels);
    }

    // 0x669efe4
    public void SetFormat(int numChannels, int samplingRate, int voiceBitrate)
    {
        CriHcaDecoderUnity.Reset(nativeHandle, numChannels, samplingRate, voiceBitrate);
    }

    // 0x669f088
    public void DecodeHcaToInterleavedPcm(byte[] source, int dataOffset, int dataLength, float[] output, ref int processedDataLength,
        ref int outputSampleCount)
    {
        CriHcaDecoderUnity.DecodeHcaToInterleavedPcm(nativeHandle, source, dataOffset, dataLength, output, ref processedDataLength,
            ref outputSampleCount);
    }

    // 0x669f3b0
    ~CriHcaDecoder()
    {
        if (nativeHandle != null)
        {
            CriHcaDecoderUnity.Destroy(nativeHandle);
            nativeHandle = null;
        }
    }
}

// The native side of CriHcaDecoder (libcri_ware_unity.so: criHcaDecoderUnity_* at 0x3d9b0..0x3de4c and the HCA decoder
// at 0x1a3940..0x1a7c20).
public static partial class CriHcaDecoderUnity
{
    // Receives the plugin's error and warning strings (criErr notifications); unset means they are dropped.
    public static Action<string> ErrorCallback;

    private static bool initialized;

    // criHcaDecoderUnity handle (0x28 bytes): HCA decoder, channel count, per-channel 128-sample buffers, format flag.
    public class Handle
    {
        public HcaDecoder decoder;
        public int maxChannels;
        public int numChannels;
        public float[][] channelBuffers;
        public bool formatSet;
    }

    private static void Notify(string message)
    {
        if (ErrorCallback != null)
            ErrorCallback(message);
    }

    // 0x3d9b0
    public static void Initialize()
    {
        if (initialized)
        {
            Notify("E2021090712:CriHcaDecoderUnity is already initialized.");
            return;
        }
        initialized = true;
    }

    // criHcaDecoderUnity_Finalize (0x3da00)
    public static void FinalizeLibrary()
    {
        initialized = false;
    }

    // 0x3da48: the channel buffers are malloc'd (not cleared) in the plugin; they are always written before being read.
    public static Handle Create(int maxChannels)
    {
        if (!initialized)
        {
            Notify("E2021090714:CriHcaDecoderUnity is not initialized.");
            return null;
        }
        Handle handle = new Handle();
        handle.decoder = HcaDecoder.Create(maxChannels);
        if (handle.decoder == null)
        {
            Destroy(handle);
            return null;
        }
        handle.channelBuffers = new float[maxChannels][];
        for (int i = 0; i < maxChannels; i++)
            handle.channelBuffers[i] = new float[128];
        handle.maxChannels = maxChannels;
        handle.numChannels = 0;
        handle.formatSet = false;
        return handle;
    }

    // 0x3db54
    public static void Destroy(Handle handle)
    {
        if (handle == null)
            return;
        handle.decoder = null;
        handle.channelBuffers = null;
    }

    // 0x3dc14: the format flag is set even when the derived header is rejected.
    public static void Reset(Handle handle, int numChannels, int samplingRate, int voiceBitrate)
    {
        if (handle == null || handle.decoder == null)
            return;
        handle.decoder.Reset();
        handle.decoder.SetFormat(numChannels, samplingRate, voiceBitrate);
        handle.numChannels = numChannels;
        handle.formatSet = true;
    }

    // 0x3dc74: decodes whole frames from data[dataOffset..] and interleaves 8 x 128 samples per channel and frame.
    public static void DecodeHcaToInterleavedPcm(Handle handle, byte[] data, int dataOffset, int dataLength, float[] output,
        ref int processedDataLength, ref int outputSampleCount)
    {
        processedDataLength = 0;
        outputSampleCount = 0;
        if (handle == null)
        {
            Notify("E2021090705");
            return;
        }
        if (!handle.formatSet)
        {
            Notify("E2021090706:Format information is not set for CriHcaDecoderUnity.");
            return;
        }
        int remain = dataLength;
        int samples = 0;
        int processed = 0;
        if (remain >= 1)
        {
            while (true)
            {
                long consumed;
                if (handle.decoder.SubmitFrame(data, dataOffset + processed, remain, out consumed) != 0)
                    Notify("W2021090701:Decode packet is corrupted.");
                int channels = handle.numChannels;
                for (int i = 0; i != 8; i++)
                {
                    if (handle.decoder.DecodeSubframe(handle.channelBuffers) != 0)
                        throw new InvalidOperationException("CriHcaDecoderUnity: decoder without a valid format (native memory corruption)");
                    channels = handle.numChannels;
                    for (int ch = 0; ch < channels; ch++)
                    {
                        float[] buffer = handle.channelBuffers[ch];
                        int index = samples + ch;
                        for (int k = 0; k < 128; k++)
                        {
                            output[index] = buffer[k];
                            index += channels;
                        }
                    }
                    samples += channels << 7;
                }
                if ((consumed >> 31) != 0)
                {
                    Notify("E2022112801:Decoded sample is overflow.");
                    break;
                }
                remain -= (int)consumed;
                processed += (int)consumed;
                if (remain <= 0)
                    break;
            }
        }
        processedDataLength = processed;
        outputSampleCount = samples;
    }

    // CRI HCA decoder state (0x1a3940 layout: version +4, channels +8, frame +48, resolutions +56/+60, bands +64..+84,
    // unpack state +232..+248, frame buffer +256, sample window +272/+280).
    public partial class HcaDecoder
    {
        private class Channel
        {
            public float[] spectra = new float[128];
            public float[] gain = new float[128];
            public byte[] scalefactors = new byte[128];
            public byte[] resolution = new byte[128];
            public byte[] noises = new byte[128];
            public byte[] intensity = new byte[8];
            public int type;
            public int codedCount;
            public int validCount;
            public int noiseCount;
            public float[] imdctPrevious = new float[128];
            public float[] imdctTemp = new float[128];
        }

        // Header configuration (the struct written by 0x1b422c and read back by 0x1b3da8).
        private struct Config
        {
            public int versionMajor, versionMinor, headerSize, samplingRate, blockCount, muteHeader, muteFooter, frameSize, channels;
            public int maxResolution, minResolution, totalBandCount, baseBandCount, stereoBandCount, bandsPerHfrGroup, msStereo;
            public int trackCount, channelConfig, loopStart, loopStartDelay, loopEnd, loopEndDelay, cipherType;
            public float volume;
        }

        private int maxChannels;
        private int version;
        private int channels;
        private int samplingRate;
        private int headerSize;
        private int frameSize;
        private int frameBits;
        private int maxResolution;
        private int minResolution;
        private int totalBandCount;
        private int baseBandCount;
        private int stereoBandCount;
        private int hfrGroupCount;
        private int bandsPerHfrGroup;
        private int msStereo;
        private int trackCount;
        private int channelConfig;
        private Channel[] channel;
        private int noiseLevel;
        private int evaluationBoundary;
        private int state;
        private int bitPosition;
        private uint random;
        private byte[] frameBuffer;
        private int frameBufferSize;
        private long skipSamples;
        private long remainSamples;

        // 0x1a3940: the frame buffer is the zero-filled tail of the work area (520 * channels + 104 bytes); it is padded
        // here so reads past a corrupt frame stay in bounds (the plugin reads adjacent memory there).
        public static HcaDecoder Create(int maxChannels)
        {
            if ((uint)(maxChannels - 1) > 0xF)
                return null;
            HcaDecoder decoder = new HcaDecoder();
            decoder.maxChannels = maxChannels;
            decoder.channel = new Channel[maxChannels];
            for (int i = 0; i < maxChannels; i++)
                decoder.channel[i] = new Channel();
            decoder.frameBufferSize = 520 * maxChannels + 104;
            decoder.frameBuffer = new byte[decoder.frameBufferSize + 0x10000];
            decoder.Reset();
            return decoder;
        }

        // 0x1a3bc4
        public void Reset()
        {
            for (int i = 0; i < maxChannels; i++)
            {
                Array.Clear(channel[i].imdctPrevious, 0, 128);
                Array.Clear(channel[i].imdctTemp, 0, 128);
            }
            headerSize = 0;
            state = 0;
            random = 1;
            skipSamples = 0;
            remainSamples = long.MaxValue;
        }

        // ARM sdiv: division by zero gives 0 and int.MinValue / -1 wraps.
        private static int Sdiv(int a, int b)
        {
            if (b == 0)
                return 0;
            if (a == int.MinValue && b == -1)
                return int.MinValue;
            return a / b;
        }

        // ARM fcvtzs: truncates, NaN gives 0, out-of-range saturates.
        private static int Fcvtzs(float value)
        {
            if (float.IsNaN(value))
                return 0;
            if (value >= 2147483648f)
                return int.MaxValue;
            if (value <= -2147483648f)
                return int.MinValue;
            return (int)value;
        }

        // 0x1a49ac: derives the band layout from the voice format, then writes and parses a v3.0 header.
        public int SetFormat(int channels, int samplingRate, int bitrate)
        {
            float rate = samplingRate;
            int nyquist = (samplingRate < 0 ? samplingRate + 1 : samplingRate) >> 1;
            float ratio = (float)((float)((float)((float)bitrate / (float)channels) / rate) * 128f);
            int total = Fcvtzs((float)((float)((float)(nyquist << 8) / rate) + 0.5f));
            ratio = (float)(ratio / (float)total);
            int baseBands, stereoBands, hfrBands;
            if (channels <= 1)
            {
                baseBands = total;
                if (!(ratio >= 2.6666667f))
                {
                    if (ratio >= 1.3333334f)
                    {
                        float bands = (float)((float)(6 * bitrate) / (float)(channels << 5));
                        float limit = nyquist;
                        if (bands > limit)
                            bands = limit;
                        baseBands = Fcvtzs((float)((float)((float)(bands * 256f) / rate) + 0.5f));
                    }
                    else
                    {
                        baseBands = (total < 0 ? total + 1 : total) >> 1;
                    }
                }
                if (baseBands < total - baseBands)
                    baseBands++;
                stereoBands = 0;
                hfrBands = total - baseBands;
            }
            else if (ratio >= 2.6666667f)
            {
                hfrBands = 0;
                stereoBands = 0;
                baseBands = total;
            }
            else if (ratio >= 2f)
            {
                float limit = nyquist;
                float bands = (float)((float)(6 * bitrate) / (float)(channels << 5));
                if (bands > limit)
                    bands = limit;
                float upper = (float)(limit - bands);
                float lower = (float)(bands - upper);
                baseBands = Fcvtzs((float)((float)((float)(lower * 256f) / rate) + 0.5f));
                hfrBands = 0;
                stereoBands = total - baseBands;
            }
            else
            {
                int coded;
                if (ratio >= 1f)
                {
                    float limit = nyquist;
                    float bands = (float)((float)(bitrate << 3) / (float)(channels << 5));
                    if (bands > limit)
                        bands = limit;
                    coded = Fcvtzs((float)((float)((float)(bands * 256f) / rate) + 0.5f));
                }
                else
                {
                    coded = (total < 0 ? total + 1 : total) >> 1;
                }
                if (coded < total - coded)
                    coded++;
                baseBands = (coded & 1) + ((coded < 0 ? coded + 1 : coded) >> 1);
                stereoBands = coded - baseBands;
                hfrBands = total - coded;
            }
            int groupBands = (hfrBands < 0 ? hfrBands + 7 : hfrBands) >> 3;
            if (hfrBands - ((hfrBands < 0 ? hfrBands + 7 : hfrBands) & ~7) > 0)
                groupBands++;
            int frame = Sdiv(bitrate << 10, samplingRate);
            frame = (frame < 0 ? frame + 7 : frame) >> 3;

            Config config = new Config();
            config.versionMajor = 3;
            config.versionMinor = 0;
            config.headerSize = 96;
            config.samplingRate = samplingRate;
            config.blockCount = 0x7FFFFFFE;
            config.muteHeader = 0;
            config.muteFooter = 0;
            config.frameSize = frame;
            config.channels = channels;
            config.maxResolution = 15;
            config.minResolution = 0;
            config.totalBandCount = total;
            config.baseBandCount = baseBands;
            config.stereoBandCount = stereoBands;
            config.bandsPerHfrGroup = groupBands;
            config.msStereo = 0;
            config.trackCount = 1;
            config.channelConfig = 0;
            config.loopStart = 0;
            config.loopStartDelay = 0;
            config.loopEnd = 0;
            config.loopEndDelay = 1024;
            config.cipherType = 0;
            config.volume = 1f;
            if (!ValidateHeader(ref config))
                return 2;
            return ApplyHeader(ref config);
        }

        // 0x1b422c / 0x1b3da8 validation (shared by the header writer and parser).
        private static bool ValidateHeader(ref Config c)
        {
            if ((uint)(c.channels - 1) > 0xF)
                return false;
            if (c.trackCount > c.channels)
                return false;
            if ((uint)(c.samplingRate - 1) > 0x7FFFFE)
                return false;
            if (!(c.frameSize < 0x10000 && (c.frameSize >= 8 || c.frameSize == 0)))
                return false;
            if (c.minResolution < 0)
                return false;
            if (c.maxResolution > 31 || c.maxResolution < c.minResolution)
                return false;
            if (c.blockCount < 0)
                return false;
            if (c.loopStart < 0 || c.loopEnd < 0 || c.loopStart > c.loopEnd)
                return false;
            if (c.blockCount >= 1 && c.loopEnd >= c.blockCount)
                return false;
            if ((uint)c.cipherType > 0x38 || ((1L << c.cipherType) & 0x100000000000003L) == 0)
                return false;
            return true;
        }

        // 0x1a3c40 (after 0x1b3da8 has parsed the header written above). The cipher type is always 0 for this format.
        private int ApplyHeader(ref Config c)
        {
            if (c.channels > maxChannels)
                return 11;
            if (frameBufferSize < c.frameSize)
                return 11;
            if (c.minResolution < 0)
                return 11;
            if (c.maxResolution > 15)
                return 11;
            version = c.versionMajor;
            channels = c.channels;
            frameSize = c.frameSize;
            frameBits = 8 * c.frameSize;
            samplingRate = c.samplingRate;
            maxResolution = c.maxResolution;
            minResolution = c.minResolution;
            totalBandCount = c.totalBandCount;
            baseBandCount = c.baseBandCount;
            stereoBandCount = c.stereoBandCount;
            bandsPerHfrGroup = c.bandsPerHfrGroup;
            msStereo = c.msStereo;
            trackCount = c.trackCount;
            channelConfig = c.channelConfig;
            if (bandsPerHfrGroup < 1)
            {
                hfrGroupCount = 0;
            }
            else
            {
                int bands = totalBandCount - baseBandCount - stereoBandCount;
                hfrGroupCount = bands % bandsPerHfrGroup <= 0 ? bands / bandsPerHfrGroup : bands / bandsPerHfrGroup + 1;
            }
            int[] types = new int[channels];
            SetupChannelTypes(channels, trackCount, channelConfig, stereoBandCount > 0, types);
            for (int i = 0; i < channels; i++)
            {
                channel[i].codedCount = (types[i] == 2 ? 0 : stereoBandCount) + baseBandCount;
                channel[i].type = types[i];
            }
            headerSize = c.headerSize;
            return 0;
        }

        // 0x1b4778: channel roles per track (0 discrete, 1 stereo primary, 2 stereo secondary).
        private static void SetupChannelTypes(int channels, int trackCount, int channelConfig, bool stereo, int[] types)
        {
            int perTrack = channels / trackCount;
            if (!stereo || perTrack == 1)
            {
                Array.Clear(types, 0, channels);
                return;
            }
            int pos = 0;
            if (trackCount >= 1)
            {
                for (int t = 0; t < trackCount; t++)
                {
                    switch (perTrack)
                    {
                        case 2:
                            types[pos] = 1; types[pos + 1] = 2;
                            break;
                        case 3:
                            types[pos] = 1; types[pos + 1] = 2; types[pos + 2] = 0;
                            break;
                        case 4:
                            types[pos] = 1; types[pos + 1] = 2;
                            types[pos + 2] = channelConfig == 0 ? 1 : 0;
                            types[pos + 3] = channelConfig == 0 ? 2 : 0;
                            break;
                        case 5:
                            types[pos] = 1; types[pos + 1] = 2; types[pos + 2] = 0;
                            types[pos + 3] = channelConfig < 3 ? 1 : 0;
                            types[pos + 4] = channelConfig < 3 ? 2 : 0;
                            break;
                        case 6:
                            types[pos] = 1; types[pos + 1] = 2; types[pos + 2] = 0; types[pos + 3] = 0; types[pos + 4] = 1; types[pos + 5] = 2;
                            break;
                        case 7:
                            types[pos] = 1; types[pos + 1] = 2; types[pos + 2] = 0; types[pos + 3] = 0; types[pos + 4] = 1; types[pos + 5] = 2;
                            types[pos + 6] = 0;
                            break;
                        case 8:
                            types[pos] = 1; types[pos + 1] = 2; types[pos + 2] = 0; types[pos + 3] = 0; types[pos + 4] = 1; types[pos + 5] = 2;
                            types[pos + 6] = 1; types[pos + 7] = 2;
                            break;
                        default:
                            if (perTrack >= 1)
                                Array.Clear(types, pos, perTrack);
                            break;
                    }
                    pos += perTrack;
                }
            }
            for (int i = perTrack * trackCount; i < channels; i++)
                types[i] = 0;
        }

        // 0x25F9C60。官方只有头写入器 0x25FC050 引用它；复刻省掉了头的写入→解析往返，SubmitFrame 也不校验帧 CRC，
        // 所以当前无调用方，仅保留作对照。
        private static ushort Crc16(ushort crc, byte[] data, int offset, int length)
        {
            uint value = crc;
            for (int i = 0; i < length; i++)
                value = (uint)CrcTable[(data[offset + i] ^ (value >> 8)) & 0xFF] ^ (value << 8);
            return (ushort)value;
        }

        private static long ScanToSync(byte[] data, int offset, long length)
        {
            long index = 0;
            if (length != 1)
            {
                do
                {
                    if (data[offset + index + 1] == 0xFF)
                        break;
                    index++;
                }
                while (index < length - 1);
            }
            return index + 1;
        }

        // 官方 7.0.0 iOS sub_25FA3B0（Android libcri 0x1a4230 另带帧 CRC 校验，iOS 没有）：只检查同步字
        // （0xFFFF，或 0xFFFE 加只能缩小帧长的 16 位 size），通过后复制帧数据；失败时 consumed 为跳到下一个 0xFF 的距离。
        public int SubmitFrame(byte[] data, int offset, long length, out long consumed)
        {
            consumed = 0;
            if (headerSize < 1)
                return 6;
            if (length == 0)
                return 9;
            if (data[offset] != 0xFF)
            {
                consumed = ScanToSync(data, offset, length);
                return 10;
            }
            if (length < 8)
                return 9;
            int second = data[offset + 1];
            int size = frameSize;
            int headerBits;
            if (second == 0xFF)
            {
                headerBits = 16;
                if (length < size)
                    return 9;
            }
            else
            {
                int newSize = data[offset + 3] | (data[offset + 2] << 8);
                if (second != 0xFE || newSize > size)
                {
                    consumed = ScanToSync(data, offset, length);
                    return 10;
                }
                frameSize = newSize;
                frameBits = 8 * newSize;
                headerBits = 32;
                size = newSize;
                if (length < newSize)
                    return 9;
            }
            int first = size <= length ? size : (int)length;
            // 官方 7.0.0 iOS sub_25FA3B0（HCA submit frame）同步字/长度检查通过后直接查表复制或 memcpy 帧数据，
            // state=1、bitPosition=16/32、consumed=size，全程不校验帧 CRC（CRC16 只被头写入器引用），故这里不做 CRC 拒收。
            Buffer.BlockCopy(data, offset, frameBuffer, 0, first);
            state = 1;
            bitPosition = headerBits;
            consumed = size;
            return 0;
        }

        // 0x1a4574 (through 0x1a4520): one 128-sample subframe per channel into output[ch].
        public int DecodeSubframe(float[][] output)
        {
            if (headerSize < 1)
                return 6;
            if ((uint)(state - 1) > 9)
                return 0;
            long skip = skipSamples;
            long remain = remainSamples;
            if (skip <= 0 && remain >= 128)
            {
                DecodeBlock(output);
                remainSamples = remain - 128;
                if (remainSamples <= 0)
                    state = 11;
                return 0;
            }
            if (remain <= 0)
            {
                state = 11;
                return 0;
            }
            if (skip >= 1153)
            {
                int s = state;
                if (s == 1)
                {
                    s = 2;
                    state = 2;
                }
                state = s == 9 ? 11 : s + 1;
                skipSamples = skip - 128;
                return 0;
            }
            if (skip >= 257)
            {
                DecodeBlock(null);
                skipSamples -= 128;
                return 0;
            }
            DecodeBlock(output);
            if (skip >= 128)
            {
                skipSamples -= 128;
                return 0;
            }
            long count = remain + skip >= 128 ? 128 : remain + skip;
            if (output != null && skip >= 1)
            {
                count -= skip;
                if (channels >= 1 && count >= 1)
                {
                    for (int ch = 0; ch < channels; ch++)
                        Array.Copy(output[ch], (int)skip, output[ch], 0, (int)count);
                }
                skipSamples = 0;
            }
            remainSamples = remain - count;
            if (remainSamples <= 0)
                state = 11;
            return 0;
        }

        private int Peek(int position, int bits)
        {
            int index = position >> 3;
            int value = (frameBuffer[index] << 16) | (frameBuffer[index + 1] << 8) | frameBuffer[index + 2];
            return (value >> (24 - bits - (position & 7))) & BitMasks[bits];
        }

        // 0x1a4ca8: on the frame's first call unpacks scalefactors/intensity and derives resolutions and gains, then
        // dequantizes one subframe, rebuilds noise/high bands/stereo and runs the IMDCT into output.
        private void DecodeBlock(float[][] output)
        {
            if (state == 1)
            {
                int start = bitPosition;
                noiseLevel = Peek(start, 9);
                evaluationBoundary = Peek(start + 9, 7);
                int position = start + 16;
                for (int i = 0; i < channels; i++)
                    position = UnpackChannel(channel[i], position);
                int packedNoiseLevel = (noiseLevel << 8) - evaluationBoundary;
                for (int i = 0; i < channels; i++)
                    CalculateResolution(channel[i], packedNoiseLevel);
                for (int i = 0; i < channels; i++)
                    CalculateGain(channel[i]);
                if (position <= frameBits)
                    bitPosition = position;
                state++;
            }
            {
                int position = bitPosition;
                for (int i = 0; i < channels; i++)
                    position = Dequantize(channel[i], position);
                if (position <= frameBits)
                    bitPosition = position;
            }
            int current = state;
            state = current + 1;
            if (minResolution <= 0)
                ReconstructNoise();
            if (bandsPerHfrGroup > 0)
                ReconstructHighFrequency();
            if (stereoBandCount >= 1)
                ApplyIntensityStereo(current - 2);
            if (msStereo != 0)
                ApplyMsStereo();
            if (output != null)
            {
                for (int i = 0; i < channels; i++)
                {
                    if (output[i] != null)
                        ImdctTransform(channel[i], output[i]);
                }
                if (state == 10)
                    state = 11;
            }
            else if (state == 10)
            {
                state = 11;
            }
        }

        private int UnpackChannel(Channel ch, int position)
        {
            int coded = ch.codedCount;
            int head = Peek(position, 9);
            int deltaBits = head >> 6;
            int hfrScales = (ch.type == 2 || hfrGroupCount <= 0 || version <= 2) ? 0 : hfrGroupCount;
            byte[] sf = ch.scalefactors;
            if (deltaBits == 0)
            {
                position += 3;
                Array.Clear(sf, 0, 128);
            }
            else
            {
                int count = hfrScales + coded;
                int value = head & 0x3F;
                sf[0] = (byte)value;
                if (head >= 0x180)
                {
                    int p = position + 9;
                    for (int i = 1; i < count; i++)
                    {
                        sf[i] = (byte)Peek(p, 6);
                        p += 6;
                    }
                    position = count > 1 ? position + 6 * count + 3 : position + 9;
                }
                else
                {
                    int p = position + 9;
                    int expected = ~(-1 << deltaBits);
                    int half = (int)((uint)expected >> 1);
                    for (int i = 1; i < count; i++)
                    {
                        int delta = Peek(p, deltaBits);
                        p += deltaBits;
                        if (delta == expected)
                        {
                            value = Peek(p, 6);
                            p += 6;
                        }
                        else
                        {
                            value = value - half + delta;
                        }
                        sf[i] = (byte)(value & 0x3F);
                    }
                    position = p;
                }
            }
            for (int k = hfrScales - 1; k >= 0; k--)
                sf[128 - hfrGroupCount + k] = sf[coded + k];
            if (ch.type == 2)
            {
                if (version > 2)
                {
                    int head6 = Peek(position, 6);
                    if (head6 >= 0x3C)
                    {
                        position += 4;
                        for (int i = 0; i < 8; i++)
                            ch.intensity[i] = 7;
                    }
                    else
                    {
                        int value = head6 >> 2;
                        int deltaBits2 = head6 & 3;
                        ch.intensity[0] = (byte)value;
                        int p = position + 6;
                        if (deltaBits2 == 3)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                ch.intensity[i] = (byte)Peek(p, 4);
                                p += 4;
                            }
                        }
                        else
                        {
                            int bits = deltaBits2 + 1;
                            int bmax = (2 << deltaBits2) - 1;
                            int half = bmax >> 1;
                            for (int i = 1; i < 8; i++)
                            {
                                int delta = Peek(p, bits);
                                p += bits;
                                int next;
                                if (delta == bmax)
                                {
                                    next = Peek(p, 4);
                                    p += 4;
                                }
                                else
                                {
                                    next = value - half + delta;
                                }
                                int clamped = next & ~(next >> 31);
                                if (clamped >= 15)
                                    clamped = 15;
                                ch.intensity[i] = (byte)clamped;
                                value = clamped;
                            }
                        }
                        position = p;
                    }
                }
                else
                {
                    int head8 = Peek(position, 8);
                    ch.intensity[0] = (byte)(head8 >> 4);
                    if ((head8 & 0xFF0) <= 0xE0)
                    {
                        ch.intensity[1] = (byte)(head8 & 0xF);
                        for (int i = 1; i < 4; i++)
                        {
                            int pair = Peek(position + 8 * i, 8);
                            ch.intensity[2 * i] = (byte)(pair >> 4);
                            ch.intensity[2 * i + 1] = (byte)(pair & 0xF);
                        }
                        position += 32;
                    }
                }
            }
            else if (version < 3 && hfrGroupCount > 0)
            {
                for (int i = 0; i < hfrGroupCount; i++)
                {
                    sf[128 - hfrGroupCount + i] = (byte)Peek(position, 6);
                    position += 6;
                }
            }
            return position;
        }

        private void CalculateResolution(Channel ch, int packedNoiseLevel)
        {
            int coded = ch.codedCount;
            if (coded <= 0)
            {
                ch.validCount = 0;
                ch.noiseCount = 0;
                Array.Clear(ch.resolution, 0, 128);
                return;
            }
            int valid = 0;
            int noise = 0;
            for (int i = 0; i < coded; i++)
            {
                int scalefactor = ch.scalefactors[i];
                if (scalefactor == 0)
                {
                    ch.resolution[i] = 0;
                    continue;
                }
                int curve = ((packedNoiseLevel + i) >> 8) + 1 - (int)((uint)(5 * scalefactor) >> 1);
                int resolution;
                if (curve < 0)
                    resolution = 15;
                else if (curve <= 65)
                    resolution = InvertTable[curve];
                else
                    resolution = 0;
                if (resolution > maxResolution)
                    resolution = maxResolution;
                if (resolution < minResolution)
                    resolution = minResolution;
                ch.resolution[i] = (byte)resolution;
                if (resolution < 1)
                    ch.noises[noise++] = (byte)i;
                else
                    ch.noises[127 - valid++] = (byte)i;
            }
            ch.validCount = valid;
            ch.noiseCount = noise;
            if (coded <= 127)
                Array.Clear(ch.resolution, coded, 128 - coded);
        }

        // 0x1a66a8: computed in groups of 8 up to the coded count.
        private static void CalculateGain(Channel ch)
        {
            int coded = ch.codedCount;
            for (int i = 0; i < coded; i += 8)
            {
                for (int k = i; k < i + 8; k++)
                    ch.gain[k] = (float)(RangeTable[ch.resolution[k]] * ScalingTable[ch.scalefactors[k]]);
            }
        }

        private int Dequantize(Channel ch, int position)
        {
            int coded = ch.codedCount;
            for (int i = 0; i < coded; i++)
            {
                int resolution = ch.resolution[i];
                int bits = MaxBitTable[resolution];
                int code = Peek(position, bits);
                float value;
                if (resolution > 7)
                {
                    int signedCode = (1 - 2 * (code & 1)) * (code >> 1);
                    value = signedCode;
                    position += bits - (signedCode == 0 ? 1 : 0);
                }
                else
                {
                    int index = 16 * resolution + code;
                    value = ReadValTable[index];
                    position += ReadBitTable[index];
                }
                ch.spectra[i] = (float)(value * ch.gain[i]);
            }
            if (coded <= 127)
                Array.Clear(ch.spectra, coded, 128 - coded);
            return position;
        }

        // Noise substitution with the lib's LCG (state shared by all channels and kept across subframes).
        private void ReconstructNoise()
        {
            uint seed = random;
            for (int c = 0; c < channels; c++)
            {
                Channel ch = channel[c];
                if (msStereo != 0 && ch.type != 1)
                    continue;
                int valid = ch.validCount;
                if (valid == 0 || ch.noiseCount < 1)
                    continue;
                for (int i = 0; i < ch.noiseCount; i++)
                {
                    seed = 214013 * seed + 2531011;
                    int source = ch.noises[128 - valid + (int)(((ulong)((seed >> 16) & 0x7FFF) * (uint)valid) >> 15)];
                    int target = ch.noises[i];
                    int index = ch.scalefactors[target] - ch.scalefactors[source] + 62;
                    ch.spectra[target] = (float)(ScaleConversionTable[index & ~(index >> 31)] * ch.spectra[source]);
                }
            }
            random = seed;
        }

        // The lowband walks down, then (v3) up and down again through the HFR groups; the last rebuilt band is cleared.
        private void ReconstructHighFrequency()
        {
            int groups = hfrGroupCount;
            int halfGroups = groups >= 0 ? groups : groups + 1;
            int limit = version >= 3 ? halfGroups >> 1 : groups;
            int start = stereoBandCount + baseBandCount;
            if (channels < 1)
                return;
            if (groups <= 0)
            {
                for (int c = 0; c < channels; c++)
                {
                    if (channel[c].type != 2)
                        channel[c].spectra[start - 1] = 0f;
                }
                return;
            }
            int total = totalBandCount;
            int scaleBase = 128 - groups;
            for (int c = 0; c < channels; c++)
            {
                Channel ch = channel[c];
                if (ch.type == 2)
                    continue;
                int highband = start;
                int lowband = start - 1;
                for (int group = 0; group != groups; group++)
                {
                    if (highband < total && lowband >= 0)
                    {
                        int direction = (group >= 2 * limit || group < limit) ? -1 : 1;
                        int count = 0;
                        int offset = 0;
                        int next;
                        while (true)
                        {
                            int index = ch.scalefactors[scaleBase + group] - ch.scalefactors[lowband + offset] + 63;
                            float scale = ScaleConversionTable[index & ~(index >> 31)];
                            bool more = highband + 1 + count < total;
                            next = offset + direction;
                            ch.spectra[highband + count] = (float)(scale * ch.spectra[lowband + offset]);
                            count++;
                            if (!more)
                                break;
                            if (direction + lowband + offset < 0)
                                break;
                            offset += direction;
                            if (count >= bandsPerHfrGroup)
                                break;
                        }
                        lowband += next;
                        highband += count;
                    }
                }
                ch.spectra[highband - 1] = 0f;
            }
        }

        private void ApplyIntensityStereo(int subframe)
        {
            for (int c = 0; c < channels - 1; c++)
            {
                if (channel[c].type != 1)
                    continue;
                float ratio = IntensityRatioTable[channel[c + 1].intensity[subframe]];
                float other = (float)(2f - ratio);
                float[] left = channel[c].spectra;
                float[] right = channel[c + 1].spectra;
                for (int band = baseBandCount; band < totalBandCount; band++)
                {
                    float value = left[band];
                    left[band] = (float)(ratio * value);
                    right[band] = (float)(other * value);
                }
            }
        }

        private void ApplyMsStereo()
        {
            const float ratio = 0.70710677f;
            for (int c = 0; c < channels - 1; c++)
            {
                if (channel[c].type != 1)
                    continue;
                float[] left = channel[c].spectra;
                float[] right = channel[c + 1].spectra;
                for (int band = 0; band < baseBandCount; band++)
                {
                    float l = left[band];
                    float r = right[band];
                    left[band] = (float)((float)(l + r) * ratio);
                    right[band] = (float)((float)(l - r) * ratio);
                }
            }
        }

        // HCAIMDCT_Transform (0x1a6820): DCT-IV butterflies and twiddles, then windowed overlap-add with the previous
        // subframe. The lib's NEON schedule produces the same values as this order of operations.
        private static void ImdctTransform(Channel ch, float[] wave)
        {
            float[] t1 = ch.spectra;
            float[] t2 = ch.imdctTemp;
            int count1 = 1;
            int count2 = 64;
            for (int i = 0; i < 7; i++)
            {
                int s = 0;
                int d1 = 0;
                int d2 = count2;
                for (int j = 0; j < count1; j++)
                {
                    for (int k = 0; k < count2; k++)
                    {
                        float a = t1[s++];
                        float b = t1[s++];
                        t2[d1++] = (float)(a + b);
                        t2[d2++] = (float)(a - b);
                    }
                    d1 += count2;
                    d2 += count2;
                }
                float[] swap = t1;
                t1 = t2;
                t2 = swap;
                count1 <<= 1;
                count2 >>= 1;
            }
            count1 = 64;
            count2 = 1;
            for (int i = 0; i < 7; i++)
            {
                int table = i * 64;
                int d1 = 0;
                int d2 = count2 * 2 - 1;
                int s1 = 0;
                int s2 = count2;
                for (int j = 0; j < count1; j++)
                {
                    for (int k = 0; k < count2; k++)
                    {
                        float a = t1[s1++];
                        float b = t1[s2++];
                        float sin = ImdctSin[table];
                        float cos = ImdctCos[table];
                        table++;
                        t2[d1++] = (float)((float)(a * sin) - (float)(b * cos));
                        t2[d2--] = (float)((float)(a * cos) + (float)(b * sin));
                    }
                    s1 += count2;
                    s2 += count2;
                    d1 += count2;
                    d2 += count2 * 3;
                }
                float[] swap = t1;
                t1 = t2;
                t2 = swap;
                count1 >>= 1;
                count2 <<= 1;
            }
            float[] dct = t1;
            float[] prev = ch.imdctPrevious;
            for (int i = 0; i < 64; i++)
            {
                wave[i] = (float)((float)(ImdctWindow[i] * dct[i + 64]) + prev[i]);
                wave[i + 64] = (float)((float)(ImdctWindow[i + 64] * dct[127 - i]) - prev[i + 64]);
            }
            for (int i = 0; i < 64; i++)
            {
                prev[i] = (float)(ImdctWindow[127 - i] * dct[63 - i]);
                prev[i + 64] = (float)(ImdctWindow[63 - i] * dct[i]);
            }
            if (!ReferenceEquals(dct, ch.spectra))
                Array.Copy(dct, ch.spectra, 128);
        }

        private static float[] Floats(uint[] bits)
        {
            float[] values = new float[bits.Length];
            for (int i = 0; i < bits.Length; i++)
                values[i] = BitConverter.ToSingle(BitConverter.GetBytes(bits[i]), 0);
            return values;
        }

        // word_204464: CRC-16 (poly 0x8005) lookup.
        private static readonly ushort[] CrcTable =
        {
            0x0000, 0x8005, 0x800F, 0x000A, 0x801B, 0x001E, 0x0014, 0x8011, 0x8033, 0x0036, 0x003C, 0x8039, 0x0028, 0x802D, 0x8027, 0x0022,
            0x8063, 0x0066, 0x006C, 0x8069, 0x0078, 0x807D, 0x8077, 0x0072, 0x0050, 0x8055, 0x805F, 0x005A, 0x804B, 0x004E, 0x0044, 0x8041,
            0x80C3, 0x00C6, 0x00CC, 0x80C9, 0x00D8, 0x80DD, 0x80D7, 0x00D2, 0x00F0, 0x80F5, 0x80FF, 0x00FA, 0x80EB, 0x00EE, 0x00E4, 0x80E1,
            0x00A0, 0x80A5, 0x80AF, 0x00AA, 0x80BB, 0x00BE, 0x00B4, 0x80B1, 0x8093, 0x0096, 0x009C, 0x8099, 0x0088, 0x808D, 0x8087, 0x0082,
            0x8183, 0x0186, 0x018C, 0x8189, 0x0198, 0x819D, 0x8197, 0x0192, 0x01B0, 0x81B5, 0x81BF, 0x01BA, 0x81AB, 0x01AE, 0x01A4, 0x81A1,
            0x01E0, 0x81E5, 0x81EF, 0x01EA, 0x81FB, 0x01FE, 0x01F4, 0x81F1, 0x81D3, 0x01D6, 0x01DC, 0x81D9, 0x01C8, 0x81CD, 0x81C7, 0x01C2,
            0x0140, 0x8145, 0x814F, 0x014A, 0x815B, 0x015E, 0x0154, 0x8151, 0x8173, 0x0176, 0x017C, 0x8179, 0x0168, 0x816D, 0x8167, 0x0162,
            0x8123, 0x0126, 0x012C, 0x8129, 0x0138, 0x813D, 0x8137, 0x0132, 0x0110, 0x8115, 0x811F, 0x011A, 0x810B, 0x010E, 0x0104, 0x8101,
            0x8303, 0x0306, 0x030C, 0x8309, 0x0318, 0x831D, 0x8317, 0x0312, 0x0330, 0x8335, 0x833F, 0x033A, 0x832B, 0x032E, 0x0324, 0x8321,
            0x0360, 0x8365, 0x836F, 0x036A, 0x837B, 0x037E, 0x0374, 0x8371, 0x8353, 0x0356, 0x035C, 0x8359, 0x0348, 0x834D, 0x8347, 0x0342,
            0x03C0, 0x83C5, 0x83CF, 0x03CA, 0x83DB, 0x03DE, 0x03D4, 0x83D1, 0x83F3, 0x03F6, 0x03FC, 0x83F9, 0x03E8, 0x83ED, 0x83E7, 0x03E2,
            0x83A3, 0x03A6, 0x03AC, 0x83A9, 0x03B8, 0x83BD, 0x83B7, 0x03B2, 0x0390, 0x8395, 0x839F, 0x039A, 0x838B, 0x038E, 0x0384, 0x8381,
            0x0280, 0x8285, 0x828F, 0x028A, 0x829B, 0x029E, 0x0294, 0x8291, 0x82B3, 0x02B6, 0x02BC, 0x82B9, 0x02A8, 0x82AD, 0x82A7, 0x02A2,
            0x82E3, 0x02E6, 0x02EC, 0x82E9, 0x02F8, 0x82FD, 0x82F7, 0x02F2, 0x02D0, 0x82D5, 0x82DF, 0x02DA, 0x82CB, 0x02CE, 0x02C4, 0x82C1,
            0x8243, 0x0246, 0x024C, 0x8249, 0x0258, 0x825D, 0x8257, 0x0252, 0x0270, 0x8275, 0x827F, 0x027A, 0x826B, 0x026E, 0x0264, 0x8261,
            0x0220, 0x8225, 0x822F, 0x022A, 0x823B, 0x023E, 0x0234, 0x8231, 0x8213, 0x0216, 0x021C, 0x8219, 0x0208, 0x820D, 0x8207, 0x0202,
        };
        // dword_202D2C: (1 << n) - 1.
        private static readonly int[] BitMasks =
        {
            0x0000, 0x0001, 0x0003, 0x0007, 0x000F, 0x001F, 0x003F, 0x007F,
            0x00FF, 0x01FF, 0x03FF, 0x07FF, 0x0FFF, 0x1FFF, 0x3FFF, 0x7FFF,
        };
        // byte_202CE8: curve position -> resolution.
        private static readonly byte[] InvertTable =
        {
            14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 12, 12, 12, 12, 12, 12, 11, 11, 11, 11,
            11, 11, 10, 10, 10, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 8, 8, 8, 8, 8, 8, 7,
            6, 6, 5, 4, 4, 4, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1,
        };
        // byte_202C30: resolution -> max code bits.
        private static readonly byte[] MaxBitTable =
        {
            0, 2, 3, 3, 4, 4, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12,
        };
        // byte_202F6C: prefix code lengths (resolution 0..7).
        private static readonly byte[] ReadBitTable =
        {
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            1, 1, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            2, 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0,
            2, 2, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0,
            3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4,
            3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4,
            3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
            3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
        };
        // flt_202D6C: prefix code values (resolution 0..7), float bits.
        private static readonly uint[] ReadValTableBits =
        {
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x3F800000, 0xBF800000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x3F800000, 0x3F800000, 0xBF800000, 0xBF800000, 0x40000000, 0xC0000000,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x3F800000, 0xBF800000, 0x40000000, 0xC0000000, 0x40400000, 0xC0400000,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x3F800000, 0x3F800000, 0xBF800000, 0xBF800000, 0x40000000, 0x40000000,
            0xC0000000, 0xC0000000, 0x40400000, 0x40400000, 0xC0400000, 0xC0400000, 0x40800000, 0xC0800000,
            0x00000000, 0x00000000, 0x3F800000, 0x3F800000, 0xBF800000, 0xBF800000, 0x40000000, 0x40000000,
            0xC0000000, 0xC0000000, 0x40400000, 0xC0400000, 0x40800000, 0xC0800000, 0x40A00000, 0xC0A00000,
            0x00000000, 0x00000000, 0x3F800000, 0x3F800000, 0xBF800000, 0xBF800000, 0x40000000, 0xC0000000,
            0x40400000, 0xC0400000, 0x40800000, 0xC0800000, 0x40A00000, 0xC0A00000, 0x40C00000, 0xC0C00000,
            0x00000000, 0x00000000, 0x3F800000, 0xBF800000, 0x40000000, 0xC0000000, 0x40400000, 0xC0400000,
            0x40800000, 0xC0800000, 0x40A00000, 0xC0A00000, 0x40C00000, 0xC0C00000, 0x40E00000, 0xC0E00000,
        };
        // flt_20326C: scalefactor -> scale, float bits.
        private static readonly uint[] ScalingTableBits =
        {
            0x342A8D26, 0x34633F89, 0x3497657D, 0x34C9B9BE, 0x35066491, 0x353311C4, 0x356E9910, 0x359EF532,
            0x35D3CCF1, 0x360D1ADF, 0x363C034A, 0x367A83B3, 0x36A6E595, 0x36DE60F5, 0x371426FF, 0x3745672A,
            0x37838359, 0x37AF3B79, 0x37E97C38, 0x381B8D3A, 0x384F4319, 0x388A14D5, 0x38B7FBF0, 0x38F5257D,
            0x3923520F, 0x39599D16, 0x3990FA4D, 0x39C12C4D, 0x3A00B1ED, 0x3A2B7A3A, 0x3A647B6D, 0x3A9837F0,
            0x3ACAD226, 0x3B071F62, 0x3B340AAF, 0x3B6FE4BA, 0x3B9FD228, 0x3BD4F35B, 0x3C0DDF04, 0x3C3D08A4,
            0x3C7BDFED, 0x3CA7CD94, 0x3CDF9613, 0x3D14F4F0, 0x3D467991, 0x3D843A29, 0x3DB02F0E, 0x3DEAC0C7,
            0x3E1C6573, 0x3E506334, 0x3E8AD4C6, 0x3EB8FBAF, 0x3EF67A41, 0x3F243516, 0x3F5ACB94, 0x3F91C3D3,
            0x3FC238D2, 0x400164D2, 0x402C6897, 0x4065B907, 0x40990B88, 0x40CBEC15, 0x4107DB35, 0x413504F3,
        };
        // flt_20322C: resolution -> 1 / range (index 0 is 0), float bits.
        private static readonly uint[] RangeTableBits =
        {
            0x00000000, 0x3F2AAAAB, 0x3ECCCCCD, 0x3E924925, 0x3E638E39, 0x3E3A2E8C, 0x3E1D89D9, 0x3E088889,
            0x3D842108, 0x3D020821, 0x3C810204, 0x3C008081, 0x3B804020, 0x3B002008, 0x3A801002, 0x3A000801,
        };
        // flt_202FEC: scalefactor difference -> ratio, float bits.
        private static readonly uint[] ScaleConversionTableBits =
        {
            0x00000000, 0x32A0B051, 0x32D61B5E, 0x330EA43A, 0x333E0F68, 0x337D3E0C, 0x33A8B6D5, 0x33E0CCDF,
            0x3415C3FF, 0x34478D75, 0x3484F1F6, 0x34B123F6, 0x34EC0719, 0x351D3EDA, 0x355184DF, 0x358B95C2,
            0x35B9FCD2, 0x35F7D0DF, 0x36251958, 0x365BFBB8, 0x36928E72, 0x36C346CD, 0x370218AF, 0x372D583F,
            0x3766F85B, 0x3799E046, 0x37CD078C, 0x3808980F, 0x38360094, 0x38728177, 0x38A18FAF, 0x38D744FD,
            0x390F6A81, 0x393F179A, 0x397E9E11, 0x39A9A15B, 0x39E2055B, 0x3A16942D, 0x3A48A2D8, 0x3A85AAC3,
            0x3AB21A32, 0x3AED4F30, 0x3B1E196E, 0x3B52A81E, 0x3B8C57CA, 0x3BBAFF5B, 0x3BF9295A, 0x3C25FED7,
            0x3C5D2D82, 0x3C935A2B, 0x3CC4563F, 0x3D02CD87, 0x3D2E4934, 0x3D68396A, 0x3D9AB62B, 0x3DCE248C,
            0x3E0955EE, 0x3E36FD92, 0x3E73D290, 0x3EA27043, 0x3ED87039, 0x3F1031DC, 0x3F40213B, 0x3F800000,
            0x3FAA8D26, 0x3FE33F89, 0x4017657D, 0x4049B9BE, 0x40866491, 0x40B311C4, 0x40EE9910, 0x411EF532,
            0x4153CCF1, 0x418D1ADF, 0x41BC034A, 0x41FA83B3, 0x4226E595, 0x425E60F5, 0x429426FF, 0x42C5672A,
            0x43038359, 0x432F3B79, 0x43697C38, 0x439B8D3A, 0x43CF4319, 0x440A14D5, 0x4437FBF0, 0x4475257D,
            0x44A3520F, 0x44D99D16, 0x4510FA4D, 0x45412C4D, 0x4580B1ED, 0x45AB7A3A, 0x45E47B6D, 0x461837F0,
            0x464AD226, 0x46871F62, 0x46B40AAF, 0x46EFE4BA, 0x471FD228, 0x4754F35B, 0x478DDF04, 0x47BD08A4,
            0x47FBDFED, 0x4827CD94, 0x485F9613, 0x4894F4F0, 0x48C67991, 0x49043A29, 0x49302F0E, 0x496AC0C7,
            0x499C6573, 0x49D06334, 0x4A0AD4C6, 0x4A38FBAF, 0x4A767A41, 0x4AA43516, 0x4ADACB94, 0x4B11C3D3,
            0x4B4238D2, 0x4B8164D2, 0x4BAC6897, 0x4BE5B907, 0x4C190B88, 0x4C4BEC15, 0x00000000, 0x00000000,
        };
        // dword_2031EC: intensity -> ratio, float bits.
        private static readonly uint[] IntensityRatioTableBits =
        {
            0x40000000, 0x3FEDB6DB, 0x3FDB6DB7, 0x3FC92492, 0x3FB6DB6E, 0x3FA49249, 0x3F924925, 0x3F800000,
            0x3F5B6DB7, 0x3F36DB6E, 0x3F124925, 0x3EDB6DB7, 0x3E924925, 0x3E124925, 0x00000000, 0x00000000,
        };
        // unk_203430: IMDCT window, float bits.
        private static readonly uint[] ImdctWindowBits =
        {
            0x3A3504F0, 0x3B0183B8, 0x3B70C538, 0x3BBB9268, 0x3C04A809, 0x3C308200, 0x3C61284C, 0x3C8B3F17,
            0x3CA83992, 0x3CC77FBD, 0x3CE91110, 0x3D0677CD, 0x3D198FC4, 0x3D2DD35C, 0x3D434643, 0x3D59ECC1,
            0x3D71CBA8, 0x3D85741E, 0x3D92A413, 0x3DA078B4, 0x3DAEF522, 0x3DBE1C9E, 0x3DCDF27B, 0x3DDE7A1D,
            0x3DEFB6ED, 0x3E00D62B, 0x3E0A2EDA, 0x3E13E72A, 0x3E1E00B1, 0x3E287CF2, 0x3E335D55, 0x3E3EA321,
            0x3E4A4F75, 0x3E56633F, 0x3E62DF37, 0x3E6FC3D1, 0x3E7D1138, 0x3E8563A2, 0x3E8C72B7, 0x3E93B561,
            0x3E9B2AEF, 0x3EA2D26F, 0x3EAAAAAB, 0x3EB2B222, 0x3EBAE706, 0x3EC34737, 0x3ECBD03D, 0x3ED47F46,
            0x3EDD5128, 0x3EE6425C, 0x3EEF4EFF, 0x3EF872D7, 0x3F00D4A9, 0x3F0576CA, 0x3F0A1D3B, 0x3F0EC548,
            0x3F136C25, 0x3F180EF2, 0x3F1CAAC2, 0x3F213CA2, 0x3F25C1A5, 0x3F2A36E7, 0x3F2E9998, 0x3F32E705,
            0xBF371C9E, 0xBF3B37FE, 0xBF3F36F2, 0xBF431780, 0xBF46D7E6, 0xBF4A76A4, 0xBF4DF27C, 0xBF514A6F,
            0xBF547DC5, 0xBF578C03, 0xBF5A74EE, 0xBF5D3887, 0xBF5FD707, 0xBF6250DA, 0xBF64A699, 0xBF66D908,
            0xBF68E90E, 0xBF6AD7B1, 0xBF6CA611, 0xBF6E5562, 0xBF6FE6E7, 0xBF715BEF, 0xBF72B5D1, 0xBF73F5E6,
            0xBF751D89, 0xBF762E13, 0xBF7728D7, 0xBF780F20, 0xBF78E234, 0xBF79A34C, 0xBF7A5397, 0xBF7AF439,
            0xBF7B8648, 0xBF7C0ACE, 0xBF7C82C8, 0xBF7CEF26, 0xBF7D50CB, 0xBF7DA88E, 0xBF7DF737, 0xBF7E3D86,
            0xBF7E7C2A, 0xBF7EB3CC, 0xBF7EE507, 0xBF7F106C, 0xBF7F3683, 0xBF7F57CA, 0xBF7F74B6, 0xBF7F8DB6,
            0xBF7FA32E, 0xBF7FB57B, 0xBF7FC4F6, 0xBF7FD1ED, 0xBF7FDCAD, 0xBF7FE579, 0xBF7FEC90, 0xBF7FF22E,
            0xBF7FF688, 0xBF7FF9D0, 0xBF7FFC32, 0xBF7FFDDA, 0xBF7FFEED, 0xBF7FFF8F, 0xBF7FFFDF, 0xBF7FFFFC,
        };
        // IMDCT twiddles per stage (7 x 64), float bits; the constants of HCAIMDCT_Transform (0x1a6820).
        private static readonly uint[] ImdctSinBits =
        {
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75, 0x3DA73D75,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31, 0x3F7B14BE, 0x3F54DB31,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403, 0x3F7EC46D, 0x3F74FA0B, 0x3F61C598, 0x3F45E403,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FB10F, 0x3F7D3AAC, 0x3F7853F8, 0x3F710908, 0x3F676BD8, 0x3F5B941A, 0x3F4D9F02, 0x3F3DAEF9,
            0x3F7FEC43, 0x3F7F4E6D, 0x3F7E1324, 0x3F7C3B28, 0x3F79C79D, 0x3F76BA07, 0x3F731447, 0x3F6ED89E,
            0x3F6A09A7, 0x3F64AA59, 0x3F5EBE05, 0x3F584853, 0x3F514D3D, 0x3F49D112, 0x3F41D870, 0x3F396842,
            0x3F7FEC43, 0x3F7F4E6D, 0x3F7E1324, 0x3F7C3B28, 0x3F79C79D, 0x3F76BA07, 0x3F731447, 0x3F6ED89E,
            0x3F6A09A7, 0x3F64AA59, 0x3F5EBE05, 0x3F584853, 0x3F514D3D, 0x3F49D112, 0x3F41D870, 0x3F396842,
            0x3F7FEC43, 0x3F7F4E6D, 0x3F7E1324, 0x3F7C3B28, 0x3F79C79D, 0x3F76BA07, 0x3F731447, 0x3F6ED89E,
            0x3F6A09A7, 0x3F64AA59, 0x3F5EBE05, 0x3F584853, 0x3F514D3D, 0x3F49D112, 0x3F41D870, 0x3F396842,
            0x3F7FEC43, 0x3F7F4E6D, 0x3F7E1324, 0x3F7C3B28, 0x3F79C79D, 0x3F76BA07, 0x3F731447, 0x3F6ED89E,
            0x3F6A09A7, 0x3F64AA59, 0x3F5EBE05, 0x3F584853, 0x3F514D3D, 0x3F49D112, 0x3F41D870, 0x3F396842,
            0x3F7FFB11, 0x3F7FD397, 0x3F7F84AB, 0x3F7F0E58, 0x3F7E70B0, 0x3F7DABCC, 0x3F7CBFC9, 0x3F7BACCD,
            0x3F7A7302, 0x3F791298, 0x3F778BC5, 0x3F75DEC6, 0x3F740BDD, 0x3F721352, 0x3F6FF573, 0x3F6DB293,
            0x3F6B4B0C, 0x3F68BF3C, 0x3F660F88, 0x3F633C5A, 0x3F604621, 0x3F5D2D53, 0x3F59F26A, 0x3F5695E5,
            0x3F531849, 0x3F4F7A1F, 0x3F4BBBF8, 0x3F47DE65, 0x3F43E200, 0x3F3FC767, 0x3F3B8F3B, 0x3F373A23,
            0x3F7FFB11, 0x3F7FD397, 0x3F7F84AB, 0x3F7F0E58, 0x3F7E70B0, 0x3F7DABCC, 0x3F7CBFC9, 0x3F7BACCD,
            0x3F7A7302, 0x3F791298, 0x3F778BC5, 0x3F75DEC6, 0x3F740BDD, 0x3F721352, 0x3F6FF573, 0x3F6DB293,
            0x3F6B4B0C, 0x3F68BF3C, 0x3F660F88, 0x3F633C5A, 0x3F604621, 0x3F5D2D53, 0x3F59F26A, 0x3F5695E5,
            0x3F531849, 0x3F4F7A1F, 0x3F4BBBF8, 0x3F47DE65, 0x3F43E200, 0x3F3FC767, 0x3F3B8F3B, 0x3F373A23,
            0x3F7FFEC4, 0x3F7FF4E6, 0x3F7FE129, 0x3F7FC38F, 0x3F7F9C18, 0x3F7F6AC7, 0x3F7F2F9D, 0x3F7EEA9D,
            0x3F7E9BC9, 0x3F7E4323, 0x3F7DE0B1, 0x3F7D7474, 0x3F7CFE73, 0x3F7C7EB0, 0x3F7BF531, 0x3F7B61FC,
            0x3F7AC516, 0x3F7A1E84, 0x3F796E4E, 0x3F78B47B, 0x3F77F110, 0x3F772417, 0x3F764D97, 0x3F756D97,
            0x3F748422, 0x3F73913F, 0x3F7294F8, 0x3F718F57, 0x3F708066, 0x3F6F6830, 0x3F6E46BE, 0x3F6D1C1D,
            0x3F6BE858, 0x3F6AAB7B, 0x3F696591, 0x3F6816A8, 0x3F66BECC, 0x3F655E0B, 0x3F63F473, 0x3F628210,
            0x3F6106F2, 0x3F5F8327, 0x3F5DF6BE, 0x3F5C61C7, 0x3F5AC450, 0x3F591E6A, 0x3F577026, 0x3F55B993,
            0x3F53FAC3, 0x3F5233C6, 0x3F5064AF, 0x3F4E8D90, 0x3F4CAE79, 0x3F4AC77F, 0x3F48D8B3, 0x3F46E22A,
            0x3F44E3F5, 0x3F42DE29, 0x3F40D0DA, 0x3F3EBC1B, 0x3F3CA003, 0x3F3A7CA4, 0x3F385216, 0x3F36206C,
        };
        // IMDCT twiddles per stage (7 x 64), float bits; the constants of HCAIMDCT_Transform (0x1a6820).
        private static readonly uint[] ImdctCosBits =
        {
            0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4,
            0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4,
            0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4,
            0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4,
            0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4,
            0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4,
            0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4,
            0x3D0A8BD4, 0xBD0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4, 0x3D0A8BD4, 0x3D0A8BD4, 0xBD0A8BD4,
            0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA,
            0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA,
            0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA,
            0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA,
            0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA,
            0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA,
            0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA,
            0x3E47C5C2, 0x3F0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0xBE47C5C2, 0xBF0E39DA, 0x3E47C5C2, 0x3F0E39DA,
            0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799, 0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799,
            0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799, 0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799,
            0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799, 0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799,
            0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799, 0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799,
            0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799, 0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799,
            0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799, 0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799,
            0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799, 0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799,
            0x3DC8BD36, 0x3E94A031, 0x3EF15AEA, 0x3F226799, 0xBDC8BD36, 0xBE94A031, 0xBEF15AEA, 0xBF226799,
            0xBD48FB30, 0xBE164083, 0xBE78CFCC, 0xBEAC7CD4, 0xBEDAE880, 0xBF039C3D, 0xBF187FC0, 0xBF2BEB4A,
            0x3D48FB30, 0x3E164083, 0x3E78CFCC, 0x3EAC7CD4, 0x3EDAE880, 0x3F039C3D, 0x3F187FC0, 0x3F2BEB4A,
            0x3D48FB30, 0x3E164083, 0x3E78CFCC, 0x3EAC7CD4, 0x3EDAE880, 0x3F039C3D, 0x3F187FC0, 0x3F2BEB4A,
            0xBD48FB30, 0xBE164083, 0xBE78CFCC, 0xBEAC7CD4, 0xBEDAE880, 0xBF039C3D, 0xBF187FC0, 0xBF2BEB4A,
            0x3D48FB30, 0x3E164083, 0x3E78CFCC, 0x3EAC7CD4, 0x3EDAE880, 0x3F039C3D, 0x3F187FC0, 0x3F2BEB4A,
            0xBD48FB30, 0xBE164083, 0xBE78CFCC, 0xBEAC7CD4, 0xBEDAE880, 0xBF039C3D, 0xBF187FC0, 0xBF2BEB4A,
            0xBD48FB30, 0xBE164083, 0xBE78CFCC, 0xBEAC7CD4, 0xBEDAE880, 0xBF039C3D, 0xBF187FC0, 0xBF2BEB4A,
            0x3D48FB30, 0x3E164083, 0x3E78CFCC, 0x3EAC7CD4, 0x3EDAE880, 0x3F039C3D, 0x3F187FC0, 0x3F2BEB4A,
            0xBCC90AB0, 0xBD96A905, 0xBDFAB273, 0xBE2F10A2, 0xBE605C13, 0xBE888E93, 0xBEA09AE5, 0xBEB8442A,
            0xBECF7BCA, 0xBEE63375, 0xBEFC5D27, 0xBF08F59B, 0xBF13682A, 0xBF1D7FD1, 0xBF273656, 0xBF3085BB,
            0x3CC90AB0, 0x3D96A905, 0x3DFAB273, 0x3E2F10A2, 0x3E605C13, 0x3E888E93, 0x3EA09AE5, 0x3EB8442A,
            0x3ECF7BCA, 0x3EE63375, 0x3EFC5D27, 0x3F08F59B, 0x3F13682A, 0x3F1D7FD1, 0x3F273656, 0x3F3085BB,
            0x3CC90AB0, 0x3D96A905, 0x3DFAB273, 0x3E2F10A2, 0x3E605C13, 0x3E888E93, 0x3EA09AE5, 0x3EB8442A,
            0x3ECF7BCA, 0x3EE63375, 0x3EFC5D27, 0x3F08F59B, 0x3F13682A, 0x3F1D7FD1, 0x3F273656, 0x3F3085BB,
            0xBCC90AB0, 0xBD96A905, 0xBDFAB273, 0xBE2F10A2, 0xBE605C13, 0xBE888E93, 0xBEA09AE5, 0xBEB8442A,
            0xBECF7BCA, 0xBEE63375, 0xBEFC5D27, 0xBF08F59B, 0xBF13682A, 0xBF1D7FD1, 0xBF273656, 0xBF3085BB,
            0xBC490E90, 0xBD16C32C, 0xBD7B2B74, 0xBDAFB680, 0xBDE1BC2E, 0xBE09CF86, 0xBE22ABB6, 0xBE3B6ECF,
            0xBE541501, 0xBE6C9A7F, 0xBE827DC0, 0xBE8E9A22, 0xBE9AA086, 0xBEA68F12, 0xBEB263EF, 0xBEBE1D4A,
            0xBEC9B953, 0xBED53641, 0xBEE0924F, 0xBEEBCBBB, 0xBEF6E0CB, 0xBF00E7E4, 0xBF064B82, 0xBF0B9A6B,
            0xBF10D3CD, 0xBF15F6D9, 0xBF1B02C6, 0xBF1FF6CB, 0xBF24D225, 0xBF299415, 0xBF2E3BDE, 0xBF32C8C9,
            0x3C490E90, 0x3D16C32C, 0x3D7B2B74, 0x3DAFB680, 0x3DE1BC2E, 0x3E09CF86, 0x3E22ABB6, 0x3E3B6ECF,
            0x3E541501, 0x3E6C9A7F, 0x3E827DC0, 0x3E8E9A22, 0x3E9AA086, 0x3EA68F12, 0x3EB263EF, 0x3EBE1D4A,
            0x3EC9B953, 0x3ED53641, 0x3EE0924F, 0x3EEBCBBB, 0x3EF6E0CB, 0x3F00E7E4, 0x3F064B82, 0x3F0B9A6B,
            0x3F10D3CD, 0x3F15F6D9, 0x3F1B02C6, 0x3F1FF6CB, 0x3F24D225, 0x3F299415, 0x3F2E3BDE, 0x3F32C8C9,
            0xBBC90F88, 0xBC96C9B6, 0xBCFB49BA, 0xBD2FE007, 0xBD621469, 0xBD8A200A, 0xBDA3308C, 0xBDBC3AC3,
            0xBDD53DB9, 0xBDEE3876, 0xBE039502, 0xBE1008B7, 0xBE1C76DE, 0xBE28DEFC, 0xBE354098, 0xBE419B37,
            0xBE4DEE60, 0xBE5A3997, 0xBE667C66, 0xBE72B651, 0xBE7EE6E1, 0xBE8586CE, 0xBE8B9507, 0xBE919DDD,
            0xBE97A117, 0xBE9D9E78, 0xBEA395C5, 0xBEA986C4, 0xBEAF713A, 0xBEB554EC, 0xBEBB31A0, 0xBEC1071E,
            0xBEC6D529, 0xBECC9B8B, 0xBED25A09, 0xBED8106B, 0xBEDDBE79, 0xBEE363FA, 0xBEE900B7, 0xBEEE9479,
            0xBEF41F07, 0xBEF9A02D, 0xBEFF17B2, 0xBF0242B1, 0xBF04F484, 0xBF07A136, 0xBF0A48AD, 0xBF0CEAD0,
            0xBF0F8784, 0xBF121EB0, 0xBF14B039, 0xBF173C07, 0xBF19C200, 0xBF1C420C, 0xBF1EBC12, 0xBF212FF9,
            0xBF239DA9, 0xBF26050A, 0xBF286605, 0xBF2AC082, 0xBF2D1469, 0xBF2F61A5, 0xBF31A81D, 0xBF33E7BC,
        };
        private static readonly float[] ReadValTable = Floats(ReadValTableBits);
        private static readonly float[] ScalingTable = Floats(ScalingTableBits);
        private static readonly float[] RangeTable = Floats(RangeTableBits);
        private static readonly float[] ScaleConversionTable = Floats(ScaleConversionTableBits);
        private static readonly float[] IntensityRatioTable = Floats(IntensityRatioTableBits);
        private static readonly float[] ImdctWindow = Floats(ImdctWindowBits);
        private static readonly float[] ImdctSin = Floats(ImdctSinBits);
        private static readonly float[] ImdctCos = Floats(ImdctCosBits);
    }
}
