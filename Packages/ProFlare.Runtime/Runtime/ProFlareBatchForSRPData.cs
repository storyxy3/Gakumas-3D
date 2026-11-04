using global::System;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::Unity.Collections;
using global::Unity.Collections.LowLevel.Unsafe;
using global::UnityEngine.Jobs;
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
    private static readonly int _InputBuffer = Shader.PropertyToID("_InputBuffer");
    private static readonly int _ProcessBuffer = Shader.PropertyToID("_ProcessBuffer");
    private static readonly int _OcclusionParams = Shader.PropertyToID("_OcclusionParams");
    internal static readonly int _ElementBuffer = Shader.PropertyToID("_ElementBuffer");
    internal static readonly int _MainTex = Shader.PropertyToID("_MainTex");
    private readonly ProfilingSampler _computeProfilingSampler = new ProfilingSampler("ComputeProFlare");
    private readonly ProfilingSampler _renderProfilingSampler = new ProfilingSampler("Draw ProFlare");
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
            return _indexBuffer;
        }
    }

    public ComputeBuffer FlareElementsBuffer
    {
        get
        {
            return _flareElementsBuffer;
        }
    }

    public ComputeBuffer InputBuffer
    {
        get
        {
            return _inputBuffer;
        }
    }

    public ComputeBuffer ProcessBuffer
    {
        get
        {
            return _processBuffer;
        }
    }

    public int FlareCount
    {
        get
        {
            return _flareCount;
        }
    }

    public int VisibleFlareElementCount
    {
        get
        {
            return _visibleFlareElementCount;
        }
    }

    public bool CanDispose
    {
        get
        {
            return _unusedFrameCount < 0;
        }
    }

    public ProFlareBatchForSRPData(ProFlareBatchForSRP flareBatchForSrp, Camera camera)
    {
        this.flareBatchForSrp = flareBatchForSrp;
        this.camera = camera;
        _materialPropertyBlock = new MaterialPropertyBlock();
    }

    public void SetShader(ComputeShader computeShader, int updateKernelIndex, Material material)
    {
        _computeShader = computeShader;
        _updateKernelIndex = updateKernelIndex;
        _material = material;
        if (_materialPropertyBlock == null) _materialPropertyBlock = new MaterialPropertyBlock();
    }

    public unsafe void ScheduleFlares(bool isDirty)
    {
        _unusedFrameCount = 4;
        _flareCount = 0;
        var flares = flareBatchForSrp.FlaresList;
        if (flares.Count > _flareElementsData.Length)
        {
            Debug.LogError("Flareデータ不整合");
            return;
        }
        if (!_flareUpdateInoutData.IsCreated) return;
        float aspect = camera.aspect;
        var shared = new _003C_003Ec__DisplayClass48_0
        {
            currentTime = Time.time, visibleFlareElementCount = 0, flareElementsData = _flareElementsData
        };
        for (int i = 0; i < flares.Count; i++)
        {
            var flare = flares[i];
            var input = _flareUpdateInoutData[i];
            input.isVisible = flare != null && flare.isVisible && flare._Atlas == flareBatchForSrp.CurrentAtlas &&
                flare.GlobalBrightness >= 0.001f && Mathf.Max(Mathf.Max(flare.GlobalTintColor.r, flare.GlobalTintColor.g), flare.GlobalTintColor.b) >= 0.001f &&
                flare.GlobalScale >= 0.01f && flare.thisTransform.localScale.x >= 0.01f;
            if (input.isVisible) input.offScreenFadeDist = flare.OffScreenFadeDist;
            _flareUpdateInoutData[i] = input;
        }
        var cameraTransform = camera.transform;
        Vector3 cameraPosition = cameraTransform.position;
        var transformJob = new ProFlareUpdateJob
        {
            reversedZ = SystemInfo.usesReversedZBuffer,
            cameraPosition = cameraPosition, cameraForward = cameraTransform.forward,
            vpMatrix = GL.GetGPUProjectionMatrix(camera.projectionMatrix, false) * camera.worldToCameraMatrix,
            inoutData = _flareUpdateInoutData
        };
        transformJob.ScheduleReadOnly(flareBatchForSrp.TransformAccessArray, 32).Complete();
        shared.pFlareUpdateElement = (ProFlareUpdateElementData*)_flareUpdateElementData.GetUnsafePtr();
        int elementCount = 0;
        for (int i = 0; i < flares.Count; i++)
        {
            var transformData = _flareUpdateInoutData[i];
            var input = _inputData[i];
            input.Visible = transformData.isVisible;
            if (!transformData.isVisible)
            {
                _inputData[i] = input;
                continue;
            }
            var flare = flares[i];
            float3 lens = transformData.lensPosition;
            if (flare.sunMode && flare.sunModeTransformA != null && flare.sunModeTransformB != null)
            {
                flare.sunModeTransformA.position = cameraPosition;
                lens = camera.WorldToViewportPoint(flare.sunModeTransformB.position);
                flare.sunModeTransformA.rotation = flare.thisTransform.rotation;
            }
            input.lensPosition = lens;
            input.occlusionScaleSpeed = flare.occlusionScaleSpeed;
            input.occlusionBrightnessSpeed = flare.occlusionBrightnessSpeed;
            float screenFade = 1f;
            bool insideX = lens.x > 0f && lens.x < 1f;
            bool insideY = lens.y > 0f && lens.y < 1f;
            if (!insideX || !insideY)
            {
                float x = insideX ? 0f : lens.x <= 0.5f ? Mathf.Abs(lens.x) : lens.x - 1f;
                float y = insideY ? 0f : lens.y <= 0.5f ? Mathf.Abs(lens.y) : lens.y - 1f;
                screenFade = Mathf.Clamp01(1f - (1f / flare.OffScreenFadeDist) * Mathf.Max(x, y));
            }
            float centerBoost = 0f;
            float range = flare.DynamicCenterRange;
            if (lens.x > 0.5f - range && range > 0f && lens.x < range + 0.5f && lens.y > 0.5f - range && lens.y < range + 0.5f)
                centerBoost = 1f - Mathf.Max(Mathf.Abs(lens.x - 0.5f), Mathf.Abs(lens.y - 0.5f)) * (1f / range);
            float edgeRange = flare.DynamicEdgeRange;
            float bias = flare.DynamicEdgeBias;
            float inner = bias + edgeRange;
            bool innerScreen = lens.x > inner && lens.x < 1f - bias - edgeRange && lens.y > inner && lens.y < 1f - bias - edgeRange;
            float edgeFactor = 0f;
            if (lens.x + edgeRange > bias && lens.x - edgeRange < 1f - bias && lens.y + edgeRange > bias && lens.y - edgeRange < 1f - bias && !innerScreen)
            {
                float x = 0f;
                float y = 0f;
                if (lens.x <= inner || lens.x >= 1f - bias - edgeRange)
                    x = (1f / edgeRange) * (lens.x <= 0.5f ? Mathf.Abs(lens.x - bias - edgeRange) : lens.x - 1f + bias + edgeRange) * 0.5f;
                if (lens.y <= inner || lens.y >= 1f - bias - edgeRange)
                    y = (1f / edgeRange) * (lens.y <= 0.5f ? Mathf.Abs(lens.y - bias - edgeRange) : lens.y - 1f + bias + edgeRange) * 0.5f;
                edgeFactor = Mathf.Max(x, y);
            }
            edgeFactor = flare.DynamicEdgeCurve.Evaluate(edgeFactor);
            float angleFactor = 1f;
            if (flare.UseAngleLimit)
            {
                float angle = Mathf.Abs(Mathf.Clamp(transformData.horizDiffAngle, -flare.maxAngle, flare.maxAngle));
                angleFactor = 0f;
                if (angle <= flare.maxAngle)
                {
                    angleFactor = (1f / (flare.maxAngle * -0.5f)) * angle + 1f;
                    if (flare.UseAngleCurve) angleFactor = flare.AngleCurve.Evaluate(angleFactor);
                }
            }
            float distanceFactor = 1f;
            if (flare.useMaxDistance)
            {
                distanceFactor = 1f - transformData.distance / flare.GlobalMaxDistance;
                if (distanceFactor < 0.001f) input.Visible = false;
            }
            _inputData[i] = input;
            if (!input.Visible) screenFade = 0f;
            var flareState = new _003C_003Ec__DisplayClass48_1 { flareIndex = i };
            var context = new _003C_003Ec__DisplayClass48_2
            {
                flare = flare, scaleMulti = flare.MultiplyScaleByTransformScale ? transformData.localScale : 1f,
                lensPosition = new float3(2f * aspect * (lens.x - 0.5f), 2f * (lens.y - 0.5f), 0f)
            };
            for (int elementIndex = 0; elementIndex < flare.Elements.Count; elementIndex++)
            {
                var element = flare.Elements[elementIndex];
                var state = new _003C_003Ec__DisplayClass48_3
                {
                    element = element, globalColor = flare.GlobalTintColor,
                    addAlpha = 0f, multiplyAlpha = 1f, finalScale = 1f
                };
                if (flare.useDynamicEdgeBoost)
                {
                    state.finalScale += edgeFactor * (element.OverrideDynamicEdgeBoost ? element.DynamicEdgeBoostOverride : flare.DynamicEdgeBoost);
                    state.addAlpha += edgeFactor * (element.OverrideDynamicEdgeBrightness ? element.DynamicEdgeBrightnessOverride : flare.DynamicEdgeBrightness);
                }
                if (flare.useDynamicCenterBoost)
                {
                    state.finalScale += centerBoost * (element.OverrideDynamicCenterBoost ? element.DynamicCenterBoostOverride : flare.DynamicCenterBoost);
                    state.addAlpha += centerBoost * (element.OverrideDynamicCenterBrightness ? element.DynamicCenterBrightnessOverride : flare.DynamicCenterBrightness);
                }
                if (state.finalScale < 0f) state.finalScale = 0f;
                if (flare.UseAngleScale) state.finalScale *= angleFactor;
                if (flare.useDistanceScale) state.finalScale *= distanceFactor;
                if (flare.UseAngleBrightness) state.multiplyAlpha = angleFactor;
                if (flare.useDistanceFade) state.multiplyAlpha *= distanceFactor;
                state.multiplyAlpha *= screenFade;
                if (element.Visible)
                {
                    if (state.finalScale > 0.001f && !flare.DisabledPlayMode && shared.visibleFlareElementCount < _flareElementsData.Length && element.elementTextureID < _uvData.Length)
                    {
                        if (element.type == ProFlareElement.Type.Single)
                            _003CScheduleFlares_003Eg__UpdateElementJobData_007C48_0(element.ElementTint, 1f, element.angle, element.position, ref shared, ref flareState, ref context, ref state);
                        else if (element.type == ProFlareElement.Type.Multi)
                        {
                            for (int subIndex = 0; subIndex < element.subElements.Count; subIndex++)
                            {
                                var sub = element.subElements[subIndex];
                                _003CScheduleFlares_003Eg__UpdateElementJobData_007C48_0(sub.color, sub.scale, element.angle + sub.angle,
                                    element.useRangeOffset ? sub.position : element.position, ref shared, ref flareState, ref context, ref state);
                                if (shared.visibleFlareElementCount >= _flareElementsData.Length) break;
                            }
                        }
                    }
                }
                else state.finalScale = 0f;
                if (element.type == ProFlareElement.Type.Single) elementCount++;
                else if (element.type == ProFlareElement.Type.Multi) elementCount += element.subElements.Count;
            }
        }
        _flareCount = flares.Count;
        _flareElementCount = elementCount;
        _visibleFlareElementCount = shared.visibleFlareElementCount;
        if (_visibleFlareElementCount > 0)
        {
            var job = new ProFlareUpdateElementJob
            {
                VR_Mode = flareBatchForSrp.VR_Mode, VR_Depth = flareBatchForSrp.VR_Depth,
                useBrightnessThreshold = flareBatchForSrp.useBrightnessThreshold, BrightnessThreshold = flareBatchForSrp.BrightnessThreshold,
                OverdrawDebug = flareBatchForSrp.overdrawDebug, InputData = _flareUpdateElementData,
                FlareElementData = _flareElementsData, UVData = _uvData
            };
            _jobHandle = job.Schedule(_visibleFlareElementCount, 32);
        }
    }

    public void CompleteJob()
    {
        _jobHandle.Complete();
    }

    public void ComputeFlares(CommandBuffer cmd)
    {
        int groups = _flareCount / 16 + (_flareCount % 16 != 0 ? 1 : 0);
        if (groups == 0) return;
        using (new ProfilingScope(cmd, _computeProfilingSampler))
        {
            UpdateComputeBuffer(cmd);
            cmd.SetComputeBufferParam(_computeShader, _updateKernelIndex, _InputBuffer, _inputBuffer);
            cmd.SetComputeBufferParam(_computeShader, _updateKernelIndex, _ProcessBuffer, _processBuffer);
            float near = camera.nearClipPlane;
            float far = camera.farClipPlane;
            cmd.SetComputeVectorParam(_computeShader, _OcclusionParams, new Vector4(flareBatchForSrp.cullFlaresAfterTime, Time.deltaTime, (far - near) / (near * far), 1f / far));
            cmd.DispatchCompute(_computeShader, _updateKernelIndex, groups, 1, 1);
        }
    }

    public void RenderFlares(CommandBuffer cmd)
    {
        if (_visibleFlareElementCount == 0) return;
        using (new ProfilingScope(cmd, _renderProfilingSampler))
        {
            _materialPropertyBlock.SetTexture(_MainTex, flareBatchForSrp.overdrawDebug ? Texture2D.whiteTexture : flareBatchForSrp.CurrentAtlas.texture);
            var projection = Matrix4x4.Ortho(-1f, 1f, -1f, 1f, -2f, 2f);
            projection.m00 = 1f / camera.aspect;
            var view = Matrix4x4.identity;
            view.m22 = -1f;
            cmd.SetViewProjectionMatrices(view, projection);
            if (SystemInfo.maxComputeBufferInputsVertex >= 2)
            {
                _materialPropertyBlock.SetBuffer(_ProcessBuffer, _processBuffer);
                _materialPropertyBlock.SetBuffer(_ElementBuffer, _flareElementsBuffer);
                cmd.DrawProcedural(_indexBuffer, Matrix4x4.identity, _material, 0, MeshTopology.Triangles, _visibleFlareElementCount * 6, 1, _materialPropertyBlock);
            }
        }
    }

    private void UpdateComputeBuffer(CommandBuffer cmd)
    {
        cmd.SetBufferData(_inputBuffer, _inputData);
        cmd.SetBufferData(_flareElementsBuffer, _flareElementsData);
    }

    public void UpdateUVData(ProFlareAtlas atlas)
    {
        if (atlas == null || atlas.elementsList == null) return;
        if (_uvData.IsCreated && _uvData.Length != atlas.elementsList.Count)
        {
            _uvData.Dispose(_jobHandle);
            _uvData = default;
        }
        if (!_uvData.IsCreated) _uvData = new NativeArray<float4>(atlas.elementsList.Count, Allocator.Persistent);
        for (int i = 0; i < atlas.elementsList.Count; ++i)
        {
            var uv = atlas.elementsList[i].UV;
            _uvData[i] = new float4(uv.x, uv.y, uv.x + uv.width, uv.y + uv.height);
        }
    }

    private void UpdateElementData(int maxFlareElementSize)
    {
        if (!_flareElementsData.IsCreated) _flareElementsData = new NativeArray<ProFlareElementData>(maxFlareElementSize, Allocator.Persistent);
        if (!_flareUpdateElementData.IsCreated) _flareUpdateElementData = new NativeArray<ProFlareUpdateElementData>(maxFlareElementSize, Allocator.Persistent);
        if (_flareElementsBuffer == null)
        {
            _flareElementsBuffer = new ComputeBuffer(maxFlareElementSize, Marshal.SizeOf<ProFlareElementData>(), ComputeBufferType.Structured);
            _flareElementsBuffer.SetData(_flareElementsData);
        }
    }

    public void Initialize(int maxFlareElementSize)
    {
        _unusedFrameCount = 4;
        if (!_inputData.IsCreated) _inputData = new NativeArray<ProFlareInputData>(maxFlareElementSize, Allocator.Persistent);
        if (_inputBuffer == null)
        {
            _inputBuffer = new ComputeBuffer(maxFlareElementSize, Marshal.SizeOf<ProFlareInputData>(), ComputeBufferType.Structured);
            _inputBuffer.SetData(_inputData);
        }
        if (_processBuffer == null)
        {
            _processBuffer = new ComputeBuffer(maxFlareElementSize, Marshal.SizeOf<ProFlareProcessData>(), ComputeBufferType.Structured);
            var processData = new NativeArray<ProFlareProcessData>(maxFlareElementSize, Allocator.Temp);
            _processBuffer.SetData(processData);
            processData.Dispose();
        }
        UpdateElementData(maxFlareElementSize);
        if (_indexBuffer == null)
        {
            var indices = new NativeArray<int>(6 * maxFlareElementSize, Allocator.Temp);
            for (int i = 0; i < maxFlareElementSize; i++)
            {
                int vertex = i * 4;
                int index = i * 6;
                indices[index] = vertex;
                indices[index + 1] = vertex + 1;
                indices[index + 2] = vertex + 2;
                indices[index + 3] = vertex + 2;
                indices[index + 4] = vertex + 1;
                indices[index + 5] = vertex + 3;
            }
            _indexBuffer = new GraphicsBuffer(GraphicsBuffer.Target.Index | GraphicsBuffer.Target.Raw, indices.Length, 4);
            _indexBuffer.SetData(indices);
            indices.Dispose();
        }
        if (!_flareUpdateInoutData.IsCreated) _flareUpdateInoutData = new NativeArray<ProFlareUpdateInOutputData>(1024, Allocator.Persistent);
    }

    public bool IsValid()
    {
        return camera != null && flareBatchForSrp != null && _uvData.IsCreated && _unusedFrameCount >= 0;
    }

    public void DisposeCountdown()
    {
        _unusedFrameCount--;
    }

    public void Dispose()
    {
        if (_indexBuffer != null)
        {
            _indexBuffer.Dispose();
            _indexBuffer = null;
        }
        if (_uvData.IsCreated) _uvData.Dispose(_jobHandle);
        if (_flareElementsBuffer != null)
        {
            _flareElementsBuffer.Release();
            _flareElementsBuffer = null;
        }
        if (_flareElementsData.IsCreated) _flareElementsData.Dispose(_jobHandle);
        if (_flareUpdateElementData.IsCreated) _flareUpdateElementData.Dispose(_jobHandle);
        if (_inputBuffer != null)
        {
            _inputBuffer.Release();
            _inputBuffer = null;
        }
        if (_inputData.IsCreated) _inputData.Dispose(_jobHandle);
        if (_processBuffer != null)
        {
            _processBuffer.Release();
            _processBuffer = null;
        }
        if (_flareUpdateInoutData.IsCreated) _flareUpdateInoutData.Dispose(_jobHandle);
        Debug.Log("Dispose FlareData (" + (camera != null ? camera.name : "") + ")");
    }

    [CompilerGenerated]
    private static unsafe void _003CScheduleFlares_003Eg__UpdateElementJobData_007C48_0(Color tintColor, float subScale, float angle, float position, ref _003C_003Ec__DisplayClass48_0 P_4, ref _003C_003Ec__DisplayClass48_1 P_5, ref _003C_003Ec__DisplayClass48_2 P_6, ref _003C_003Ec__DisplayClass48_3 P_7)
    {
        var element = P_7.element;
        *P_4.pFlareUpdateElement = new ProFlareUpdateElementData
        {
            IsMulti = element.type == ProFlareElement.Type.Multi, FlareIndex = P_5.flareIndex,
            GlobalColor = P_7.globalColor, TintColor = tintColor, AddAlpha = P_7.addAlpha, MultiplyAlpha = P_7.multiplyAlpha,
            Scale = P_6.scaleMulti * (P_7.finalScale * (P_6.flare.GlobalScale * ((element.Scale * subScale) * 0.01f))),
            Size = element.size, UseRangeOffset = element.useRangeOffset, Position = position,
            OffsetPostion = element.OffsetPostion, LensPosition = P_6.lensPosition, Anamorphic = element.Anamorphic,
            RotateToFlare = element.rotateToFlare, RotationSpeed = element.rotationSpeed,
            RotationOverTime = P_4.currentTime * element.rotationOverTime, Angle = angle, ElementTextureID = element.elementTextureID
        };
        P_4.visibleFlareElementCount++;
        if (P_4.visibleFlareElementCount < P_4.flareElementsData.Length) P_4.pFlareUpdateElement++;
    }
}
