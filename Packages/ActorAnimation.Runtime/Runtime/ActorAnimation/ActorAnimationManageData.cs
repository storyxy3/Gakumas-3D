namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    [RequireComponent(typeof(Camera))]
    public class ActorAnimationManageData : MonoBehaviour
    {
        [SerializeField]
        [HideInInspector]
        public ActorAnimationManagePropertyData propertyData = new ActorAnimationManagePropertyData(1f, 0f, 1f, 1f, 1f, 1f, 1f, 1f, global::Unity.Mathematics.float3.zero, Vector3.down, 0f, 1f, 0f, 1f, 0f, 10f, -10f, 0f, 0f, 0f, 0f, 30);
        private void OnEnable()
        {
            RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
        }

        private void OnDisable()
        {
            RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
        }

        private static void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
        {
            var parameter = VolumeManager.instance.stack.GetComponent<ActorAnimationParameter>();
            if (!camera.TryGetComponent<ActorAnimationManageData>(out var data)) return;
            float weight = parameter.weight.value;
            float modelingPoseWeight = parameter.modelingPoseWeight.value;
            float rootWeight = parameter.rootWeight.value;
            float rootHorizontalWeight = parameter.rootHorizontalWeight.value;
            float rootVerticalWeight = parameter.rootVerticalWeight.value;
            float swingPowerWeight = parameter.swingPowerWeight.value;
            float swingBreastPowerWeight = parameter.swingBreastPowerWeight.value;
            float swingBreastCorrectionPowerWeight = parameter.swingBreastCorrectionPowerWeight.value;
            int prewarmCount = parameter.prewarmCount.value;
            data.propertyData.prewarmCount = prewarmCount;
            data.propertyData.weight = weight;
            data.propertyData.modelingPoseWeight = modelingPoseWeight;
            data.propertyData.rootHorizontalWeight = rootHorizontalWeight;
            data.propertyData.rootVerticalWeight = rootVerticalWeight;
            data.propertyData.swingPowerWeight = swingPowerWeight;
            data.propertyData.swingBreastPowerWeight = swingBreastPowerWeight;
            data.propertyData.swingBreastCorrectionPowerWeight = swingBreastCorrectionPowerWeight;
            data.propertyData.rootWeight = rootWeight;
        }

        public void SetCommonPropertyData(ref ActorAnimationManagePropertyData p)
        {
            propertyData.rootWeight = p.rootWeight;
            propertyData.rootHorizontalWeight = p.rootHorizontalWeight;
            propertyData.prewarmCount = p.prewarmCount;
            propertyData.rootVerticalWeight = p.rootVerticalWeight;
            propertyData.weight = p.weight;
            propertyData.modelingPoseWeight = p.modelingPoseWeight;
            propertyData.swingPowerWeight = p.swingPowerWeight;
            propertyData.swingBreastPowerWeight = p.swingBreastPowerWeight;
            propertyData.swingBreastCorrectionPowerWeight = p.swingBreastCorrectionPowerWeight;
        }

        public void SetWindPropertyData(ref ActorAnimationManagePropertyData p)
        {
            propertyData.globalForce = p.globalForce;
            propertyData.windDirection = p.windDirection;
            propertyData.windPower = p.windPower;
            propertyData.windFluctuation = p.windFluctuation;
            propertyData.windWaveAmplitude = p.windWaveAmplitude;
            propertyData.windWaveFrequency = p.windWaveFrequency;
            propertyData.windWavePhase = p.windWavePhase;
            propertyData.windRangeMax = p.windRangeMax;
            propertyData.windRangeMin = p.windRangeMin;
            propertyData.windRangeFrequency = p.windRangeFrequency;
            propertyData.windRangePhase = p.windRangePhase;
            propertyData.randomPower = p.randomPower;
            propertyData.randomFluctuation = p.randomFluctuation;
        }

        public ActorAnimationManageData()
        {
        }
    }
}
