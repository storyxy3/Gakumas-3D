namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    public class VLActorEyeHighlight : MonoBehaviour
    {
        [Serializable]
        public class LimitData
        {
            public int index;
            public float value;
            public LimitData()
            {
            }
        }

        public SkinnedMeshRenderer target;
        public LimitData[] blendShapes;
        public float GetHighlightOffset()
        {
            return default(float);
        }

        public VLActorEyeHighlight()
        {
        }
    }
}
