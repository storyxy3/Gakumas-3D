namespace CanvasRT
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class CanvasRenderTextureImage : MonoBehaviour
    {
        internal static readonly int _BaseMap = Shader.PropertyToID("_BaseMap");
        [Range(0f, 3f)]
        public int index;
        private Texture _target;
        private RawImage _rawImage;
        private Renderer _renderer;
        private Material _material;
        private Material _prevMaterial;
        private void OnEnable()
        {
            _rawImage = GetComponent<RawImage>();
            _renderer = GetComponent<Renderer>();
        }

        private void OnDisable()
        {
            if (_renderer != null && _prevMaterial != null) _renderer.sharedMaterial = _prevMaterial;
            if (_material != null)
            {
                UnityEngine.Object.DestroyImmediate(_material);
                _material = null;
            }
            _prevMaterial = null;
            _rawImage = null;
            _renderer = null;
            _target = null;
        }

        private void Update()
        {
            if (_target == null) _target = CanvasRenderTexture.GetCanvasRenderTexture(index);
            if (_rawImage != null) _rawImage.texture = _target;
            else if (_renderer != null)
            {
                if (_prevMaterial == null)
                {
                    _prevMaterial = _renderer.sharedMaterial;
                    if (_prevMaterial != null)
                    {
                        _material = new Material(_prevMaterial);
                        _renderer.sharedMaterial = _material;
                    }
                }
                _material.SetTexture(_BaseMap, _target);
            }
        }

        public CanvasRenderTextureImage()
        {
        }
    }
}
