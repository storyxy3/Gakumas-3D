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
        }

        public sealed override void UpdateBehaviour()
        {
        }

        public sealed override void UpdateBehaviour(LiveEquipmentController controller)
        {
        }

        public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return default(Playable);
        }

        private T GetTemplate(PlayableGraph graph)
        {
            return null;
        }

        protected LiveEquipmentClipBase()
        {
        }
    }
}
