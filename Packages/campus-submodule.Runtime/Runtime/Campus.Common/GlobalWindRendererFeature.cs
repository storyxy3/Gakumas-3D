namespace Campus.Common
{
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::Unity.Mathematics;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class GlobalWindRendererFeature : ScriptableRendererFeature
    {
        private class GlobalWindPass : ScriptableRenderPass
        {
            private static readonly int _GlobalWind = UnityEngine.Shader.PropertyToID("_GlobalWind");
            public GlobalWindPass()
            {
                profilingSampler = new ProfilingSampler("GlobalWindPass");
                renderPassEvent = (RenderPassEvent)0;
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
                var parameter = VolumeManager.instance.stack.GetComponent<GlobalWindParameter>();
                if (!renderingData.cameraData.camera.TryGetComponent(out ActorAnimationManageData manageData))
                    return;
                var data = new ActorAnimationManagePropertyData(1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                    parameter.constantPower.value,
                    new float3(parameter.directionX.value, parameter.directionY.value, parameter.directionZ.value),
                    parameter.wavePower.value, parameter.waveFrequency.value,
                    parameter.windWaveAmplitude.value, parameter.windWaveFrequency.value, parameter.windWavePhase.value,
                    parameter.windRangeMax.value, parameter.windRangeMin.value, parameter.windRangeFrequency.value, parameter.windRangePhase.value,
                    parameter.randomPower.value, parameter.randomFrequency.value, 30);
                manageData.SetWindPropertyData(ref data);
            }
        }

        private GlobalWindPass _pass;
        public override void Create()
        {
            _pass = new GlobalWindPass();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            renderer.EnqueuePass(_pass);
        }

        public GlobalWindRendererFeature()
        {
        }
    }
}
