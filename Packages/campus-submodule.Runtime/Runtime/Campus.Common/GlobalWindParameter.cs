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
        public FloatParameter directionX = new FloatParameter(0f);
        [Tooltip("Y軸方向")]
        public FloatParameter directionY = new FloatParameter(0f);
        [Tooltip("Z軸方向")]
        public FloatParameter directionZ = new FloatParameter(0f);
        [Tooltip("形状")]
        public IntParameter type = new IntParameter(0);
        [Tooltip("距離ズレ(Sphereのみ)")]
        public FloatParameter distanceGap = new FloatParameter(0f);
        [Tooltip("定常的に掛かる力")]
        public FloatParameter constantPower = new FloatParameter(0f);
        [Tooltip("振動する揺れの力")]
        public FloatParameter wavePower = new FloatParameter(0f);
        [Tooltip("振動する揺れの周期")]
        public FloatParameter waveFrequency = new FloatParameter(0f);
        [Tooltip("振動する力")]
        public FloatParameter vibrationPower = new FloatParameter(0f);
        [Tooltip("波揺れの力")]
        public FloatParameter windWaveAmplitude = new FloatParameter(0f);
        [Tooltip("波揺れの周期")]
        public FloatParameter windWaveFrequency = new FloatParameter(1f);
        [Tooltip("波揺れの位相")]
        public FloatParameter windWavePhase = new FloatParameter(0f);
        [Tooltip("揺れ範囲の最大")]
        public FloatParameter windRangeMax = new FloatParameter(10f);
        [Tooltip("揺れ範囲の最小")]
        public FloatParameter windRangeMin = new FloatParameter(-10f);
        [Tooltip("揺れ範囲の周期")]
        public FloatParameter windRangeFrequency = new FloatParameter(0f);
        [Tooltip("揺れ範囲の位相")]
        public FloatParameter windRangePhase = new FloatParameter(0f);
        [Tooltip("ランダムに振動する力")]
        public FloatParameter randomPower = new FloatParameter(0f);
        [Tooltip("ランダムに振動する周期")]
        public FloatParameter randomFrequency = new FloatParameter(0f);
        public GlobalWindParameter()
        {
        }
    }
}
