namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;

    [Serializable]
    public class CustomArcFlickDirectionData : IFlickDirectionData
    {
        [SerializeField]
        private string _directionName;
        [SerializeField]
        private float _startAngle;
        [SerializeField]
        private float _endAngle;
        [SerializeField]
        private float _threshold;
        public string DirectionName
        {
            get
            {
                return null;
            }
        }

        public float StartAngle
        {
            get
            {
                return default(float);
            }
        }

        public float EndAngle
        {
            get
            {
                return default(float);
            }
        }

        public float Threshold
        {
            get
            {
                return default(float);
            }
        }

        public override string ToString()
        {
            return null;
        }

        public CustomArcFlickDirectionData()
        {
        }
    }
}
