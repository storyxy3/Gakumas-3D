namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    public class VLActorTalkData : ScriptableObject
    {
        [Serializable]
        public class TalkCurve
        {
            public int index;
            public AnimationCurve curve;
            public TalkCurve()
            {
            }
        }

        [Serializable]
        public class TalkBlend
        {
            public string blendShape;
            public float value;
            public TalkBlend()
            {
            }
        }

        [Serializable]
        public class TalkData
        {
            public TalkCurve[] talkCurves;
            public string previewName;
            public bool ignoreVoice;
            public TalkBlend[] blends;
            public TalkData()
            {
            }
        }

        public enum TalkAdditiveType
        {
            TransX,
            TransZ
        }

        [Serializable]
        public class TalkAdditiveBinding
        {
            public string path;
            public AnimationCurve[] curves;
            public TalkAdditiveType[] types;
            public TalkAdditiveBinding()
            {
            }
        }

        [Serializable]
        public class TalkAdditiveData
        {
            public TalkAdditiveBinding[] bindings;
            public TalkAdditiveData()
            {
            }
        }

        public TalkData[] talks;
        public string[] targetBlendShapes;
        public int totalCurveCount;
        public int totalKeyframeCount;
        public TalkAdditiveData[] additiveDatas;
        public VLActorTalkData()
        {
        }
    }
}
