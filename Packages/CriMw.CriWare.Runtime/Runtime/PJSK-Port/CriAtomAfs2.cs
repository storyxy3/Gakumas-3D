using System;
using System.Collections.Generic;
using System.IO;

namespace CriWare
{
    // Each wave is a slice of the original memory AWB; IDs need not be contiguous.
    internal sealed class CriAtomAfs2
    {
        internal readonly struct Entry
        {
            public uint Id { get; }
            public ArraySegment<byte> Data { get; }
            internal Entry(uint id, ArraySegment<byte> data) { Id = id; Data = data; }
        }

        private readonly Dictionary<uint, ArraySegment<byte>> byId = new Dictionary<uint, ArraySegment<byte>>();
        public byte Version { get; }
        public ushort Subkey { get; }
        public ushort Alignment { get; }
        public IReadOnlyList<Entry> Entries { get; }
        public ArraySegment<byte> this[uint id] => byId[id];
        public bool TryGetValue(uint id, out ArraySegment<byte> data) => byId.TryGetValue(id, out data);
        public static CriAtomAfs2 Parse(ArraySegment<byte> bytes) => new CriAtomAfs2(bytes);

        private CriAtomAfs2(ArraySegment<byte> bytes)
        {
            Require(bytes.Array != null && bytes.Count >= 16, "Truncated AFS2 header.");
            ulong Read(int offset, int width)
            {
                ulong value = 0;
                for (int i = width - 1; i >= 0; i--) value = (value << 8) | bytes.Array[bytes.Offset + offset + i];
                return value;
            }
            Require(Read(0, 4) == 0x32534641, "Expected CRI AFS2 bank.");
            Version = (byte)Read(4, 1);
            int offsetWidth = (int)Read(5, 1), idWidth = (int)Read(6, 1);
            Require(Version == 1 || Version == 2, "Unsupported AFS2 version.");
            Require(offsetWidth == 1 || offsetWidth == 2 || offsetWidth == 4 || offsetWidth == 8,
                "Unsupported AFS2 offset width.");
            Require(idWidth == 1 || idWidth == 2 || idWidth == 4, "Unsupported AFS2 ID width.");
            ulong count = Read(8, 4);
            Alignment = (ushort)Read(12, 2);
            Subkey = (ushort)Read(14, 2);
            Require(Alignment != 0, "Invalid AFS2 alignment.");
            ulong tableEnd = 16 + count * (ulong)idWidth + (count + 1) * (ulong)offsetWidth;
            Require(tableEnd <= (ulong)bytes.Count, "AFS2 entry table exceeds the bank.");
            int offsets = 16 + (int)count * idWidth;
            var entries = new Entry[(int)count];
            ulong previous = Read(offsets, offsetWidth);
            Require(previous >= tableEnd && previous <= (ulong)bytes.Count, "Invalid AFS2 first offset.");
            for (int i = 0; i < entries.Length; i++)
            {
                uint id = (uint)Read(16 + i * idWidth, idWidth);
                ulong next = Read(offsets + (i + 1) * offsetWidth, offsetWidth);
                ulong start = previous + ((ulong)Alignment - previous % Alignment) % Alignment;
                Require(next >= start && next <= (ulong)bytes.Count, "AFS2 wave exceeds the bank or has reversed offsets.");
                var wave = new ArraySegment<byte>(bytes.Array, bytes.Offset + (int)start, (int)(next - start));
                Require(!byId.ContainsKey(id), "Duplicate AFS2 wave ID.");
                byId.Add(id, wave);
                entries[i] = new Entry(id, wave);
                previous = next;
            }
            Entries = Array.AsReadOnly(entries);
        }

        private static void Require(bool valid, string message)
        {
            if (!valid) throw new InvalidDataException(message);
        }
    }
}
