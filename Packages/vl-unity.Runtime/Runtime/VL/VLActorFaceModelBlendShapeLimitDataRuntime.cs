namespace VL
{
    using global::System;
    using global::VL;
    using global::VL.FaceSystem;

    [Serializable]
    public class VLActorFaceModelBlendShapeLimitDataRuntime
    {
        public VLActorFaceModel faceModel;
        public VLActorBlendShapeIndexLimitData[] blendShapes;
        public int Length
        {
            get
            {
                return default(int);
            }
        }

        public bool IsLimit()
        {
            return default(bool);
        }

        public bool IsValid(int index)
        {
            return default(bool);
        }

        public bool IsLimit(int index)
        {
            return default(bool);
        }

        public void Update()
        {
        }

        public void SetBlendShapeWeight(int index, float value)
        {
        }

        public VLActorFaceModelBlendShapeLimitDataRuntime()
        {
        }
    }
}
