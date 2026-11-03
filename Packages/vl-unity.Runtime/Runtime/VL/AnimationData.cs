namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
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
                return default(bool);
            }
        }

        public float animationLength
        {
            get
            {
                return default(float);
            }
        }

        public bool isValid
        {
            get
            {
                return default(bool);
            }
        }

        public Playable CreatePlayable(Animator animator, PlayableGraph graph)
        {
            return default(Playable);
        }

        public Playable CreateAnimationClipPlayable(PlayableGraph graph)
        {
            return default(Playable);
        }

        public AnimationData()
        {
        }
    }
}
