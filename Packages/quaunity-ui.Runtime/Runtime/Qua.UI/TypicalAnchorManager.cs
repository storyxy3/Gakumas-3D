namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    [SingletonResourcePath("Prefabs/TypicalAnchorManager", true)]
    public class TypicalAnchorManager : TypicalAnchorManagerBase<TypicalAnchorManager, TypicalAnchor.AnchorType>
    {
        [SerializeField]
        private RectTransform _fullscreenRectTransform;
        [SerializeField]
        private RectTransform _uiContentAreaRectTransform;
        public RectTransform FullscreenRectTransform
        {
            get
            {
                return null;
            }
        }

        public RectTransform UIContentAreaRectTransform
        {
            get
            {
                return null;
            }
        }

        protected override void OnInitialize()
        {
        }

        public override RectTransform GetAnchorTarget(TypicalAnchor.AnchorType anchorType)
        {
            return null;
        }

        public TypicalAnchorManager()
        {
        }

        [CompilerGenerated]
        private void _003COnInitialize_003Eb__6_0(RectTransform _)
        {
        }
    }
}
