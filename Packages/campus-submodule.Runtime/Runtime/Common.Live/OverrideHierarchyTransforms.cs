namespace Common.Live
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class OverrideHierarchyTransforms
    {
        public string hierarchyName;
        public bool applyPosition;
        public Vector3 localPosition;
        public bool applyRotation;
        public Vector3 localEulerAngles;
        public bool applyScale;
        public Vector3 localScale;
        public OverrideHierarchyTransforms()
        {
        }
    }
}
