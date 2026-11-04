namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.Video;

    [Serializable]
    [TrackClipType(typeof(CampusVideoPlayerClip))]
    [TrackBindingType(typeof(VideoPlayer))]
    [TrackColor(0.008f, 0.698f, 0.655f)]
    public class CampusVideoPlayerTrack : TrackAsset
    {
        [SerializeField]
        [NotKeyable]
        public bool Loop = true;
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            if (!go.TryGetComponent<PlayableDirector>(out var director)) return base.CreateTrackMixer(graph, go, inputCount);
            if (!(director.GetGenericBinding(this) is VideoPlayer videoPlayer) || !videoPlayer.TryGetComponent<global::Campus.Common.VideoImage>(out var videoImage)) return base.CreateTrackMixer(graph, go, inputCount);
            videoPlayer.skipOnDrop = true;
            videoPlayer.waitForFirstFrame = false;
            videoPlayer.playOnAwake = false;
            videoPlayer.isLooping = Loop;
            var behaviour = new CampusVideoPlayerTrackBehaviour
            {
                VideoPlayer = videoPlayer,
                VideoImage = videoImage,
                IsRecording = false,
                IsPlayMode = Application.isPlaying,
                Loop = Loop
            };
            return ScriptPlayable<CampusVideoPlayerTrackBehaviour>.Create(graph, behaviour, inputCount);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
            base.GatherProperties(director, driver);
        }

        public CampusVideoPlayerTrack()
        {
        }
    }
}
