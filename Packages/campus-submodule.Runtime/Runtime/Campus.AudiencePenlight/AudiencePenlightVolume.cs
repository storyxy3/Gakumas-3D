namespace Campus.AudiencePenlight
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class AudiencePenlightVolume : Volume
    {
        [NonSerialized]
        private AudiencePenlightVolumeComponent _audiencePenlightVolumeComponent;
        [NonSerialized]
        private IAudiencePenlight _audiencePenlight;
        public IAudiencePenlight AudiencePenlight
        {
            get
            {
                return null;
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void UpdateParameters(ScriptableRenderContext context, List<Camera> cameras)
        {
        }

        public AudiencePenlightVolume()
        {
        }
    }
}
