namespace VL.Animation.Timeline
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::VL.Timeline;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL.Animation;
    using global::VL.Animation.Timeline;

    [Serializable]
    [TrackClipType(typeof(MotionDefinePlayerTimelineAsset), false)]
    [TrackBindingType(typeof(MotionDefinePlayer))]
    [TrackColor(0.1f, 0f, 1f)]
    public class MotionDefinePlayerTimelineTrack : PlayableTrack, ILayerable
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<TimelineClip, bool> _003C_003E9__2_0;
            public static Func<TrackAsset, bool> _003C_003E9__3_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CCreateLayerParams_003Eb__2_0(TimelineClip x)
            {
                return x.asset is MotionDefinePlayerTimelineAsset;
            }

            internal bool _003CCreateLayerMixer_003Eb__3_0(TrackAsset x)
            {
                return !x.mutedInHierarchy;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public PlayableGraph graph;
            public bool isAdditive;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal ClipParam _003CCreateLayerParams_003Eb__1(TimelineClip clip)
            {
                var asset = clip.asset as MotionDefinePlayerTimelineAsset;
                MotionDefine resolved = asset.exposedMotion.Resolve(graph.GetResolver());
                MotionDefine motion = resolved != null ? resolved : asset.motion != null ? asset.motion : null;
                if (motion == null)
                    Debug.LogError("Timeline: " + clip.displayName + " にMotionDefine・ExposedMotionが設定されていません");
                else
                    isAdditive |= motion.isAdditive;
                return new ClipParam(motion).SetLength(clip.duration);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public MotionDefinePlayerTimelineTrack _003C_003E4__this;
            public PlayableGraph graph;
            public MotionDefinePlayer player;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal ILayerAnimationController _003CCreateLayerMixer_003Eb__1(TrackAsset track, int index)
            {
                return player.CreateLayerController(_003C_003E4__this.CreateLayerParams(graph, index, track.GetClips()));
            }
        }

        protected override void OnCreateClip(TimelineClip clip)
        {
            MotionDefine motion = ((MotionDefinePlayerTimelineAsset)clip.asset).motion;
            if (motion != null)
                clip.displayName = motion.name;
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return Playable.Create(graph, inputCount);
        }

        private LayerParam CreateLayerParams(PlayableGraph graph, int index, IEnumerable<TimelineClip> clips)
        {
            var closure = new _003C_003Ec__DisplayClass2_0 { graph = graph, isAdditive = false };
            var selected = clips.Where(_003C_003Ec._003C_003E9__2_0 ?? (_003C_003Ec._003C_003E9__2_0 = new Func<TimelineClip, bool>(_003C_003Ec._003C_003E9._003CCreateLayerParams_003Eb__2_0)))
                .Select(new Func<TimelineClip, ClipParam>(closure._003CCreateLayerParams_003Eb__1));
            return new LayerParam(selected).SwitchToExternalControl().SetLayerName("Timeline" + index.ToString()).SetLayerAdditive(closure.isAdditive);
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var closure = new _003C_003Ec__DisplayClass3_0 { _003C_003E4__this = this, graph = graph };
            if (go.TryGetComponent(out PlayableDirector director))
            {
                closure.player = director.GetGenericBinding(this) as MotionDefinePlayer;
                if (closure.player != null)
                {
                    ILayerAnimationController[] controllers = Enumerable.Empty<TrackAsset>().Append(this).Concat(GetChildTracks())
                        .Where(_003C_003Ec._003C_003E9__3_0 ?? (_003C_003Ec._003C_003E9__3_0 = new Func<TrackAsset, bool>(_003C_003Ec._003C_003E9._003CCreateLayerMixer_003Eb__3_0)))
                        .Select(new Func<TrackAsset, int, ILayerAnimationController>(closure._003CCreateLayerMixer_003Eb__1)).ToArray();
                    VLActorMotionResetMarker[] resetMarkers = GetMarkers().OfType<VLActorMotionResetMarker>().ToArray();
                    VLActorAnimationManagePropertyDataApplyMarker[] propertyMarkers = GetMarkers().OfType<VLActorAnimationManagePropertyDataApplyMarker>().ToArray();
                    return MotionDefinePlayerTimelineTrackLayerBehaviour.Create(graph, inputCount, closure.player, controllers, resetMarkers, propertyMarkers);
                }
            }
            return Playable.Create(graph, inputCount);
        }

        public MotionDefinePlayerTimelineTrack()
        {
        }
    }
}
