namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::JetBrains.Annotations;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    public class CrowdAnimator : IDisposable
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<CrowdModelData.CrowdVolumeBoneData, int> _003C_003E9__21_0;
            public static Func<CrowdModelData.CrowdVolumeBoneData, Vector3> _003C_003E9__21_1;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ector_003Eb__21_0(CrowdModelData.CrowdVolumeBoneData d)
            {
                return d.boneIndex;
            }

            internal Vector3 _003C_002Ector_003Eb__21_1(CrowdModelData.CrowdVolumeBoneData d)
            {
                return d.size;
            }
        }

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
        private readonly float _maxDelay = 0.1f;
        private ScriptPlayable<CrowdAnimationBehaviour> _scriptPlayable;
        private ClipData[] _clips;
        private NativeArray<TransformStreamHandle> _transformStreams;
        public NativeArray<Matrix4x4> Matrices
        {
            get
            {
                return _matrices;
            }
        }

        public NativeArray<Matrix4x4> RawMatrices
        {
            get
            {
                return _rawMatrices;
            }
        }

        public NativeArray<Bounds> Bounds
        {
            get
            {
                return _bounds;
            }
        }

        public CrowdAnimator(Transform transform, [NotNull] Animator animator, [NotNull] CrowdVolume volume)
        {
            _rootTransform = transform;
            _graph = PlayableGraph.Create("Crowd Animator");
            _graph.SetTimeUpdateMode(DirectorUpdateMode.GameTime);
            _animator = animator;
            var output = AnimationPlayableOutput.Create(_graph, "Crowd Animation Output", animator);
            var model = volume.modelData;
            int boneCount = model.Bones.Length;
            _invRootMatrix = new NativeReference<Matrix4x4>(Matrix4x4.identity, Allocator.Persistent);
            _transformStreams = new NativeArray<TransformStreamHandle>(boneCount, Allocator.Persistent);
            _bindPoses = new NativeArray<Matrix4x4>(model.BindPoses, Allocator.Persistent);
            _matrices = new NativeArray<Matrix4x4>(8 * boneCount, Allocator.Persistent);
            _bounds = new NativeArray<Bounds>(8, Allocator.Persistent);
            _rawMatrices = new NativeArray<Matrix4x4>(8 * boneCount, Allocator.Persistent);
            _excludeBoundBoneIndexes = new NativeArray<int>(model.excludeBoundBoneIndexes.Length, Allocator.Persistent);
            _excludeBoundBoneIndexes.CopyFrom(model.excludeBoundBoneIndexes);
            _volumeBoneIndexes = new NativeArray<int>(model.volumeBoneDatas.Length, Allocator.Persistent);
            _volumeBoneIndexes.CopyFrom(FasterLinq.Select(model.volumeBoneDatas,
                _003C_003Ec._003C_003E9__21_0 ?? (_003C_003Ec._003C_003E9__21_0 = _003C_003Ec._003C_003E9._003C_002Ector_003Eb__21_0)).ToArray());
            _volumeBoneSizes = new NativeArray<Vector3>(model.volumeBoneDatas.Length, Allocator.Persistent);
            _volumeBoneSizes.CopyFrom(FasterLinq.Select(model.volumeBoneDatas,
                _003C_003Ec._003C_003E9__21_1 ?? (_003C_003Ec._003C_003E9__21_1 = _003C_003Ec._003C_003E9._003C_002Ector_003Eb__21_1)).ToArray());
            _animator.avatar = model.avatar;
            for (int i = 0; i < boneCount; i++)
            {
                var bone = transform.Find(model.Bones[i]);
                if (bone == null) Debug.LogError("子階層に存在しないGameObjectがあります。再生成のボタンまたはモデルデータの再出力を行ってください");
                _transformStreams[i] = animator.BindStreamTransform(bone);
            }
            _scriptPlayable = ScriptPlayable<CrowdAnimationBehaviour>.Create(_graph, new CrowdAnimationBehaviour
            {
                jobTemplate = new CrowdAnimationJob
                {
                    invRootMatrix = _invRootMatrix,
                    transforms = _transformStreams,
                    bindPoses = _bindPoses,
                    excludeBoundBoneIndexes = _excludeBoundBoneIndexes,
                    volumeBoneIndexes = _volumeBoneIndexes,
                    volumeBoneSizes = _volumeBoneSizes,
                    matrices = _matrices,
                    rawMatrices = _rawMatrices,
                    bounds = _bounds
                }
            });
            output.SetSourcePlayable(_scriptPlayable);
            _graph.Play();
        }

        public void Dispose()
        {
            if (IsValid()) _graph.Destroy();
            if (_invRootMatrix.IsCreated) _invRootMatrix.Dispose();
            if (_transformStreams.IsCreated) _transformStreams.Dispose();
            if (_bindPoses.IsCreated) _bindPoses.Dispose();
            if (_matrices.IsCreated) _matrices.Dispose();
            if (_rawMatrices.IsCreated) _rawMatrices.Dispose();
            if (_bounds.IsCreated) _bounds.Dispose();
            if (_excludeBoundBoneIndexes.IsCreated) _excludeBoundBoneIndexes.Dispose();
            if (_volumeBoneIndexes.IsCreated) _volumeBoneIndexes.Dispose();
            if (_volumeBoneSizes.IsCreated) _volumeBoneSizes.Dispose();
        }

        public void ConnectAnimation(CrowdMotionDefine motionDefine)
        {
            ConnectAnimation(motionDefine, 0d, _maxDelay, 0);
        }

        public void ConnectAnimation(CrowdMotionDefine[] motionDefines)
        {
            ConnectAnimation(motionDefines, 0d, _maxDelay, 0);
        }

        public void ConnectAnimation(CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
            if (!IsValid() || motionDefine == null || !IsValid()) return;
            var behaviour = _scriptPlayable.GetBehaviour();
            behaviour.SetAnimationCount(1);
            behaviour.ConnectAnimation(0, motionDefine, skipDuration, delay, seed);
        }

        public void ConnectAnimation(CrowdMotionDefine[] motionDefines, double skipDuration, float delay, int seed)
        {
            if (!IsValid() || motionDefines == null || !IsValid()) return;
            var behaviour = _scriptPlayable.GetBehaviour();
            behaviour.SetAnimationCount(1);
            behaviour.SetOverrideAnimationCount(1);
            behaviour.ConnectAnimation(0, motionDefines[0], skipDuration, delay, seed);
            behaviour.ConnectOverrideAnimation(0, motionDefines[1], skipDuration, delay, seed);
            behaviour.SetOverrideAnimationWeight(0, 1f);
        }

        public void ConnectAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
            if (!IsValid() || motionDefine == null || !IsValid()) return;
            _scriptPlayable.GetBehaviour().ConnectAnimation(index, motionDefine, skipDuration, delay, seed);
        }

        public void ConnectOverrideAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
            if (!IsValid() || motionDefine == null || !IsValid()) return;
            _scriptPlayable.GetBehaviour().ConnectOverrideAnimation(index, motionDefine, skipDuration, delay, seed);
        }

        public void SetAnimationCount(int count)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetAnimationCount(count);
        }

        public void SetAnimationWeight(int index, float weight)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetAnimationWeight(index, weight);
        }

        public void SetAnimationTime(int index, double time)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetAnimationTime(index, time);
        }

        public void Update()
        {
            _invRootMatrix.Value = _rootTransform.worldToLocalMatrix;
        }

        public void Play()
        {
            if (IsValid()) _scriptPlayable.Play();
        }

        public bool IsPlaying()
        {
            return IsValid() && _scriptPlayable.GetPlayState() == PlayState.Playing;
        }

        public void SetTime(double time)
        {
            if (IsValid()) _scriptPlayable.SetTime(time);
        }

        public double GetTime()
        {
            return IsValid() ? _scriptPlayable.GetTime() : double.NaN;
        }

        public void Pause()
        {
            if (IsValid()) _scriptPlayable.Pause();
        }

        public bool IsPaused()
        {
            return IsValid() && _scriptPlayable.GetPlayState() == PlayState.Paused;
        }

        private bool IsValid()
        {
            return _graph.IsValid() && _scriptPlayable.IsValid();
        }

        public void SetOverrideAnimationCount(int count)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetOverrideAnimationCount(count);
        }

        public void SetOverrideAnimationWeight(int index, float inputWeight)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetOverrideAnimationWeight(index, inputWeight);
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
            if (IsValid()) _scriptPlayable.GetBehaviour().SetOverrideAnimationTime(index, time);
        }
    }
}
