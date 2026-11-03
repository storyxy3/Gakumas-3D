namespace Campus.Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    [VectorParameterLabels("TopLeft", "TopRight", "BottomRight", "BottomLeft", null)]
    public class RoundParameter : Vector4Parameter
    {
        public RoundParameter()
        {
        }
    }
}
