namespace VL
{
    using global::UnityEngine;

    public struct VLActorPropFixConstraint
    {
        [SerializeField]
        private string _constraintTargetJointName;
        [SerializeField]
        private bool _isAdaptScale;
        public string constraintTargetJointName
        {
            get
            {
                return _constraintTargetJointName;
            }
        }

        public bool isAdaptScale
        {
            get
            {
                return _isAdaptScale;
            }
        }

        public VLActorPropFixConstraint(string constraintTargetJointName, bool isAdaptScale)
        {
            _constraintTargetJointName = constraintTargetJointName;
            _isAdaptScale = isAdaptScale;
        }
    }
}
