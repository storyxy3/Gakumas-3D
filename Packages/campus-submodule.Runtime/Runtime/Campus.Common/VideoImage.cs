namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.UI;
    using global::UnityEngine.Video;

    [ExecuteAlways]
    [RequireComponent(typeof(VideoPlayer))]
    public class VideoImage : RawImage
    {
        private VideoPlayer _videoPlayer;
        [CompilerGenerated]
        private bool _003CDisableAutoResumeOnApplicationPause_003Ek__BackingField;
        public bool DisableAutoResumeOnApplicationPause
        {
            [CompilerGenerated]
            get
            {
                return _003CDisableAutoResumeOnApplicationPause_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CDisableAutoResumeOnApplicationPause_003Ek__BackingField = value;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            _videoPlayer = GetComponent<VideoPlayer>();
            _videoPlayer.renderMode = VideoRenderMode.APIOnly;
            if (TryGetComponent<AudioSource>(out var audioSource))
            {
                _videoPlayer.EnableAudioTrack(0, true);
                _videoPlayer.SetTargetAudioSource(0, audioSource);
            }
            else
            {
                _videoPlayer.EnableAudioTrack(0, false);
                _videoPlayer.SetTargetAudioSource(0, null);
            }
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            texture = null;
        }

        private void LateUpdate()
        {
            if (texture == null) texture = _videoPlayer.texture;
        }

        public VideoImage()
        {
        }
    }
}
