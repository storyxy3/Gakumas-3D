namespace VLB
{
    using global::System.Collections.Generic;
    using global::VLB;

    public class EntityIndexer
    {
        public struct EntityItem
        {
            public int chunkIndex;
            public int arrayIndex;
            public int version;
        }

        private readonly List<EntityItem> _entities;
        private readonly Queue<int> _freeIndices;
        public bool IsValid(Entity entity)
        {
            return default(bool);
        }

        public Entity CreateEntity(int arrayIndex, int chunkIndex)
        {
            return default(Entity);
        }

        public void DestroyEntity(Entity entity)
        {
        }

        public EntityItem GetItem(Entity entity)
        {
            return default(EntityItem);
        }

        public void UpdateIndex(Entity entity, int newArrayIndex)
        {
        }

        public void RemapChunkIndices(List<int> remaper)
        {
        }

        public void Clear()
        {
        }

        public EntityIndexer()
        {
        }
    }
}
