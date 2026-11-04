namespace Campus.Rendering
{
    using global::UnityEngine.Rendering;

    [VolumeComponentMenu("Campus/Vegetation Parameter")]
    public class VegetationParameter : VolumeComponent
    {
        public Vector2Parameter windDirection = new Vector2Parameter(new UnityEngine.Vector2(0.015f, 0.015f));
        public FloatParameter bendStrengthScale = new MinFloatParameter(1f, 0f);
        public FloatParameter leafFrequencyScale = new MinFloatParameter(1f, 0f);
        public FloatParameter leafAmplitudeScale = new MinFloatParameter(1f, 0f);
        public FloatParameter branchAmplitudeScale = new MinFloatParameter(1f, 0f);
        public VegetationParameter()
        {
        }
    }
}
