namespace VL
{
    using global::System;
    using global::System.Linq;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<(VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r), bool> _003C_003E9__36_1;
            public static Func<(VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r), VLActorBlendShapeLimitDataRuntime> _003C_003E9__36_2;
            public _003C_003Ec()
            {
            }

            internal bool _003CInitializeFacialParts_003Eb__36_1((VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r) tuple)
            {
                return tuple.r != null && tuple.r.sharedMesh != null;
            }

            internal VLActorBlendShapeLimitDataRuntime _003CInitializeFacialParts_003Eb__36_2((VLActorFacialLimitData.LimitData x, SkinnedMeshRenderer r) tuple)
            {
                var closure = new _003C_003Ec__DisplayClass36_0 { tuple = tuple };
                return new VLActorBlendShapeLimitDataRuntime { renderer = closure.tuple.r, blendShapes = closure.tuple.x.blendShapes.Select(closure._003CInitializeFacialParts_003Eb__3).ToArray() };
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
                return new VLActorBlendShapeIndexLimitData { index = r.sharedMesh.GetBlendShapeIndex(x), limit = d.limits[blendShapeNameIndex] };
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
                return new VLActorBlendShapeIndexLimitData { index = CS_0024_003C_003E8__locals1.faceModel.GetBlendShapeIndex(x), limit = d.limits[blendShapeNameIndex] };
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
                return new VLActorBlendShapeIndexLimitData { index = tuple.r.sharedMesh.GetBlendShapeIndex(x.blendShapeName), limit = x.limit };
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
                return new VLActorFaceModelBlendShapeLimitDataRuntime { faceModel = faceModel, blendShapes = x.blendShapes.Select(_003C_003E9__1 ?? (_003C_003E9__1 = _003CInitializeFaceModelFacialParts_003Eb__1)).ToArray() };
            }

            internal VLActorBlendShapeIndexLimitData _003CInitializeFaceModelFacialParts_003Eb__1(VLActorFacialLimitData.BlendShapeData x)
            {
                return new VLActorBlendShapeIndexLimitData { index = faceModel.GetBlendShapeIndex(x.blendShapeName), limit = x.limit };
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
        public float blinkTimeScale = 1;
        public bool useBlink = true;
        public bool autoBlinkDisabled;
        private BlinkState _blinkState;
        private bool _currentBlink;
        private float _currentBlinkTime;
        private float _nextBlinkTime = -1;
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
            return UnityEngine.Random.Range(3f, 6f);
        }

        public override void Initialize()
        {
            _nextBlinkTime = GetBlinkWaitTime();
            if (_faceModel != null)
            {
                InitializeFaceModelEyeBlink(_faceModel);
                InitializeFaceModelFacialParts(_faceModel);
            }
            else
            {
                InitializeEyeBlink();
                InitializeFacialParts();
            }
        }

        public override void OnLateUpdate()
        {
            UpdateBlink();
            UpdateFacialParts();
        }

        public void ResetEyeBlink()
        {
            _currentBlinkTime = _blinkData.length * blinkTimeScale;
        }

        public void SetupEyeBlink(VLActorEyeBlinkData data, VLActorFaceModel faceModel)
        {
            _faceModel = faceModel;
            _blinkData = data;
            if (faceModel != null) InitializeFaceModelEyeBlink(faceModel);
            else InitializeEyeBlink();
        }

        public void SetEyeBlinkWeight(float weight)
        {
            _isUpdateBlink = true;
            _blinkWeight = Mathf.Clamp01(weight);
        }

