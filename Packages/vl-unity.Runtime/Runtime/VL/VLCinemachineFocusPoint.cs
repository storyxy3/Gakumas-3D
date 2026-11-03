namespace VL
{
    using global::Cinemachine;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    [AddComponentMenu("")]
    [SaveDuringPlay]
    public class VLCinemachineFocusPoint : CinemachineExtension
    {
        private class VcamFocusPointState
        {
            public VolumeProfile profile;
            public void CreateProfile()
            {
            }

            public void DestroyProfileCopy()
            {
            }

            public VcamFocusPointState()
            {
            }
        }

        public float offset;
        public Transform target;
        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public void InvalidateCachedProfile()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        public VLCinemachineFocusPoint()
        {
        }
    }
}
