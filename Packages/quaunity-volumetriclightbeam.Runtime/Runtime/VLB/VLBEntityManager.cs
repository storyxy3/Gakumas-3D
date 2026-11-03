namespace VLB
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine.Profiling;
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

        public const int MaxVLBSize = 200;
        private Dictionary<int, int> _materialIDToChunkIndex;
        internal List<VLBEntityChunk> entityChunks;
        internal List<VLBCachedChunk> cachedChunks;
        internal List<VLBCulledChunk> culledChunks;
        internal List<VLBDrawCallChunk> drawCallChunks;
        internal int chunkCount;
        private EntityIndexer _entityIndexer;
        private List<CombinedChunks> _combinedChunks;
        private List<int> _combinedChunkRemmap;
        private CustomSampler _samplerUpdateAllEntity;
        public bool IsValid(Entity entity)
        {
            return default(bool);
        }

        public Entity CreateEntity(VolumetricLightBeamSD component)
        {
            return default(Entity);
        }

        public VLBEntityManager()
        {
        }

        private int CreateChunkIndex(VolumetricLightBeamSD vlb)
        {
            return default(int);
        }

        public void UpdateAllEntityData()
        {
        }

        public void UpdateEntityData(Entity entity, VolumetricLightBeamSD vlb, bool checkJobHandle = true)
        {
        }

        public void DestroyEntity(Entity entity)
        {
        }

        public void Update()
        {
        }

        public void Dispose()
        {
        }
    }
}
