namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::VL.EntitySystem;

    public class CampusDecalLightEntityManager : EntityManager<CampusDecalLight, int, CampusDecalLightCombinedChunks, CampusDecalLightEntityChunk>
    {
        private Mesh _boxMesh;
        protected override void UpdateChunk(ref CampusDecalLightCombinedChunks chunks, int arrayIndex, CampusDecalLight component)
        {
        }

        public override void Dispose()
        {
        }

        private static Mesh CreateBoxMesh()
        {
            return null;
        }

        public CampusDecalLightEntityManager()
        {
        }
    }
}