        private void InitializeEyeBlink()
        {
            if (_blinkData == null) return;
            _blinkDataRuntime = new VLActorEyeBlinkDataRuntime[_blinkData.blinkDatas.Length];
            for (int i = 0; i < _blinkDataRuntime.Length; ++i)
            {
                var data = _blinkData.blinkDatas[i];
                var child = transform.Find(data.path);
                if (child == null || !child.TryGetComponent<SkinnedMeshRenderer>(out var renderer) || renderer.sharedMesh == null) return;
                _blinkDataRuntime[i] = new VLActorEyeBlinkDataRuntime { renderer = renderer, blendShapeIndex = renderer.sharedMesh.GetBlendShapeIndex(data.blendShapeName), curve = data.curve };
                if (data.curve == null) return;
            }
            if (_blinkData.limitDatas == null || _blinkData.limitDatas.Length == 0) return;
            _blinkLimitDataRuntime = new VLActorBlendShapeLimitDataRuntime[_blinkData.limitDatas.Length];
            for (int i = 0; i < _blinkLimitDataRuntime.Length; ++i)
            {
                var closure = new _003C_003Ec__DisplayClass29_0 { d = _blinkData.limitDatas[i] };
                var child = transform.Find(closure.d.path);
                if (child == null || !child.TryGetComponent(out closure.r) || closure.r.sharedMesh == null) continue;
                if (closure.d.blendShapeNames.Count == closure.d.limits.Count)
                    _blinkLimitDataRuntime[i] = new VLActorBlendShapeLimitDataRuntime { renderer = closure.r, blendShapes = closure.d.blendShapeNames.Select(closure._003CInitializeEyeBlink_003Eb__0).ToArray() };
            }
        }

        private void InitializeFaceModelEyeBlink(VLActorFaceModel faceModel)
        {
            var outer = new _003C_003Ec__DisplayClass30_0 { faceModel = faceModel };
            if (_blinkData == null) return;
            _faceModelBlinkDataRuntime = new VLActorFaceModelEyeBlinkDataRuntime[_blinkData.blinkDatas.Length];
            for (int i = 0; i < _faceModelBlinkDataRuntime.Length; ++i)
            {
                var data = _blinkData.blinkDatas[i];
                _faceModelBlinkDataRuntime[i] = new VLActorFaceModelEyeBlinkDataRuntime { faceModel = outer.faceModel, blendShapeIndex = outer.faceModel.GetBlendShapeIndex(data.blendShapeName), curve = data.curve };
                if (data.curve == null) return;
            }
            if (_blinkData.limitDatas == null || _blinkData.limitDatas.Length == 0) return;
            _faceModelBlinkLimitDataRuntime = new VLActorFaceModelBlendShapeLimitDataRuntime[_blinkData.limitDatas.Length];
            for (int i = 0; i < _faceModelBlinkLimitDataRuntime.Length; ++i)
            {
                var closure = new _003C_003Ec__DisplayClass30_1 { CS_0024_003C_003E8__locals1 = outer, d = _blinkData.limitDatas[i] };
                if (closure.d.blendShapeNames.Count == closure.d.limits.Count)
                    _faceModelBlinkLimitDataRuntime[i] = new VLActorFaceModelBlendShapeLimitDataRuntime { faceModel = closure.CS_0024_003C_003E8__locals1.faceModel, blendShapes = closure.d.blendShapeNames.Select(closure._003CInitializeFaceModelEyeBlink_003Eb__0).ToArray() };
            }
        }

        public bool IsEyeLimit()
        {
            if (_faceModelBlinkLimitDataRuntime != null)
            {
                for (int i = 0; i < _faceModelBlinkLimitDataRuntime.Length; ++i)
                    if (_faceModelBlinkLimitDataRuntime[i].IsLimit()) return true;
            }
            else if (_blinkLimitDataRuntime != null)
            {
                for (int i = 0; i < _blinkLimitDataRuntime.Length; ++i)
                    if (_blinkLimitDataRuntime[i].IsLimit()) return true;
            }
            return false;
        }

        public bool CanEyeBlink()
        {
            return _currentBlink;
        }

        private void UpdateBlink()
        {
            if (_blinkData == null)
            {
                Debug.Log("BlinkDataが指定されていません");
                return;
            }
            if (autoBlinkDisabled)
            {
                _currentBlink = useBlink && !IsEyeLimit();
                if (_isUpdateBlink)
                {
                    _isUpdateBlink = false;
                    SetBlinkBlendShapeWeight(_blinkWeight);
                }
                return;
            }
            if (_animationPlayer == null) TryGetComponent(out _animationPlayer);
            _currentBlink = useBlink;
            var current = _animationPlayer?.GetPlayingBaseController();
            if (current != null && current.IsPlaying()) _currentBlink = false;
            else if (_currentBlink)
            {
                if (IsEyeLimit()) _currentBlink = false;
                else if (_currentBlink) _nextBlinkTime -= Time.deltaTime;
            }
            if (_nextBlinkTime < 0)
            {
                _blinkState = BlinkState.BLINK;
                _currentBlinkTime = 0;
                _nextBlinkTime = GetBlinkWaitTime();
            }
            if (_blinkState != BlinkState.NONE)
            {
                float length = _blinkData.length * blinkTimeScale;
                _currentBlinkTime += Time.deltaTime;
                SetBlinkBlendShapeWeight(Mathf.Clamp01(_currentBlinkTime / length));
                if (_currentBlinkTime >= length) _blinkState = BlinkState.NONE;
            }
        }

