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
                return default(ClipCaps);
            }
        }

        public override double duration
        {
            get
            {
                return default(double);
            }
        }

        public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public MotionDefinePlayerTimelineAsset()
        {
        }
    }
}
