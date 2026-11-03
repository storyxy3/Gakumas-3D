namespace Campus.Common
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/Global Wind")]
    public class GlobalWindParameter : VolumeComponent
    {
        [Tooltip("X軸方向")]
        public FloatParameter directionX;
        [Tooltip("Y軸方向")]
        public FloatParameter directionY;
        [Tooltip("Z軸方向")]
        public FloatParameter directionZ;
        [Tooltip("形状")]
        public IntParameter type;
        [Tooltip("距離ズレ(Sphereのみ)")]
        public FloatParameter distanceGap;
        [Tooltip("定常的に掛かる力")]
        public FloatParameter constantPower;
        [Tooltip("振動する揺れの力")]
        public FloatParameter wavePower;
        [Tooltip("振動する揺れの周期")]
        public FloatParameter waveFrequency;
        [Tooltip("振動する力")]
        public FloatParameter vibrationPower;
        [Tooltip("波揺れの力")]
        public FloatParameter windWaveAmplitude;
        [Tooltip("波揺れの周期")]
        public FloatParameter windWaveFrequency;
        [Tooltip("波揺れの位相")]
        public FloatParameter windWavePhase;
        [Tooltip("揺れ範囲の最大")]
        public FloatParameter windRangeMax;
        [Tooltip("揺れ範囲の最小")]
        public FloatParameter windRangeMin;
        [Tooltip("揺れ範囲の周期")]
        public FloatParameter windRangeFrequency;
        [Tooltip("揺れ範囲の位相")]
        public FloatParameter windRangePhase;
        [Tooltip("ランダムに振動する力")]
        public FloatParameter randomPower;
        [Tooltip("ランダムに振動する周期")]
        public FloatParameter randomFrequency;
        public GlobalWindParameter()
        {
        }
    }
}
