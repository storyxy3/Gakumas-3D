// TODO(qa-recon): Selected APK bodies still need reconstruction: Awake, InitializeCrowdAnimator, IsPaused, OnDisable, OnEnable, Pause, Play, SetAnimationCount, SetAnimationData, SetAnimationTime, SetAnimationWeight, SetHidePenlight, SetOverrideAnimationCount, SetOverrideAnimationData, SetOverrideAnimationTime, SetOverrideAnimationWeight, SetPenlightColorTable, SetPenlightProjectionUvRect, SetTime, SetUsePenlightColorProjection, Update, get_Bounds, get_Matrices, get_ProjectionUvRectMax, get_ProjectionUvRectMin, get_RawMatrices, set_ProjectionUvRectMax, set_ProjectionUvRectMin.
namespace Campus.Crowd
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(Animator), typeof(CrowdVolume))]
    public class CrowdAnimationTimeline : MonoBehaviour, ICrowdAnimation, ICrowdPenlight
    {
        [CompilerGenerated]
        private bool _003CHidePenlight_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CUseColorProjection_003Ek__BackingField;
        [CompilerGenerated]
        private Vector4[] _003CColorTable_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CProjectionUvRectMin_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CProjectionUvRectMax_003Ek__BackingField;
        private CrowdAnimator _crowdAnimator;
        public NativeArray<Matrix4x4> Matrices
        {
            get
            {
                return _crowdAnimator != null ? _crowdAnimator.Matrices : default;
            }
        }

        public NativeArray<Bounds> Bounds
        {
            get
            {
                return _crowdAnimator != null ? _crowdAnimator.Bounds : default;
            }
        }

        public NativeArray<Matrix4x4> RawMatrices
        {
            get
            {
                return _crowdAnimator != null ? _crowdAnimator.RawMatrices : default;
            }
        }

        public bool HidePenlight
        {
            [CompilerGenerated]
            get
            {
                return _003CHidePenlight_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CHidePenlight_003Ek__BackingField = value;
            }
        }

        public bool UseColorProjection
        {
            [CompilerGenerated]
            get
            {
                return _003CUseColorProjection_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CUseColorProjection_003Ek__BackingField = value;
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return _003CColorTable_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CColorTable_003Ek__BackingField = value;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            [CompilerGenerated]
            get
            {
                return _003CProjectionUvRectMin_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CProjectionUvRectMin_003Ek__BackingField = value;
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            [CompilerGenerated]
            get
            {
                return _003CProjectionUvRectMax_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CProjectionUvRectMax_003Ek__BackingField = value;
            }
        }

        private void Awake()
        {
            SetUsePenlightColorProjection(false);
            SetPenlightColorTable(null);
        }

        private void InitializeCrowdAnimator()
        {
            if (_crowdAnimator == null && TryGetComponent<Animator>(out var animator) && TryGetComponent<CrowdVolume>(out var volume))
                _crowdAnimator = new CrowdAnimator(transform, animator, volume);
        }

        private void OnEnable()
        {
            InitializeCrowdAnimator();
        }

        private void OnDisable()
        {
            _crowdAnimator?.Dispose();
            _crowdAnimator = null;
        }

        private void Update()
        {
            _crowdAnimator?.Update();
        }

        public void SetTime(double time)
        {
            _crowdAnimator?.SetTime(time);
        }

        public void Pause()
        {
            _crowdAnimator?.Pause();
        }

        public bool IsPaused()
        {
            return _crowdAnimator != null && _crowdAnimator.IsPaused();
        }

        public void Play()
        {
            _crowdAnimator?.Play();
        }

        public void SetAnimationCount(int count)
        {
            InitializeCrowdAnimator();
            _crowdAnimator.SetAnimationCount(count);
        }

        public void SetAnimationData(int index, CrowdTimelineBehaviour behaviour)
        {
            _crowdAnimator?.ConnectAnimation(index, behaviour.crowdMotionDefine, behaviour.skipDuration, behaviour.maxDelay, behaviour.delayRandomSeed);
        }

        public void SetAnimationWeight(int index, float weight)
        {
            _crowdAnimator?.SetAnimationWeight(index, weight);
        }

        public void SetAnimationTime(int index, double time)
        {
            _crowdAnimator?.SetAnimationTime(index, time);
        }

        public void SetOverrideAnimationData(int index, CrowdTimelineBehaviour behaviour)
        {
            _crowdAnimator?.ConnectOverrideAnimation(index, behaviour.crowdMotionDefine, behaviour.skipDuration, behaviour.maxDelay, behaviour.delayRandomSeed);
        }

        public void SetHidePenlight(bool hidePenlight)
        {
            HidePenlight = hidePenlight;
        }

        public void SetUsePenlightColorProjection(bool useColorProjection)
        {
            UseColorProjection = useColorProjection;
        }

        public void SetPenlightColorTable(Color[] colorTable)
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(colorTable)) colorTable = new[] { Color.white };
            ColorTable = new Vector4[8];
            for (int i = 0; i < 8; i++) ColorTable[i] = colorTable[i % colorTable.Length];
        }

        public void SetPenlightProjectionUvRect(Vector2 min, Vector2 max)
        {
            ProjectionUvRectMin = Vector2.Min(min, max);
            ProjectionUvRectMax = Vector2.Max(min, max);
        }

        public void SetOverrideAnimationCount(int count)
        {
            _crowdAnimator?.SetOverrideAnimationCount(count);
        }

        public void SetOverrideAnimationWeight(int index, float getInputWeight)
        {
            _crowdAnimator?.SetOverrideAnimationWeight(index, getInputWeight);
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
            _crowdAnimator?.SetOverrideAnimationTime(index, time);
        }

        public CrowdAnimationTimeline()
        {
        }
    }
}
