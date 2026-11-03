namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(PlayableDirectorGroup))]
    [TrackClipType(typeof(ConditionBranchClip))]
    [DisplayName("Titan/ConditionBranch")]
    public class ConditionBranchTrack : TweenTrackBase
    {
        protected override void InsertTween(TweenCreationContext context)
        {
        }

        private int GetClipTarget(ConditionBranchClip clipAsset)
        {
            return default(int);
        }

        public ConditionBranchTrack()
        {
        }
    }
}
