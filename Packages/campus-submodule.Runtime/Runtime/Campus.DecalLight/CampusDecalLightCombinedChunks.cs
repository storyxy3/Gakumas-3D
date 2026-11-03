namespace Campus.DecalLight
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::VL.EntitySystem;

    public class CampusDecalLightCombinedChunks : ICombinedChunks, IDisposable, IEntityChunk<CampusDecalLight, int, CampusDecalLightEntityChunk>
    {
        public Mesh mesh;
        [CompilerGenerated]
        private CampusDecalLightEntityChunk _003CentityChunk_003Ek__BackingField;
        [CompilerGenerated]
        private CampusDecalLightCachedChunk _003CCachedChunk_003Ek__BackingField;
        [CompilerGenerated]
        private CampusDecalLightCulledChunk _003CCulledChunk_003Ek__BackingField;
        [CompilerGenerated]
        private CampusDecalLightResultChunk _003CResultChunk_003Ek__BackingField;
        public CampusDecalLightEntityChunk entityChunk
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CampusDecalLightCachedChunk CachedChunk
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CampusDecalLightCulledChunk CulledChunk
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CampusDecalLightResultChunk ResultChunk
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public void Create()
        {
        }

        public void CreateEntityChunk(int chunkKey)
        {
        }

        public void SetCapacity(int newCapacity)
        {
        }

        public void Push()
        {
        }

        public void RemoveAtSwapBack(int arrayIndex)
        {
        }

        public void Dispose()
        {
        }

        public CampusDecalLightCombinedChunks()
        {
        }
    }
}
