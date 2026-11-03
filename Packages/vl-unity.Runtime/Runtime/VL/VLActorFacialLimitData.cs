namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "VLActorFacialLimitData.asset", menuName = "VL/Actor/Facial Limit Data", order = 62000)]
    public class VLActorFacialLimitData : ScriptableObject
    {
        [Serializable]
        public class BlendShapeData
        {
            public string blendShapeName;
            public float limit;
            public BlendShapeData()
            {
            }
        }

        [Serializable]
        public class LimitData
        {
            public string path;
            public List<BlendShapeData> blendShapes;
            public LimitData()
            {
            }
        }

        public LimitData[] limitDatas;
        public VLActorFacialLimitData()
        {
        }
    }
}
