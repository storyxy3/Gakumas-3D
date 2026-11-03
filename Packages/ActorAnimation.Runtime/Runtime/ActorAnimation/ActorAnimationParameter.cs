namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Actor Animation/Actor Animation Parameter")]
    public class ActorAnimationParameter : VolumeComponent
    {
        [Tooltip("リセット時に温めるフレーム数")]
        public IntParameter prewarmCount;
        [Tooltip("モデリング姿勢の維持率")]
        public ClampedFloatParameter modelingPoseWeight;
        [Tooltip("全体の適用量")]
        public ClampedFloatParameter weight;
        [Tooltip("揺れの適用量")]
        public ClampedFloatParameter swingPowerWeight;
        [Tooltip("胸揺れの適用量")]
        public ClampedFloatParameter swingBreastPowerWeight;
        [Tooltip("胸揺れ腕補正の適用量")]
        public ClampedFloatParameter swingBreastCorrectionPowerWeight;
        [Tooltip("ルートの適用量")]
        public ClampedFloatParameter rootWeight;
        [Tooltip("ルートの適用量(水平乗算)")]
        public ClampedFloatParameter rootHorizontalWeight;
        [Tooltip("ルートの適用量(鉛直乗算)")]
        public ClampedFloatParameter rootVerticalWeight;
        public ActorAnimationParameter()
        {
        }
    }
}
