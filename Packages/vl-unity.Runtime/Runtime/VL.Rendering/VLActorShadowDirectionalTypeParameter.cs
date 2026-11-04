namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [Serializable]
    public sealed class VLActorShadowDirectionalTypeParameter : VolumeParameter<VLActorShadowDirectionalType>
    {
        public VLActorShadowDirectionalTypeParameter(VLActorShadowDirectionalType value, bool overrideState = false) : base(value, overrideState)
        {
        }
    }
}
