namespace VL.Animation
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;

    [Serializable]
    public class EffectData : IComparable<EffectData>
    {
        public MotionEffectBase effect;
        public double startTime;
        public double duration;
        public Playable CreatePlayable(PlayableGraph graph, GameObject go, bool isSubTrack, bool isTimeline = false)
        {
            return default(Playable);
        }

        public int CompareTo(EffectData other)
        {
            return default(int);
        }

        public EffectData()
        {
        }
    }
}
