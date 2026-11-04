namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Animations;
    using global::VL;

    [Serializable]
    public class AnimationData
    {
        public AnimationClip clip;
        public CustomClip customClip;
        public AvatarMask mask;
        [Tooltip("PlayableIKを使用するかどうか")]
        public bool applyPlayableIK;
        [Tooltip("FootIKを使用するかどうか")]
        public bool applyFootIK;
        public List<AnimationBindingData> bindings;
        public bool isLoop
        {
            get
            {
                return customClip != null ? customClip.isLooping : clip != null && clip.isLooping;
            }
        }

        public float animationLength
        {
            get
            {
                return customClip != null ? customClip.length : clip != null ? clip.length : 0f;
            }
        }

        public bool isValid
        {
            get
            {
                return customClip != null || clip != null;
            }
        }

        public Playable CreatePlayable(Animator animator, PlayableGraph graph)
        {
            if (customClip != null)
                return customClip.CreatePlayable(animator, graph);
            return CreateAnimationClipPlayable(graph);
        }

        public Playable CreateAnimationClipPlayable(PlayableGraph graph)
        {
            if (clip == null)
                return Playable.Null;
            AnimationClipPlayable playable = AnimationClipPlayable.Create(graph, clip);
            playable.SetApplyPlayableIK(applyPlayableIK);
            playable.SetApplyFootIK(applyFootIK);
            return playable;
        }

        public AnimationData()
        {
        }
    }
}
