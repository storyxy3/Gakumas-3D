// TODO(qa-recon): UpdateRenderTexture/DestroyTextures depend on the separately owned VLSRPAdditionalCameraData.targetTexture setter, which is still a skeleton.
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
        public float bufferScale = 1f;
        public int maxBufferPixel = 1280;
        [Tooltip("アスペクト比（幅,高さ）")]
        public Vector2 aspectRatio = new Vector2(-1f, -1f);
        public bool useDynamicScale;
        private Camera _mainCamera;
        private AudioListener _audioListener;
        private UniversalAdditionalCameraData _additionalCameraData;
        private VLSRPAdditionalCameraData _vlSrpAdditionalCameraData;
        private List<UnityAction> _preCullFrameEvents;
        private bool _isDirty;
        private bool _targetChangeRequested;
        private bool _captureRequested;
        private Vector2Int _customResolution = new Vector2Int(-1, -1);
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
                if (_mainCamera == null && this != null) TryGetComponent(out _mainCamera);
                return _mainCamera;
            }
        }

        public AudioListener audioListener
        {
            get
            {
                if (_audioListener == null) TryGetComponent(out _audioListener);
                return _audioListener;
            }
        }

        public UniversalAdditionalCameraData additionalCameraData
        {
            get
            {
                if (_additionalCameraData == null) mainCamera.TryGetComponent(out _additionalCameraData);
                return _additionalCameraData;
            }
        }

        public VLSRPAdditionalCameraData vlSrpAdditionalCameraData
        {
            get
            {
                if (_vlSrpAdditionalCameraData == null && !mainCamera.TryGetComponent(out _vlSrpAdditionalCameraData))
                    _vlSrpAdditionalCameraData = mainCamera.gameObject.AddComponent<VLSRPAdditionalCameraData>();
                return _vlSrpAdditionalCameraData;
            }
        }

        public RenderTexture targetTexture
        {
            get
            {
                return _targetTexture;
            }
        }

        public RenderTexture capturedTexture
        {
            get
            {
                return _capturedTexture;
            }
        }

        public RenderTextureDescriptor targetTextureDescriptor
        {
            [CompilerGenerated]
            get
            {
                return _003CtargetTextureDescriptor_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CtargetTextureDescriptor_003Ek__BackingField = value;
            }
        }

        public RenderTextureDescriptor hdrTargetTextureDescriptor
        {
            get
            {
                var descriptor = targetTextureDescriptor;
                descriptor.colorFormat = RenderingUtils.SupportsRenderTextureFormat(RenderTextureFormat.RGB111110Float) ? RenderTextureFormat.RGB111110Float : RenderTextureFormat.DefaultHDR;
                descriptor.sRGB = QualitySettings.activeColorSpace == ColorSpace.Linear;
                return descriptor;
            }
        }

        public Vector3 position
        {
            get
            {
                return transform.localPosition;
            }

            set
            {
                transform.localPosition = value;
            }
        }

        public Quaternion rotation
        {
            get
            {
                return transform.localRotation;
            }

            set
            {
                transform.localRotation = value;
            }
        }

        public Vector3 eulerAngles
        {
            get
            {
                return transform.localEulerAngles;
            }

            set
            {
                transform.localEulerAngles = value;
            }
        }

        public Vector3 forward
        {
            get
            {
                return transform.forward;
            }
        }

        public Vector3 scale
        {
            get
            {
                return transform.localScale;
            }

            set
            {
                transform.localScale = value;
            }
        }

        private static event CameraAction _onTargetTextureChange
        {
            [CompilerGenerated]
            add
            {
                CameraAction previous;
                CameraAction current = m__onTargetTextureChange;
                do
                {
                    previous = current;
                    var updated = (CameraAction)Delegate.Combine(previous, value);
                    current = System.Threading.Interlocked.CompareExchange(ref m__onTargetTextureChange, updated, previous);
                } while (!object.ReferenceEquals(current, previous));
            }

            [CompilerGenerated]
            remove
            {
                CameraAction previous;
                CameraAction current = m__onTargetTextureChange;
                do
                {
                    previous = current;
                    var updated = (CameraAction)Delegate.Remove(previous, value);
                    current = System.Threading.Interlocked.CompareExchange(ref m__onTargetTextureChange, updated, previous);
                } while (!object.ReferenceEquals(current, previous));
            }
        }

        public static event CameraAction onTargetTextureChange
        {
            add
            {
                _onTargetTextureChange += value;
                if (HasInstance) value(Instance);
            }

            remove
            {
                _onTargetTextureChange -= value;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
        }

        private void OnDisable()
        {
            RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
            DestroyTextures();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            DestroyTextures();
        }

        private void Update()
        {
            if ((_customResolution.x < 0 || _customResolution.y < 0) &&
                (Screen.width != _cacheScreenWidth || Screen.height != _cacheScreenHeight || maxBufferPixel != _cacheMaxBufferPixel ||
                !Mathf.Approximately(bufferScale, _cacheBufferScale) || !Mathf.Approximately(aspectRatio.x, _cacheAspectRatio.x) || !Mathf.Approximately(aspectRatio.y, _cacheAspectRatio.y)))
                UpdateRenderTarget(-1, -1);
        }

        public void ResetHistory()
        {
            additionalCameraData.taaSettings.resetHistoryFrames++;
        }

        public void UpdateRenderTarget()
        {
            UpdateRenderTarget(-1, -1);
        }

        public void UpdateRenderTarget(int width, int height, bool forceAlpha = false)
        {
            int screenWidth = Screen.width;
            int screenHeight = Screen.height;
            _cacheScreenWidth = Screen.width;
            _cacheScreenHeight = Screen.height;
            _cacheMaxBufferPixel = maxBufferPixel;
            _cacheBufferScale = bufferScale;
            _cacheAspectRatio = aspectRatio;
            var resolution = VLUtility.GetLimitedResolution(screenWidth, screenHeight, aspectRatio, maxBufferPixel, bufferScale);
            _customResolution = new Vector2Int(width, height);
            if (width <= 0 || height <= 0)
            {
                if (resolution.Item1 == 0 || resolution.Item2 == 0) width = height = 128;
                else { width = resolution.Item1; height = resolution.Item2; }
            }
            if (targetTextureDescriptor.width != width || targetTextureDescriptor.height != height)
            {
                targetTextureDescriptor = new RenderTextureDescriptor(width, height, (UnityEngine.Experimental.Rendering.GraphicsFormat)4, 0) { useDynamicScale = false };
                _targetChangeRequested = true;
                Debug.Log("Request UpdateRenderTarget");
            }
        }

        private void DestroyTextures()
        {
            mainCamera.targetTexture = null;
            if (_vlSrpAdditionalCameraData != null) _vlSrpAdditionalCameraData.targetTexture = null;
            CoreUtils.Destroy(_targetTexture);
            CoreUtils.Destroy(_capturedTexture);
            _targetTexture = null;
            _capturedTexture = null;
            m__onTargetTextureChange?.Invoke(this);
        }

        private void UpdateCapturedTexture()
        {
            if (_targetTexture == null)
            {
                Debug.LogError("targetTexture == null\nUpdateRenderTargetを実行してください");
                return;
            }
            if (_capturedTexture != null && _capturedTexture.width == _targetTexture.width && _capturedTexture.height == _targetTexture.height && _capturedTexture.graphicsFormat == _targetTexture.graphicsFormat) return;
            var descriptor = targetTextureDescriptor;
            var texture = new RenderTexture(descriptor) { name = string.Format("_VLCapturedTexture_{0}x{1}", descriptor.width, descriptor.height), filterMode = FilterMode.Bilinear };
            texture.Create();
            if (_capture != null && _capture.Remove(_capturedTexture)) _capture.Add(texture, DefaultCapturePassEvent);
            CoreUtils.Destroy(_capturedTexture);
            _capturedTexture = texture;
        }

        public void CaptureRequest()
        {
            _captureRequested = true;
            UpdateCapturedTexture();
        }

        public void CaptureRequest(RenderTargetIdentifier target, [Optional] Action onCapture)
        {
            CaptureRequest(target, DefaultCapturePassEvent, onCapture);
        }

        public void CaptureRequest(RenderTargetIdentifier target, RenderPassEvent renderPassEvent, [Optional] Action onCapture)
        {
            if (_capture == null && !TryGetComponent(out _capture)) _capture = gameObject.AddComponent<VLSRPCapture>();
            _capture.Add(target, renderPassEvent, onCapture);
        }

        public void CaptureRequest(VLSRPCapture.RequestData requestData)
        {
            if (_capture == null && !TryGetComponent(out _capture)) _capture = gameObject.AddComponent<VLSRPCapture>();
            _capture.Add(requestData);
        }

        private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
        {
            if (camera != mainCamera) return;
            UpdateRenderTexture();
        }

        private void UpdateRenderTexture()
        {
            if (_targetChangeRequested)
            {
                var descriptor = targetTextureDescriptor;
                Debug.LogFormat(string.Format("Update RenderTarget {0}x{1}", descriptor.width, descriptor.height));
                var texture = new RenderTexture(descriptor) { name = string.Format("_VLTargetTexture_{0}x{1}", descriptor.width, descriptor.height), filterMode = FilterMode.Bilinear };
                vlSrpAdditionalCameraData.targetTexture = texture;
                mainCamera.targetTexture = texture;
                CoreUtils.Destroy(_targetTexture);
                _targetTexture = texture;
                m__onTargetTextureChange?.Invoke(this);
                _targetChangeRequested = false;
            }
            if (_captureRequested)
            {
                UpdateCapturedTexture();
                CaptureRequest(_capturedTexture, DefaultCapturePassEvent);
                _captureRequested = false;
            }
        }

        public Ray GetCameraRay()
        {
            return GetCameraRay(Input.mousePosition);
        }

        public Ray GetCameraRay(Vector2 position)
        {
            if (Screen.height > 0) position *= (float)targetTextureDescriptor.height / Screen.height;
            return mainCamera.ScreenPointToRay(position);
        }

        public int GetCameraLayerMask()
        {
            return mainCamera.cullingMask;
        }

        public void AddChild(GameObject child)
        {
            child.layer = gameObject.layer;
            child.transform.SetParent(transform, false);
        }

        public VLSRPCameraController()
        {
        }
    }
}
