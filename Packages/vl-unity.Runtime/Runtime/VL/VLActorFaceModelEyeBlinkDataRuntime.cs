namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL.FaceSystem;

    [Serializable]
    public class VLActorFaceModelEyeBlinkDataRuntime
    {
        public VLActorFaceModel faceModel;
        public int blendShapeIndex;
        public AnimationCurve curve;
        public void SetBlendShapeWeight(float value)
        {
        }

        public VLActorFaceModelEyeBlinkDataRuntime()
        {
        }
    }
}
