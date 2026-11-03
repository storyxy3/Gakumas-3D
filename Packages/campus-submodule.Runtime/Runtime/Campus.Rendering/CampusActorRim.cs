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
        public ColorParameter color;
        [Tooltip("リムの強度")]
        public FloatParameter intensity;
        [Tooltip("リムの角度")]
        public Vector2Parameter rimAngle;
        [Tooltip("リム色上書き割合")]
        public FloatParameter rimAdditive;
        [Tooltip("リムの掛け方")]
        public FloatParameter rimPower;
        public CampusActorRim()
        {
        }
    }
}
