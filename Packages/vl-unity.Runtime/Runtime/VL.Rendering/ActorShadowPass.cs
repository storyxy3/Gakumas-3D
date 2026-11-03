namespace VL.Rendering
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class ActorShadowPass : ScriptableRenderPass
    {
        public struct ActorShadowData
        {
            public Matrix4x4 viewMatrix;
            public Matrix4x4 projMatrix;
            public Matrix4x4 shadowTransform;
            public Matrix4x4 lightToWorldMatrix;
            public int resolution;
            public float startDistance2;
            public float endDistance2;
            public float fade;
            public float strength;
            public float useOffset;
            public float facePartsStrength;
            public void Clear()
            {
            }
        }

        public delegate Bounds GetBoundsEvent(Camera camera, float far, int resolution);
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass33_0
        {
            public CameraPlanes cullingPlane;
            public int actorCount;
            public Bounds bounds;
        }

        [CompilerGenerated]
        private static GetBoundsEvent m_getBounds;
        public static readonly string _ACTOR_SHADOWS;
        private ShaderTagId _shaderTag;
        private readonly int _ShadowBias;
        private readonly int _LightDirection;
        private readonly int _WorldToActorShadow;
        private readonly int _ActorShadowParams;
        private readonly int _ActorShadowParams2;
        private readonly int _ActorShadowOffset0;
        private readonly int _ActorShadowOffset1;
        private readonly int _ActorShadowmapSize;
        private static readonly string _ActorShadowmapTexture;
        private int _ActorShadowmapTextureID;
        private RTHandle _actorShadowmapTexture;
        private ActorShadowData _actorShadowData;
        private Vector4 _actorShadowBias;
        private FilteringSettings _filteringSettings;
        private bool _supportsShadow;
        private static readonly Vector3[] _frustumCornersCached;
        private static readonly Vector3[] _transformBoundsCached;
        public static event GetBoundsEvent getBounds
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public ActorShadowPass(ref DrawActorShadowPass.Settings settings)
        {
        }

        public void Dispose()
        {
        }

        public void Setup(ref RenderingData renderingData, ref DrawActorShadowPass.Settings settings)
        {
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
        }

        private void DrawShadow(CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
        }

        private void Clear()
        {
        }

        private Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
        {
            return default(Matrix4x4);
        }

        private bool UpdateShadowData(ref RenderingData renderingData, ref DrawActorShadowPass.Settings settings, int resolution)
        {
            return default(bool);
        }

        private Vector4 GetShadowBias(ref Matrix4x4 lightProjectionMatrix, float shadowResolution)
        {
            return default(Vector4);
        }

        private void SetupActorShadowCasterConstants(CommandBuffer cmd, ref Matrix4x4 lightToWorldMatrix, Vector4 shadowBias)
        {
        }

        private void SetupActorShadowReceiverConstants(CommandBuffer cmd)
        {
        }

        [CompilerGenerated]
        private static void _003CUpdateShadowData_003Eg__UpdateBounds_007C33_0(Bounds b, ref _003C_003Ec__DisplayClass33_0 P_1)
        {
        }
    }
}
