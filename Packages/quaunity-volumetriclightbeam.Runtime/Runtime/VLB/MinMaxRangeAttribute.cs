namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;

    public class MinMaxRangeAttribute : Attribute
    {
        [CompilerGenerated]
        private float _003CminValue_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CmaxValue_003Ek__BackingField;
        private float minValue
        {
            [CompilerGenerated]
            set
            {
                _003CminValue_003Ek__BackingField = value;
            }
        }

        private float maxValue
        {
            [CompilerGenerated]
            set
            {
                _003CmaxValue_003Ek__BackingField = value;
            }
        }

        public MinMaxRangeAttribute(float min, float max)
        {
        }
    }
}
