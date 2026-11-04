// TODO(qa-recon): Selected APK bodies still need reconstruction: .cctor, .ctor, GetCanvasRenderTexture, GetTextureName, OnDisable, OnEnable, RegisterInstance, RegisterMonitor3D, Start, UnRegisterInstance, UnregisterMonitor3D, UpdateParameter, UpdateTexture.
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
        private int _baseHeight;
        [SerializeField]
        private float _aspectRatio;
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
        private bool _orthographic;
        [SerializeField]
        private float _fieldOfView;
        [SerializeField]
        private float _planeDistance;
        [SerializeField]
        private AdditionalCanvasShaderChannels _additionalShaderChannels;
        [SerializeField]
        private bool _isHDRFormat;
        [NonSerialized]
        private RenderTexture _target;
        private Camera _camera;
        private int _instanceIndex;
        private List<Monitor3DImage> _threeDImages;
        internal static CanvasRenderTexture[] Instances;
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
            return null;
        }

        public void UpdateTexture()
        {
        }

        private bool RegisterInstance()
        {
            return default(bool);
        }

        private bool UnRegisterInstance()
        {
            return default(bool);
        }

        public void UpdateParameter()
        {
        }

        private void OnEnable()
        {
        }

        private void Start()
        {
        }

        private void OnDisable()
        {
        }

        internal void RegisterMonitor3D(Monitor3DImage monitor3DImage)
        {
        }

        internal void UnregisterMonitor3D(Monitor3DImage monitor3DImage)
        {
        }

        public static Texture GetCanvasRenderTexture(int index)
        {
            return null;
        }

        public CanvasRenderTexture()
        {
        }
    }
}
