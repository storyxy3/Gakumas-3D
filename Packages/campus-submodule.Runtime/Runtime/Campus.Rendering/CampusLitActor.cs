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
        public ColorParameter lightColor = new ColorParameter(Color.white, true, false, true, false);
        [Tooltip("giスケール")]
        public FloatParameter giScale = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("陰影ライト角度空間")]
        public LightSpaceTypeParameter mainLightSpace = new LightSpaceTypeParameter((LightSpaceType)0);
        [Tooltip("陰影ライト角度")]
        public Vector2Parameter mainLightAngle = new Vector2Parameter(new Vector2(-7f, 7f));
        [Tooltip("陰の量オフセット")]
        public FloatParameter matCapOffset = new ClampedFloatParameter(0f, -1f, 1f);
        [Tooltip("陰の適用量")]
        public FloatParameter shadeApplyRatio = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("陰の追加乗算カラー")]
        public ColorParameter shadeColorMultiply = new ColorParameter(Color.white, false, false, false, false);
        [Tooltip("陰の追加加算カラー")]
        public ColorParameter shadeColorAdditive = new ColorParameter(Color.black, true, false, false, false);
        [Tooltip("リムの角度")]
        public Vector2Parameter rimAngle = new Vector2Parameter(Vector2.zero);
        [Tooltip("リムのbaseColor乗算割合")]
        public FloatParameter rimBaseColorRatio = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("リムの掛け方")]
        public FloatParameter rimPower = new ClampedFloatParameter(8f, 1f, 32f);
        [Tooltip("リムの色 (出さない場合は黒)")]
        public ColorParameter rimColor = new ColorParameter(Color.black, true, true, false, false);
        public CampusLitActor()
        {
        }
    }
}
