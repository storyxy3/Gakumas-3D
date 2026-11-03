namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;

    [Serializable]
    public struct EquipmentId
    {
        [CompilerGenerated]
        private sealed class _003Cget_flags_003Ed__18 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private int _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public EquipmentId _003C_003E4__this;
            public EquipmentId _003C_003E3___003C_003E4__this;
            private int _003Ci_003E5__2;
            int System.Collections.Generic.IEnumerator<System.Int32>.Current
            {
                [DebuggerHidden]
                get
                {
                    return default(int);
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003Cget_flags_003Ed__18(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }

            [DebuggerHidden]
            IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        public const int BitSize = 64;
        public const int MaxFlag = 448;
        public const int BlockSize = 16;
        public const int GroupSize = 28;
        public const long Zero = 0L;
        public const long One = 1L;
        public long id0;
        public long id1;
        public long id2;
        public long id3;
        public long id4;
        public long id5;
        public long id6;
        public IEnumerable<int> flags
        {
            [IteratorStateMachine(typeof(_003Cget_flags_003Ed__18))]
            get
            {
                return null;
            }
        }

        public bool Exist(int id)
        {
            return default(bool);
        }

        public char GetGroupName(int id)
        {
            return default(char);
        }

        public int GetGroupNumber(int id)
        {
            return default(int);
        }

        public EquipmentIdList GetIdList()
        {
            return default(EquipmentIdList);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
