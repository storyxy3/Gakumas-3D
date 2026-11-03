namespace Campus.Common
{
    using global::UnityEngine;
    using global::VL;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1500)]
    public class CampusActorHipCorrector : VLActorExtension
    {
        [SerializeField]
        private Transform _moveTransform;
        [SerializeField]
        private Transform _hipTransform;
        public void Setup(Transform moveTransform, Transform hipTransform)
        {
        }

        private void LateUpdate()
        {
        }

        public CampusActorHipCorrector()
        {
        }
    }
}
