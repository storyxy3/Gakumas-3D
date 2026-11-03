namespace VL
{
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;
    using global::VL.FaceSystem;

    [AddComponentMenu("")]
    public class VLActorFacialSystem : VLActorExtension
    {
        public enum BlinkState
        {
            NONE,
            BLINK
        }

        [SerializeField]
        private VLActorEyeBlinkData _blinkData;
        [SerializeField]
        private VLActorEyeBlinkDataRuntime[] _blinkDataRuntime;
        [SerializeField]
        private VLActorFaceModelEyeBlinkDataRuntime[] _faceModelBlinkDataRuntime;
        [SerializeField]
        private VLActorBlendShapeLimitDataRuntime[] _blinkLimitDataRuntime;
        [SerializeField]
        private VLActorFaceModelBlendShapeLimitDataRuntime[] _faceModelBlinkLimitDataRuntime;
        [SerializeField]
        private VLActorFacialLimitData _facialLimitData;
        [SerializeField]
        private VLActorBlendShapeLimitDataRuntime[] _facialLimitDataRuntime;
        [SerializeField]
        private VLActorFaceModelBlendShapeLimitDataRuntime[] _faceModelFacialLimitDataRuntime;
        [SerializeField]
        private VLActorFaceModel _faceModel;
        public float blinkTimeScale;
        public bool useBlink;
        public bool autoBlinkDisabled;
        private BlinkState _blinkState;
        private bool _currentBlink;
        private float _currentBlinkTime;
        private float _nextBlinkTime;
        private float _blinkWeight;
        private bool _isUpdateBlink;
        private IAnimationPlayer _animationPlayer;
        public float NextBlinkTime
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        private float GetBlinkWaitTime()
        {
            return default(float);
        }

        public override void Initialize()
        {
        }

        public override void OnLateUpdate()
        {
        }

        public void ResetEyeBlink()
        {
        }

        public void SetupEyeBlink(VLActorEyeBlinkData data, VLActorFaceModel faceModel)
        {
        }

        public void SetEyeBlinkWeight(float weight)
        {
        }

        private void InitializeEyeBlink()
        {
        }

        private void InitializeFaceModelEyeBlink(VLActorFaceModel faceModel)
        {
        }

        public bool IsEyeLimit()
        {
            return default(bool);
        }

        public bool CanEyeBlink()
        {
            return default(bool);
        }

        private void UpdateBlink()
        {
        }

        private void SetBlinkBlendShapeWeight(float weight)
        {
        }

        public void SetupFacialParts(VLActorFacialLimitData data, VLActorFaceModel faceModel)
        {
        }

        private void InitializeFacialParts()
        {
        }

        private void InitializeFaceModelFacialParts(VLActorFaceModel faceModel)
        {
        }

        private void UpdateFacialParts()
        {
        }

        public VLActorFacialSystem()
        {
        }
    }
}
