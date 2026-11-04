namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::VL.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CampusActorParameterPass : ScriptableRenderPass
    {
        public static readonly int _MatCapLightColor = Shader.PropertyToID("_MatCapLightColor");
        public static readonly int _MatCapMainLight = Shader.PropertyToID("_MatCapMainLight");
        public static readonly int _MatCapRimLight = Shader.PropertyToID("_MatCapRimLight");
        public static readonly int _MatCapRimColor = Shader.PropertyToID("_MatCapRimColor");
        public static readonly int _MatCapParam = Shader.PropertyToID("_MatCapParam");
        public static readonly int _ShadeMultiplyColor = Shader.PropertyToID("_ShadeMultiplyColor");
        public static readonly int _ShadeAdditiveColor = Shader.PropertyToID("_ShadeAdditiveColor");
        public static readonly int _VLSpecCube = Shader.PropertyToID("_VLSpecCube");
        public static readonly int _VLSpecColor = Shader.PropertyToID("_VLSpecColor");
        public static readonly int _VLEyeSpecCube = Shader.PropertyToID("_VLEyeSpecCube");
        public static readonly int _VLEyeSpecColor = Shader.PropertyToID("_VLEyeSpecColor");
        public static readonly int _GlobalLightParameter = Shader.PropertyToID("_GlobalLightParameter");
        public static readonly int _LightmapScaleColor = Shader.PropertyToID("_LightmapScaleColor");
        public static readonly int _LitColorMultiplier = Shader.PropertyToID("_LitColorMultiplier");
        public static readonly int _SkinSaturation = Shader.PropertyToID("_SkinSaturation");
        public static readonly int _EyeHighlightColor = Shader.PropertyToID("_EyeHighlightColor");
        public static readonly int _LitActorLightColor = Shader.PropertyToID("_LitActorLightColor");
        public static readonly int _LitActorMainLight = Shader.PropertyToID("_LitActorMainLight");
        public static readonly int _LitActorParam = Shader.PropertyToID("_LitActorParam");
        public static readonly int _LitActorShadeMultiplyColor = Shader.PropertyToID("_LitActorShadeMultiplyColor");
        public static readonly int _LitActorShadeAdditiveColor = Shader.PropertyToID("_LitActorShadeAdditiveColor");
        public static readonly int _LitActorRimLight = Shader.PropertyToID("_LitActorRimLight");
        public static readonly int _LitActorRimColor = Shader.PropertyToID("_LitActorRimColor");
        public static readonly int _WindDirection = Shader.PropertyToID("_WindDirection");
        public static readonly int _GlobalVegetationParams = Shader.PropertyToID("_GlobalVegetationParams");
        internal static readonly int _OutlineParam = Shader.PropertyToID("_OutlineParam");
        private CampusActorParameterSettings _settings;
        public static readonly int _VirtualColor = Shader.PropertyToID("_VirtualColor");
        public static readonly int _ScanlineDensity = Shader.PropertyToID("_ScanlineDensity");
        public static readonly int _ScanlineRange = Shader.PropertyToID("_ScanlineRange");
        public static readonly int _ScanlineAlpha = Shader.PropertyToID("_ScanlineAlpha");
        public static readonly int _EmissiveScanlineColor = Shader.PropertyToID("_EmissiveScanlineColor");
        public static readonly int _EmissiveScanlineSpeed = Shader.PropertyToID("_EmissiveScanlineSpeed");
        public static readonly int _EmissiveScanlinePower = Shader.PropertyToID("_EmissiveScanlinePower");
        public CampusActorParameterPass()
        {
            profilingSampler = new ProfilingSampler("CampusActorParameterPass");
            renderPassEvent = RenderPassEvent.BeforeRendering;
        }

        public void Setup(CampusActorParameterSettings settings)
        {
            _settings = settings;
        }

        private void UpdateOutlineCommand(CommandBuffer cmd, ref CameraData cameraData)
        {
            float focalLength = cameraData.camera.focalLength;
            if (!cameraData.camera.usePhysicalProperties)
                focalLength = cameraData.camera.sensorSize.y * 0.5f / Mathf.Tan(cameraData.camera.fieldOfView * Mathf.Deg2Rad * 0.5f);
            float scale = _settings.outlineFocalLengthScale != null
                ? _settings.outlineFocalLengthScale.Evaluate(focalLength) : 50f / Mathf.Max(1f, focalLength);
            cmd.SetGlobalVector(_OutlineParam, new Vector4(_settings.outlineRangeMinSize, _settings.outlineRangeMaxSize,
                1f / _settings.outlineRangeDistance, scale));
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            UpdateActorCommand(cmd, VolumeManager.instance.stack, renderingData.cameraData.camera.transform);
            UpdateVirtualEffectCommand(cmd, VolumeManager.instance.stack);
            UpdateOutlineCommand(cmd, ref renderingData.cameraData);
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private static Vector3 CalcLightVector(bool isGlobal, Vector2 angle, float cameraRoll)
        {
            Quaternion rotation;
            if (isGlobal)
                rotation = Quaternion.Euler(-angle.x, angle.y + 180f, 0f);
            else
                rotation = Quaternion.AngleAxis(-cameraRoll, Vector3.forward) * Quaternion.Euler(-angle.y, angle.x, 0f);
            return rotation * Vector3.forward;
        }

        public static void UpdateActorCommand(CommandBuffer cmd, VolumeStack stack, Transform cameraTransform)
        {
            var actor = stack.GetComponent<VLActorParameter>();
            Cubemap reflection = CoreUtils.blackCubeTexture;
            Cubemap eyeReflection = CoreUtils.blackCubeTexture;
            if (actor != null)
            {
                cmd.SetGlobalColor(_MatCapLightColor, actor.lightColor.value);
                bool isGlobal = (int)actor.mainLightSpace.value == 1;
                Vector3 direction = CalcLightVector(isGlobal, actor.mainLightAngle.value, cameraTransform.eulerAngles.z);
                cmd.SetGlobalVector(_MatCapMainLight, new Vector4(direction.x, direction.y, direction.z, isGlobal ? 1f : 0f));
                cmd.SetGlobalVector(_MatCapParam, new Vector4(actor.matCapOffset.value, actor.matCapSmoothScale.value, actor.shadeApplyRatio.value, 0f));
                cmd.SetGlobalColor(_ShadeMultiplyColor, actor.shadeColorMultiply.value);
                cmd.SetGlobalColor(_ShadeAdditiveColor, actor.shadeColorAdditive.value);
                Vector2 rimAngle = actor.rimAngle.value;
                Vector3 rimDirection = Quaternion.Euler(rimAngle.y, rimAngle.x, 0f) * Vector3.forward;
                cmd.SetGlobalVector(_MatCapRimLight, new Vector4(rimDirection.x, rimDirection.y, rimDirection.z, actor.rimPower.value));
                Color rimColor = actor.rimColor.value;
                rimColor.a = actor.rimBaseColorRatio.value;
                cmd.SetGlobalColor(_MatCapRimColor, rimColor);
                cmd.SetGlobalVector(_GlobalLightParameter, new Vector4(actor.giScale.value, actor.additiveLightScale.value, actor.additiveLightSpecularScale.value, 0f));
                cmd.SetGlobalFloat(_SkinSaturation, actor.skinSaturation.value + 1f);
                cmd.SetGlobalColor(_EyeHighlightColor, actor.eyeHighlightColor.value);
                if (actor.reflectionTexture != null && actor.reflectionTexture.value != null) reflection = actor.reflectionTexture.value;
                if (actor.eyeReflectionTexture != null && actor.eyeReflectionTexture.value != null) eyeReflection = actor.eyeReflectionTexture.value;
                cmd.SetGlobalColor(_VLSpecColor, actor.reflectionColor.value);
                cmd.SetGlobalColor(_VLEyeSpecColor, actor.eyeReflectionColor.value);
            }
            cmd.SetGlobalTexture(_VLSpecCube, reflection);
            cmd.SetGlobalTexture(_VLEyeSpecCube, eyeReflection);
            var lightmap = stack.GetComponent<VLLightmapVolume>();
            if (lightmap != null)
            {
                Color color = lightmap.color.value;
                float intensity = lightmap.intensity.value;
                cmd.SetGlobalColor(_LightmapScaleColor, new Color(color.r * intensity, color.g * intensity, color.b * intensity, lightmap.reflectionScale.value));
            }
            var litColor = stack.GetComponent<CampusLitColorParameter>();
            if (litColor != null) cmd.SetGlobalColor(_LitColorMultiplier, litColor.multiplyColor.value);
            var probe = stack.GetComponent<VLGlobalLightProbe>();
            if (probe != null) VLLightProbeUtility.SetupGlobalLightProbe(cmd, probe.pivot.value);
            var litActor = stack.GetComponent<CampusLitActor>();
            if (litActor != null)
            {
                cmd.SetGlobalColor(_LitActorLightColor, litActor.lightColor.value);
                bool isGlobal = (int)litActor.mainLightSpace.value == 1;
                Vector3 direction = CalcLightVector(isGlobal, litActor.mainLightAngle.value, cameraTransform.eulerAngles.z);
                cmd.SetGlobalVector(_LitActorMainLight, new Vector4(direction.x, direction.y, direction.z, isGlobal ? 1f : 0f));
                cmd.SetGlobalVector(_LitActorParam, new Vector4(litActor.matCapOffset.value, 1f, litActor.shadeApplyRatio.value, litActor.giScale.value));
                cmd.SetGlobalColor(_LitActorShadeMultiplyColor, litActor.shadeColorMultiply.value);
                cmd.SetGlobalColor(_LitActorShadeAdditiveColor, litActor.shadeColorAdditive.value);
                Vector2 rimAngle = litActor.rimAngle.value;
                Vector3 rimDirection = Quaternion.Euler(rimAngle.y, rimAngle.x, 0f) * Vector3.forward;
                cmd.SetGlobalVector(_LitActorRimLight, new Vector4(rimDirection.x, rimDirection.y, rimDirection.z, litActor.rimPower.value));
                Color rimColor = litActor.rimColor.value;
                rimColor.a = litActor.rimBaseColorRatio.value;
                cmd.SetGlobalColor(_LitActorRimColor, rimColor);
            }
            var vegetation = stack.GetComponent<VegetationParameter>();
            if (vegetation != null)
            {
                Vector2 direction = vegetation.windDirection.value;
                cmd.SetGlobalVector(_WindDirection, new Vector4(direction.x, direction.y, 0f, 0f));
                cmd.SetGlobalVector(_GlobalVegetationParams, new Vector4(vegetation.bendStrengthScale.value, vegetation.leafFrequencyScale.value,
                    vegetation.leafAmplitudeScale.value, vegetation.branchAmplitudeScale.value));
            }
        }

        public static void UpdateVirtualEffectCommand(CommandBuffer cmd, VolumeStack stack)
        {
            var effect = stack.GetComponent<VLVirtualEffect>();
            if (effect.IsActive() && effect != null)
            {
                cmd.SetGlobalColor(_VirtualColor, effect.virtualColor.value.linear);
                cmd.SetGlobalFloat(_ScanlineDensity, effect.scanLineDensity.value);
                cmd.SetGlobalFloat(_ScanlineRange, effect.scanlineRange.value);
                cmd.SetGlobalFloat(_ScanlineAlpha, effect.scanLineAlpha.value);
                cmd.SetGlobalColor(_EmissiveScanlineColor, effect.emissiveScanlineColor.value.linear);
                cmd.SetGlobalFloat(_EmissiveScanlineSpeed, effect.emissiveScanlineSpeed.value);
                cmd.SetGlobalFloat(_EmissiveScanlinePower, effect.emissiveScanlinePower.value);
            }
        }
    }
}
