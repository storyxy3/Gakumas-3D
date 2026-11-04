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
        public FloatParameter shadowStrength = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("オフセットを使用する")]
        public FloatParameter useOffset = new ClampedFloatParameter(1f, 0f, 1f);
        [Tooltip("Lightの方向")]
        public VLActorShadowDirectionalTypeParameter directionalType = new VLActorShadowDirectionalTypeParameter(VLActorShadowDirectionalType.Fixed);
        [Tooltip("Fixedモードの時の角度")]
        public Vector2Parameter lightDirectional = new Vector2Parameter(Vector2.zero);
        [Tooltip("FacePartsの影適用量")]
        public FloatParameter facePartsShadowStrength = new ClampedFloatParameter(0f, 0f, 1f);
        public VLActorShadow()
        {
        }
    }
}
