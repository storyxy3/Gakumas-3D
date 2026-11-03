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
        }

        public void SetWindPropertyData(ref ActorAnimationManagePropertyData p)
        {
        }

        public ActorAnimationManageData()
        {
        }
    }
}
