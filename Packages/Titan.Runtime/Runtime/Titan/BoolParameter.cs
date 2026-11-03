namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    public class BoolParameter : ParameterBase<bool>
    {
        protected override bool GetValueFromExpressionValue(Value value)
        {
            return default(bool);
        }

        public BoolParameter()
        {
        }
    }
}
