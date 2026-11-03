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

        public VLActorBlendShapeLimitDataRuntime()
        {
        }
    }
}
