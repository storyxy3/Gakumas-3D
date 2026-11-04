using global::UnityEngine;

public class ProFlareRenderingSystem
{
    private ComputeShader _computeShader;
    private Material _material;
    private ProFlareBatchForSRP _proFlare;
    private static readonly int _ProcessBuffer = Shader.PropertyToID("_ProcessBuffer");
    private static readonly string UpdateKernelName = "Update";
    private int _updateKernelIndex;
    public ProFlareRenderingSystem(ComputeShader flareComputeShader, Material flareMaterial)
    {
        bool supportsComputeShaders = SystemInfo.supportsComputeShaders;
        _computeShader = flareComputeShader;
        _material = flareMaterial;
        _material.enableInstancing = true;
        if (_computeShader != null)
        {
            if (!(supportsComputeShaders & _computeShader.HasKernel(UpdateKernelName))) return;
        }
        else if (!supportsComputeShaders) return;
        if (_material != null) _updateKernelIndex = _computeShader.FindKernel(UpdateKernelName);
    }

    public bool TryGetFlareData(Camera camera, out ProFlareBatchForSRPData proFlareData)
    {
        proFlareData = null;
        if (_proFlare == null && Camera.main != null) Camera.main.TryGetComponent(out _proFlare);
        if (_proFlare == null || _proFlare.CurrentAtlas == null || _proFlare.CurrentAtlas.texture == null) return false;
        return _proFlare.TryGetScheduledFlareData(camera, _computeShader, _updateKernelIndex, _material, out proFlareData);
    }
}
