namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    public class TypicalAnchor : TypicalAnchorBase<TypicalAnchor.AnchorType, TypicalAnchor.AnchorInfo>
    {
        public enum AnchorType
        {
            UIContentArea,
            FullScreen
        }

        [Serializable]
        public class AnchorInfo : AnchorInfoBase
        {
            public AnchorInfo()
            {
            }
        }

        protected override ITypicalAnchorManager<AnchorType> Manager
        {
            get
            {
                return null;
            }
        }

        protected override bool ExistsManager
        {
            get
            {
                return default(bool);
            }
        }

        public TypicalAnchor()
        {
        }
    }
}
