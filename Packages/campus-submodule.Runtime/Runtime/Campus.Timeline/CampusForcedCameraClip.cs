namespace Campus.Timeline
{
    using global::System;
    using global::System.ComponentModel;
    using global::Campus.Common.Panorama;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [DisplayName("カメラ強制指定クリップ")]
    public class CampusForcedCameraClip : PlayableAsset, ITimelineClipAsset
    {
        public PanoramaCameraType CameraType;
        public int CameraIndex;
        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CampusForcedCameraClip()
        {
        }
    }
}
