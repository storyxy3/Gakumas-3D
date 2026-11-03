namespace Campus.Rendering
{
    using global::UnityEngine;

    [RequireComponent(typeof(Renderer))]
    [ExecuteAlways]
    public class OverrideEmissionColor : MonoBehaviour
    {
        private static readonly int EmissionColor;
        public int materialIndex;
        [ColorUsage(false, true)]
        public Color color;
        private Renderer _renderer;
        private MaterialPropertyBlock _propertyBlock;
        public Color Color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public OverrideEmissionColor()
        {
        }
    }
}
