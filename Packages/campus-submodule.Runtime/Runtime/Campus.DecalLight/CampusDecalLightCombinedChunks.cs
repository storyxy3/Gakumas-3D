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
                return _003CentityChunk_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CentityChunk_003Ek__BackingField = value;
            }
        }

        public CampusDecalLightCachedChunk CachedChunk
        {
            [CompilerGenerated]
            get
            {
                return _003CCachedChunk_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCachedChunk_003Ek__BackingField = value;
            }
        }

        public CampusDecalLightCulledChunk CulledChunk
        {
            [CompilerGenerated]
            get
            {
                return _003CCulledChunk_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCulledChunk_003Ek__BackingField = value;
            }
        }

        public CampusDecalLightResultChunk ResultChunk
        {
            [CompilerGenerated]
            get
            {
                return _003CResultChunk_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CResultChunk_003Ek__BackingField = value;
            }
        }

        public void Create()
        {
            var propertyBlock = new MaterialPropertyBlock();
            CachedChunk = new CampusDecalLightCachedChunk { propertyBlock = propertyBlock };
            CulledChunk = new CampusDecalLightCulledChunk();
            ResultChunk = new CampusDecalLightResultChunk();
        }

        public void CreateEntityChunk(int chunkKey)
        {
            entityChunk = new CampusDecalLightEntityChunk { chunkKey = chunkKey };
        }

        public void SetCapacity(int newCapacity)
        {
            entityChunk.SetCapacity(newCapacity);
            CachedChunk.SetCapacity(newCapacity);
            CulledChunk.SetCapacity(newCapacity);
            ResultChunk.SetCapacity(newCapacity);
        }

        public void Push()
        {
            entityChunk.Push();
            CachedChunk.Push();
            CulledChunk.Push();
            ResultChunk.Push();
        }

        public void RemoveAtSwapBack(int arrayIndex)
        {
            entityChunk.currentJobHandle.Complete();
            CachedChunk.currentJobHandle.Complete();
            CulledChunk.currentJobHandle.Complete();
            ResultChunk.currentJobHandle.Complete();
            entityChunk.RemoveAtSwapBack(arrayIndex);
            CachedChunk.RemoveAtSwapBack(arrayIndex);
            CulledChunk.RemoveAtSwapBack(arrayIndex);
            ResultChunk.RemoveAtSwapBack(arrayIndex);
        }

        public void Dispose()
        {
            entityChunk.currentJobHandle.Complete();
            CachedChunk.currentJobHandle.Complete();
            CulledChunk.currentJobHandle.Complete();
            ResultChunk.currentJobHandle.Complete();
            entityChunk.Dispose();
            CachedChunk.Dispose();
            CulledChunk.Dispose();
            ResultChunk.Dispose();
        }

        public CampusDecalLightCombinedChunks()
        {
        }
    }
}
