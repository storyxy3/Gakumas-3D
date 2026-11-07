namespace VL.Unsafe.Jobs
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Animations;
    using global::VL.Unsafe.Jobs;

    public struct TalkBlendShapeJobData
    {
        [CompilerGenerated]
        private PropertyStreamHandle _003Chandle_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CshapeVector_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CcalcTemp_003Ek__BackingField;
        public PropertyStreamHandle handle
        {
            [CompilerGenerated]
            readonly get
            {
                return default(PropertyStreamHandle);
            }

            [CompilerGenerated]
            set
            {
                _003Chandle_003Ek__BackingField = value;
            }
        }

        public float shapeVector
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
                _003CshapeVector_003Ek__BackingField = value;
            }
        }

        public float calcTemp
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
                _003CcalcTemp_003Ek__BackingField = value;
            }
        }

        public void UpdateShapeVector(AnimationStream stream)
        {
        }

        public void UpdateCalcTemp(TalkTargetJobData data)
        {
        }

        public void ApplyTalkWeight(float talkWeight)
        {
        }

        public void ApplyStreamHandle(AnimationStream stream)
        {
        }
    }
}
