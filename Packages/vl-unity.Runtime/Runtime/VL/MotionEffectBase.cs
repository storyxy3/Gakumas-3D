namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public abstract class MotionEffectBase : ScriptableObject
    {
        public virtual string className
        {
            get
            {
                return GetType().Name;
            }
        }

        public virtual string trackName
        {
            get
            {
                return GetType().Name;
            }
        }

        public abstract Playable CreatePlayable(PlayableGraph graph, GameObject go, bool isSubTrack, bool isTimeline);
        protected MotionEffectBase()
        {
        }
    }
}
