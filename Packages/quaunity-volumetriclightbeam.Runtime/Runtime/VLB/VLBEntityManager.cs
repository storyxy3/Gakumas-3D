namespace VLB
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Profiling;
    using global::UnityEngine;
    using global::Unity.Mathematics;
    using global::VLB;

    public class VLBEntityManager : IDisposable
    {
        internal struct CombinedChunks
        {
            public VLBEntityChunk entityChunk;
            public VLBCachedChunk cachedChunk;
            public VLBCulledChunk culledChunk;
            public VLBDrawCallChunk drawCallChunk;
            public int previousChunkIndex;
            public bool valid;
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Comparison<CombinedChunks> _003C_003E9__19_0;
            public _003C_003Ec()
            {
            }

            internal int _003CUpdate_003Eb__19_0(CombinedChunks a, CombinedChunks b)
            {
                if (a.valid && !b.valid) return -1;
                if (!a.valid && b.valid) return 1;
                return a.entityChunk.materialID.CompareTo(b.entityChunk.materialID);
            }
        }

        public const int MaxVLBSize = 200;
        private Dictionary<int, int> _materialIDToChunkIndex = new Dictionary<int, int>();
        internal List<VLBEntityChunk> entityChunks = new List<VLBEntityChunk>();
        internal List<VLBCachedChunk> cachedChunks = new List<VLBCachedChunk>();
        internal List<VLBCulledChunk> culledChunks = new List<VLBCulledChunk>();
        internal List<VLBDrawCallChunk> drawCallChunks = new List<VLBDrawCallChunk>();
        internal int chunkCount;
        private EntityIndexer _entityIndexer = new EntityIndexer();
        private List<CombinedChunks> _combinedChunks = new List<CombinedChunks>();
        private List<int> _combinedChunkRemmap = new List<int>();
        private CustomSampler _samplerUpdateAllEntity;
        public bool IsValid(Entity entity)
        {
            return _entityIndexer.IsValid(entity);
        }

        public Entity CreateEntity(VolumetricLightBeamSD component)
        {
            int index = CreateChunkIndex(component);
            int arrayIndex = entityChunks[index].count;
            var entity = _entityIndexer.CreateEntity(arrayIndex, index);
            var entityChunk = entityChunks[index];
            var cachedChunk = cachedChunks[index];
            var culledChunk = culledChunks[index];
            var drawCallChunk = drawCallChunks[index];
            if (entityChunk.capacity == entityChunk.count)
            {
                int capacity = Math.Max(8, entityChunk.capacity * 2);
                entityChunk.SetCapacity(capacity);
                cachedChunk.SetCapacity(capacity);
                culledChunk.SetCapacity(capacity);
                drawCallChunk.SetCapacity(capacity);
            }
            entityChunk.Push();
            cachedChunk.Push();
            culledChunk.Push();
            drawCallChunk.Push();
            entityChunk.components[arrayIndex] = component;
            entityChunk.entities[arrayIndex] = entity;
            entityChunk.transformAccessArray.Add(component.transform);
            UpdateEntityData(entity, component);
            return entity;
        }

        public VLBEntityManager()
        {
            _samplerUpdateAllEntity = CustomSampler.Create("VLBUpdateAllEntity.Execute");
        }

        private int CreateChunkIndex(VolumetricLightBeamSD vlb)
        {
            var properties = vlb.GetStaticProps();
            int materialID = properties.GetMaterialID();
            if (_materialIDToChunkIndex.TryGetValue(materialID, out int index)) return index;
            var material = Config.Instance.NewMaterialTransient(ShaderMode.SD, true);
            if (material) properties.ApplyToMaterial(material);
            var propertyBlock = new MaterialPropertyBlock();
            entityChunks.Add(new VLBEntityChunk { materialID = materialID, material = material });
            cachedChunks.Add(new VLBCachedChunk { propertyBlock = propertyBlock });
            culledChunks.Add(new VLBCulledChunk());
            drawCallChunks.Add(new VLBDrawCallChunk());
            _combinedChunks.Add(default);
            _combinedChunkRemmap.Add(0);
            _materialIDToChunkIndex.Add(materialID, chunkCount);
            return chunkCount++;
        }

        public void UpdateAllEntityData()
        {
            for (int i = 0; i < chunkCount; i++)
            {
                var chunks = _combinedChunks[i];
                chunks.cachedChunk.currentJobHandle.Complete();
                for (int j = 0; j < chunks.entityChunk.count; j++)
                    UpdateEntityData(chunks.entityChunk.entities[j], chunks.entityChunk.components[j], false);
            }
        }

        public void UpdateEntityData(Entity entity, VolumetricLightBeamSD vlb, bool checkJobHandle = true)
        {
            var item = _entityIndexer.GetItem(entity);
            var chunk = cachedChunks[item.chunkIndex];
            if (checkJobHandle) chunk.currentJobHandle.Complete();
            vlb.UpdateAfterManualPropertyChange();
            int index = item.arrayIndex;
            Color color = vlb.color;
            chunk.colors[index] = color;
            chunk.coneRadiuses[index] = new float2(vlb.coneRadiusStart, vlb.coneRadiusEnd);
            chunk.glares[index] = new float2(vlb.glareFrontal, vlb.glareBehind);
            chunk.fallOff[index] = new float4(vlb.fallOffStart, vlb.fallOffEnd, vlb.maxGeometryDistance, vlb.attenuationLerpLinearQuad);
            Noise3D.LoadIfNeeded();
            Vector3 velocity = vlb.noiseVelocityUseGlobal ? Config.Instance.globalNoiseVelocity : vlb.noiseVelocityLocal;
            float noiseScale = vlb.noiseScaleUseGlobal ? Config.Instance.globalNoiseScale : vlb.noiseScaleLocal;
            chunk.noiseVelocity[index] = new float4(velocity.x, velocity.y, velocity.z, noiseScale);
            chunk.noiseParameter[index] = new float2(vlb.noiseIntensity, vlb.noiseMode == NoiseMode.WorldSpace ? 0f : 1f);
            chunk.entityIndex[index] = vlb.entity.index;
            chunk.coneApexOffsetZ[index] = vlb.coneApexOffsetZ;
            chunk.coneAngle[index] = vlb.coneAngle;
            chunk.cameraClippingDistance[index] = vlb.cameraClippingDistance;
            chunk.fresnelPow[index] = vlb.fresnelPow;
            chunk.depthBlendDistance[index] = vlb.depthBlendDistance;
            chunk.shadowIntensity[index] = vlb.shadowIntensity;
            vlb.GetInsideAndOutsideIntensity(out float inside, out float outside);
            chunk.intensity[index] = new float2(inside, outside);
            float radius = Mathf.Max(vlb.coneRadiusStart, vlb.coneRadiusEnd);
            chunk.rotations[index] = vlb.beamInternalLocalRotation;
            chunk.scales[index] = new float3(radius, radius, vlb.maxGeometryDistance);
            chunk.enableds[index] = Mathf.Max(Mathf.Max(color.r, color.g), color.b) >= 0.001f && Mathf.Min(inside, outside) >= 0.001f;
        }

        public void DestroyEntity(Entity entity)
        {
            if (!_entityIndexer.IsValid(entity)) return;
            var item = _entityIndexer.GetItem(entity);
            _entityIndexer.DestroyEntity(entity);
            var entityChunk = entityChunks[item.chunkIndex];
            var cachedChunk = cachedChunks[item.chunkIndex];
            var culledChunk = culledChunks[item.chunkIndex];
            var drawCallChunk = drawCallChunks[item.chunkIndex];
            int last = entityChunk.count - 1;
            if (last != item.arrayIndex) _entityIndexer.UpdateIndex(entityChunk.entities[last], item.arrayIndex);
            drawCallChunk.currentJobHandle.Complete();
            entityChunk.RemoveAtSwapBack(item.arrayIndex);
            cachedChunk.RemoveAtSwapBack(item.arrayIndex);
            culledChunk.RemoveAtSwapBack(item.arrayIndex);
            drawCallChunk.RemoveAtSwapBack(item.arrayIndex);
        }

        public void Update()
        {
            for (int i = 0; i < chunkCount; i++)
            {
                _combinedChunks[i] = new CombinedChunks
                {
                    entityChunk = entityChunks[i], cachedChunk = cachedChunks[i],
                    culledChunk = culledChunks[i], drawCallChunk = drawCallChunks[i],
                    previousChunkIndex = i, valid = entityChunks[i].count != 0
                };
            }
            _combinedChunks.Sort(_003C_003Ec._003C_003E9__19_0 ??
                (_003C_003Ec._003C_003E9__19_0 = _003C_003Ec._003C_003E9._003CUpdate_003Eb__19_0));
            bool changed = false;
            for (int i = 0; i < chunkCount; i++)
            {
                if (i != _combinedChunks[i].previousChunkIndex || !_combinedChunks[i].valid)
                {
                    changed = true;
                    break;
                }
            }
            if (!changed) return;
            _materialIDToChunkIndex.Clear();
            int validCount = 0;
            for (int i = 0; i < chunkCount; i++)
            {
                var chunks = _combinedChunks[i];
                if (chunks.valid)
                {
                    entityChunks[i] = chunks.entityChunk;
                    cachedChunks[i] = chunks.cachedChunk;
                    culledChunks[i] = chunks.culledChunk;
                    drawCallChunks[i] = chunks.drawCallChunk;
                    if (!_materialIDToChunkIndex.ContainsKey(entityChunks[i].materialID))
                        _materialIDToChunkIndex.Add(entityChunks[i].materialID, i);
                    _combinedChunkRemmap[chunks.previousChunkIndex] = i;
                    validCount++;
                }
                else
                {
                    chunks.entityChunk.currentJobHandle.Complete();
                    chunks.cachedChunk.currentJobHandle.Complete();
                    chunks.culledChunk.currentJobHandle.Complete();
                    chunks.drawCallChunk.currentJobHandle.Complete();
                    chunks.entityChunk.Dispose();
                    chunks.cachedChunk.Dispose();
                    chunks.culledChunk.Dispose();
                    chunks.drawCallChunk.Dispose();
                }
            }
            if (chunkCount > validCount)
            {
                entityChunks.RemoveRange(validCount, chunkCount - validCount);
                cachedChunks.RemoveRange(validCount, chunkCount - validCount);
                culledChunks.RemoveRange(validCount, chunkCount - validCount);
                drawCallChunks.RemoveRange(validCount, chunkCount - validCount);
                _combinedChunks.RemoveRange(validCount, chunkCount - validCount);
                chunkCount = validCount;
            }
            _entityIndexer.RemapChunkIndices(_combinedChunkRemmap);
        }

        public void Dispose()
        {
            _materialIDToChunkIndex.Clear();
            _combinedChunks.Clear();
            foreach (var chunk in entityChunks) chunk.currentJobHandle.Complete();
            foreach (var chunk in cachedChunks) chunk.currentJobHandle.Complete();
            foreach (var chunk in culledChunks) chunk.currentJobHandle.Complete();
            foreach (var chunk in drawCallChunks) chunk.currentJobHandle.Complete();
            foreach (var chunk in entityChunks) chunk.Dispose();
            foreach (var chunk in cachedChunks) chunk.Dispose();
            foreach (var chunk in culledChunks) chunk.Dispose();
            foreach (var chunk in drawCallChunks) chunk.Dispose();
            _entityIndexer.Clear();
            _materialIDToChunkIndex.Clear();
            entityChunks.Clear();
            cachedChunks.Clear();
            culledChunks.Clear();
            drawCallChunks.Clear();
            _combinedChunks.Clear();
            chunkCount = 0;
        }
    }
}
