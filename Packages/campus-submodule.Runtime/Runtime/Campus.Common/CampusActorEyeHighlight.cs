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
            return default(float);
        }

        public CampusActorEyeHighlight()
        {
        }
    }
}
