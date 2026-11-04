namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/Actor Rim")]
    public class CampusActorRim : VolumeComponent
    {
        [Tooltip("リムの色 (出さない場合は黒)")]
        public ColorParameter color = new ColorParameter(Color.white, false, false, false, false);
        [Tooltip("リムの強度")]
        public FloatParameter intensity = new MinFloatParameter(0f, 0f);
        [Tooltip("リムの角度")]
        public Vector2Parameter rimAngle = new Vector2Parameter(Vector2.zero);
        [Tooltip("リム色上書き割合")]
        public FloatParameter rimAdditive = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("リムの掛け方")]
        public FloatParameter rimPower = new ClampedFloatParameter(8f, 1f, 32f);
        public CampusActorRim()
        {
        }
    }
}
