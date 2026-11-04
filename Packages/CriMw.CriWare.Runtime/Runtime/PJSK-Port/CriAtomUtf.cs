using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CriWare
{
    // Views of the original ACF/ACB bytes. The owner keeps the backing array unchanged
    // for the lifetime of these tables and any blob slices returned from them.
    internal static class CriAtomUtf
    {
        internal sealed class Column
        {
            public string Name { get; internal set; }
            public byte Type { get; internal set; }
            public byte Flags { get; internal set; }
            internal int Offset;
            internal object Constant;
            internal bool PerRow;
        }

        internal sealed class Table
        {
            private static readonly UTF8Encoding Utf8 = new UTF8Encoding(false, true);
            private static readonly int[] Widths = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 4, 8 };
            private readonly ArraySegment<byte> bytes;
            private readonly Dictionary<string, Column> byName = new Dictionary<string, Column>(StringComparer.Ordinal);
            private readonly int rowsOffset, rowWidth, stringsOffset, dataOffset;

            public string Name { get; }
            public ushort Version { get; }
            public int RowCount { get; }
            public IReadOnlyList<Column> Columns { get; }

            public static Table Parse(ArraySegment<byte> bytes) => new Table(bytes);

            private Table(ArraySegment<byte> source)
            {
                bytes = source;
                Require(source.Array != null && source.Count >= 32, "Truncated UTF header.");
                Require(U32(0) == 0x40555446, "Expected CRI @UTF table.");
                long length = (long)U32(4) + 8;
                Require(length >= 32 && length <= source.Count, "UTF size exceeds its container.");
                bytes = new ArraySegment<byte>(source.Array, source.Offset, (int)length);
                Version = U16(8);
                Require(Version <= 1, "Unsupported UTF version.");
                rowsOffset = U16(10) + 8;
                long strings = (long)U32(12) + 8, data = (long)U32(16) + 8;
                Require(rowsOffset >= 32 && rowsOffset <= strings && strings < data && data <= length,
                    "Invalid UTF section boundaries.");
                stringsOffset = (int)strings;
                dataOffset = (int)data;
                rowWidth = U16(26);
                uint count = U32(28);
                Require(count <= int.MaxValue && (long)count * rowWidth <= stringsOffset - rowsOffset,
                    "UTF rows exceed the row section.");
                RowCount = (int)count;
                Name = String(U32(20));

                var columns = new Column[U16(24)];
                int schema = 32, row = 0;
                for (int i = 0; i < columns.Length; i++)
                {
                    Require(schema <= rowsOffset - 5, "Truncated UTF column schema.");
                    byte flags = Byte(schema), type = (byte)(flags & 15);
                    Require((flags & 0x90) == 0x10 && type < Widths.Length, "Unsupported UTF column type or flags.");
                    var column = new Column { Name = String(U32(schema + 1)), Type = type, Flags = flags };
                    schema += 5;
                    int width = Widths[type];
                    // A schema constant takes precedence if both storage bits are present.
                    if ((flags & 0x20) != 0)
                    {
                        Require(schema <= rowsOffset - width, "Truncated UTF column constant.");
                        column.Constant = Value(type, schema);
                        schema += width;
                    }
                    else if ((flags & 0x40) != 0)
                    {
                        column.PerRow = true;
                        column.Offset = row;
                        row += width;
                    }
                    else column.Constant = Zero(type);
                    Require(!byName.ContainsKey(column.Name), "Duplicate UTF column name.");
                    byName.Add(column.Name, column);
                    columns[i] = column;
                }
                // Some original HCA v3 ACB Header tables put reserved fields after
                // rowWidth. There is one row; its fields still end before strings.
                Require(RowCount == 0 || (RowCount == 1 ? row <= stringsOffset - rowsOffset : row <= rowWidth),
                    "UTF columns exceed the row boundary.");
                Columns = Array.AsReadOnly(columns);
            }

            public Row GetRow(int index)
            {
                if (index < 0 || index >= RowCount) throw new ArgumentOutOfRangeException(nameof(index));
                return new Row(this, index);
            }

            internal bool TryGetValue(int row, string name, out object value)
            {
                if (!byName.TryGetValue(name, out var column)) { value = null; return false; }
                value = column.PerRow ? Value(column.Type, rowsOffset + row * rowWidth + column.Offset) : column.Constant;
                return true;
            }

            private object Value(byte type, int offset)
            {
                switch (type)
                {
                    case 0: return Byte(offset);
                    case 1: return unchecked((sbyte)Byte(offset));
                    case 2: return U16(offset);
                    case 3: return unchecked((short)U16(offset));
                    case 4: return U32(offset);
                    case 5: return unchecked((int)U32(offset));
                    case 6: return U64(offset);
                    case 7: return unchecked((long)U64(offset));
                    case 8: return BitConverter.Int32BitsToSingle(unchecked((int)U32(offset)));
                    case 9: return BitConverter.Int64BitsToDouble(unchecked((long)U64(offset)));
                    case 10: return String(U32(offset));
                    case 11:
                        uint start = U32(offset), length = U32(offset + 4);
                        Require((long)start + length <= bytes.Count - dataOffset, "UTF blob exceeds the data section.");
                        return new ArraySegment<byte>(bytes.Array, bytes.Offset + dataOffset + (int)start, (int)length);
                    default: throw new InvalidDataException("Unsupported UTF value type.");
                }
            }

            private object Zero(byte type)
            {
                switch (type)
                {
                    case 0: return (byte)0;
                    case 1: return (sbyte)0;
                    case 2: return (ushort)0;
                    case 3: return (short)0;
                    case 4: return 0u;
                    case 5: return 0;
                    case 6: return 0ul;
                    case 7: return 0L;
                    case 8: return 0f;
                    case 9: return 0d;
                    case 10: return string.Empty;
                    case 11: return new ArraySegment<byte>(bytes.Array, bytes.Offset + dataOffset, 0);
                    default: throw new InvalidDataException("Unsupported UTF zero type.");
                }
            }

            private string String(uint offset)
            {
                Require(offset < dataOffset - stringsOffset, "UTF string offset exceeds the string section.");
                int start = bytes.Offset + stringsOffset + (int)offset;
                int end = start, limit = bytes.Offset + dataOffset;
                while (end < limit && bytes.Array[end] != 0) end++;
                Require(end < limit, "Unterminated UTF string.");
                try { return Utf8.GetString(bytes.Array, start, end - start); }
                catch (DecoderFallbackException ex) { throw new InvalidDataException("Invalid UTF-8 string.", ex); }
            }

            private byte Byte(int offset) => bytes.Array[bytes.Offset + offset];
            private ushort U16(int offset) => (ushort)((Byte(offset) << 8) | Byte(offset + 1));
            private uint U32(int offset) => ((uint)U16(offset) << 16) | U16(offset + 2);
            private ulong U64(int offset) => ((ulong)U32(offset) << 32) | U32(offset + 4);
        }

        internal readonly struct Row
        {
            private readonly Table table;
            private readonly int index;
            internal Row(Table table, int index) { this.table = table; this.index = index; }

            public bool TryGetValue(string column, out object value) => table.TryGetValue(index, column, out value);
            public object this[string column] => TryGetValue(column, out var value) ? value :
                throw new KeyNotFoundException("UTF column not found: " + column);
            public T Get<T>(string column) => (T)this[column];
        }

        private static void Require(bool valid, string message)
        {
            if (!valid) throw new InvalidDataException(message);
        }
    }
}
