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
        public static readonly string LAYER_NAME = "baseAdditive";
        public float transitionTime = 0.3f;
        [SerializeField]
        private MotionDefine[] _motions;
        private IAnimationPlayer _animationPlayer;
        private ILayerAnimationController _layerController;
        private IVLAnimationPlayerController[] _animationControllers;
        private bool _isAdditiveEnable;
        public override void Initialize()
        {
            if (_motions == null) return;
            if (!TryGetComponent<IAnimationPlayer>(out _animationPlayer)) return;
            if (!_animationPlayer.initialized || !IsValidMotion(_motions)) return;
            if (_animationPlayer is IMotionDefinePlayer motionDefinePlayer)
            {
                motionDefinePlayer.onPrepareFrameEvent += OnMDPlayerPrepareFrameEvent;
            }
            else if (_animationPlayer is IVLAnimationClipPlayer clipPlayer)
            {
                _animationControllers = new IVLAnimationPlayerController[_motions.Length];
                for (int i = 0; i < _motions.Length; i++)
                {
                    _animationControllers[i] = clipPlayer.GetAnimationController(new VLAnimationClipPlayerParam(new[] { _motions[i] }));
                    _animationControllers[i].RegisterPrepareFrameEvent(OnPrepareFrameEvent);
                }
            }
            _isAdditiveEnable = false;
        }

        public override void Dispose()
        {
            if (_animationPlayer == null) return;
            _isAdditiveEnable = false;
            if (_animationPlayer is IMotionDefinePlayer motionDefinePlayer)
            {
                motionDefinePlayer.onPrepareFrameEvent -= OnMDPlayerPrepareFrameEvent;
                _layerController?.Stop();
            }
            else if (_animationPlayer is IVLAnimationClipPlayer)
            {
                if (_animationControllers != null)
                {
                    for (int i = 0; i < _animationControllers.Length; i++)
                        _animationControllers[i].UnregisterPrepareFrameEvent(OnPrepareFrameEvent);
                }
                _animationPlayer.GetPlayingLayerController(LAYER_NAME)?.Stop();
            }
        }

        public bool IsValidMotion(MotionDefine[] motions)
        {
            if (motions == null) return false;
            for (int i = 0; i < motions.Length; i++)
            {
                if (motions[i] == null || !motions[i].isAdditive)
                {
                    Debug.LogError("モーションが不正です");
                    return false;
                }
                if (motions[i].layerName != LAYER_NAME)
                {
                    Debug.LogErrorFormat("Idle加算アニメーションのlayerNameは[{0}]にする必要があります", LAYER_NAME);
                    return false;
                }
            }
            return true;
        }

        public void SetAdditiveAnimation(MotionDefine motion)
        {
            _motions = new[] { motion };
            Dispose();
            Initialize();
        }

        public void SetAdditiveAnimation(MotionDefine[] motions)
        {
            _motions = motions;
            Dispose();
            Initialize();
        }

        private void OnPrepareFrameEvent(VLAnimationClipParam currentParam, VLAnimationClipParamMixerPlayable playable, float currentTime, FrameData info)
        {
        }

        private void OnMDPlayerPrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
            if (_animationPlayer == null || !layerParam.isBaseLayer) return;
            _isAdditiveEnable = false;
            if (!clipParam.isLoop && !clipParam.ignoreAdditive && currentTime - clipParam.length >= 0.0) _isAdditiveEnable = true;
            float step = Mathf.Approximately(transitionTime, 0f) ? 1f : info.deltaTime / transitionTime;
            float weight = _layerController != null ? _layerController.GetWeight() : 0f;
            float target;
            if (_isAdditiveEnable)
            {
                if (Mathf.Approximately(weight, 0f))
                {
                    var motion = _motions[Random.Range(0, _motions.Length)];
                    if (motion == null) return;
                    _layerController?.Stop();
                    if (_animationPlayer is IMotionDefinePlayer motionDefinePlayer && _layerController == null)
                        _layerController = motionDefinePlayer.CreateLayerController(new LayerParam(motion));
                    _layerController?.Play();
                }
                target = step + weight;
            }
            else
            {
                target = weight - step;
            }
            _layerController?.SetWeight(Mathf.Clamp01(target));
        }

        public VLActorBodyAdditiveAnimation()
        {
        }
    }
}
