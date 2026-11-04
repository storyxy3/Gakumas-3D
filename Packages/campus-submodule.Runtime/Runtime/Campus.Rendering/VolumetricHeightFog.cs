namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("VL/Volumetric Height Fog")]
    public class VolumetricHeightFog : VolumeComponent
    {
        public BoolParameter UseFog = new BoolParameter(false);
        public VolumetricHeightFog()
        {
        }
    }
}
