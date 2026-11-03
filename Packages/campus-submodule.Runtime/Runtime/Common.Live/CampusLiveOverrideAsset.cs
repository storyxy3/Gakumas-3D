namespace Common.Live
{
    using global::Common.Live;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Video;

    [CreateAssetMenu(fileName = "CampusLiveOverrideAsset", menuName = "Campus/LiveOverrideAsset")]
    public class CampusLiveOverrideAsset : ScriptableObject
    {
        [CanBeNull]
        public VideoClip videoClip;
        [CanBeNull]
        public OverrideMonitorSprite[] overrideMonitorSprites;
        [CanBeNull]
        public string[] muteTrackNames;
        [CanBeNull]
        public MuteTrackDisableSetting[] muteTrackDisableSettings;
        [CanBeNull]
        public string[] activeTrackNames;
        [CanBeNull]
        public OverrideActorMotionTrack[] overrideActorMotionTracks;
        [CanBeNull]
        public OverrideActorHierarchyTransform[] overrideActorHierarchyTransforms;
        public CampusLiveOverrideAsset()
        {
        }
    }
}
