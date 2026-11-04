using global::System;
using global::System.Collections.Generic;
using global::UnityEngine;
using global::UnityEngine.Jobs;

[ExecuteAlways]
[DefaultExecutionOrder(-100)]
[RequireComponent(typeof(Camera))]
public class ProFlareBatchForSRP : MonoBehaviour
{
    public bool debugMessages = true;
    [NonSerialized]
    private ProFlareAtlas _atlas;
    public const int MaxFlareSize = 1024;
    [NonSerialized]
    public List<ProFlare> FlaresList = new List<ProFlare>(1024);
    private Queue<int> _flareEmptyQueue = new Queue<int>(1024);
    private Dictionary<int, int> _flareInstanceIDTable = new Dictionary<int, int>(1024);
    public int MaxFlareElementSize = 1024;
    private List<ProFlareBatchForSRPData> _batchDatas = new List<ProFlareBatchForSRPData>();
    private bool _flareTransformDirty;
    private TransformAccessArray _transformAccessArray;
    public bool useBrightnessThreshold = true;
    public int BrightnessThreshold = 1;
    public bool overdrawDebug;
    public bool useCulling = true;
    public int cullFlaresAfterTime = 5;
    public int cullFlaresAfterCount = 5;
    public float reshowCulledFlaresAfter = 0.3f;
    public bool showAllConnectedFlares;
    public bool VR_Mode;
    public float VR_Depth = 0.2f;
    public TransformAccessArray TransformAccessArray
    {
        get
        {
            return _transformAccessArray;
        }
    }

    public IEnumerable<ProFlareBatchForSRPData> BatchDatas
    {
        get
        {
            return _batchDatas;
        }
    }

    public float DeltaTime
    {
        get
        {
            return Time.deltaTime;
        }
    }

    public ProFlareAtlas CurrentAtlas
    {
        get
        {
            return _atlas;
        }
    }

    private void OnEnable()
    {
        if (_batchDatas == null) return;
        foreach (var data in _batchDatas) data?.Initialize(MaxFlareElementSize);
    }

    private void Dispose()
    {
        if (_transformAccessArray.isCreated) _transformAccessArray.Dispose();
        if (_batchDatas == null) return;
        foreach (var data in _batchDatas) data?.Dispose();
    }

    private void OnDisable()
    {
        Dispose();
    }

    private void OnDestroy()
    {
        Dispose();
    }

    public bool TryGetScheduledFlareData(Camera c, ComputeShader computeShader, int updateKernelIndex, Material material, out ProFlareBatchForSRPData data)
    {
        data = null;
        if (c == null || _batchDatas == null || _flareInstanceIDTable.Count == 0) return false;
        for (int i = 0; i < _batchDatas.Count; i++)
        {
            if (_batchDatas[i].camera == c)
            {
                data = _batchDatas[i];
                break;
            }
        }
        if (data == null)
        {
            data = new ProFlareBatchForSRPData(this, c);
            data.Initialize(MaxFlareElementSize);
            data.UpdateUVData(_atlas);
            _batchDatas.Add(data);
        }
        data.SetShader(computeShader, updateKernelIndex, material);
        if (_flareTransformDirty)
        {
            if (!_transformAccessArray.isCreated) _transformAccessArray = new TransformAccessArray(1024);
            for (int i = 0; i < FlaresList.Count; i++)
            {
                var transform = FlaresList[i] != null ? FlaresList[i].thisTransform : null;
                if (i < _transformAccessArray.length) _transformAccessArray[i] = transform;
                else _transformAccessArray.Add(transform);
            }
            for (int i = _transformAccessArray.length - 1; i >= FlaresList.Count; i--) _transformAccessArray.RemoveAtSwapBack(i);
        }
        data.ScheduleFlares(false);
        _flareTransformDirty = false;
        return true;
    }

    public void RemoveFlare(ProFlare _flare)
    {
        int instanceID = _flare.GetInstanceID();
        if (_flareInstanceIDTable.TryGetValue(instanceID, out int index))
        {
            FlaresList[index] = null;
            _flareEmptyQueue.Enqueue(index);
            _flareInstanceIDTable.Remove(instanceID);
        }
        if (_flareInstanceIDTable.Count == 0) _atlas = null;
        _flareTransformDirty = true;
    }

    public void AddFlare(ProFlare _flare)
    {
        int instanceID = _flare.GetInstanceID();
        if (_flareInstanceIDTable.ContainsKey(instanceID)) return;
        if (_atlas == null)
        {
            _atlas = _flare._Atlas;
            foreach (var data in _batchDatas) data.UpdateUVData(_atlas);
        }
        int index;
        if (_flareEmptyQueue.Count > 0)
        {
            index = _flareEmptyQueue.Dequeue();
            FlaresList[index] = _flare;
        }
        else
        {
            index = FlaresList.Count;
            FlaresList.Add(_flare);
        }
        _flareInstanceIDTable.Add(instanceID, index);
        _flareTransformDirty = true;
    }

    private void LateUpdate()
    {
        for (int i = 0; i < _batchDatas.Count; i++)
        {
            var data = _batchDatas[i];
            data.DisposeCountdown();
            if (!data.IsValid())
            {
                data.Dispose();
                _batchDatas.RemoveAt(i);
                return;
            }
        }
    }

    public void ForceRefresh()
    {
        FlaresList.Clear();
        _flareEmptyQueue.Clear();
        _flareInstanceIDTable.Clear();
        _atlas = null;
        foreach (var flare in (ProFlare[])UnityEngine.Object.FindObjectsOfType(typeof(ProFlare)))
        {
            if (flare._Atlas == _atlas) AddFlare(flare);
        }
    }

    public ProFlareBatchForSRP()
    {
    }
}
