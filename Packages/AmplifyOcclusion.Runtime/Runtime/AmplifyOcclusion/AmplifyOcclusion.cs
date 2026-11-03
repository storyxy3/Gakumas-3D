namespace AmplifyOcclusion
{
    using global::System;
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    [Serializable]
    [VolumeComponentMenuForRenderPipeline("AmplifyCreations/AmplifyOcclusion", new Type[] { typeof(UniversalRenderPipeline) })]
    public sealed class AmplifyOcclusion : VolumeComponent
    {
        [Header("Ambient Occlusion")]
        [Tooltip("How to inject the occlusion: Post Effect = Overlay, Debug - Vizualize.")]
        public ApplicationMethodParameter ApplyMethod;
        [Tooltip("Number of samples per pass.")]
        public SampleCountLevelParameter SampleCount;
        [Tooltip("Source of per-pixel normals: None = All, GBuffer = Deferred.")]
        public PerPixelNormalSourceParameter PerPixelNormals;
        [Tooltip("Final applied intensity of the occlusion effect.")]
        public ClampedFloatParameter Intensity;
        [Tooltip("Color tint for occlusion.")]
        public ColorParameter Tint;
        [Tooltip("Radius spread of the occlusion.")]
        public ClampedFloatParameter Radius;
        [Tooltip("Power exponent attenuation of the occlusion.")]
        public ClampedFloatParameter PowerExponent;
        [Tooltip("Controls the initial occlusion contribution offset.")]
        public ClampedFloatParameter Bias;
        [Tooltip("Controls the thickness occlusion contribution.")]
        [Range(0f, 1f)]
        public ClampedFloatParameter Thickness;
        [Tooltip("Compute the Occlusion and Blur at half of the resolution.")]
        public BoolParameter Downsample;
        [Tooltip("Cache optimization for best performance / quality tradeoff.")]
        public BoolParameter CacheAware;
        [Header("Distance Fade")]
        [Tooltip("Control parameters at faraway.")]
        public BoolParameter FadeEnabled;
        [Tooltip("Distance in Unity unities that start to fade.")]
        public FloatParameter FadeStart;
        [Tooltip("Length distance to performe the transition.")]
        public FloatParameter FadeLength;
        [Tooltip("Final Intensity parameter.")]
        public FloatParameter FadeToIntensity;
        public ColorParameter FadeToTint;
        [Tooltip("Final Radius parameter.")]
        public FloatParameter FadeToRadius;
        [Tooltip("Final PowerExponent parameter.")]
        public FloatParameter FadeToPowerExponent;
        [Tooltip("Final Thickness parameter.")]
        public FloatParameter FadeToThickness;
        [Header("Bilateral Blur")]
        public BoolParameter BlurEnabled;
        [Tooltip("Radius in screen pixels.")]
        public IntParameter BlurRadius;
        [Tooltip("Number of times that the Blur will repeat.")]
        public IntParameter BlurPasses;
        [Tooltip("Sharpness of blur edge-detection: 0 = Softer Edges, 20 = Sharper Edges.")]
        [Range(0f, 20f)]
        public FloatParameter BlurSharpness;
        [Header("Temporal Filter")]
        [Tooltip("Accumulates the effect over the time.")]
        public BoolParameter FilterEnabled;
        public BoolParameter FilterDownsample;
        [Tooltip("Controls the accumulation decayment: 0 = More flicker with less ghosting, 1 = Less flicker with more ghosting.")]
        public FloatParameter FilterBlending;
        [Tooltip("Controls the discard sensitivity based on the motion of the scene and objects.")]
        public FloatParameter FilterResponse;
        public bool IsActive()
        {
            return default(bool);
        }

        public AmplifyOcclusion()
        {
        }
    }
}
