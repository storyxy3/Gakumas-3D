namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Class)]
    public class ParameterRangeAttribute : Attribute
    {
        [CompilerGenerated]
        private readonly float _003CMin_003Ek__BackingField;
        [CompilerGenerated]
        private readonly float _003CMax_003Ek__BackingField;
        public ParameterRangeAttribute(float min, float max)
        {
        }
    }
}
