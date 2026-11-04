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
        public IntParameter prewarmCount = new IntParameter(30);
        [Tooltip("モデリング姿勢の維持率")]
        public ClampedFloatParameter modelingPoseWeight = new ClampedFloatParameter(0f, 0f, 1f);
        [Tooltip("全体の適用量")]
        public ClampedFloatParameter weight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("揺れの適用量")]
        public ClampedFloatParameter swingPowerWeight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("胸揺れの適用量")]
        public ClampedFloatParameter swingBreastPowerWeight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("胸揺れ腕補正の適用量")]
        public ClampedFloatParameter swingBreastCorrectionPowerWeight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("ルートの適用量")]
        public ClampedFloatParameter rootWeight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("ルートの適用量(水平乗算)")]
        public ClampedFloatParameter rootHorizontalWeight = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("ルートの適用量(鉛直乗算)")]
        public ClampedFloatParameter rootVerticalWeight = new ClampedFloatParameter(1f, 0f, 1f);
        public ActorAnimationParameter()
        {
        }
    }
}
