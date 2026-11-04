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
            if (!go.TryGetComponent<PlayableDirector>(out var director)) return base.CreateTrackMixer(graph, go, inputCount);
            var playable = ScriptPlayable<CampusLightMixerBehaviour>.Create(graph, inputCount);
            var behaviour = playable.GetBehaviour();
            var anchor = director.GetGenericBinding(this) as CampusLightAnchorBase;
            if (anchor != null)
            {
                behaviour.lightAnchor = anchor;
                behaviour.transformAnchor = anchor.GetComponent<ICampusTransformAnchor>();
            }
            return playable;
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        private void GatherPropertiesLightAnchor(CampusLightAnchor lightAnchor, IPropertyCollector driver)
        {
            if (lightAnchor == null) return;
            GatherPropertiesLight(driver, lightAnchor);
            GatherPropertiesTransformAnchor(driver, lightAnchor.GetComponentInChildren<CampusTransformAnchor>());
        }

        private void GatherPropertiesLightAnchorGroup(CampusLightAnchorGroup lightAnchorGroup, IPropertyCollector driver)
        {
            if (lightAnchorGroup == null) return;
            foreach (var light in lightAnchorGroup.LightAnchors) GatherPropertiesLight(driver, light);
            var group = lightAnchorGroup.GetComponentInChildren<CampusTransformAnchorGroup>();
            if (group != null)
                foreach (var anchor in group.TransformAnchors) GatherPropertiesTransformAnchor(driver, anchor);
        }

        protected void GatherPropertiesLight(IPropertyCollector driver, CampusLightAnchor lightAnchor)
        {
            if (lightAnchor == null || driver == null) return;
            var light = lightAnchor.targetLight;
            if (light == null) return;
            driver.AddFromName<Light>(light.gameObject, "m_Intensity");
            driver.AddFromName<Light>(light.gameObject, "m_Color");
            driver.AddFromName<Light>(light.gameObject, "m_ColorTemperature");
            driver.AddFromName<Light>(light.gameObject, "m_Range");
            driver.AddFromName<Light>(light.gameObject, "m_UseColorTemperature");
            driver.AddFromName<Light>(light.gameObject, "m_Shadows.m_Type");
            driver.AddFromName<Light>(light.gameObject, "m_Shadows.m_Strength");
            driver.AddFromName<Light>(light.gameObject, "m_SpotAngle");
            driver.AddFromName<Light>(light.gameObject, "m_InnerSpotAngle");
        }

        protected void GatherPropertiesTransformAnchor(IPropertyCollector driver, CampusTransformAnchor transformAnchor)
        {
            if (transformAnchor == null || driver == null) return;
            driver.AddFromComponent(transformAnchor.gameObject, transformAnchor);
            driver.AddFromComponent(transformAnchor.gameObject, transformAnchor.transform);
        }

        public CampusLightTrack()
        {
        }
    }
}
