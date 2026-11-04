namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/観客ペンライトカラー")]
    public class AudiencePenlightVolumeComponent : VolumeComponent
    {
        public AudiencePenlightVolumeParameter target = new AudiencePenlightVolumeParameter(null);
        public AudiencePenlightVolumeComponent()
        {
        }
    }
}
