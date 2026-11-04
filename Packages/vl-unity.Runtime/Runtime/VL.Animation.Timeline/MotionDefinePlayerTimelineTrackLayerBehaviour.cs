namespace VL.Animation.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;
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
            if (_player != null)
            {
                _prevUpdateMode = _player.GetTimeUpdateMode();
                _player.SetTimeUpdateMode(DirectorUpdateMode.Manual);
            }
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            if (_controllers != null)
            {
                foreach (ILayerAnimationController controller in _controllers)
                    controller?.Dispose();
            }
            if (_player != null)
                _player.SetTimeUpdateMode(_prevUpdateMode);
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            if (_player != null && _player.TryGetComponent(out IVLActorController actor))
                actor.ResetTime();
            if (_controllers != null)
            {
                foreach (ILayerAnimationController controller in _controllers)
                    controller?.Play();
            }
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (_controllers != null)
            {
                foreach (ILayerAnimationController controller in _controllers)
                    controller?.Pause();
            }
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (_controllers == null)
                return;
            if (playable.GetInputCount() != _controllers.Length)
            {
                Debug.LogError("TrackPlayableのサイズが一致していません");
                return;
            }
            for (int i = 0; i < _controllers.Length; ++i)
            {
                ILayerAnimationController controller = _controllers[i];
                if (controller == null || !controller.IsValid())
                    continue;
                Playable track = playable.GetInput(i);
                if (controller.GetPlayableCount() != track.GetInputCount())
                {
                    Debug.LogError("ClipPlayableのサイズが一致していません");
                    continue;
                }
                for (int j = 0; j < track.GetInputCount(); ++j)
                {
                    Playable clip = track.GetInput(j);
                    if (!clip.IsValid())
                        continue;
                    float weight = track.GetInputWeight(j);
                    controller.SetPlayableWeight(j, weight);
                    PlayState state = controller.GetPlayablePlayState(j);
                    if (weight < 0.001f && state == PlayState.Playing)
                        controller.PausePlayable(j);
                    else if (weight > 0.001f && state == PlayState.Paused)
                        controller.PlayPlayable(j);
                    controller.SetPlayableTime(j, clip.GetTime());
                }
            }
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            bool reset = false;
            if (_actorMotionResetMarkers != null)
            {
                foreach (VLActorMotionResetMarker marker in _actorMotionResetMarkers)
                {
                    if (marker.time <= playable.GetTime() && marker.time >= playable.GetTime() - info.deltaTime)
                    {
                        reset = true;
                        break;
                    }
                }
            }
            if ((info.seekOccurred || reset) && _player.TryGetComponent(out IVLActorController resetActor))
                resetActor.ResetModel();
            if (_actorAnimationManagePropetyDataApplyMarkers != null)
            {
                foreach (VLActorAnimationManagePropertyDataApplyMarker marker in _actorAnimationManagePropetyDataApplyMarkers)
                {
                    if (marker.time <= playable.GetTime() && marker.time >= playable.GetTime() - info.deltaTime)
                    {
                        if (_player.TryGetComponent(out IVLActorController actor))
                            actor.ApplyActorAnimationManagePropertyData(marker.propertyData);
                        break;
                    }
                }
            }
            _player.Evaluate(info.deltaTime);
            _ = info.seekOccurred;
        }

        public static ScriptPlayable<MotionDefinePlayerTimelineTrackLayerBehaviour> Create(PlayableGraph graph, int inputCount, MotionDefinePlayer player, ILayerAnimationController[] controllers, VLActorMotionResetMarker[] motionResetMarkers, VLActorAnimationManagePropertyDataApplyMarker[] actorAnimationManagePropertyDataApplyMarkers)
        {
            return ScriptPlayable<MotionDefinePlayerTimelineTrackLayerBehaviour>.Create(graph, new MotionDefinePlayerTimelineTrackLayerBehaviour
            {
                _player = player,
                _controllers = controllers,
                _actorMotionResetMarkers = motionResetMarkers,
                _actorAnimationManagePropetyDataApplyMarkers = actorAnimationManagePropertyDataApplyMarkers
            }, inputCount);
        }

        public MotionDefinePlayerTimelineTrackLayerBehaviour()
        {
        }
    }
}
