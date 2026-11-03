namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class LiveEquipmentPsylliumClip : LiveEquipmentClipBase<LiveEquipmentPsylliumAssetBehaviour>
    {
        public int animationIndex;
        [ColorUsage(false, true)]
        public Color mainColor;
        public bool useDefaultPsylliumColor;
        public override ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        protected override void OnUpdateParameter(LiveEquipmentPsylliumAssetBehaviour behaviour, PlayableGraph graph)
        {
        }

        public LiveEquipmentPsylliumClip()
        {
        }
    }
}
