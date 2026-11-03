namespace Campus.Timeline
{
    using global::System;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CampusTweenMixerBehaviour : PlayableBehaviour
    {
        [NonSerialized]
        [CanBeNull]
        public Transform target;
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        private bool HasAnyInputWeight(Playable playable)
        {
            return default(bool);
        }

        public CampusTweenMixerBehaviour()
        {
        }
    }
}
