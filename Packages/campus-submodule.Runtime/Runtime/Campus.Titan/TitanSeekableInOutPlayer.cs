namespace Campus.Titan
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Titan;
    using global::Titan;

    public class TitanSeekableInOutPlayer
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass9_0
        {
            public TitanPlayer player;
        }

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

        [CompilerGenerated]
        private static (ITimelineTween, float) _003C_002Ector_003Eg__InitializeTween_007C9_0(string groupName, ref _003C_003Ec__DisplayClass9_0 P_1)
        {
            return default((ITimelineTween, float));
        }
    }
}
