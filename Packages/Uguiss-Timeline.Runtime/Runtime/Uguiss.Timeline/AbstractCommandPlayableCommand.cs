namespace Uguiss.Timeline
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public abstract class AbstractCommandPlayableCommand : AbstractPlayableCommand
    {
        [CompilerGenerated]
        private List<TimelineElement> _003CElements_003Ek__BackingField;
        private List<TimelineElement> Elements
        {
            [CompilerGenerated]
            set
            {
            }
        }

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

        protected virtual void OnCreateMixerPlayable()
        {
        }

        public virtual void OnPrepareFrame(Playable playable, FrameData info)
        {
        }

        public virtual void OnProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public virtual void OnResetMixer()
        {
        }

        protected AbstractCommandPlayableCommand()
        {
        }
    }
}
