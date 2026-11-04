namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public abstract class LiveEquipmentClipBase<T> : LiveEquipmentClipBase where T : LiveEquipmentAssetBehaviour, new()
    {
        private ScriptPlayable<T> _scriptPlayable;
        protected virtual void OnUpdateParameter(T behaviour, PlayableGraph graph)
        {
        }

        protected void UpdateBaseParameter(T behaviour, PlayableGraph graph)
        {
            var fireParameter = Vector4.zero;
            if (_fireType == FireType.Normal || _fireType == FireType.Reverse) fireParameter = new Vector4(_delayInterval, _delayOffset, 0f, 0f);
            if (controller != null)
            {
                behaviour.InitialData = controller.InitialData;
                behaviour.AnimationData = controller.AnimationData;
            }
            else
            {
                behaviour.InitialData = default;
                behaviour.AnimationData = default;
            }
            behaviour.EquipmentValue = track.EquipmentValue;
            behaviour.TrackReverseFlag = track.ReverseFlags;
            behaviour.ClipIgnoreReverseFlag = IgnoreReverseFlags;
            behaviour.FireType = _fireType;
            behaviour.FireParameter = fireParameter;
            behaviour.UseBpm = _useBpm;
            behaviour.BpmInfo = BpmInfo;
            behaviour.Beat = _beat;
            behaviour.BeatOffset = _beatOffset;
            behaviour.LookAtTarget = _lookAtTarget.Resolve(graph.GetResolver());
            behaviour.MovingMode = _movingMode;
            behaviour.RotateAngle = rotateAngle;
            behaviour.RotateSpeed = rotateSpeed;
        }

        public sealed override void UpdateBehaviour()
        {
            if (!_scriptPlayable.IsValid()) return;
            var behaviour = _scriptPlayable.GetBehaviour();
            var graph = _scriptPlayable.GetGraph();
            UpdateBaseParameter(behaviour, graph);
            OnUpdateParameter(behaviour, graph);
        }

        public sealed override void UpdateBehaviour(LiveEquipmentController controller)
        {
            this.controller = controller;
            UpdateBehaviour();
        }

        public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            _scriptPlayable = ScriptPlayable<T>.Create(graph, GetTemplate(graph));
            return _scriptPlayable;
        }

        private T GetTemplate(PlayableGraph graph)
        {
            var behaviour = new T { IsMainTrack = !isSubTrack, Curves = curves };
            UpdateBaseParameter(behaviour, graph);
            OnUpdateParameter(behaviour, graph);
            return behaviour;
        }

        protected LiveEquipmentClipBase()
        {
        }
    }
}
