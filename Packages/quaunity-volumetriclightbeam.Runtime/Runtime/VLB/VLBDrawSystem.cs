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
        public static readonly int _ColorParam = Shader.PropertyToID("_ColorParam");
        public static readonly int _CameraParam = Shader.PropertyToID("_CameraParam");
        public static readonly int _Params0 = Shader.PropertyToID("_Params0");
        public static readonly int _Params1 = Shader.PropertyToID("_Params1");
        public static readonly int _ShadowParam = Shader.PropertyToID("_ShadowParam");
        public static readonly int _ObjectToAdditionalLightShadow = Shader.PropertyToID("_ObjectToAdditionalLightShadow");
        public static readonly int _ShadowLightIndex = Shader.PropertyToID("_ShadowLightIndex");
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
            _entityManager = entityManager;
            _localToWorlds = new Matrix4x4[200];
            _colorArray = new Vector4[200];
            _cameraParamArray = new Vector4[200];
            _params0Array = new Matrix4x4[200];
            _params1Array = new Matrix4x4[200];
            _sampler = CustomSampler.Create("VLBDrawCallSystem");
        }

        public void Execute(CommandBuffer cmd, ref CullingResults cullResults)
        {
            if (!isDrawCallSystemExecuted) return;
            for (int i = 0; i < _entityManager.chunkCount; i++)
            {
                var entityChunk = _entityManager.entityChunks[i];
                if ((entityChunk.materialID & 1024) == 0)
                    Execute(cmd, entityChunk, _entityManager.cachedChunks[i], _entityManager.drawCallChunks[i], entityChunk.count, ref cullResults);
            }
        }

        public void ExecuteHD(CommandBuffer cmd, ref CullingResults cullResults, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
            if (!isDrawCallSystemExecuted) return;
            for (int i = 0; i < _entityManager.chunkCount; i++)
            {
                var entityChunk = _entityManager.entityChunks[i];
                if ((entityChunk.materialID & 1024) != 0)
                    ExecuteHD(cmd, entityChunk, _entityManager.cachedChunks[i], _entityManager.drawCallChunks[i], entityChunk.count, ref cullResults, shadowCasterPass);
            }
        }

        public void MarkRendered()
        {
            isDrawCallSystemExecuted = true;
        }

        private void Execute(CommandBuffer cmd, VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, VLBDrawCallChunk drawCallChunk, int count, ref CullingResults cullResults)
        {
            cachedChunk.currentJobHandle.Complete();
            drawCallChunk.currentJobHandle.Complete();
            if (count == 0 || entityChunk.material == null || !entityChunk.material.enableInstancing) return;
            var mesh = GlobalMeshSD.Get();
            for (int i = 0; i < drawCallChunk.subCallCount; i++)
            {
                var call = drawCallChunk.subCalls[i];
                NativeArray<Matrix4x4>.Copy(drawCallChunk.localToWorlds.Reinterpret<Matrix4x4>(), call.start, _localToWorlds, 0, call.count);
                NativeArray<Vector4>.Copy(drawCallChunk.colors.Reinterpret<Vector4>(), call.start, _colorArray, 0, call.count);
                NativeArray<Vector4>.Copy(drawCallChunk.cameraParams.Reinterpret<Vector4>(), call.start, _cameraParamArray, 0, call.count);
                NativeArray<Matrix4x4>.Copy(drawCallChunk.params0.Reinterpret<Matrix4x4>(), call.start, _params0Array, 0, call.count);
                NativeArray<Matrix4x4>.Copy(drawCallChunk.params1.Reinterpret<Matrix4x4>(), call.start, _params1Array, 0, call.count);
                cachedChunk.propertyBlock.SetVectorArray(_ColorParam, _colorArray);
                cachedChunk.propertyBlock.SetVectorArray(_CameraParam, _cameraParamArray);
                cachedChunk.propertyBlock.SetMatrixArray(_Params0, _params0Array);
                cachedChunk.propertyBlock.SetMatrixArray(_Params1, _params1Array);
                cmd.DrawMeshInstanced(mesh, 0, entityChunk.material, 0, _localToWorlds, call.count, cachedChunk.propertyBlock);
            }
        }

        private int GetShadowLightIndex(VolumetricLightBeamSD vlb, NativeArray<VisibleLight> visibleLights, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
            for (int i = 0; i < visibleLights.Length; i++)
            {
                var light = visibleLights[i];
                if (light.lightType == LightType.Spot && vlb.lightSpotAttached == light.light)
                    return shadowCasterPass.GetShadowLightIndexFromLightIndex(i);
            }
            return -1;
        }

        private void ExecuteHD(CommandBuffer cmd, VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, VLBDrawCallChunk drawCallChunk, int count, ref CullingResults cullResults, AdditionalLightsShadowCasterPass shadowCasterPass)
        {
            cachedChunk.currentJobHandle.Complete();
            drawCallChunk.currentJobHandle.Complete();
            if (count == 0 || entityChunk.material == null || !entityChunk.material.enableInstancing || shadowCasterPass == null) return;
            var mesh = GlobalMeshHD.Get();
            var lights = cullResults.visibleLights;
            double phase = System.Math.Floor(Time.timeAsDouble * 60.0) * 1.61803399;
            float jitter = (float)(phase - System.Math.Floor(phase));
            for (int i = 0; i < drawCallChunk.subCallCount; i++)
            {
                var call = drawCallChunk.subCalls[i];
                for (int j = call.start; j < call.end; j++)
                {
                    int index = drawCallChunk.instanceIndexToVisibleIndex[j];
                    int shadowIndex = GetShadowLightIndex(entityChunk.components[index], lights, shadowCasterPass);
                    if (shadowIndex < 0) continue;
                    var parameters = drawCallChunk.params0[j];
                    cachedChunk.propertyBlock.SetVector(_ColorParam, drawCallChunk.colors[j]);
                    cachedChunk.propertyBlock.SetVector(_CameraParam, drawCallChunk.cameraParams[j]);
                    cachedChunk.propertyBlock.SetVector(_Params0, new Vector4(parameters.c0.y, parameters.c1.y, parameters.c2.y, parameters.c1.x));
                    cachedChunk.propertyBlock.SetVector(_ShadowParam, new Vector4(cachedChunk.shadowIntensity[index], jitter, 0f, 0f));
                    cachedChunk.propertyBlock.SetMatrix(_ObjectToAdditionalLightShadow, cachedChunk.localToWorlds[index]);
                    cmd.SetGlobalInt(_ShadowLightIndex, shadowIndex);
                    cmd.DrawMesh(mesh, drawCallChunk.localToWorlds[j], entityChunk.material, 0, 0, cachedChunk.propertyBlock);
                }
            }
        }
    }
}
