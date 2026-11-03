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
                return null;
            }
        }

        public bool isAdaptScale
        {
            get
            {
                return default(bool);
            }
        }

        public VLActorPropFixConstraint(string constraintTargetJointName, bool isAdaptScale)
        {
            this = default;
        }
    }
}
