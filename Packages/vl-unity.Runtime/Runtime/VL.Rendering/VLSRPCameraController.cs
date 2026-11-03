namespace VL.Rendering
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Events;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;
    using global::VL.Rendering;

    [ExecuteAlways]
    [RequireComponent(typeof(Camera), typeof(VLSRPAdditionalCameraData))]
    [DefaultExecutionOrder(-12000)]
    public class VLSRPCameraController : VLCameraControllerSingleton<VLSRPCameraController>, IVLCameraController, IVLTransform
    {
        public delegate void CameraAction(IVLCameraController cameraController);
        [CompilerGenerated]
        private static CameraAction m__onTargetTextureChange;
        public const RenderPassEvent DefaultCapturePassEvent = (RenderPassEvent)1010;
        public float bufferScale;
        public int maxBufferPixel;
        [Tooltip("アスペクト比（幅,高さ）")]
        public Vector2 aspectRatio;
        public bool useDynamicScale;
        private Camera _mainCamera;
        private AudioListener _audioListener;
        private UniversalAdditionalCameraData _additionalCameraData;
        private VLSRPAdditionalCameraData _vlSrpAdditionalCameraData;
        private List<UnityAction> _preCullFrameEvents;
        private bool _isDirty;
        private bool _targetChangeRequested;
        private bool _captureRequested;
        private Vector2Int _customResolution;
        private int _cacheScreenWidth;
        private int _cacheScreenHeight;
        private float _cacheBufferScale;
        private int _cacheMaxBufferPixel;
        private Vector2 _cacheAspectRatio;
        private RenderTexture _targetTexture;
        private RenderTexture _capturedTexture;
        [CompilerGenerated]
        private RenderTextureDescriptor _003CtargetTextureDescriptor_003Ek__BackingField;
        private VLSRPCapture _capture;
        public Camera mainCamera
        {
            get
            {
                return null;
            }
        }

        public AudioListener audioListener
        {
            get
            {
                return null;
            }
        }

        public UniversalAdditionalCameraData additionalCameraData
        {
            get
            {
                return null;
            }
        }

        public VLSRPAdditionalCameraData vlSrpAdditionalCameraData
        {
            get
            {
                return null;
            }
        }

        public RenderTexture targetTexture
        {
            get
            {
                return null;
            }
        }

        public RenderTexture capturedTexture
        {
            get
            {
                return null;
            }
        }

        public RenderTextureDescriptor targetTextureDescriptor
        {
            [CompilerGenerated]
            get
            {
                return default(RenderTextureDescriptor);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public RenderTextureDescriptor hdrTargetTextureDescriptor
        {
            get
            {
                return default(RenderTextureDescriptor);
            }
        }

        public Vector3 position
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Quaternion rotation
        {
            get
            {
                return default(Quaternion);
            }

            set
            {
            }
        }

        public Vector3 eulerAngles
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 forward
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 scale
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        private static event CameraAction _onTargetTextureChange
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static event CameraAction onTargetTextureChange
        {
            add
            {
            }

            remove
            {
            }
        }

        protected override void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        private void Update()
        {
        }

        public void ResetHistory()
        {
        }

        public void UpdateRenderTarget()
        {
        }

        public void UpdateRenderTarget(int width, int height, bool forceAlpha = false)
        {
        }

        private void DestroyTextures()
        {
        }

        private void UpdateCapturedTexture()
        {
        }

        public void CaptureRequest()
        {
        }

        public void CaptureRequest(RenderTargetIdentifier target, [Optional] Action onCapture)
        {
        }

        public void CaptureRequest(RenderTargetIdentifier target, RenderPassEvent renderPassEvent, [Optional] Action onCapture)
        {
        }

        public void CaptureRequest(VLSRPCapture.RequestData requestData)
        {
        }

        private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
        {
        }

        private void UpdateRenderTexture()
        {
        }

        public Ray GetCameraRay()
        {
            return default(Ray);
        }

        public Ray GetCameraRay(Vector2 position)
        {
            return default(Ray);
        }

        public int GetCameraLayerMask()
        {
            return default(int);
        }

        public void AddChild(GameObject child)
        {
        }

        public VLSRPCameraController()
        {
        }
    }
}
