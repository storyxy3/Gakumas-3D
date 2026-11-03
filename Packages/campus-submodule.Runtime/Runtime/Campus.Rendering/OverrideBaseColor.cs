namespace Campus.Rendering
{
    using global::UnityEngine;

    [RequireComponent(typeof(Renderer))]
    [ExecuteAlways]
    public class OverrideBaseColor : MonoBehaviour
    {
        private static readonly int BaseColor;
        public int materialIndex;
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

        public OverrideBaseColor()
        {
        }
    }
}
