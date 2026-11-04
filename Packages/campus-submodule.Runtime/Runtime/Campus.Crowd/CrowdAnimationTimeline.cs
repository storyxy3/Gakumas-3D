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
                return default(NativeArray<Matrix4x4>);
            }
        }

        public NativeArray<Bounds> Bounds
        {
            get
            {
                return default(NativeArray<Bounds>);
            }
        }

        public NativeArray<Matrix4x4> RawMatrices
        {
            get
            {
                return default(NativeArray<Matrix4x4>);
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
                return default(Vector2);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        private void Awake()
        {
        }

        private void InitializeCrowdAnimator()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Update()
        {
        }

        public void SetTime(double time)
        {
        }

        public void Pause()
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public void Play()
        {
        }

        public void SetAnimationCount(int count)
        {
        }

        public void SetAnimationData(int index, CrowdTimelineBehaviour behaviour)
        {
        }

        public void SetAnimationWeight(int index, float weight)
        {
        }

        public void SetAnimationTime(int index, double time)
        {
        }

        public void SetOverrideAnimationData(int index, CrowdTimelineBehaviour behaviour)
        {
        }

        public void SetHidePenlight(bool hidePenlight)
        {
        }

        public void SetUsePenlightColorProjection(bool useColorProjection)
        {
        }

        public void SetPenlightColorTable(Color[] colorTable)
        {
        }

        public void SetPenlightProjectionUvRect(Vector2 min, Vector2 max)
        {
        }

        public void SetOverrideAnimationCount(int count)
        {
        }

        public void SetOverrideAnimationWeight(int index, float getInputWeight)
        {
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
        }

        public CrowdAnimationTimeline()
        {
        }
    }
}
