namespace VL.Core
{
    using global::System;
    using global::VL.Core;

    [Serializable]
    public class VLActorModelParts<TDescriptor> : VLActorModelParts where TDescriptor : VLActorDescriptor
    {
        public VLActorModelParts()
        {
        }
    }
}
