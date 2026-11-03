#if !UNITY_2019_1_OR_NEWER
#define CINEMACHINE_TIMELINE
#endif
#if CINEMACHINE_TIMELINE

using UnityEngine.Playables;
using Cinemachine;

//namespace Cinemachine.Timeline
//{
    internal sealed class CinemachineShotPlayable : PlayableBehaviour
    {
        public CinemachineVirtualCameraBase VirtualCamera;
        // TODO(qa-recon): game shot storage and lifecycle signatures only.
        public UnityEngine.Animator CameraAnimator;
        public override void OnGraphStart(Playable playable) { }
        public override void OnBehaviourPlay(Playable playable, FrameData info) { }
        public override void OnBehaviourPause(Playable playable, FrameData info) { }

        public bool IsValid { get { return VirtualCamera != null; } }
    }
//}
#endif
