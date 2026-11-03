namespace Campus.Gasha
{
    using global::System.Collections.Generic;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    public class GashaBuildGraphUseCase
    {
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
