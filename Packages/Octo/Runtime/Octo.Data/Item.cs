namespace Octo.Data
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo.Data;
    using global::Octo.Proto;
    using global::Octo.Util;
    using global::UnityEngine;

    internal class Item
    {
        [CompilerGenerated]
        private sealed class _003CGetFamily_003Ed__35 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private Item _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public Item _003C_003E4__this;
            private Item[] _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            Item System.Collections.Generic.IEnumerator<Octo.Data.Item>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
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
            public _003CGetFamily_003Ed__35(int _003C_003E1__state)
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
            IEnumerator<Item> System.Collections.Generic.IEnumerable<Octo.Data.Item>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        private static readonly string Tag;
        private static string[] EmptyTags;
        private static Item[] EmptyDependencies;
        public int id;
        public string name;
        public ObjectName objectName;
        public int size;
        public uint crc;
        public MD5Value md5;
        public int /* TODO(qa-recon): octdata Octo.Proto.Data.State (Int32) excluded. */ state;
        public int Size
        {
            get
            {
                return default(int);
            }
        }

        public virtual ItemType Type
        {
            get
            {
                return default(ItemType);
            }
        }

        public virtual string[] Tags
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual Item[] Dependencies
        {
            get
            {
                return null;
            }
        }

        public virtual Item[] FlatDependencies
        {
            get
            {
                return null;
            }
        }

        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public Hash128 Hash
        {
            get
            {
                return default(Hash128);
            }
        }

        public CachedAssetBundle CachedAssetBundle
        {
            get
            {
                return default(CachedAssetBundle);
            }
        }

        public Item(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames)
        {
        }

        public virtual void SetData(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames)
        {
        }

        public virtual void SetDependencies(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, Dictionary<int, Item> items)
        {
        }

        [IteratorStateMachine(typeof(_003CGetFamily_003Ed__35))]
        public IEnumerable<Item> GetFamily()
        {
            return null;
        }

        public void Write(object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, Dictionary<string, int> tagDictionary)
        {
        }

        public override string ToString()
        {
            return null;
        }
    }
}
