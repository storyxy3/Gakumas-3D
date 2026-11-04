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
            _moveTransform = moveTransform;
            _hipTransform = hipTransform;
        }

        private void LateUpdate()
        {
            if (_moveTransform != null && _hipTransform != null)
            {
                var position = _moveTransform.localPosition;
                _hipTransform.localPosition = new Vector3(position.x, _hipTransform.localPosition.y, position.z);
            }
        }

        public CampusActorHipCorrector()
        {
        }
    }
}
