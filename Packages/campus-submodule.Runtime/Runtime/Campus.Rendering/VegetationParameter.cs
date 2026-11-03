namespace Campus.Rendering
{
    using global::UnityEngine.Rendering;

    [VolumeComponentMenu("Campus/Vegetation Parameter")]
    public class VegetationParameter : VolumeComponent
    {
        public Vector2Parameter windDirection;
        public FloatParameter bendStrengthScale;
        public FloatParameter leafFrequencyScale;
        public FloatParameter leafAmplitudeScale;
        public FloatParameter branchAmplitudeScale;
        public VegetationParameter()
        {
        }
    }
}
