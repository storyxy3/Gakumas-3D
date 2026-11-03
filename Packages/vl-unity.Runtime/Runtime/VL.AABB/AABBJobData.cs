namespace VL.AABB
{
    using global::System;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::VL.AABB;

    [Serializable]
    public struct AABBJobData : IDisposable
    {
        private NativeArray<AABBData> _aabbData;
        private TransformAccessArray _aabbTransformAccessArray;
        private NativeArray<Vector3> _aabbTransforms;
        private NativeArray<float4x4> _localToWorlds;
        private NativeArray<Bounds> _localBounds;
        private NativeArray<Bounds> _bounds;
        private AABBPositionJob _aabbPositionJob;
        private AABBCalcJob _aabbCalcJob;
        private JobHandle _jobHandle;
        public AABBJobData(NativeArray<AABBData> aabbData, TransformAccessArray aabbTransformAccessArray)
        {
            this = default;
        }

        public void UpdateLocalToWorldMatrix(int index, in Matrix4x4 localToWorld)
        {
        }

        public JobHandle Schedule()
        {
            return default(JobHandle);
        }

        public void Run()
        {
        }

        public void Complete()
        {
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        public bool IsActive(int index)
        {
            return default(bool);
        }

        public Bounds GetBounds(int index)
        {
            return default(Bounds);
        }

        public Bounds GetLocalBounds(int index)
        {
            return default(Bounds);
        }
    }
}
