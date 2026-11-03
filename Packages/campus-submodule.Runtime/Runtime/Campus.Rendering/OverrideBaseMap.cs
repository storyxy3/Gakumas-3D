namespace Campus.Rendering
{
    using global::UnityEngine;

    [RequireComponent(typeof(Renderer))]
    public class OverrideBaseMap : MonoBehaviour
    {
        private static readonly int BaseMap;
        public int materialIndex;
        private Renderer _renderer;
        private MaterialPropertyBlock _propertyBlock;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void SetTexture(Texture texture)
        {
        }

        public OverrideBaseMap()
        {
        }
    }
}
