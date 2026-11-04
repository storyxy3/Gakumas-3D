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
            _aabbData = aabbData;
            _aabbTransformAccessArray = aabbTransformAccessArray;
            _aabbTransforms = new NativeArray<Vector3>(aabbTransformAccessArray.length, Allocator.Persistent);
            _localToWorlds = new NativeArray<float4x4>(aabbData.Length, Allocator.Persistent);
            _localBounds = new NativeArray<Bounds>(aabbData.Length, Allocator.Persistent);
            _bounds = new NativeArray<Bounds>(aabbData.Length, Allocator.Persistent);
            _aabbPositionJob = new AABBPositionJob { positions = _aabbTransforms };
            _aabbCalcJob = new AABBCalcJob { positions = _aabbTransforms, aabbs = _aabbData, localToWorlds = _localToWorlds, localBounds = _localBounds, bounds = _bounds };
            _jobHandle = default;
        }

        public void UpdateLocalToWorldMatrix(int index, in Matrix4x4 localToWorld)
        {
            _localToWorlds.ReinterpretStore(index, localToWorld);
        }

        public JobHandle Schedule()
        {
            _jobHandle.Complete();
            _jobHandle = _aabbPositionJob.ScheduleReadOnlyByRef(_aabbTransformAccessArray, 32);
            _jobHandle = _aabbCalcJob.ScheduleByRef(_aabbData.Length, _jobHandle);
            return _jobHandle;
        }

        public void Run()
        {
            _aabbPositionJob.RunReadOnlyByRef(_aabbTransformAccessArray);
            _aabbCalcJob.RunByRef(_aabbData.Length);
        }

        public void Complete()
        {
            _jobHandle.Complete();
        }

        public bool IsValid()
        {
            return _aabbTransformAccessArray.isCreated;
        }

        public void Dispose()
        {
            _jobHandle.Complete();
            if (_aabbData.IsCreated) { _aabbData.Dispose(); _aabbData = default; }
            if (_aabbTransforms.IsCreated) { _aabbTransforms.Dispose(); _aabbTransforms = default; }
            if (_aabbTransformAccessArray.isCreated) { _aabbTransformAccessArray.Dispose(); _aabbTransformAccessArray = default; }
            if (_localToWorlds.IsCreated) { _localToWorlds.Dispose(); _localToWorlds = default; }
            if (_localBounds.IsCreated) { _localBounds.Dispose(); _localBounds = default; }
            if (_bounds.IsCreated) { _bounds.Dispose(); _bounds = default; }
        }

        public bool IsActive(int index)
        {
            return _aabbData[index].aabbCalcType != VLActorAABBCalcType.None;
        }

        public Bounds GetBounds(int index)
        {
            return _bounds[index];
        }

        public Bounds GetLocalBounds(int index)
        {
            return _localBounds[index];
        }
    }
}
