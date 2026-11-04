namespace VL
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class VLActorEyeBlinkDataRuntime
    {
        public SkinnedMeshRenderer renderer;
        public int blendShapeIndex;
        public AnimationCurve curve;
        public void SetBlendShapeWeight(float value)
        {
            if (renderer != null && blendShapeIndex >= 0) renderer.SetBlendShapeWeight(blendShapeIndex, value);
        }

        public VLActorEyeBlinkDataRuntime()
        {
        }
    }
}
