namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;

    public class VLActorFaceBehaviour : PlayableBehaviour
    {
        [BurstCompile]
        private struct FaceJob : IAnimationJob
        {
            public NativeArray<PropertyStreamHandle> handles;
            public NativeArray<float> values;
            public void ProcessAnimation(AnimationStream stream)
            {
            }

            public void ProcessRootMotion(AnimationStream stream)
            {
            }
        }

        private static readonly Dictionary<VLActorFaceClip.BindType, Type> BindTypeTable;
        public VLActorFaceClip.BindData[] bindArray;
        public Animator animator;
        private AnimationScriptPlayable _animationPlayable;
        private NativeArray<PropertyStreamHandle> _handles;
        private NativeArray<float> _values;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public VLActorFaceBehaviour()
        {
        }
    }
}
