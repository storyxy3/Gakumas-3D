namespace VLB
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Profiling;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VLB;

    public class VLBDrawSystem
    {
        public static readonly int _ColorParam;
        public static readonly int _CameraParam;
        public static readonly int _Params0;
        public static readonly int _Params1;
        public static readonly int _ShadowParam;
        public static readonly int _ObjectToAdditionalLightShadow;
        public static readonly int _ShadowLightIndex;
        internal bool isDrawCallSystemExecuted;
        private VLBEntityManager _entityManager;
        private Matrix4x4[] _localToWorlds;
        private Vector4[] _colorArray;
        private Vector4[] _cameraParamArray;
        private Matrix4x4[] _params0Array;
        private Matrix4x4[] _params1Array;
        private readonly CustomSampler _sampler;
        public VLBDrawSystem(VLBEntityManager entityManager)
        {
        }

        public void Execute(CommandBuffer cmd, ref CullingResults cullResults)
        {
        }

        public void ExecuteHD(CommandBuffer cmd, ref CullingResults cullResults, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
        }

        public void MarkRendered()
        {
        }

        private void Execute(CommandBuffer cmd, VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, VLBDrawCallChunk drawCallChunk, int count, ref CullingResults cullResults)
        {
        }

        private int GetShadowLightIndex(VolumetricLightBeamSD vlb, NativeArray<VisibleLight> visibleLights, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
            return default(int);
        }

        private void ExecuteHD(CommandBuffer cmd, VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, VLBDrawCallChunk drawCallChunk, int count, ref CullingResults cullResults, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
        }
    }
}
