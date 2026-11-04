namespace VL.Animation.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL;
    using global::VL.Animation;

    public class MotionDefinePlayerTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public MotionDefine motion;
        [SerializeField]
        public ExposedReference<MotionDefine> exposedMotion;
        private int _clipIndex;
        private ILayerAnimationController _controller;
        public ClipCaps clipCaps
        {
            get
            {
                return motion == null ? ClipCaps.None : ClipCaps.ClipIn | ClipCaps.SpeedMultiplier | ClipCaps.Blending | (motion.isLoop ? ClipCaps.Looping : ClipCaps.None);
            }
        }

        public override double duration
        {
            get
            {
                return motion != null ? motion.animationLength : base.duration;
            }
        }

        public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return Playable.Create(graph);
        }

        public MotionDefinePlayerTimelineAsset()
        {
        }
    }
}
