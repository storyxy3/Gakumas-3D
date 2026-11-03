namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    public static class TransformUtils
    {
        public struct Packed
        {
            public Vector3 position;
            public Quaternion rotation;
            public Vector3 lossyScale;
            public bool IsSame(Transform transf)
            {
                return default(bool);
            }
        }

        public static Packed GetWorldPacked(this Transform self)
        {
            return default(Packed);
        }
    }
}
