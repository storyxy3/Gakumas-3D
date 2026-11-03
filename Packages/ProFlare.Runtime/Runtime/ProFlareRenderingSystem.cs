using global::UnityEngine;

public class ProFlareRenderingSystem
{
    private ComputeShader _computeShader;
    private Material _material;
    private ProFlareBatchForSRP _proFlare;
    private static readonly int _ProcessBuffer;
    private static readonly string UpdateKernelName;
    private int _updateKernelIndex;
    public ProFlareRenderingSystem(ComputeShader flareComputeShader, Material flareMaterial)
    {
    }

    public bool TryGetFlareData(Camera camera, out ProFlareBatchForSRPData proFlareData)
    {
        throw null;
    }
}
