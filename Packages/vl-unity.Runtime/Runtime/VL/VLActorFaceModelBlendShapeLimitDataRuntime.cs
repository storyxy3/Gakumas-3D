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
                return blendShapes?.Length ?? 0;
            }
        }

        public bool IsLimit()
        {
            if (faceModel == null || blendShapes == null) return false;
            for (int i = 0; i < blendShapes.Length; ++i)
            {
                var data = blendShapes[i];
                if (faceModel.GetBlendShapeWeight(data.index) >= data.limit) return true;
            }
            return false;
        }

        public bool IsValid(int index)
        {
            return faceModel != null && blendShapes != null && blendShapes.Length > index;
        }

        public bool IsLimit(int index)
        {
            if (!IsValid(index)) return false;
            var data = blendShapes[index];
            return faceModel.GetBlendShapeWeight(data.index) >= data.limit;
        }

        public void Update()
        {
            for (int i = 0; i < Length; ++i)
                if (!IsLimit(i)) SetBlendShapeWeight(i, 0);
        }

        public void SetBlendShapeWeight(int index, float value)
        {
            if (IsValid(index)) faceModel.SetBlendShapeWeight(blendShapes[index].index, value);
        }

        public VLActorFaceModelBlendShapeLimitDataRuntime()
        {
        }
    }
}
