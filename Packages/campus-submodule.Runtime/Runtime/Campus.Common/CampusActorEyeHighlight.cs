namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL.FaceSystem;

    public class CampusActorEyeHighlight : MonoBehaviour
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

        public VLActorFaceModel target;
        public LimitData[] blendShapes;
        public float GetHighlightOffset()
        {
            float offset = 0f;
            if (target == null) return offset;
            if (blendShapes != null && blendShapes.Length > 0)
            {
                for (int i = 0; i < blendShapes.Length; i++)
                {
                    var shape = blendShapes[i];
                    offset += shape.value * Mathf.Clamp01(target.GetBlendShapeWeight(shape.index) / 100f);
                }
            }
            return offset;
        }

        public CampusActorEyeHighlight()
        {
        }
    }
}
