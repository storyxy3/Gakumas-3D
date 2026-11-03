namespace VL.Timeline.Legacy
{
    using global::UnityEngine.Playables;
    using global::VL.Timeline.Legacy;

    public class VLAnimationClipPlayerTimelineMixerPlayable : PlayableBehaviour
    {
        public double delay;
        public int inputCount;
        private Playable _mixerPlayable;
        private int _currentInputIndex;
        public static ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable> Create(PlayableGraph graph, Playable timelinePlayable)
        {
            return default(ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable>);
        }

        public void AddClipPlayable(ScriptPlayable<VLAnimationClipPlayerTimelineClipPlayable> playable)
        {
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public int GetInputCount()
        {
            return default(int);
        }

        public void SetInputWeight(int index, float weight)
        {
        }

        public VLAnimationClipPlayerTimelineMixerPlayable()
        {
        }
    }
}
