namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    public static class Consts
    {
        public static class Internal
        {
            public static readonly bool ProceduralObjectsVisibleInEditor = true;
            public static HideFlags ProceduralObjectsHideFlags
            {
                get
                {
                    return ProceduralObjectsVisibleInEditor ? HideFlags.DontSave | HideFlags.NotEditable : HideFlags.HideAndDontSave;
                }
            }
        }

        public static class Beam
        {
            public static class SD
            {
                public static readonly Vector2 TiltDefault = Vector2.zero;
                public static readonly Vector3 SkewingLocalForwardDirectionDefault = Vector3.forward;
            }

            public static class HD
            {
                public static readonly MinMaxRangeFloat JitteringLerpRange;
            }

            public static readonly Color FlatColor = Color.white;
            public static readonly Vector3 NoiseVelocityDefault = new Vector3(0.07f, 0.18f, 0.05f);
        }

        public static class DustParticles
        {
            public static readonly Vector3 VelocityDefault;
            public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;
        }

        public static class DynOcclusion
        {
            public static readonly LayerMask LayerMaskDefault;
        }

        public static class Effects
        {
            public static readonly MinMaxRangeFloat FlickeringDurationDefault;
            public static readonly MinMaxRangeFloat PauseDurationDefault;
            public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;
        }

        public static class Shadow
        {
            public static readonly LayerMask LayerMaskDefault;
            public static string GetErrorChangeRuntimeDepthMapResolution(VolumetricShadowHD comp)
            {
                return null;
            }
        }

        public static class Cookie
        {
            public static readonly Vector2 TranslationDefault;
            public static readonly Vector2 ScaleDefault;
        }
    }
}
