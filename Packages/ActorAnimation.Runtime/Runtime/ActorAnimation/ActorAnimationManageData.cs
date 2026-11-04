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
        public ActorAnimationManagePropertyData propertyData;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private static void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
        {
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
        }

        public ActorAnimationManageData()
        {
        }
    }
}
