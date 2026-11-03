namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    public class GlobalWindVolume : Volume
    {
        public GlobalWindType type;
        public float constantPower;
        public float wavePower;
        public float waveFrequency;
        public float vibrationPower;
        public float windWaveAmplitude;
        public float windWaveFrequency;
        public float windWavePhase;
        public float windRangeMax;
        public float windRangeMin;
        public float windRangeFrequency;
        public float windRangePhase;
        public float randomPower;
        public float randomFrequency;
        public float distanceGap;
        private GlobalWindParameter _windParameter;
        private void LateUpdate()
        {
        }

        public GlobalWindVolume()
        {
        }
    }
}
