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
                if (_audiencePenlight == null) _audiencePenlight = GetComponent<IAudiencePenlight>();
                return _audiencePenlight;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            RenderPipelineManager.beginContextRendering += UpdateParameters;
        }

        protected override void OnDisable()
        {
            RenderPipelineManager.beginContextRendering -= UpdateParameters;
            base.OnDisable();
        }

        private void OnDestroy()
        {
            if (_audiencePenlightVolumeComponent != null) UnityEngine.Object.DestroyImmediate(_audiencePenlightVolumeComponent);
            UnityEngine.Object.DestroyImmediate(profile);
        }

        private void UpdateParameters(ScriptableRenderContext context, List<Camera> cameras)
        {
            if (_audiencePenlightVolumeComponent == null && !profile.TryGet(out _audiencePenlightVolumeComponent))
                _audiencePenlightVolumeComponent = profile.Add<AudiencePenlightVolumeComponent>();
            _audiencePenlightVolumeComponent.target.Override(this);
        }

        public AudiencePenlightVolume()
        {
        }
    }
}
