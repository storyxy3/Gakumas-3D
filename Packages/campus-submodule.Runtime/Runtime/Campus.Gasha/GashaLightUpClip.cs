namespace Campus.Gasha
{
    using global::System;
    using global::Campus.Gasha.Sequences;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class GashaLightUpClip : PlayableAsset
    {
        [NonSerialized]
        public GashaListSequence listSequence;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return default(Playable);
        }

        public GashaLightUpClip()
        {
        }
    }
}
