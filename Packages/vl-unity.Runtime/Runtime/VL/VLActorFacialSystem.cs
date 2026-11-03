namespace VL
{
    using global::System;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<(VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r), bool> _003C_003E9__36_1;
            public static Func<(VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r), VLActorBlendShapeLimitDataRuntime> _003C_003E9__36_2;
            public _003C_003Ec()
            {
            }

            internal bool _003CInitializeFacialParts_003Eb__36_1((VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r) tuple)
            {
                return default(bool);
            }

            internal VLActorBlendShapeLimitDataRuntime _003CInitializeFacialParts_003Eb__36_2((VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r) tuple)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_0
        {
            public SkinnedMeshRenderer r;
            public VLActorEyeBlinkData.LimitData d;
            public _003C_003Ec__DisplayClass29_0()
            {
            }

            internal VLActorBlendShapeIndexLimitData _003CInitializeEyeBlink_003Eb__0(string x, int blendShapeNameIndex)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass30_0
        {
            public VLActorFaceModel faceModel;
            public _003C_003Ec__DisplayClass30_0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass30_1
        {
            public VLActorEyeBlinkData.LimitData d;
            public _003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass30_1()
            {
            }

            internal VLActorBlendShapeIndexLimitData _003CInitializeFaceModelEyeBlink_003Eb__0(string x, int blendShapeNameIndex)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass36_0
        {
            public (VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r) tuple;
            public _003C_003Ec__DisplayClass36_0()
            {
            }

            internal VLActorBlendShapeIndexLimitData _003CInitializeFacialParts_003Eb__3(VLActorFacialLimitData.BlendShapeData x)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass37_0
        {
            public VLActorFaceModel faceModel;
            public Func<VLActorFacialLimitData.BlendShapeData, VLActorBlendShapeIndexLimitData> _003C_003E9__1;
            public _003C_003Ec__DisplayClass37_0()
            {
            }

            internal VLActorFaceModelBlendShapeLimitDataRuntime _003CInitializeFaceModelFacialParts_003Eb__0(VLActorFacialLimitData.LimitData x)
            {
                return null;
            }

            internal VLActorBlendShapeIndexLimitData _003CInitializeFaceModelFacialParts_003Eb__1(VLActorFacialLimitData.BlendShapeData x)
            {
                return null;
            }
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

        [CompilerGenerated]
        private (VLActorFacialLimitData.LimitData, SkinnedMeshRenderer) _003CInitializeFacialParts_003Eb__36_0(VLActorFacialLimitData.LimitData x)
        {
            return default((VLActorFacialLimitData.LimitData, SkinnedMeshRenderer));
        }
    }
}
