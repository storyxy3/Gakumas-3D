namespace Campus.DecalLight
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Unity.Collections;
    using global::CanvasRT;
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightDrawSystem : IDisposable
    {
        public static readonly int PositionAndAtten = Shader.PropertyToID("_PositionAndAtten");
        public static readonly int Params = Shader.PropertyToID("_Params");
        public static readonly int Params2 = Shader.PropertyToID("_Params2");
        public static readonly int Color = Shader.PropertyToID("_Color");
        public static readonly int UVScaleOffset = Shader.PropertyToID("_UVScaleOffset");
        public static readonly int _DecalLightTexture = Shader.PropertyToID("_DecalLightTexture");
        public const int MaxLightCount = 128;
        private readonly CampusDecalLightEntityManager _entityManager;
        private readonly ProfilingSampler _drawSampler;
        private readonly Material _sourceMaterial;
        private readonly int _stencilPass;
        private readonly int _maskPass;
        private readonly int _clearStencilPass;
        private readonly int _resolvePass;
        private Matrix4x4[] _localToWorlds;
        private Vector4[] _positionAndAttens;
        private Matrix4x4[] _params;
        private Vector4[] _colors;
        private Vector4[] _uvScaleOffsets;
        private Dictionary<int, Material> _materials;
        internal bool isSystemExecuted;
        public bool IsActive
        {
            get
            {
                return isSystemExecuted && _entityManager.combinedChunksList != null;
            }
        }

        public CampusDecalLightDrawSystem(CampusDecalLightEntityManager entityManager, Material sourceMaterial)
        {
            _entityManager = entityManager;
            _sourceMaterial = sourceMaterial;
            _localToWorlds = new Matrix4x4[MaxLightCount];
            _positionAndAttens = new Vector4[MaxLightCount];
            _params = new Matrix4x4[MaxLightCount];
            _colors = new Vector4[MaxLightCount];
            _uvScaleOffsets = new Vector4[MaxLightCount];
            _materials = new Dictionary<int, Material>();
            _drawSampler = new ProfilingSampler("CampusDecalLight.Draw");
        }

        public void Dispose()
        {
            foreach (var pair in _materials)
            {
                if (pair.Value != null) CoreUtils.Destroy(pair.Value);
            }
            _materials.Clear();
        }

        public void CompleteJob()
        {
            if (!IsActive) return;
            foreach (var chunks in _entityManager.combinedChunksList)
            {
                if (chunks == null) continue;
                chunks.CulledChunk.currentJobHandle.Complete();
                chunks.ResultChunk.currentJobHandle.Complete();
            }
        }

        public void Execute(CommandBuffer cmd)
        {
            if (!IsActive || !SystemInfo.supportsInstancing) return;
            Texture texture = CanvasRenderTexture.GetCanvasRenderTexture(0);
            if (texture == null) texture = Texture2D.whiteTexture;
            using (new ProfilingScope(cmd, _drawSampler))
            {
                foreach (var chunks in _entityManager.combinedChunksList)
                {
                    if (chunks == null) continue;
                    int lightType = chunks.entityChunk.chunkKey;
                    int count = chunks.CulledChunk.culledCount[0];
                    if (count > MaxLightCount)
                    {
                        Debug.LogError(string.Format("DecalLight ({0}) の描画上限を超えています。{1} > {2}", (CampusDecalLight.LightShapeType)lightType, count, MaxLightCount));
                        continue;
                    }
                    var cached = chunks.CachedChunk;
                    var result = chunks.ResultChunk;
                    var mesh = chunks.mesh;
                    if (!_materials.TryGetValue(lightType, out var drawMaterial))
                    {
                        drawMaterial = new Material(_sourceMaterial) { hideFlags = HideFlags.HideAndDontSave, enableInstancing = true };
                        switch ((CampusDecalLight.LightShapeType)lightType)
                        {
                            case CampusDecalLight.LightShapeType.Box: CoreUtils.SetKeyword(drawMaterial, "_BOX", true); break;
                            case CampusDecalLight.LightShapeType.Capsule: CoreUtils.SetKeyword(drawMaterial, "_CAPSULE", true); break;
                            case CampusDecalLight.LightShapeType.Sphere: CoreUtils.SetKeyword(drawMaterial, "_SPHERE", true); break;
                        }
                        _materials.Add(lightType, drawMaterial);
                    }
                    NativeArray<Matrix4x4>.Copy(result.lightToWorldsDraw.Reinterpret<Matrix4x4>(), 0, _localToWorlds, 0, count);
                    NativeArray<Vector4>.Copy(result.positionAndAttensDraw.Reinterpret<Vector4>(), 0, _positionAndAttens, 0, count);
                    NativeArray<Matrix4x4>.Copy(result.paramsDraw.Reinterpret<Matrix4x4>(), 0, _params, 0, count);
                    NativeArray<Vector4>.Copy(result.colorsDraw.Reinterpret<Vector4>(), 0, _colors, 0, count);
                    NativeArray<Vector4>.Copy(result.uvScaleOffsetsDraw.Reinterpret<Vector4>(), 0, _uvScaleOffsets, 0, count);
                    cached.propertyBlock.SetVectorArray(PositionAndAtten, _positionAndAttens);
                    cached.propertyBlock.SetMatrixArray(Params, _params);
                    cached.propertyBlock.SetVectorArray(Color, _colors);
                    cached.propertyBlock.SetVectorArray(UVScaleOffset, _uvScaleOffsets);
                    cached.propertyBlock.SetTexture(_DecalLightTexture, texture);
                    cmd.DrawMeshInstanced(mesh, 0, drawMaterial, 0, _localToWorlds, count, cached.propertyBlock);
                }
            }
            isSystemExecuted = false;
        }
    }
}
