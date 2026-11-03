namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class EaseSetting
    {
        [SerializeField]
        private string _id;
        [SerializeField]
        private string _label;
        [SerializeField]
        private TitanEase _ease;
        [SerializeField]
        private AnimationCurve _curve;
        public string Id
        {
            get
            {
                return null;
            }
        }

        public string Label
        {
            get
            {
                return null;
            }
        }

        public TitanEase Ease
        {
            get
            {
                return default(TitanEase);
            }
        }

        public AnimationCurve Curve
        {
            get
            {
                return null;
            }
        }
    }
}
