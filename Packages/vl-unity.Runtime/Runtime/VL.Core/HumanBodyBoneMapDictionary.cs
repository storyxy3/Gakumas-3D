namespace VL.Core
{
    using global::System;
    using global::UnityEngine;
    using global::VL.Core;

    [Serializable]
    public class HumanBodyBoneMapDictionary : SerializedDictionary<HumanBodyBones, Transform>
    {
        public HumanBodyBoneMapDictionary()
        {
        }
    }
}
