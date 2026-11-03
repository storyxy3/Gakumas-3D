using global::System;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::Unity.Collections;
using global::Unity.Jobs;
using global::Unity.Mathematics;
using global::UnityEngine;
using global::UnityEngine.Rendering;

[Serializable]
public class ProFlareBatchForSRPData : IDisposable
{
    [StructLayout((LayoutKind)3)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass48_0
    {
        public unsafe ProFlareUpdateElementData* pFlareUpdateElement;
        public float currentTime;
        public int visibleFlareElementCount;
        public NativeArray<ProFlareElementData> flareElementsData;
    }

    [StructLayout((LayoutKind)3)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass48_1
    {
        public int flareIndex;
    }

    [StructLayout((LayoutKind)3)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass48_2
    {
        public ProFlare flare;
        public float scaleMulti;
        public float3 lensPosition;
    }

    [StructLayout((LayoutKind)3)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass48_3
    {
        public ProFlareElement element;
        public Color globalColor;
        public float addAlpha;
        public float multiplyAlpha;
        public float finalScale;
    }

    private const int ComputeThreadSize = 16;
    private static readonly int _InputBuffer;
    private static readonly int _ProcessBuffer;
    private static readonly int _OcclusionParams;
    internal static readonly int _ElementBuffer;
    internal static readonly int _MainTex;
    private readonly ProfilingSampler _computeProfilingSampler;
    private readonly ProfilingSampler _renderProfilingSampler;
    public const int DisposeFrame = 4;
    public ProFlareBatchForSRP flareBatchForSrp;
    public Camera camera;
    private ComputeShader _computeShader;
    private int _updateKernelIndex;
    private Material _material;
    private MaterialPropertyBlock _materialPropertyBlock;
    private GraphicsBuffer _indexBuffer;
    private NativeArray<float4> _uvData;
    private ComputeBuffer _flareElementsBuffer;
    private NativeArray<ProFlareElementData> _flareElementsData;
    private NativeArray<ProFlareUpdateElementData> _flareUpdateElementData;
    private NativeArray<ProFlareUpdateInOutputData> _flareUpdateInoutData;
    private JobHandle _jobHandle;
    private ComputeBuffer _inputBuffer;
    private NativeArray<ProFlareInputData> _inputData;
    private ComputeBuffer _processBuffer;
    private int _flareCount;
    private int _flareElementCount;
    private int _visibleFlareElementCount;
    [SerializeField]
    private int _unusedFrameCount;
    public GraphicsBuffer IndexBuffer
    {
        get
        {
            return null;
        }
    }

    public ComputeBuffer FlareElementsBuffer
    {
        get
        {
            return null;
        }
    }

    public ComputeBuffer InputBuffer
    {
        get
        {
            return null;
        }
    }

    public ComputeBuffer ProcessBuffer
    {
        get
        {
            return null;
        }
    }

    public int FlareCount
    {
        get
        {
            return default(int);
        }
    }

    public int VisibleFlareElementCount
    {
        get
        {
            return default(int);
        }
    }

    public bool CanDispose
    {
        get
        {
            return default(bool);
        }
    }

    public ProFlareBatchForSRPData(ProFlareBatchForSRP flareBatchForSrp, Camera camera)
    {
    }

    public void SetShader(ComputeShader computeShader, int updateKernelIndex, Material material)
    {
    }

    public void ScheduleFlares(bool isDirty)
    {
    }

    public void CompleteJob()
    {
    }

    public void ComputeFlares(CommandBuffer cmd)
    {
    }

    public void RenderFlares(CommandBuffer cmd)
    {
    }

    private void UpdateComputeBuffer(CommandBuffer cmd)
    {
    }

    public void UpdateUVData(ProFlareAtlas atlas)
    {
    }

    private void UpdateElementData(int maxFlareElementSize)
    {
    }

    public void Initialize(int maxFlareElementSize)
    {
    }

    public bool IsValid()
    {
        return default(bool);
    }

    public void DisposeCountdown()
    {
    }

    public void Dispose()
    {
    }

    [CompilerGenerated]
    private static void _003CScheduleFlares_003Eg__UpdateElementJobData_007C48_0(Color tintColor, float subScale, float angle, float position, ref _003C_003Ec__DisplayClass48_0 P_4, ref _003C_003Ec__DisplayClass48_1 P_5, ref _003C_003Ec__DisplayClass48_2 P_6, ref _003C_003Ec__DisplayClass48_3 P_7)
    {
    }
}
