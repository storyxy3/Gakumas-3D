namespace Campus.Titan
{
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine;

    public class CampusCanvasGroupAlphaClip : TweenerClipBase<float, FloatParameter>
    {
        [SerializeField]
        private bool _enableBlocksRaycasts;
        [SerializeField]
        private SetBlocksRaycastsType _blocksRaycastsType;
        public bool EnableBlocksRaycasts
        {
            get
            {
                return default(bool);
            }
        }

        public SetBlocksRaycastsType BlocksRaycastsType
        {
            get
            {
                return default(SetBlocksRaycastsType);
            }
        }

        public CampusCanvasGroupAlphaClip()
        {
        }
    }
}
