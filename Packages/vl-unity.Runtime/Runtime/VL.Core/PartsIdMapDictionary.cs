namespace VL.Core
{
    using global::System;
    using global::VL.Core;

    [Serializable]
    public class PartsIdMapDictionary : SerializedDictionary<string, VLActorModelParts>
    {
        public PartsIdMapDictionary(int capacity) : base(capacity)
        {
        }
    }
}
