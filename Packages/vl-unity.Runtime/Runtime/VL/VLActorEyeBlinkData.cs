namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "VLActorEyeBlinkData.asset", menuName = "VL/Actor/Eye Blink Data", order = 62001)]
    public class VLActorEyeBlinkData : ScriptableObject
    {
        [Serializable]
        public class BlinkData
        {
            public AnimationCurve curve;
            public string path;
            public string blendShapeName;
            public BlinkData()
            {
            }
        }

        [Serializable]
        public class LimitData
        {
            public string path;
            public List<string> blendShapeNames;
            public List<float> limits;
            public LimitData()
            {
            }
        }

        public float length;
        public BlinkData[] blinkDatas;
        public LimitData[] limitDatas;
        public VLActorEyeBlinkData()
        {
        }
    }
}
