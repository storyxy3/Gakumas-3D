namespace Campus.Common
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Qua.Utility;
    using global::TMPro;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [DefaultExecutionOrder(-10000)]
    [SingletonResourcePath("CampusQualityManager", true)]
    public class CampusQualityManager : Singleton<CampusQualityManager>
    {
        public enum QualityLevel
        {
            None = 0,
            Low = 10,
            Middle = 20,
            High = 30,
            VeryHigh = 40,
            Recording = 100
        }

        [CompilerGenerated]
        private float _003CFrameChangeScale_003Ek__BackingField;
        [CompilerGenerated]
        private QualityLevel _003CThreeD_003Ek__BackingField;
        private const uint MaxFrameTiming = 1u;
        private FrameTiming[] _frameTimings;
        private char[] _cpuFrameTimeText;
        private char[] _gpuFrameTimeText;
        private char[] _bufferScaleRateText;
        private double[] _cpuFrameTimes;
        private int _currentCpuFrameTimeIndex;
        private int _bufferScaleChangeCounter;
        [SerializeField]
        private QualityLevel _startQuality;
        [SerializeField]
        private GameObject _debugCanvas;
        [SerializeField]
        private TextMeshProUGUI _cpuText;
        [SerializeField]
        private TextMeshProUGUI _gpuText;
        [SerializeField]
        private TextMeshProUGUI _bufferScaleText;
        [SerializeField]
        private Volume[] _overrideVolumes;
        private Volume _customVolume;
        private VolumeProfile _customVolumeProfile;
        public float MinBufferScale;
        [CompilerGenerated]
        private bool _003CIsAutoDynamicResolution_003Ek__BackingField;
        private float _targetFrameRate;
        public float FrameChangeScale
        {
            [CompilerGenerated]
            get
            {
                return _003CFrameChangeScale_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFrameChangeScale_003Ek__BackingField = value;
            }
        }

        public QualityLevel ThreeD
        {
            [CompilerGenerated]
            get
            {
                return _003CThreeD_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CThreeD_003Ek__BackingField = value;
            }
        }

        private Volume CustomVolume
        {
            get
            {
                return null;
            }
        }

        public QualityLevel StartQuality
        {
            get
            {
                return default(QualityLevel);
            }

            set
            {
            }
        }

        public float TargetFrameRate
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public int RenderFrameInterval
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public bool IsAutoDynamicResolution
        {
            [CompilerGenerated]
            get
            {
                return _003CIsAutoDynamicResolution_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsAutoDynamicResolution_003Ek__BackingField = value;
            }
        }

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnInitialize()
        {
        }

        private void CreateCustomVolume()
        {
        }

        public void ApplySetting(int qualitySettingsLevel, int maxBufferPixel, float renderScale, int volumeIndex)
        {
        }

        private int GetMaxBufferPixel(QualityLevel level)
        {
            return default(int);
        }

        private float GetRenderScale(QualityLevel level)
        {
            return default(float);
        }

        public int GetVolumeQuality(QualityLevel defaultLevel)
        {
            return default(int);
        }

        public int GetQualitySettingsLevel(QualityLevel level)
        {
            return default(int);
        }

        public void SetQuality(QualityLevel level, bool forceApply = false)
        {
        }

        public void SetResolutionQuality(QualityLevel resolution)
        {
        }

        public void SetVolumeQuality(QualityLevel defaultLevel)
        {
        }

        public void SetReflectionQuality(QualityLevel reflection)
        {
        }

        public void SetLODQuality(QualityLevel lod)
        {
        }

        public void SetSystemQuality(QualityLevel systemLevel)
        {
        }

        public void SetQualityLow()
        {
        }

        public void SetQualityMiddle()
        {
        }

        public void SetQualityHigh()
        {
        }

        public void SetQualityVeryHigh()
        {
        }

        private static void SetStreamingMemoryBudget()
        {
        }

        [Conditional("UNITY_IOS")]
        private static void SetDPIFactor()
        {
        }

        private void UpdateFrameTimeText(double time, char[] text)
        {
        }

        private void UpdateRateText(float rate, char[] text, int startIndex)
        {
        }

        private void Update()
        {
        }

        public CampusQualityManager()
        {
        }
    }
}
