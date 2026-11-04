namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Pool;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class MotionEffectPlayable : PlayableBehaviour
    {
        public GameObject root;
        public EffectData[] effects;
        public double defaultAnimationLength;
        public bool isLoopMotionEffect;
        public bool isTimeline;
        public override void OnPlayableCreate(Playable playable)
        {
            if (effects == null)
                return;
            playable.SetInputCount(effects.Length);
            HashSet<string> tracks = HashSetPool<string>.Get();
            for (int i = 0; i < effects.Length; ++i)
            {
                EffectData data = effects[i];
                bool isSubTrack = data.effect != null && !tracks.Add(data.effect.trackName);
                Playable input = data.CreatePlayable(playable.GetGraph(), root, isSubTrack, isTimeline);
                input.SetPropagateSetTime(true);
                playable.ConnectInput(i, input, 0, 1f);
            }
            HashSetPool<string>.Release(tracks);
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            for (int i = 0; i < playable.GetInputCount(); ++i)
                playable.GetInput(i).Play();
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            for (int i = 0; i < playable.GetInputCount(); ++i)
                playable.GetInput(i).Pause();
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (effects == null)
                return;
            for (int i = 0; i < effects.Length; ++i)
            {
                EffectData effect = effects[i];
                double time = playable.GetTime() - effect.startTime;
                double duration = effect.duration == 0 ? double.MaxValue : effect.duration;
                if (isLoopMotionEffect)
                    time %= defaultAnimationLength;
                playable.SetInputWeight(i, time > duration || time < 0 ? 0f : 1f);
                playable.GetInput(i).SetTime(Math.Clamp(time, 0, duration));
            }
        }

        public MotionEffectPlayable()
        {
        }
    }
}
