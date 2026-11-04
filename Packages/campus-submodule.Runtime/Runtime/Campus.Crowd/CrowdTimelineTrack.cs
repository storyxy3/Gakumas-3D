namespace Campus.Crowd
{
    using global::System;
    using global::System.Linq;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CrowdAnimationTimeline))]
    [TrackClipType(typeof(CrowdTimelineAsset))]
    public class CrowdTimelineTrack : PlayableTrack, ILayerable
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<TimelineClip, int, (CrowdTimelineBehaviour behaviour, int index)> _003C_003E9__0_0;
            public static Func<TimelineClip, int, (CrowdTimelineBehaviour behaviour, int index)> _003C_003E9__0_1;
            public _003C_003Ec()
            {
            }

            internal (CrowdTimelineBehaviour, int) _003CCreateLayerMixer_003Eb__0_0(TimelineClip clip, int index)
            {
                var asset = clip.asset as CrowdTimelineAsset;
                return (asset != null ? asset.behaviour : null, index);
            }

            internal (CrowdTimelineBehaviour, int) _003CCreateLayerMixer_003Eb__0_1(TimelineClip clip, int index)
            {
                var asset = clip.asset as CrowdTimelineAsset;
                return (asset != null ? asset.behaviour : null, index);
            }
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            if (!go.TryGetComponent<PlayableDirector>(out var director)) return base.CreateTrackMixer(graph, go, inputCount);
            var mixer = ScriptPlayable<CrowdTimelineMixerBehaviour>.Create(graph, inputCount);
            var timeline = director.GetGenericBinding(this) as CrowdAnimationTimeline;
            if (timeline == null) return base.CreateTrackMixer(graph, go, inputCount);
            timeline.SetAnimationCount(GetClips().Count());
            foreach (var item in GetClips().Select(_003C_003Ec._003C_003E9__0_0 ?? (_003C_003Ec._003C_003E9__0_0 = _003C_003Ec._003C_003E9._003CCreateLayerMixer_003Eb__0_0)))
                if (item.behaviour != null && item.behaviour.crowdMotionDefine != null) timeline.SetAnimationData(item.index, item.behaviour);
            var child = GetChildTracks().FirstOrDefault();
            if (child != null)
            {
                timeline.SetOverrideAnimationCount(child.GetClips().Count());
                foreach (var item in child.GetClips().Select(_003C_003Ec._003C_003E9__0_1 ?? (_003C_003Ec._003C_003E9__0_1 = _003C_003Ec._003C_003E9._003CCreateLayerMixer_003Eb__0_1)))
                    if (item.behaviour != null && item.behaviour.crowdMotionDefine != null) timeline.SetOverrideAnimationData(item.index, item.behaviour);
            }
            mixer.GetBehaviour().crowdAnimationTimeline = timeline;
            return mixer;
        }

        public CrowdTimelineTrack()
        {
        }
    }
}
