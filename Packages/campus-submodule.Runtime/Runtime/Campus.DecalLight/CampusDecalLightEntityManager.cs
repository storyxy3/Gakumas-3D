namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::Unity.Mathematics;
    using global::UnityEngine.Rendering;
    using global::System;
    using global::VL.EntitySystem;

    public class CampusDecalLightEntityManager : EntityManager<CampusDecalLight, int, CampusDecalLightCombinedChunks, CampusDecalLightEntityChunk>
    {
        private Mesh _boxMesh;
        protected override void UpdateChunk(ref CampusDecalLightCombinedChunks chunks, int arrayIndex, CampusDecalLight component)
        {
            var cached = chunks.CachedChunk;
            if (_boxMesh == null) _boxMesh = CreateBoxMesh();
            chunks.mesh = _boxMesh;
            cached.uvScaleBias[arrayIndex] = component.UvScaleBias;
            float4 light;
            switch (component.LightType)
            {
                case CampusDecalLight.LightShapeType.Box:
                    light = new float4(component.Size.z, component.Area.x, component.Area.y, 0f);
                    break;
                case CampusDecalLight.LightShapeType.Capsule:
                    light = new float4(component.Size.z, component.Size.x - 2f * component.Size.z, 0f, 0f);
                    break;
                case CampusDecalLight.LightShapeType.Sphere:
                    light = new float4(component.Size.x, 0f, 0f, 0f);
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
            light.w = component.SpecularOn ? 1f : 0f;
            cached.lightParams[arrayIndex] = light;
            Color color = component.Color;
            cached.colors[arrayIndex] = new Color(Mathf.GammaToLinearSpace(color.r) * component.Intensity,
                Mathf.GammaToLinearSpace(color.g) * component.Intensity, Mathf.GammaToLinearSpace(color.b) * component.Intensity,
                component.IsFlatColor ? 1f : 0f);
            cached.sizeOffsets[arrayIndex] = component.SizeOffset;
        }

        public override void Dispose()
        {
            base.Dispose();
            if (_boxMesh != null) CoreUtils.Destroy(_boxMesh);
        }

        private static Mesh CreateBoxMesh()
        {
            var vertices = new[]
            {
                new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f),
                new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f),
                new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f)
            };
            var indices = new[] { 0, 1, 2, 0, 2, 3, 1, 6, 2, 1, 5, 6, 3, 4, 0, 3, 7, 4, 0, 5, 1, 0, 4, 5, 2, 6, 7, 2, 7, 3, 5, 4, 7, 5, 7, 6 };
            var mesh = new Mesh { hideFlags = (HideFlags)52, indexFormat = IndexFormat.UInt16, vertices = vertices, triangles = indices };
            mesh.UploadMeshData(true);
            return mesh;
        }

        public CampusDecalLightEntityManager()
        {
        }
    }
}
