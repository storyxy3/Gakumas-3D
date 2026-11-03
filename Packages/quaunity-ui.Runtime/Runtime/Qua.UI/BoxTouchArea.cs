namespace Qua.UI
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    public sealed class BoxTouchArea : Graphic
    {
        public sealed override Material materialForRendering
        {
            get
            {
                return null;
            }
        }

        protected sealed override void OnEnable()
        {
        }

        protected sealed override void UpdateMaterial()
        {
        }

        protected sealed override void UpdateGeometry()
        {
        }

        public BoxTouchArea()
        {
        }
    }
}
