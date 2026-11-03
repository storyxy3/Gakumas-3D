namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/Lit Actor")]
    public class CampusLitActor : VolumeComponent
    {
        [Tooltip("ライトカラー")]
        public ColorParameter lightColor;
        [Tooltip("giスケール")]
        public FloatParameter giScale;
        [Tooltip("陰影ライト角度空間")]
        public LightSpaceTypeParameter mainLightSpace;
        [Tooltip("陰影ライト角度")]
        public Vector2Parameter mainLightAngle;
        [Tooltip("陰の量オフセット")]
        public FloatParameter matCapOffset;
        [Tooltip("陰の適用量")]
        public FloatParameter shadeApplyRatio;
        [Tooltip("陰の追加乗算カラー")]
        public ColorParameter shadeColorMultiply;
        [Tooltip("陰の追加加算カラー")]
        public ColorParameter shadeColorAdditive;
        [Tooltip("リムの角度")]
        public Vector2Parameter rimAngle;
        [Tooltip("リムのbaseColor乗算割合")]
        public FloatParameter rimBaseColorRatio;
        [Tooltip("リムの掛け方")]
        public FloatParameter rimPower;
        [Tooltip("リムの色 (出さない場合は黒)")]
        public ColorParameter rimColor;
        public CampusLitActor()
        {
        }
    }
}
