namespace Campus.Live.Equipment
{
    using global::System;
    using global::Campus.Live.Equipment;

    public struct EquipmentIdList : IDisposable
    {
        private static int[] _ids;
        private static int _length;
        public int Length
        {
            get
            {
                return _length;
            }
        }

        public int GetId(int index)
        {
            return _ids[index];
        }

        public EquipmentIdList(EquipmentId id)
        {
            this = default;
            if (_ids == null) _ids = new int[448];
            if (_length > 0) throw new Exception("EquipmentIdListは同時に2つ以上確保は出来ません");
            if (id.id0 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id0 >> bit) & 1L) != 0) _ids[_length++] = bit + 0;
            }
            if (id.id1 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id1 >> bit) & 1L) != 0) _ids[_length++] = bit + 64;
            }
            if (id.id2 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id2 >> bit) & 1L) != 0) _ids[_length++] = bit + 128;
            }
            if (id.id3 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id3 >> bit) & 1L) != 0) _ids[_length++] = bit + 192;
            }
            if (id.id4 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id4 >> bit) & 1L) != 0) _ids[_length++] = bit + 256;
            }
            if (id.id5 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id5 >> bit) & 1L) != 0) _ids[_length++] = bit + 320;
            }
            if (id.id6 != 0)
            {
                for (int bit = 0; bit < 64; bit++)
                    if (((id.id6 >> bit) & 1L) != 0) _ids[_length++] = bit + 384;
            }
        }

        public void Dispose()
        {
            _length = 0;
        }
    }
}
