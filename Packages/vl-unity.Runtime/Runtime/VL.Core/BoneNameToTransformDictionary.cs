namespace VL.Core
{
    using global::System;
    using global::UnityEngine;
    using global::VL.Core;

    [Serializable]
    public class BoneNameToTransformDictionary : SerializedDictionary<string, Transform>
    {
        public BoneNameToTransformDictionary(int capacity)
        {
        }
    }
}
