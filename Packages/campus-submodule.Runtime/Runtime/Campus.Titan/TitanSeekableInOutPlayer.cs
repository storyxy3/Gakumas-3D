namespace Campus.Titan
{
    using global::System.Runtime.CompilerServices;
    using global::Titan;

    public class TitanSeekableInOutPlayer
    {
        private readonly ITimelineTween _inTween;
        private readonly ITimelineTween _idleTween;
        private readonly ITimelineTween _outTween;
        [CompilerGenerated]
        private readonly float _003CInDuration_003Ek__BackingField;
        [CompilerGenerated]
        private readonly float _003COutDuration_003Ek__BackingField;
        public float InDuration
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }
        }

        public TitanSeekableInOutPlayer(TitanPlayer player)
        {
        }

        public void SeekIn(float time)
        {
        }

        public void SeekIdle(float time)
        {
        }

        public void SeekOut(float time)
        {
        }

        public void KillTweens()
        {
        }
    }
}
