namespace CanvasRT
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class CanvasRenderTextureImage : MonoBehaviour
    {
        internal static readonly int _BaseMap;
        [Range(0f, 3f)]
        public int index;
        private Texture _target;
        private RawImage _rawImage;
        private Renderer _renderer;
        private Material _material;
        private Material _prevMaterial;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Update()
        {
        }

        public CanvasRenderTextureImage()
        {
        }
    }
}
