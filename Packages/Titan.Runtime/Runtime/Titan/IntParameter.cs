namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    public class IntParameter : ParameterBase<int>
    {
        protected override int GetValueFromExpressionValue(Value value)
        {
            return default(int);
        }

        public IntParameter()
        {
        }
    }
}
