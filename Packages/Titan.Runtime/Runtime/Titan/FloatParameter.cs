namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    public class FloatParameter : ParameterBase<float>
    {
        protected override float GetValueFromExpressionValue(Value value)
        {
            return default(float);
        }

        public FloatParameter()
        {
        }
    }
}
