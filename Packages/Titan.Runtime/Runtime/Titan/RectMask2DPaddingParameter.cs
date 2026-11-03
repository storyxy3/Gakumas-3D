namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    [VectorParameterLabels("Left", "Bottom", "Right", "Top", "xzwy")]
    public class RectMask2DPaddingParameter : Vector4Parameter
    {
        public RectMask2DPaddingParameter()
        {
        }
    }
}
