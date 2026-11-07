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
                var data = new ActorAnimationManagePropertyData
                {
                    weight = 1f,
                    windDirection = new float3(parameter.directionX.value, parameter.directionY.value, parameter.directionZ.value),
                    globalForce = parameter.constantPower.value,
                    windPower = parameter.wavePower.value,
                    windFluctuation = parameter.waveFrequency.value,
                    windWaveAmplitude = parameter.windWaveAmplitude.value,
                    windWaveFrequency = parameter.windWaveFrequency.value,
                    windWavePhase = parameter.windWavePhase.value,
                    windRangeMax = parameter.windRangeMax.value,
                    windRangeMin = parameter.windRangeMin.value,
                    windRangeFrequency = parameter.windRangeFrequency.value,
                    windRangePhase = parameter.windRangePhase.value,
                    randomPower = parameter.randomPower.value,
                    randomFluctuation = parameter.randomFrequency.value,
                    prewarmCount = 30
                };
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
