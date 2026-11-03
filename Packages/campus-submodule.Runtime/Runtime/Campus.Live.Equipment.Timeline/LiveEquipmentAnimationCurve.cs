namespace Campus.Live.Equipment.Timeline
{
    using global::System;
    using global::Campus.Common;

    [Serializable]
    public class LiveEquipmentAnimationCurve
    {
        public ColorGradient colorGradient;
        public FloatCurve intensity;
        public FloatCurve Yow;
        public FloatCurve Pitch;
        public FloatCurve v2;
        public FloatCurve v3;
        public bool HasIntensity
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasColor
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasYow
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasPitch
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasV2
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasV3
        {
            get
            {
                return default(bool);
            }
        }

        public LiveEquipmentAnimationCurve()
        {
        }
    }
}
