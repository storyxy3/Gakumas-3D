namespace VL.Core
{
    using global::System;
    using global::VL.Core;

    [Serializable]
    public class InstanceIDToDefaultBoneInfoIndexDictionary : SerializedDictionary<int, int>
    {
        public InstanceIDToDefaultBoneInfoIndexDictionary(int capacity) : base(capacity)
        {
        }
    }
}
