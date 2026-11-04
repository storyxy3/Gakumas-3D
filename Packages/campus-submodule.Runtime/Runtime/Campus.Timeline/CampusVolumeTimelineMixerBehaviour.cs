namespace Campus.Timeline
{
    using global::UnityEngine.Playables;

    public class CampusVolumeTimelineMixerBehaviour : PlayableBehaviour
    {
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            int inputCount = playable.GetInputCount();
            (CampusVolumeTimelineBehaviour behaviour, float weight) first = default;
            (CampusVolumeTimelineBehaviour behaviour, float weight) second = default;
            for (int i = 0; i < inputCount; i++)
            {
                float weight = playable.GetInputWeight(i);
                var input = (ScriptPlayable<CampusVolumeTimelineBehaviour>)playable.GetInput(i);
                if (weight <= 0f) continue;
                var behaviour = input.GetBehaviour();
                if (!first.Equals(default))
                {
                    second = (behaviour, weight);
                    break;
                }
                first = (behaviour, weight);
            }
            if (first.Equals(default)) return;
            if (second.Equals(default))
            {
                first.behaviour.SetVolumeWeight(first.weight);
                first.behaviour.ResetVolumePriority();
                return;
            }
            var earlier = first.behaviour.startTime < second.behaviour.startTime ? first : second;
            var later = first.behaviour.startTime >= second.behaviour.startTime ? first : second;
            earlier.behaviour.SetVolumeWeight(1f);
            earlier.behaviour.ResetVolumePriority();
            later.behaviour.SetVolumeWeight(later.weight);
            later.behaviour.OffsetVolumePriority(1f);
        }

        public CampusVolumeTimelineMixerBehaviour()
        {
        }
    }
}
