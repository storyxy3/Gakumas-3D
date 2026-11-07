namespace Uguiss.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class CommandMixerPlayable : MixerPlayableBase
    {
        [CompilerGenerated]
        private AbstractCommandPlayableCommand _003CCommand_003Ek__BackingField;
        internal AbstractCommandPlayableCommand Command
        {
            [CompilerGenerated]
            get
            {
                return _003CCommand_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CCommand_003Ek__BackingField = value;
            }
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public override void ResetMixer()
        {
        }

        public CommandMixerPlayable()
        {
        }
    }
}
