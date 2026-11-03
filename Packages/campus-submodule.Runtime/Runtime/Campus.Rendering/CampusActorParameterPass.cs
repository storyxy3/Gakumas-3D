namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CampusActorParameterPass : ScriptableRenderPass
    {
        public static readonly int _MatCapLightColor;
        public static readonly int _MatCapMainLight;
        public static readonly int _MatCapRimLight;
        public static readonly int _MatCapRimColor;
        public static readonly int _MatCapParam;
        public static readonly int _ShadeMultiplyColor;
        public static readonly int _ShadeAdditiveColor;
        public static readonly int _VLSpecCube;
        public static readonly int _VLSpecColor;
        public static readonly int _VLEyeSpecCube;
        public static readonly int _VLEyeSpecColor;
        public static readonly int _GlobalLightParameter;
        public static readonly int _LightmapScaleColor;
        public static readonly int _LitColorMultiplier;
        public static readonly int _SkinSaturation;
        public static readonly int _EyeHighlightColor;
        public static readonly int _LitActorLightColor;
        public static readonly int _LitActorMainLight;
        public static readonly int _LitActorParam;
        public static readonly int _LitActorShadeMultiplyColor;
        public static readonly int _LitActorShadeAdditiveColor;
        public static readonly int _LitActorRimLight;
        public static readonly int _LitActorRimColor;
        public static readonly int _WindDirection;
        public static readonly int _GlobalVegetationParams;
        internal static readonly int _OutlineParam;
        private CampusActorParameterSettings _settings;
        public static readonly int _VirtualColor;
        public static readonly int _ScanlineDensity;
        public static readonly int _ScanlineRange;
        public static readonly int _ScanlineAlpha;
        public static readonly int _EmissiveScanlineColor;
        public static readonly int _EmissiveScanlineSpeed;
        public static readonly int _EmissiveScanlinePower;
        public CampusActorParameterPass()
        {
        }

        public void Setup(CampusActorParameterSettings settings)
        {
        }

        private void UpdateOutlineCommand(CommandBuffer cmd, ref CameraData cameraData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private static Vector3 CalcLightVector(bool isGlobal, Vector2 angle, float cameraRoll)
        {
            return default(Vector3);
        }

        public static void UpdateActorCommand(CommandBuffer cmd, VolumeStack stack, Transform cameraTransform)
        {
        }

        public static void UpdateVirtualEffectCommand(CommandBuffer cmd, VolumeStack stack)
        {
        }
    }
}
