namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Common;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CampusLightAnchorBase))]
    [TrackClipType(typeof(CampusLightAsset))]
    public class CampusLightTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        private void GatherPropertiesLightAnchor(CampusLightAnchor lightAnchor, IPropertyCollector driver)
        {
        }

        private void GatherPropertiesLightAnchorGroup(CampusLightAnchorGroup lightAnchorGroup, IPropertyCollector driver)
        {
        }

        protected void GatherPropertiesLight(IPropertyCollector driver, CampusLightAnchor lightAnchor)
        {
        }

        protected void GatherPropertiesTransformAnchor(IPropertyCollector driver, CampusTransformAnchor transformAnchor)
        {
        }

        public CampusLightTrack()
        {
        }
    }
}
