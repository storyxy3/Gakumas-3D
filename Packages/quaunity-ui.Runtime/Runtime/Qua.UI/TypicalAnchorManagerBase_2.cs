namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public abstract class TypicalAnchorManagerBase<T, TAnchorType> : Singleton<T>, ITypicalAnchorManager<TAnchorType> where T : TypicalAnchorManagerBase<T, TAnchorType>
    {
        private HashSet<TypicalAnchorBase> _typicalAnchors;
        protected override void OnInitialize()
        {
        }

        public abstract RectTransform GetAnchorTarget(TAnchorType anchorType);
        public void AddTypicalAnchor(TypicalAnchorBase typicalAnchor)
        {
        }

        public void RemoveTypicalAnchor(TypicalAnchorBase typicalAnchor)
        {
        }

        protected void ApplyTypicalAnchors()
        {
        }

        protected TypicalAnchorManagerBase()
        {
        }
    }
}
