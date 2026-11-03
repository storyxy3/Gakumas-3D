namespace Campus.Gasha
{
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    public class GashaSequenceBindModel
    {
        public List<(GashaId id, GashaSequenceBase sequence)> sequences;
        public static GashaSequenceBindModel BuildFromGashaIds(GashaId[] gashaIds, GashaSceneModel sceneModel, [Optional] string characterId)
        {
            return null;
        }

        public GashaSequenceBindModel()
        {
        }
    }
}
