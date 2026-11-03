namespace VL.Timeline.Legacy
{
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Timeline.Legacy;

    public class VLAnimationClipPlayerTimelineClipPlayable : PlayableBehaviour
    {
        private MotionDefine _motion;
        private bool _applyFootIK;
        private AnimationLayerMixerPlayable _mixerPlayable;
        private AnimationClipPlayable[] _clipPlayables;
        public static ScriptPlayable<VLAnimationClipPlayerTimelineClipPlayable> Create(PlayableGraph graph, Playable timelinePlayable, MotionDefine motion, bool applyFootIK)
        {
            return default(ScriptPlayable<VLAnimationClipPlayerTimelineClipPlayable>);
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public VLAnimationClipPlayerTimelineClipPlayable()
        {
        }
    }
}
