namespace VL.Unsafe.Jobs
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Unsafe.Jobs;

    [BurstCompile]
    public struct VLActorTalkJob : IAnimationJob
    {
        public NativeList<TalkBlendShapeJobData> TalkBlendShapeData;
        public NativeList<TalkJobData> TalkData;
        public NativeArray<TalkCurveJobData> TalkCurveJobData;
        public NativeArray<KeyframeData> KeyframeData;
        public NativeArray<TalkTargetJobData> TalkTargetData;
        public float talkWeight;
        public int deltaTalkWeight;
        private bool _ignoreVoice;
        private float _time;
        public void ProcessAnimation(AnimationStream stream)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }
    }
}
