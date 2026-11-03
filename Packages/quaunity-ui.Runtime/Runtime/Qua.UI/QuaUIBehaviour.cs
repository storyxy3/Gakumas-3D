namespace Qua.UI
{
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class QuaUIBehaviour : UIBehaviour
    {
        private RectTransform _rectTransformCache;
        public RectTransform RectTransform
        {
            get
            {
                return null;
            }
        }

        protected override void OnDestroy()
        {
        }

        public QuaUIBehaviour()
        {
        }
    }
}
