namespace Campus.Timeline
{
    using global::System.Collections.Generic;
    using global::Campus.Common.Panorama;
    using global::Campus.Timeline;
    using global::Cinemachine;
    using global::UnityEngine.Playables;

    public class CampusForcedCameraMixerBehaviour : PlayableBehaviour
    {
        private struct ClipInfo
        {
            public ICinemachineCamera vcam;
            public float weight;
            public double localTime;
            public double duration;
            public PanoramaCameraType cameraType;
            public int cameraIndex;
        }

        public IPanoramaCameraController controller;
        private IForcedCameraInternal _internal;
        private int _sourceId;
        private bool _inClip;
        private (PanoramaCameraType type, int index) _previousIncoming;
        private readonly HashSet<(PanoramaCameraType, int)> _warnedKeys;
        public override void OnGraphStart(Playable playable)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        private void NotifyClipEntered(PanoramaCameraType type, int index)
        {
        }

        private void NotifyClipExited()
        {
        }

        private void WarnUnregisteredOnce(PanoramaCameraType type, int index)
        {
        }

        public CampusForcedCameraMixerBehaviour()
        {
        }
    }
}
