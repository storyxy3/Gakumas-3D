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
            return default(TransformAccessArray);
        }
    }

    public IEnumerable<ProFlareBatchForSRPData> BatchDatas
    {
        get
        {
            return null;
        }
    }

    public float DeltaTime
    {
        get
        {
            return default(float);
        }
    }

    public ProFlareAtlas CurrentAtlas
    {
        get
        {
            return null;
        }
    }

    private void OnEnable()
    {
    }

    private void Dispose()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    public bool TryGetScheduledFlareData(Camera c, ComputeShader computeShader, int updateKernelIndex, Material material, out ProFlareBatchForSRPData data)
    {
        throw null;
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
    }

    public void ForceRefresh()
    {
    }

    public ProFlareBatchForSRP()
    {
    }
}
