namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;

    public class MotionDefinePlayable : PlayableBehaviour
    {
        public Animator animator;
        public MotionDefine motionDefine;
        public bool isAdditive;
        public IReadOnlyList<AnimationData> defaultAnimations;
        public bool isTimeline;
        private AnimationLayerMixerPlayable _layerMixerPlayable;
        private ScriptPlayable<MotionEffectPlayable> _motionEffectPlayable;
        public override void OnPlayableCreate(Playable playable)
        {
            if (animator == null)
            {
                Debug.LogError("MotionDefinePlayable: Animatorが指定されていません");
                return;
            }
            int animationCount = motionDefine.count;
            int defaultCount = defaultAnimations?.Count ?? 0;
            bool hasEffects = motionDefine.effects != null && motionDefine.effects.Length > 0;
            _layerMixerPlayable = AnimationLayerMixerPlayable.Create(playable.GetGraph(), Mathf.Max(animationCount, defaultCount));
            playable.SetPropagateSetTime(true);
            playable.SetInputCount(hasEffects ? 2 : 1);
            playable.ConnectInput(0, _layerMixerPlayable, 0, 1f);
            _layerMixerPlayable.SetPropagateSetTime(true);
            for (int i = 0; i < _layerMixerPlayable.GetInputCount(); ++i)
            {
                AnimationData data = i < animationCount ? motionDefine[i] : null;
                if (data == null || !data.isValid)
                {
                    if (defaultAnimations != null)
                    {
                        if (i >= defaultCount)
                            continue;
                        data = defaultAnimations[i];
                    }
                }
                if (data != null && data.isValid)
                {
                    Playable input = data.CreatePlayable(animator, playable.GetGraph());
                    _layerMixerPlayable.ConnectInput(i, input, 0, 1f);
                    _layerMixerPlayable.SetLayerAdditive((uint)i, isAdditive);
                    if (data.mask != null)
                        _layerMixerPlayable.SetLayerMaskFromAvatarMask((uint)i, data.mask);
                }
            }
            if (hasEffects)
            {
                _motionEffectPlayable = ScriptPlayable<MotionEffectPlayable>.Create(playable.GetGraph(), new MotionEffectPlayable
                {
                    root = animator.gameObject,
                    effects = motionDefine.effects,
                    defaultAnimationLength = motionDefine.animationLength,
                    isLoopMotionEffect = motionDefine.isLoopMotionEffect,
                    isTimeline = isTimeline
                });
                _motionEffectPlayable.SetPropagateSetTime(true);
                playable.ConnectInput(1, _motionEffectPlayable, 0, 1f);
            }
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            _layerMixerPlayable.Play();
            for (int i = 0; i < _layerMixerPlayable.GetInputCount(); ++i)
                _layerMixerPlayable.GetInput(i).Play();
            if (_motionEffectPlayable.IsValid())
                _motionEffectPlayable.Play();
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            _layerMixerPlayable.Pause();
            for (int i = 0; i < _layerMixerPlayable.GetInputCount(); ++i)
                _layerMixerPlayable.GetInput(i).Pause();
            if (_motionEffectPlayable.IsValid())
                _motionEffectPlayable.Pause();
        }

        public MotionDefinePlayable()
        {
        }
    }
}
