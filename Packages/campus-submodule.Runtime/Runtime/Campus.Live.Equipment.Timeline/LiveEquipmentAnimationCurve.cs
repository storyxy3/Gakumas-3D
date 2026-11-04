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
                return intensity != null && intensity.IsValid;
            }
        }

        public bool HasColor
        {
            get
            {
                return colorGradient != null && colorGradient.IsValid;
            }
        }

        public bool HasYow
        {
            get
            {
                return Yow != null && Yow.IsValid;
            }
        }

        public bool HasPitch
        {
            get
            {
                return Pitch != null && Pitch.IsValid;
            }
        }

        public bool HasV2
        {
            get
            {
                return v2 != null && v2.IsValid;
            }
        }

        public bool HasV3
        {
            get
            {
                return v3 != null && v3.IsValid;
            }
        }

        public LiveEquipmentAnimationCurve()
        {
        }
    }
}
