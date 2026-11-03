namespace VL.Animation.Timeline
{
    using global::UnityEngine.Playables;
    using global::VL.Animation;
    using global::VL.Animation.Timeline;
    using global::VL.Timeline;

    public class MotionDefinePlayerTimelineTrackLayerBehaviour : PlayableBehaviour
    {
        private MotionDefinePlayer _player;
        private ILayerAnimationController[] _controllers;
        private DirectorUpdateMode _prevUpdateMode;
        private VLActorMotionResetMarker[] _actorMotionResetMarkers;
        private VLActorAnimationManagePropertyDataApplyMarker[] _actorAnimationManagePropetyDataApplyMarkers;
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

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public static ScriptPlayable<MotionDefinePlayerTimelineTrackLayerBehaviour> Create(PlayableGraph graph, int inputCount, MotionDefinePlayer player, ILayerAnimationController[] controllers, VLActorMotionResetMarker[] motionResetMarkers, VLActorAnimationManagePropertyDataApplyMarker[] actorAnimationManagePropertyDataApplyMarkers)
        {
            return default(ScriptPlayable<MotionDefinePlayerTimelineTrackLayerBehaviour>);
        }

        public MotionDefinePlayerTimelineTrackLayerBehaviour()
        {
        }
    }
}
