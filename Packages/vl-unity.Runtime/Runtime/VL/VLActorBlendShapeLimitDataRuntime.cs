namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public class VLActorBlendShapeLimitDataRuntime
    {
        public SkinnedMeshRenderer renderer;
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
            if (renderer == null || blendShapes == null) return false;
            for (int i = 0; i < blendShapes.Length; ++i)
            {
                var data = blendShapes[i];
                if (renderer.GetBlendShapeWeight(data.index) >= data.limit) return true;
            }
            return false;
        }

        public bool IsValid(int index)
        {
            return renderer != null && blendShapes != null && blendShapes.Length > index;
        }

        public bool IsLimit(int index)
        {
            if (!IsValid(index)) return false;
            var data = blendShapes[index];
            return renderer.GetBlendShapeWeight(data.index) >= data.limit;
        }

        public void Update()
        {
            for (int i = 0; i < Length; ++i)
                if (!IsLimit(i)) SetBlendShapeWeight(i, 0);
        }

        public void SetBlendShapeWeight(int index, float value)
        {
            if (IsValid(index)) renderer.SetBlendShapeWeight(blendShapes[index].index, value);
        }

        public VLActorBlendShapeLimitDataRuntime()
        {
        }
    }
}
