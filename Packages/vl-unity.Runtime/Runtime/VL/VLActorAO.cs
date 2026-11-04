// TODO(qa-recon): UpdateJob.Execute retains a semantic flag in parity selection and immediate ordering; exact native correspondence remains unresolved (TASK_D_REPORT.md).
namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::VL;
    using global::VL.Core;

    [RequireComponent(typeof(VLActorController))]
    [ExecuteAlways]
    public class VLActorAO : VLActorExtension
    {
        [Serializable]
        public struct CapsuleData
        {
            public float radius;
            public float4 offsetA;
            public float4 offsetB;
        }

        [BurstCompile]
        private struct UpdateJob : IJobParallelForTransform
        {
            [ReadOnly]
            public NativeArray<CapsuleData> dataArray;
            [WriteOnly]
            [NativeDisableParallelForRestriction]
            public NativeArray<float4> capsuleAArray;
            [WriteOnly]
            [NativeDisableParallelForRestriction]
            public NativeArray<float4> capsuleBArray;
            public void Execute(int index, TransformAccess transform)
            {
                if (!transform.isValid) return;
                int capsule = index / 2;
                bool isA = (index & 1) == 0;
                var data = dataArray[capsule];
                var offset = isA ? data.offsetA : data.offsetB;
                float radius = isA ? data.radius : 0f;
                ref var output = ref (isA ? ref capsuleAArray : ref capsuleBArray);
                float3 position = transform.position;
                quaternion rotation = transform.rotation;
                var result = new float4(position + math.rotate(rotation, offset.xyz) * offset.w, radius);
                output[capsule] = result;
            }
        }

        [SerializeField]
        private CapsuleData[] _data;
        [SerializeField]
        private Transform[] _transforms;
        private TransformAccessArray _transformArray;
        private NativeArray<CapsuleData> _dataArray;
        private NativeArray<float4> _capsuleAArray;
        private NativeArray<float4> _capsuleBArray;
        public NativeArray<Vector4> capsuleA
        {
            get
            {
                return _capsuleAArray.Reinterpret<Vector4>();
            }
        }

        public NativeArray<Vector4> capsuleB
        {
            get
            {
                return _capsuleBArray.Reinterpret<Vector4>();
            }
        }

        public override void Initialize()
        {
            if (controller == null) return;
            UpdateJobData();
        }

        private void UpdateJobData()
        {
            if (_transforms == null) return;
            if (!_transformArray.isCreated) _transformArray = new TransformAccessArray(_transforms);
            if (!_dataArray.IsCreated) _dataArray = new NativeArray<CapsuleData>(2, Allocator.Persistent);
            if (!_capsuleAArray.IsCreated) _capsuleAArray = new NativeArray<float4>(2, Allocator.Persistent);
            if (!_capsuleBArray.IsCreated) _capsuleBArray = new NativeArray<float4>(2, Allocator.Persistent);
            NativeArray<CapsuleData>.Copy(_data, _dataArray, _dataArray.Length);
            for (int i = 0; i < _capsuleAArray.Length; i++) _capsuleAArray[i] = new float4(0f, 0f, 0f, _data[i].radius);
        }

        public override void Dispose()
        {
            if (_transformArray.isCreated) _transformArray.Dispose();
            if (_dataArray.IsCreated) _dataArray.Dispose();
            if (_capsuleAArray.IsCreated) _capsuleAArray.Dispose();
            if (_capsuleBArray.IsCreated) _capsuleBArray.Dispose();
        }

        public void Setup(Dictionary<HumanBodyBones, Transform> humanBodyBoneMap, CapsuleData[] data)
        {
            _data = data;
            if (_transforms == null) _transforms = new Transform[4];
            _transforms[0] = humanBodyBoneMap[HumanBodyBones.LeftFoot];
            _transforms[1] = humanBodyBoneMap[HumanBodyBones.LeftToes];
            _transforms[2] = humanBodyBoneMap[HumanBodyBones.RightFoot];
            _transforms[3] = humanBodyBoneMap[HumanBodyBones.RightToes];
            Dispose();
            Initialize();
        }

        public override void OnLateUpdate()
        {
            if (_transformArray.isCreated)
                new UpdateJob { dataArray = _dataArray, capsuleAArray = _capsuleAArray, capsuleBArray = _capsuleBArray }.RunReadOnly(_transformArray);
        }

        public VLActorAO()
        {
        }
    }
}
