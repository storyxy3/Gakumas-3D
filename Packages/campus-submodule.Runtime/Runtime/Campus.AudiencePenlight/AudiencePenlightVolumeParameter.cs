namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine.Rendering;

    [Serializable]
    public class AudiencePenlightVolumeParameter : VolumeParameter<AudiencePenlightVolume>
    {
        public AudiencePenlightVolumeParameter(AudiencePenlightVolume value) : base(value, false)
        {
        }
    }
}