        private void SetBlinkBlendShapeWeight(float weight)
        {
            float time = _blinkData.length * weight;
            if (_faceModelBlinkDataRuntime != null)
            {
                if (_faceModelBlinkDataRuntime.Length == 1)
                {
                    var data = _faceModelBlinkDataRuntime[0];
                    float value = data.curve?.Evaluate(time) ?? 0;
                    int index = data.blendShapeIndex;
                    data.SetBlendShapeWeight(value);
                    float multiplier = (100 - value) / 100;
                    foreach (var limit in _faceModelBlinkLimitDataRuntime)
                        for (int i = 0; i < limit.Length; ++i)
                        {
                            int otherIndex = limit.blendShapes[i].index;
                            if (otherIndex != index) limit.SetBlendShapeWeight(i, multiplier * limit.faceModel.GetBlendShapeWeight(otherIndex));
                        }
                }
                else
                    foreach (var data in _faceModelBlinkDataRuntime) data.SetBlendShapeWeight(data.curve?.Evaluate(time) ?? 0);
            }
            else if (_blinkDataRuntime != null)
                foreach (var data in _blinkDataRuntime) data.SetBlendShapeWeight(data.curve?.Evaluate(time) ?? 0);
        }

        public void SetupFacialParts(VLActorFacialLimitData data, VLActorFaceModel faceModel)
        {
            _faceModel = faceModel;
            _facialLimitData = data;
            if (faceModel != null) InitializeFaceModelFacialParts(faceModel);
            else InitializeFacialParts();
        }

        private void InitializeFacialParts()
        {
            if (_facialLimitData == null) return;
            _facialLimitDataRuntime = _facialLimitData.limitDatas?.Select(_003CInitializeFacialParts_003Eb__36_0)
                .Where(_003C_003Ec._003C_003E9__36_1 ?? (_003C_003Ec._003C_003E9__36_1 = _003C_003Ec._003C_003E9._003CInitializeFacialParts_003Eb__36_1))
                .Select(_003C_003Ec._003C_003E9__36_2 ?? (_003C_003Ec._003C_003E9__36_2 = _003C_003Ec._003C_003E9._003CInitializeFacialParts_003Eb__36_2)).ToArray()
                ?? Array.Empty<VLActorBlendShapeLimitDataRuntime>();
        }

        private void InitializeFaceModelFacialParts(VLActorFaceModel faceModel)
        {
            var closure = new _003C_003Ec__DisplayClass37_0 { faceModel = faceModel };
            if (_facialLimitData == null || closure.faceModel == null) return;
            _faceModelFacialLimitDataRuntime = _facialLimitData.limitDatas?.Select(closure._003CInitializeFaceModelFacialParts_003Eb__0).ToArray() ?? Array.Empty<VLActorFaceModelBlendShapeLimitDataRuntime>();
        }

        private void UpdateFacialParts()
        {
            if (_faceModelFacialLimitDataRuntime != null)
                foreach (var data in _faceModelFacialLimitDataRuntime) data.Update();
            if (_facialLimitDataRuntime != null)
                foreach (var data in _facialLimitDataRuntime) data.Update();
        }

        public VLActorFacialSystem()
        {

        }

        [CompilerGenerated]
        private (VLActorFacialLimitData.LimitData, SkinnedMeshRenderer) _003CInitializeFacialParts_003Eb__36_0(VLActorFacialLimitData.LimitData x)
        {
            var child = transform.Find(x.path);
            SkinnedMeshRenderer renderer = null;
            if (child != null) child.TryGetComponent(out renderer);
            return (x, renderer);
        }
    }
}
