namespace CanvasRT
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Live.Monitor;
    using global::CanvasRT;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Camera))]
    [ExecuteAlways]
    public class CanvasRenderTexture : MonoBehaviour
    {
        public const int StartLayerIndex = 20;
        public const int MaxSize = 4;
        [SerializeField]
        private bool _supportResize;
        [SerializeField]
        private int _baseHeight = 768;
        [SerializeField]
        private float _aspectRatio = 1f;
        [SerializeField]
        [HideInInspector]
        private Canvas _canvas;
        [SerializeField]
        [HideInInspector]
        private CanvasScaler _canvasScaler;
        [SerializeField]
        [HideInInspector]
        private UniversalAdditionalCameraData _additionalCameraData;
        [SerializeField]
        private bool _useVolume;
        [SerializeField]
        private bool _orthographic = true;
        [SerializeField]
        private float _fieldOfView = 45f;
        [SerializeField]
        private float _planeDistance = 50f;
        [SerializeField]
        private AdditionalCanvasShaderChannels _additionalShaderChannels;
        [SerializeField]
        private bool _isHDRFormat = true;
        [NonSerialized]
        private RenderTexture _target;
        private Camera _camera;
        private int _instanceIndex = -1;
        private List<Monitor3DImage> _threeDImages;
        internal static CanvasRenderTexture[] Instances = new CanvasRenderTexture[4];
        public int BasHeight
        {
            get
            {
                return _baseHeight;
            }

            set
            {
                _baseHeight = value;
            }
        }

        public float AspectRatio
        {
            get
            {
                return _aspectRatio;
            }

            set
            {
                _aspectRatio = value;
            }
        }

        public bool IsHDRFormat
        {
            get
            {
                return _isHDRFormat;
            }

            set
            {
                _isHDRFormat = value;
            }
        }

        public RenderTexture TargetTexture
        {
            get
            {
                return _target;
            }
        }

        public Canvas Canvas
        {
            get
            {
                return _canvas;
            }
        }

        internal IList<Monitor3DImage> threeDImages
        {
            get
            {
                return _threeDImages;
            }
        }

        public int InstanceIndex
        {
            get
            {
                return _instanceIndex;
            }
        }

        public static string GetTextureName(int index)
        {
            return string.Format("CanvasRenderTexture{0}", index);
        }

        public void UpdateTexture()
        {
            if (_target != null)
            {
                _camera.targetTexture = null;
                UnityEngine.Object.DestroyImmediate(_target);
                _target = null;
            }
            int height = _baseHeight;
            if (_supportResize) height = Mathf.Min(height, Screen.height);
            int width = Mathf.RoundToInt(_aspectRatio * height);
            var format = _isHDRFormat ? global::VL.VLUtility.GetHDRFormat() : global::UnityEngine.Experimental.Rendering.GraphicsFormat.R8G8B8A8_SRGB;
            var descriptor = new RenderTextureDescriptor(width, height, format, 0) { sRGB = true };
            _target = new RenderTexture(descriptor);
            _target.name = gameObject.name;
            _camera.targetTexture = _target;
            Shader.SetGlobalTexture(GetTextureName(_instanceIndex), _target);
        }

        private bool RegisterInstance()
        {
            if (_instanceIndex >= 0)
            {
                if (Instances[_instanceIndex] == null)
                {
                    Instances[_instanceIndex] = this;
                    return true;
                }
                Debug.LogError("Registerが複数回呼ばれています", gameObject);
                return false;
            }
            for (int i = 0; i < Instances.Length; i++)
            {
                if (Instances[i] == null)
                {
                    Instances[i] = this;
                    _instanceIndex = i;
                    return true;
                }
            }
            return false;
        }

        private bool UnRegisterInstance()
        {
            if (_instanceIndex >= 0 && Instances[_instanceIndex] == this)
            {
                Instances[_instanceIndex] = null;
                _instanceIndex = -1;
                return true;
            }
            return false;
        }

        public void UpdateParameter()
        {
            if (_camera == null || _canvas == null) return;
            _camera.orthographic = _orthographic;
            if (_orthographic)
            {
                _camera.orthographicSize = 5f;
                _camera.nearClipPlane = -20f;
                _camera.farClipPlane = 20f;
                _canvas.planeDistance = 0f;
            }
            else
            {
                _camera.fieldOfView = _fieldOfView;
                _camera.nearClipPlane = 0.01f;
                _camera.farClipPlane = 100f;
                _canvas.planeDistance = _planeDistance;
            }
            _canvas.additionalShaderChannels = _additionalShaderChannels;
        }

        private void OnEnable()
        {
            _camera = GetComponent<Camera>();
            _camera.clearFlags = CameraClearFlags.Depth;
            _camera.backgroundColor = new Color(0f, 0f, 0f, 0f);
            _camera.hideFlags = HideFlags.None;
            _camera.cullingMask = 0;
            _camera.allowHDR = false;
            _camera.allowMSAA = false;
            _camera.useOcclusionCulling = false;
            _camera.renderingPath = RenderingPath.Forward;
            _camera.depth = -100f;
            if (_camera.TryGetComponent(out _additionalCameraData))
            {
                _additionalCameraData.renderShadows = false;
                _additionalCameraData.fastRendering = true;
                _additionalCameraData.requiresDepthOption = CameraOverrideOption.Off;
                _additionalCameraData.requiresColorOption = CameraOverrideOption.Off;
                _additionalCameraData.renderPostProcessing = false;
                _additionalCameraData.antialiasing = AntialiasingMode.None;
                _additionalCameraData.volumeFrameworkUpdateMode = (VolumeFrameworkUpdateMode)10;
            }
            if (!RegisterInstance()) return;
            UpdateTexture();
            _camera.cullingMask = 1 << (_instanceIndex + 20);
            if (_additionalCameraData != null)
                _additionalCameraData.volumeLayerMask = _useVolume ? _camera.cullingMask : 0;
        }

        private void Start()
        {
            if (_canvas == null)
            {
                var canvasObject = new GameObject("Canvas");
                canvasObject.transform.SetParent(transform, false);
                _canvas = canvasObject.AddComponent<Canvas>();
                _canvasScaler = canvasObject.AddComponent<CanvasScaler>();
            }
            _canvas.hideFlags = HideFlags.NotEditable;
            _canvas.renderMode = RenderMode.ScreenSpaceCamera;
            _canvas.planeDistance = 0f;
            _canvas.worldCamera = _camera;
            UpdateParameter();
        }

        private void OnDisable()
        {
            if (_target != null)
            {
                _camera.targetTexture = null;
                UnityEngine.Object.DestroyImmediate(_target);
                _target = null;
            }
            UnRegisterInstance();
        }

        internal void RegisterMonitor3D(Monitor3DImage monitor3DImage)
        {
            if (_threeDImages == null) _threeDImages = new List<Monitor3DImage>();
            _threeDImages.Add(monitor3DImage);
        }

        internal void UnregisterMonitor3D(Monitor3DImage monitor3DImage)
        {
            _threeDImages?.Remove(monitor3DImage);
        }

        public static Texture GetCanvasRenderTexture(int index)
        {
            if (index < 0 || index >= Instances.Length) return null;
            return Instances[index] != null ? Instances[index]._target : null;
        }

        public CanvasRenderTexture()
        {
        }
    }
}
