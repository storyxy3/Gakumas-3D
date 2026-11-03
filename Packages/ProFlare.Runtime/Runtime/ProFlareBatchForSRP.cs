using global::System;
using global::System.Collections.Generic;
using global::UnityEngine;
using global::UnityEngine.Jobs;

[ExecuteAlways]
[DefaultExecutionOrder(-100)]
[RequireComponent(typeof(Camera))]
public class ProFlareBatchForSRP : MonoBehaviour
{
    public bool debugMessages;
    [NonSerialized]
    private ProFlareAtlas _atlas;
    public const int MaxFlareSize = 1024;
    [NonSerialized]
    public List<ProFlare> FlaresList;
    private Queue<int> _flareEmptyQueue;
    private Dictionary<int, int> _flareInstanceIDTable;
    public int MaxFlareElementSize;
    private List<ProFlareBatchForSRPData> _batchDatas;
    private bool _flareTransformDirty;
    private TransformAccessArray _transformAccessArray;
    public bool useBrightnessThreshold;
    public int BrightnessThreshold;
    public bool overdrawDebug;
    public bool useCulling;
    public int cullFlaresAfterTime;
    public int cullFlaresAfterCount;
    public float reshowCulledFlaresAfter;
    public bool showAllConnectedFlares;
    public bool VR_Mode;
    public float VR_Depth;
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
    }

    public void AddFlare(ProFlare _flare)
    {
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
