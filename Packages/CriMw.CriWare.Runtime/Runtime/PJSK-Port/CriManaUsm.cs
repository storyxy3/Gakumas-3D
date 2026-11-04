using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CriWare
{
    // Original 1AEBF4 / 1AEE08 chunk layout, 47A68 video metadata, and 43800
    // seek entries. Packet payloads remain views of the supplied original USM.
    internal sealed class CriManaUsm
    {
        internal readonly struct Packet
        {
            public readonly int FileOffset;
            public readonly uint RawTime, RawRate;
            public readonly ArraySegment<byte> Data;
            internal Packet(int offset, uint time, uint rate, ArraySegment<byte> data)
            { FileOffset = offset; RawTime = time; RawRate = rate; Data = data; }
        }

        internal readonly struct SeekEntry
        {
            public readonly long FileOffset;
            public readonly int FrameIndex, SkipFrames;
            internal SeekEntry(long offset, int frame, int skip)
            { FileOffset = offset; FrameIndex = frame; SkipFrames = skip; }
        }

        internal sealed class VideoInfo
        {
            public int Width { get; }
            public int Height { get; }
            public int MaterialWidth { get; }
            public int MaterialHeight { get; }
            public int DisplayWidth { get; }
            public int DisplayHeight { get; }
            public int FrameRateNumerator { get; }
            public int FrameRateDenominator { get; }
            public int TotalFrames { get; }
            public int Codec { get; }
            public int AlphaType { get; }
            public int DcPrecision { get; }
            public int ColorSpace { get; }

            internal VideoInfo(CriAtomUtf.Row row)
            {
                Width = Number(row, "width"); Height = Number(row, "height");
                MaterialWidth = Number(row, "mat_width"); MaterialHeight = Number(row, "mat_height");
                DisplayWidth = Number(row, "disp_width"); DisplayHeight = Number(row, "disp_height");
                if (MaterialWidth == 0) MaterialWidth = Width;
                if (MaterialHeight == 0) MaterialHeight = Height;
                if (DisplayWidth == 0) DisplayWidth = Width;
                if (DisplayHeight == 0) DisplayHeight = Height;
                FrameRateNumerator = Number(row, "framerate_n"); FrameRateDenominator = Number(row, "framerate_d");
                TotalFrames = Number(row, "total_frames"); Codec = Number(row, "mpeg_codec");
                AlphaType = Number(row, "alpha_type"); DcPrecision = Number(row, "mpeg_dcprec");
                ColorSpace = Number(row, "color_space");
                Supported(Codec == 1 && AlphaType == 0 && ColorSpace == 0, "Unsupported USM video codec, alpha or color space.");
                Require(Width > 0 && Height > 0 && MaterialWidth > 0 && MaterialHeight > 0 &&
                    DisplayWidth > 0 && DisplayHeight > 0 && FrameRateNumerator > 0 && FrameRateDenominator > 0 &&
                    TotalFrames > 0, "Invalid USM video dimensions or frame rate.");
            }
        }

        internal sealed class AudioInfo
        {
            public int Codec { get; }
            public int SamplingRate { get; }
            public int Channels { get; }
            public int TotalSamples { get; }
            internal AudioInfo(CriAtomUtf.Row row)
            {
                Codec = Number(row, "audio_codec"); SamplingRate = Number(row, "sampling_rate");
                Channels = Number(row, "num_channels"); TotalSamples = Number(row, "total_samples");
                Supported(Codec == 2 && Number(row, "ambisonics") == 0, "Unsupported USM audio codec or ambisonics.");
                Require(SamplingRate > 0 && Channels > 0 && TotalSamples > 0, "Invalid USM audio format.");
            }
        }

        private const uint Crid = 0x43524944, Sfv = 0x40534656, Sfa = 0x40534641;
        public VideoInfo Video { get; private set; }
        public AudioInfo Audio { get; private set; }
        public int MaxChunkSize { get; private set; }
        public IReadOnlyList<Packet> VideoPackets { get; private set; }
        public IReadOnlyList<Packet> AudioPackets { get; private set; }
        public IReadOnlyList<SeekEntry> SeekEntries { get; private set; }

        public static CriManaUsm Parse(byte[] original)
        {
            if (original == null) throw new ArgumentNullException(nameof(original));
            return new CriManaUsm(original);
        }

        private CriManaUsm(byte[] bytes)
        {
            var video = new List<Packet>(); var audio = new List<Packet>(); var seek = new List<SeekEntry>();
            var videoOffsets = new Dictionary<int, int>();
            CriAtomUtf.Table directory = null;
            bool videoEnded = false, audioEnded = false, hasSeek = false;
            int position = 0;
            while (position < bytes.Length)
            {
                Require(bytes.Length - position >= 32, "Truncated USM chunk header.");
                uint tag = U32(bytes, position), size = U32(bytes, position + 4);
                long end = position + 8L + size;
                int header = bytes[position + 9], padding = bytes[position + 10] << 8 | bytes[position + 11];
                Require(size >= 24 && end <= bytes.Length && header >= 24 && header <= size && padding <= size - header,
                    "USM chunk exceeds its container.");
                Supported(header == 24 && bytes[position + 8] == 0 && bytes[position + 12] == 0 &&
                    bytes[position + 13] == 0 && bytes[position + 14] == 0 && bytes[position + 15] <= 3 &&
                    U32(bytes, position + 24) == 0 && U32(bytes, position + 28) == 0,
                    "Unsupported USM chunk flags, channel or header extension.");
                int kind = bytes[position + 15];
                var data = new ArraySegment<byte>(bytes, position + 8 + header, checked((int)size - header - padding));
                if (position == 0) Require(tag == Crid && kind == 1, "Expected a CRID USM header.");
                Supported(tag == Crid || tag == Sfv || tag == Sfa, "Unsupported USM stream type.");
                if (kind == 0)
                {
                    var packet = new Packet(position, U32(bytes, position + 16), U32(bytes, position + 20), data);
                    Require(data.Count > 0, "Empty USM data packet.");
                    if (tag == Sfv)
                    {
                        Require(Video != null && !videoEnded, "USM video data is outside its stream.");
                        videoOffsets.Add(position, video.Count); video.Add(packet);
                    }
                    else
                    {
                        Require(tag == Sfa && Audio != null && !audioEnded, "USM audio data is outside its stream.");
                        audio.Add(packet);
                    }
                }
                else if (kind == 2)
                {
                    string marker = Encoding.ASCII.GetString(bytes, data.Offset, data.Count).TrimEnd('\0');
                    if (marker == "#CONTENTS END   ===============")
                    {
                        if (tag == Sfv) { Require(!videoEnded, "Duplicate USM video end."); videoEnded = true; }
                        else if (tag == Sfa) { Require(!audioEnded, "Duplicate USM audio end."); audioEnded = true; }
                        else throw new InvalidDataException("Unexpected CRID end marker.");
                    }
                    else Supported(marker == "#HEADER END     ===============" || marker == "#METADATA END   ===============",
                        "Unsupported USM stream marker.");
                }
                else
                {
                    var table = CriAtomUtf.Table.Parse(data);
                    if (tag == Crid)
                    {
                        Require(position == 0 && directory == null && kind == 1 && table.Name == "CRIUSF_DIR_STREAM",
                            "Invalid USM directory table.");
                        directory = table;
                    }
                    else if (tag == Sfv && kind == 1)
                    {
                        Require(Video == null && video.Count == 0 && table.Name == "VIDEO_HDRINFO" && table.RowCount == 1,
                            "Invalid USM video header.");
                        Video = new VideoInfo(table.GetRow(0));
                        MaxChunkSize = Math.Max(MaxChunkSize, Number(table.GetRow(0), "ixsize"));
                    }
                    else if (tag == Sfa && kind == 1)
                    {
                        Require(Audio == null && audio.Count == 0 && table.Name == "AUDIO_HDRINFO" && table.RowCount == 1,
                            "Invalid USM audio header.");
                        Audio = new AudioInfo(table.GetRow(0));
                        MaxChunkSize = Math.Max(MaxChunkSize, Number(table.GetRow(0), "ixsize"));
                    }
                    else if (tag == Sfv && kind == 3)
                    {
                        Require(!hasSeek && video.Count == 0 && table.Name == "VIDEO_SEEKINFO", "Invalid USM seek table.");
                        hasSeek = true;
                        for (int i = 0; i < table.RowCount; i++)
                        {
                            var row = table.GetRow(i);
                            Supported(Number(row, "resv") == 0, "Unsupported USM seek flags.");
                            seek.Add(new SeekEntry(Integer(row, "ofs_byte"), Number(row, "ofs_frmid"), Number(row, "num_skip")));
                        }
                    }
                    else throw new NotSupportedException("Unsupported USM metadata stream.");
                }
                position = checked((int)end);
            }
            Require(directory != null && Video != null && videoEnded && hasSeek && video.Count == Video.TotalFrames,
                "Incomplete USM video stream.");
            Require((Audio == null && audio.Count == 0 && !audioEnded) || (Audio != null && audio.Count > 0 && audioEnded),
                "Incomplete USM audio stream.");
            int videoStreams = 0, audioStreams = 0;
            for (int i = 0; i < directory.RowCount; i++)
            {
                var row = directory.GetRow(i);
                Supported(Number(row, "fmtver") == 0, "Unsupported USM format version.");
                long stream = Integer(row, "stmid"), channel = Integer(row, "chno");
                if (i == 0)
                    Require(stream == 0 && channel == ushort.MaxValue && Integer(row, "filesize") == bytes.Length,
                        "USM directory does not match its file.");
                else if (stream == Sfv && channel == 0) videoStreams++;
                else if (stream == Sfa && channel == 0) audioStreams++;
                else throw new NotSupportedException("Unsupported USM directory stream.");
            }
            Supported(videoStreams == 1 && audioStreams == (Audio == null ? 0 : 1), "Unsupported USM stream count.");
            Require(seek.Count > 0 && seek[0].FrameIndex == 0, "USM has no initial seek entry.");
            int previousFrame = -1;
            foreach (var entry in seek)
            {
                Require(entry.FileOffset >= 0 && entry.FileOffset <= int.MaxValue &&
                    videoOffsets.TryGetValue((int)entry.FileOffset, out int frame) && frame == entry.FrameIndex &&
                    entry.FrameIndex > previousFrame && entry.SkipFrames >= 0, "Invalid USM seek entry.");
                Supported(entry.SkipFrames == 0, "USM seek preroll is outside the original movie closure.");
                previousFrame = entry.FrameIndex;
            }
            VideoPackets = video.AsReadOnly(); AudioPackets = audio.AsReadOnly(); SeekEntries = seek.AsReadOnly();
        }

        // Copy only the encoded payloads in container order. RawTime/RawRate are
        // retained packet fields, not assumed to be display PTS or a time base.
        public byte[] CopyVideoStream() => Copy(VideoPackets);
        public byte[] CopyAudioStream() => Copy(AudioPackets);

        private static byte[] Copy(IReadOnlyList<Packet> packets)
        {
            int size = 0;
            foreach (var packet in packets) size = checked(size + packet.Data.Count);
            var result = new byte[size]; int offset = 0;
            foreach (var packet in packets)
            {
                Buffer.BlockCopy(packet.Data.Array, packet.Data.Offset, result, offset, packet.Data.Count);
                offset += packet.Data.Count;
            }
            return result;
        }

        private static long Integer(CriAtomUtf.Row row, string name)
        {
            if (!row.TryGetValue(name, out object value)) throw new InvalidDataException("Missing USM field: " + name);
            if (value is byte || value is sbyte || value is ushort || value is short || value is uint || value is int || value is long)
                return Convert.ToInt64(value);
            if (value is ulong number && number <= long.MaxValue) return (long)number;
            throw new InvalidDataException("Invalid USM integer field: " + name);
        }
        private static int Number(CriAtomUtf.Row row, string name)
        {
            long value = Integer(row, name);
            Require(value >= 0 && value <= int.MaxValue, "USM field is out of range: " + name);
            return (int)value;
        }
        private static uint U32(byte[] b, int p) => (uint)b[p] << 24 | (uint)b[p + 1] << 16 | (uint)b[p + 2] << 8 | b[p + 3];
        private static void Require(bool value, string message) { if (!value) throw new InvalidDataException(message); }
        private static void Supported(bool value, string message) { if (!value) throw new NotSupportedException(message); }
    }
}
