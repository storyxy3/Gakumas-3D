namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.UI;
    using global::VL;
    using global::VL.Rendering;

    [ExecuteAlways]
    [RequireComponent(typeof(RawImage))]
    public class VLSRPTargetImage : MonoBehaviour
    {
        public enum TextureType
        {
            Target,
            Captured
        }

        [SerializeField]
        [Tooltip("CAPTUREDの場合は別スクリプトからCaptureRequestを呼んでください")]
        private TextureType _textureType;
        public bool applyAspectRatio;
        private RawImage _image;
        private RectTransform _rectTransform;
        public TextureType textureType
        {
            get
            {
                return default(TextureType);
            }

            set
            {
            }
        }

        private RawImage image
        {
            get
            {
                return null;
            }
        }

        private RectTransform rectTransform
        {
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnTargetTextureChange(IVLCameraController cameraController)
        {
        }

        private void UpdateTexture(Texture t)
        {
        }

        public VLSRPTargetImage()
        {
        }
    }
}
