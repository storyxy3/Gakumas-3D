namespace Campus.Gasha
{
    using global::Campus.Gasha.Sequences;
    using global::UnityEngine.Playables;

    public class GashaLightUpBehaviour : PlayableBehaviour
    {
        public GashaListSequence listSequence;
        public override void OnGraphStart(Playable playable)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public GashaLightUpBehaviour()
        {
        }
    }
}
