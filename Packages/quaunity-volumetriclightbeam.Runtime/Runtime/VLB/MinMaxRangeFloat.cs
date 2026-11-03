namespace VLB
{
    using global::System;
    using global::UnityEngine;
    using global::VLB;

    [Serializable]
    public struct MinMaxRangeFloat : IEquatable<MinMaxRangeFloat>
    {
        [SerializeField]
        private float m_MinValue;
        [SerializeField]
        private float m_MaxValue;
        public float minValue
        {
            get
            {
                return default(float);
            }
        }

        public float maxValue
        {
            get
            {
                return default(float);
            }
        }

        public float randomValue
        {
            get
            {
                return default(float);
            }
        }

        public float GetLerpedValue(float lerp01)
        {
            return default(float);
        }

        public MinMaxRangeFloat(float min, float max)
        {
            this = default;
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(MinMaxRangeFloat other)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
        {
            return default(bool);
        }

        public static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
        {
            return default(bool);
        }
    }
}
