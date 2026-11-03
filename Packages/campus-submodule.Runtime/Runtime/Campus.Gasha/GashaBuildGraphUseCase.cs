namespace Campus.Gasha
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    public class GashaBuildGraphUseCase
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Predicate<GashaId> _003C_003E9__0_0;
            public static Func<(RarityType rarityType, GashaSequenceBase sequenceBase), int, ((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i)> _003C_003E9__1_0;
            public static Func<((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i), bool> _003C_003E9__1_1;
            public static Func<((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i), int> _003C_003E9__1_2;
            public static Predicate<(RarityType rarityType, GashaSequenceBase sequenceBase)> _003C_003E9__1_3;
            public _003C_003Ec()
            {
            }

            internal bool _003CBuildGraph_003Eb__0_0(GashaId x)
            {
                return default(bool);
            }

            internal ((RarityType, GashaSequenceBase), int) _003CBuildCardGraph_003Eb__1_0((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i)
            {
                return default(((RarityType, GashaSequenceBase), int));
            }

            internal bool _003CBuildCardGraph_003Eb__1_1(((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i) x)
            {
                return default(bool);
            }

            internal int _003CBuildCardGraph_003Eb__1_2(((RarityType rarityType, GashaSequenceBase sequenceBase) x, int i) x)
            {
                return default(int);
            }

            internal bool _003CBuildCardGraph_003Eb__1_3((RarityType rarityType, GashaSequenceBase sequenceBase) x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public int i;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal bool _003CBuildCardGraph_003Eb__4(int x)
            {
                return default(bool);
            }
        }

        public static GashaTransitionGraph BuildGraph(GashaId[] gashaIds, Dictionary<GashaId, GashaSequenceBase> sequenceDict)
        {
            return null;
        }

        public static GashaTransitionGraph BuildCardGraph(List<(RarityType rarityType, GashaSequenceBase sequenceBase)> cardInfos)
        {
            return null;
        }
    }
}
