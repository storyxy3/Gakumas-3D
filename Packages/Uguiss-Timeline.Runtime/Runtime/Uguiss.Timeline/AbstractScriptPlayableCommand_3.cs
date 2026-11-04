namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public abstract class AbstractScriptPlayableCommand<TEngine, TPlayable, TMixer> : AbstractPlayableCommand<TEngine> where TEngine : TimelineEngine where TPlayable : PlayableBehaviour, new()
        where TMixer : PlayableBehaviour, new()
    {
        protected override Playable CreatePlayable(PlayableGraph graph)
        {
            return default(Playable);
        }

        public override Playable CreateMixerPlayable(PlayableGraph graph, int inputCount)
        {
            return default(Playable);
        }

        public override PlayableOutput CreatePlayableOutput(PlayableGraph graph)
        {
            return default(PlayableOutput);
        }

        protected TPlayable GetPlayableBehaviour()
        {
            return TimelineEngineUtility.GetPlayableBehaviour<TPlayable>(Playable);
        }

        protected AbstractScriptPlayableCommand()
        {
        }
    }
}
