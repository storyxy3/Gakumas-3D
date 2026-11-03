namespace VL
{
    public struct KeyframeData
    {
        public const float DefaultWeight = 1f / 3f;
        public float time;
        public float value;
        public float inTangent;
        public float outTangent;
        public float inWeight;
        public float outWeight;
    }
}
