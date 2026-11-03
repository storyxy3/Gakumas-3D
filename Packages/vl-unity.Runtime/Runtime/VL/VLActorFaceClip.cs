namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;

    [CreateAssetMenu(fileName = "FaceClip.asset", menuName = "VL/Actor Face Clip", order = 70001)]
    public class VLActorFaceClip : CustomClip
    {
        public enum BindType
        {
            Transform = 0,
            FaceModel = 10,
            Decal = 11
        }

        [Serializable]
        public class BindData
        {
            public BindType type;
            public string path;
            public string attribute;
            public float value;
            public BindData()
            {
            }
        }

        public BindData[] bindArray;
        public override bool isLooping
        {
            get
            {
                return default(bool);
            }
        }

        public override float length
        {
            get
            {
                return default(float);
            }
        }

        public override Playable CreatePlayable(Animator animator, PlayableGraph graph)
        {
            return default(Playable);
        }

        public VLActorFaceClip()
        {
        }
    }
}
