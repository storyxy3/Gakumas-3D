namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::JetBrains.Annotations;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    public class CrowdAnimator : IDisposable
    {
        private NativeReference<Matrix4x4> _invRootMatrix;
        private NativeArray<Matrix4x4> _bindPoses;
        private Animator _animator;
        private PlayableGraph _graph;
        private NativeArray<Matrix4x4> _matrices;
        private NativeArray<Matrix4x4> _rawMatrices;
        private Transform _rootTransform;
        private NativeArray<Bounds> _bounds;
        private NativeArray<int> _excludeBoundBoneIndexes;
        private NativeArray<int> _volumeBoneIndexes;
        private NativeArray<Vector3> _volumeBoneSizes;
        private readonly float _maxDelay;
        private ScriptPlayable<CrowdAnimationBehaviour> _scriptPlayable;
        private ClipData[] _clips;
        private NativeArray<TransformStreamHandle> _transformStreams;
        public NativeArray<Matrix4x4> Matrices
        {
            get
            {
                return default(NativeArray<Matrix4x4>);
            }
        }

        public NativeArray<Matrix4x4> RawMatrices
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

        public CrowdAnimator(Transform transform, [NotNull] Animator animator, [NotNull] CrowdVolume volume)
        {
        }

        public void Dispose()
        {
        }

        public void ConnectAnimation(CrowdMotionDefine motionDefine)
        {
        }

        public void ConnectAnimation(CrowdMotionDefine[] motionDefines)
        {
        }

        public void ConnectAnimation(CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
        }

        public void ConnectAnimation(CrowdMotionDefine[] motionDefines, double skipDuration, float delay, int seed)
        {
        }

        public void ConnectAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
        }

        public void ConnectOverrideAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
        }

        public void SetAnimationCount(int count)
        {
        }

        public void SetAnimationWeight(int index, float weight)
        {
        }

        public void SetAnimationTime(int index, double time)
        {
        }

        public void Update()
        {
        }

        public void Play()
        {
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public void SetTime(double time)
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public void Pause()
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        private bool IsValid()
        {
            return default(bool);
        }

        public void SetOverrideAnimationCount(int count)
        {
        }

        public void SetOverrideAnimationWeight(int index, float inputWeight)
        {
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
        }
    }
}
