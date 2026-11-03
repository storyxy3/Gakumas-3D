namespace Campus.Crowd
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(Animator), typeof(CrowdVolume))]
    public class CrowdAnimationComponent : MonoBehaviour, ICrowdAnimation, ICrowdPenlight
    {
        [CompilerGenerated]
        private Vector4[] _003CColorTable_003Ek__BackingField;
        [SerializeField]
        private CrowdMotionDefine motionDefineA;
        [SerializeField]
        private CrowdMotionDefine motionDefineB;
        [SerializeField]
        private bool _hidePenlight;
        [SerializeField]
        private Color[] _penlightColorTable;
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
            get
            {
                return default(bool);
            }
        }

        public bool UseColorProjection
        {
            get
            {
                return default(bool);
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            get
            {
                return default(Vector2);
            }
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

        private void CreateCrowdAnimator()
        {
        }

        private void Dispose()
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }

        public void Resume()
        {
        }

        public void Pause()
        {
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public bool IsPause()
        {
            return default(bool);
        }

        public void Step()
        {
        }

        public void SetTime(double time)
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public CrowdAnimationComponent()
        {
        }
    }
}
