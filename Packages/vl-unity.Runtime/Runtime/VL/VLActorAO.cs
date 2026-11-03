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
                return default(NativeArray<Vector4>);
            }
        }

        public NativeArray<Vector4> capsuleB
        {
            get
            {
                return default(NativeArray<Vector4>);
            }
        }

        public override void Initialize()
        {
        }

        private void UpdateJobData()
        {
        }

        public override void Dispose()
        {
        }

        public void Setup(Dictionary<HumanBodyBones, Transform> humanBodyBoneMap, CapsuleData[] data)
        {
        }

        public override void OnLateUpdate()
        {
        }

        public VLActorAO()
        {
        }
    }
}
