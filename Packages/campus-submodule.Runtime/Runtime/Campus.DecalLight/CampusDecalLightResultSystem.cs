namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightResultSystem
    {
        [BurstCompile]
        public struct ResultJob : IJob
        {
            public CampusDecalLight.LightShapeType lightType;
            public float3 worldSpaceCameraPos;
            public int count;
            public NativeArray<int> visibleIndices;
            [ReadOnly]
            public NativeArray<float4> lightParams;
            [ReadOnly]
            public NativeArray<Color> colors;
            [ReadOnly]
            public NativeArray<float4> uvScaleBiases;
            [ReadOnly]
            public NativeArray<float4x4> lightToWorlds;
            [ReadOnly]
            public NativeArray<float4x4> normalToWorlds;
            [WriteOnly]
            public NativeArray<float4x4> lightToWorldsDraw;
            [WriteOnly]
            public NativeArray<float4> positionAndAttensDraw;
            [WriteOnly]
            public NativeArray<float4x4> paramsDraw;
            [WriteOnly]
            public NativeArray<float4> colorsDraw;
            [WriteOnly]
            public NativeArray<float4> uvScaleOffsetsDraw;
            [WriteOnly]
            public NativeArray<int> culledCount;
            public void Execute()
            {
            }

            private void UpdateParams(int index, int culledIndex)
            {
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private CampusDecalLightDrawSystem _drawSystem;
        private ProfilingSampler _sampler;
        public CampusDecalLightResultSystem(CampusDecalLightEntityManager entityManager, CampusDecalLightDrawSystem drawSystem)
        {
        }

        public void Execute(Vector3 cameraPosition, Matrix4x4 viewMatrix)
        {
        }

        private void Execute(CampusDecalLightCachedChunk cachedChunk, CampusDecalLightCulledChunk culledChunk, CampusDecalLightResultChunk resultChunk, CampusDecalLight.LightShapeType lightType, Vector3 cameraPosition)
        {
        }
    }
}
