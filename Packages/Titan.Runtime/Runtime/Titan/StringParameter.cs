namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    public class StringParameter : ParameterBase<string>
    {
        protected override string GetValueFromExpressionValue(Value value)
        {
            return null;
        }

        public StringParameter()
        {
        }
    }
}
