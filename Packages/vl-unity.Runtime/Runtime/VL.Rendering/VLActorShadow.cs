namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [Serializable]
    [VolumeComponentMenu("VL/Actor Shadow")]
    public class VLActorShadow : VolumeComponent
    {
        [Tooltip("影の濃さ")]
        public FloatParameter shadowStrength;
        [Tooltip("オフセットを使用する")]
        public FloatParameter useOffset;
        [Tooltip("Lightの方向")]
        public VLActorShadowDirectionalTypeParameter directionalType;
        [Tooltip("Fixedモードの時の角度")]
        public Vector2Parameter lightDirectional;
        [Tooltip("FacePartsの影適用量")]
        public FloatParameter facePartsShadowStrength;
        public VLActorShadow()
        {
        }
    }
}
