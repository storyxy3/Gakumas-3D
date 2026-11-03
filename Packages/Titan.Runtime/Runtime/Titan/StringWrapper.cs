namespace Titan
{
    using global::System;
    using global::Titan;

    [Serializable]
    public class StringWrapper : IVariableValue
    {
        public string value;
        public object GetValue(IValueResolver resolver)
        {
            return null;
        }

        public StringWrapper()
        {
        }
    }
}
