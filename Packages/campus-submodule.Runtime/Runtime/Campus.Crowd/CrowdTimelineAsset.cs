namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CrowdTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public CrowdTimelineBehaviour behaviour = new CrowdTimelineBehaviour();
        public ClipCaps clipCaps
        {
            get
            {
                if (behaviour?.crowdMotionDefine == null) return ClipCaps.None;
                return behaviour.crowdMotionDefine.isLoop ? (ClipCaps)27 : (ClipCaps)26;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return ScriptPlayable<CrowdTimelineBehaviour>.Create(graph, behaviour);
        }

        public CrowdTimelineAsset()
        {
        }
    }
}
