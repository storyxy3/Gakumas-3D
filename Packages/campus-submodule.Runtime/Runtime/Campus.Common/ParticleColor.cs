namespace Campus.Common
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ParticleColor
    {
        [SerializeField]
        private string _key;
        [SerializeField]
        private ParticleSystem.MinMaxGradient _color;
        public string Key
        {
            get
            {
                return null;
            }
        }

        public ParticleSystem.MinMaxGradient Color
        {
            get
            {
                return default(ParticleSystem.MinMaxGradient);
            }
        }

        public ParticleColor()
        {
        }
    }
}
