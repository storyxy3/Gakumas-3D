namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Playables;

    public class CrowdTimelineMixerBehaviour : PlayableBehaviour
    {
        public CrowdAnimationTimeline crowdAnimationTimeline;
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            crowdAnimationTimeline.Pause();
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            crowdAnimationTimeline.Play();
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            int inputCount = playable.GetInputCount();
            crowdAnimationTimeline.SetTime(playable.GetTime());
            if (inputCount < 1)
            {
                crowdAnimationTimeline.Pause();
                return;
            }
            for (int layer = 0; layer < inputCount; layer++)
            {
                var input = playable.GetInput(layer);
                int count = input.GetInputCount();
                for (int index = 0; index < count; index++)
                {
                    var clip = (ScriptPlayable<CrowdTimelineBehaviour>)input.GetInput(index);
                    var behaviour = clip.GetBehaviour();
                    float weight = input.GetInputWeight(index);
                    if (layer == 1)
                    {
                        crowdAnimationTimeline.SetOverrideAnimationWeight(index, weight);
                        if (weight <= 0f) continue;
                        crowdAnimationTimeline.SetOverrideAnimationTime(index, clip.GetTime());
                    }
                    else
                    {
                        crowdAnimationTimeline.SetAnimationWeight(index, weight);
                        if (weight <= 0f) continue;
                        crowdAnimationTimeline.SetAnimationTime(index, clip.GetTime());
                    }
                    crowdAnimationTimeline.SetHidePenlight(behaviour.hidePenlight);
                }
            }
            if (info.evaluationType == FrameData.EvaluationType.Evaluate) crowdAnimationTimeline.Pause();
            else if (crowdAnimationTimeline.IsPaused()) crowdAnimationTimeline.Play();
        }

        public CrowdTimelineMixerBehaviour()
        {
        }
    }
}
