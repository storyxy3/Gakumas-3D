namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Animation.Legacy;

    [AddComponentMenu("")]
    public class VLActorBodyAdditiveAnimation : VLActorExtension
    {
        public static readonly string LAYER_NAME;
        public float transitionTime;
        [SerializeField]
        private MotionDefine[] _motions;
        private IAnimationPlayer _animationPlayer;
        private ILayerAnimationController _layerController;
        private IVLAnimationPlayerController[] _animationControllers;
        private bool _isAdditiveEnable;
        public override void Initialize()
        {
        }

        public override void Dispose()
        {
        }

        public bool IsValidMotion(MotionDefine[] motions)
        {
            return default(bool);
        }

        public void SetAdditiveAnimation(MotionDefine motion)
        {
            _motions = new[] { motion };
            // TODO(qa-recon): needs vl-unity.Runtime::VLActorBodyAdditiveAnimation.Dispose/Initialize (outside the supplied method census).
            Dispose();
            Initialize();
        }

        public void SetAdditiveAnimation(MotionDefine[] motions)
        {
            _motions = motions;
            // TODO(qa-recon): needs vl-unity.Runtime::VLActorBodyAdditiveAnimation.Dispose/Initialize (outside the supplied method census).
            Dispose();
            Initialize();
        }

        private void OnPrepareFrameEvent(VLAnimationClipParam currentParam, VLAnimationClipParamMixerPlayable playable, float currentTime, FrameData info)
        {
        }

        private void OnMDPlayerPrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
        }

        public VLActorBodyAdditiveAnimation()
        {
        }
    }
}
