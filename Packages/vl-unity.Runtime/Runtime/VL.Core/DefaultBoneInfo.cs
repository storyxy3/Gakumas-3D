namespace VL.Core
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class DefaultBoneInfo
    {
        public Transform transform;
        public string name;
        public Vector3 localPosition;
        public Quaternion localRotation;
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 scale;
        public DefaultBoneInfo(string transformName, Transform transform)
        {
        }
    }
}
