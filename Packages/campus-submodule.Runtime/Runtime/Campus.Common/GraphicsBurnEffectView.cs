namespace Campus.Common
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RawImage))]
    public class GraphicsBurnEffectView : QuaUIBehaviour
    {
        private static class PropertyId
        {
            public static readonly int BurnProgress;
        }

        [SerializeField]
        private Image _targetImage;
        [SerializeField]
        private float _progress;
        private Material _material;
        private Material Material
        {
            get
            {
                return null;
            }
        }

        public float Progress
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public GraphicsBurnEffectView()
        {
        }
    }
}
