namespace Campus.Gasha
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::UnityEngine.SceneManagement;

    public class GashaSceneModel
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public string characterId;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal bool _003CGetSequence_003Eb__0(GashaSequenceBase x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private Dictionary<GashaId, List<GashaSequenceBase>> _003CSequences_003Ek__BackingField;
        [CompilerGenerated]
        private GashaGlobalEffect _003CGlobalEffect_003Ek__BackingField;
        private Dictionary<RarityType, GashaSequenceBase> _supportSequences;
        private Dictionary<(RarityType before, RarityType after), GashaSequenceBase> _supportReversalSequences;
        private Dictionary<RarityType, GashaSequenceBase> _idolSequences;
        private Dictionary<(RarityType before, RarityType after), GashaSequenceBase> _idolReversalSequences;
        public Dictionary<GashaId, List<GashaSequenceBase>> Sequences
        {
            [CompilerGenerated]
            get
            {
                return _003CSequences_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CSequences_003Ek__BackingField = value;
            }
        }

        public GashaGlobalEffect GlobalEffect
        {
            [CompilerGenerated]
            get
            {
                return _003CGlobalEffect_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CGlobalEffect_003Ek__BackingField = value;
            }
        }

        public GashaSequenceBase GetSequence(GashaId gashaId, [Optional] string characterId)
        {
            return null;
        }

        public GashaSequenceBase GetCardSequence(CardType cardType, RarityType rarityType)
        {
            return null;
        }

        public GashaSequenceBase GetCardSequenceReversal(CardType cardType, RarityType beforeRarity, RarityType afterRarity)
        {
            return null;
        }

        public static GashaSceneModel BuildModelV2(Scene scene)
        {
            return null;
        }

        public GashaSceneModel()
        {
        }
    }
}
