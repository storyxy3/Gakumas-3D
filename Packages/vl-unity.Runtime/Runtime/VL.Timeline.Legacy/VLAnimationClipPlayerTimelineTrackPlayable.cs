namespace VL.Timeline.Legacy
{
    using global::UnityEngine.Playables;
    using global::VL.Animation.Legacy;
    using global::VL.Timeline.Legacy;

    public class VLAnimationClipPlayerTimelineTrackPlayable : PlayableBehaviour
    {
        private VLAnimationClipPlayer _player;
        private ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable> _playerPlayable;
        public static ScriptPlayable<VLAnimationClipPlayerTimelineTrackPlayable> Create(PlayableGraph graph, VLAnimationClipPlayer player, int inputCount)
        {
            return default(ScriptPlayable<VLAnimationClipPlayerTimelineTrackPlayable>);
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public VLAnimationClipPlayerTimelineTrackPlayable()
        {
        }
    }
}
