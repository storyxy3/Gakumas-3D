namespace Titan
{
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [NotKeyable]
    public class ConditionBranchClip : LoopableTweenClip
    {
        [SerializeField]
        private int _playTimelineIndex;
        public int PlayTimelineIndex
        {
            get
            {
                return default(int);
            }
        }

        public override bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public ConditionBranchClip()
        {
        }
    }
}
