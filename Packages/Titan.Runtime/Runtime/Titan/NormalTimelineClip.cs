namespace Titan
{
    using global::Titan;

    public class NormalTimelineClip : LoopableTweenClip
    {
        public override bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public NormalTimelineClip()
        {
        }
    }
}
