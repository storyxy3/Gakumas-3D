namespace VL.Timeline.Legacy
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL;

    public sealed class VLAnimationClipPlayerTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public MotionDefine motion;
        [SerializeField]
        public ExposedReference<MotionDefine> exposedMotion;
        public bool applyFootIK;
        public Vector3 positionOffsets;
        public Vector3 rotationOffsets;
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

        public VLAnimationClipPlayerTimelineAsset()
        {
        }
    }
}
