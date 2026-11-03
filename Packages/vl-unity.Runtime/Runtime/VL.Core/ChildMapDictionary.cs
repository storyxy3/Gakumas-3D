namespace VL.Core
{
    using global::System;
    using global::VL.Core;

    [Serializable]
    public class ChildMapDictionary : SerializedDictionary<string, VLActorModelParts>
    {
        public ChildMapDictionary(int capacity)
        {
        }
    }
}
