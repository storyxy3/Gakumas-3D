// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, LateUpdate, OnDisable, OnEnable.
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
        }

        protected override void OnDisable()
        {
        }

        private void LateUpdate()
        {
        }

        public VideoImage()
        {
        }
    }
}
