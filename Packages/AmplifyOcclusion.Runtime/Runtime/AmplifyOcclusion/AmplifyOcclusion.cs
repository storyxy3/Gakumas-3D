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
        public ApplicationMethodParameter ApplyMethod = new ApplicationMethodParameter { value = (ApplicationMethod)0 };
        [Tooltip("Number of samples per pass.")]
        public SampleCountLevelParameter SampleCount = new SampleCountLevelParameter { value = (SampleCountLevel)1 };
        [Tooltip("Source of per-pixel normals: None = All, GBuffer = Deferred.")]
        public PerPixelNormalSourceParameter PerPixelNormals = new PerPixelNormalSourceParameter { value = (PerPixelNormalSource)0 };
        [Tooltip("Final applied intensity of the occlusion effect.")]
        public ClampedFloatParameter Intensity = new ClampedFloatParameter(0, 0, 1);
        [Tooltip("Color tint for occlusion.")]
        public ColorParameter Tint = new ColorParameter(Color.black, false, false, false);
        [Tooltip("Radius spread of the occlusion.")]
        public ClampedFloatParameter Radius = new ClampedFloatParameter(2, 0, 32);
        [Tooltip("Power exponent attenuation of the occlusion.")]
        public ClampedFloatParameter PowerExponent = new ClampedFloatParameter(1.8f, 0, 16);
        [Tooltip("Controls the initial occlusion contribution offset.")]
        public ClampedFloatParameter Bias = new ClampedFloatParameter(0.05f, 0, 0.99f);
        [Tooltip("Controls the thickness occlusion contribution.")]
        [Range(0f, 1f)]
        public ClampedFloatParameter Thickness = new ClampedFloatParameter(1, 0, 1);
        [Tooltip("Compute the Occlusion and Blur at half of the resolution.")]
        public BoolParameter Downsample = new BoolParameter(true);
        [Tooltip("Cache optimization for best performance / quality tradeoff.")]
        public BoolParameter CacheAware = new BoolParameter(true);
        [Header("Distance Fade")]
        [Tooltip("Control parameters at faraway.")]
        public BoolParameter FadeEnabled = new BoolParameter(false);
        [Tooltip("Distance in Unity unities that start to fade.")]
        public FloatParameter FadeStart = new MinFloatParameter(100, 0);
        [Tooltip("Length distance to performe the transition.")]
        public FloatParameter FadeLength = new MinFloatParameter(50, 0.01f);
        [Tooltip("Final Intensity parameter.")]
        public FloatParameter FadeToIntensity = new ClampedFloatParameter(0, 0, 1);
        public ColorParameter FadeToTint = new ColorParameter(Color.black);
        [Tooltip("Final Radius parameter.")]
        public FloatParameter FadeToRadius = new ClampedFloatParameter(2, 0, 32);
        [Tooltip("Final PowerExponent parameter.")]
        public FloatParameter FadeToPowerExponent = new ClampedFloatParameter(1, 0, 16);
        [Tooltip("Final Thickness parameter.")]
        public FloatParameter FadeToThickness = new ClampedFloatParameter(1, 0, 1);
        [Header("Bilateral Blur")]
        public BoolParameter BlurEnabled = new BoolParameter(true);
        [Tooltip("Radius in screen pixels.")]
        public IntParameter BlurRadius = new ClampedIntParameter(3, 1, 4);
        [Tooltip("Number of times that the Blur will repeat.")]
        public IntParameter BlurPasses = new ClampedIntParameter(1, 1, 4);
        [Tooltip("Sharpness of blur edge-detection: 0 = Softer Edges, 20 = Sharper Edges.")]
        [Range(0f, 20f)]
        public FloatParameter BlurSharpness = new ClampedFloatParameter(15, 0, 20);
        [Header("Temporal Filter")]
        [Tooltip("Accumulates the effect over the time.")]
        public BoolParameter FilterEnabled = new BoolParameter(true);
        public BoolParameter FilterDownsample = new BoolParameter(true);
        [Tooltip("Controls the accumulation decayment: 0 = More flicker with less ghosting, 1 = Less flicker with more ghosting.")]
        public FloatParameter FilterBlending = new ClampedFloatParameter(0.8f, 0, 1);
        [Tooltip("Controls the discard sensitivity based on the motion of the scene and objects.")]
        public FloatParameter FilterResponse = new ClampedFloatParameter(0.5f, 0, 1);
        public bool IsActive()
        {
            return Intensity.value > 0;
        }

        public AmplifyOcclusion()
        {
        }
    }
}
