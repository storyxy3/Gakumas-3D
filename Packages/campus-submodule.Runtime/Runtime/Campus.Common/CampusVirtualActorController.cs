// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, OnBind, OnLateUpdate, Setup, get_ActorController, get_Color, get_HipRootTransform, get_HumanScale, get_OutlineColor, get_rootPosition, get_rootRotation, set_Color, set_OutlineColor.
namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL;

    public class CampusVirtualActorController : VLVirtualActorController<ICampusActorController>
    {
        public class FocusedEyeBoneResult : IBindResult
        {
            public Transform target;
            public float weight;
            public void LateUpdate(BindData data)
            {
                if (target != null && data.transform != null && weight > 0.01f)
                {
                    var position = target.position;
                    if (VLCameraController.HasInstance)
                    {
                        var cameraPosition = VLCameraController.Instance.position;
                        var right = target.right;
                        var direction = (cameraPosition - position).normalized;
                        float side = Mathf.Clamp01(Vector3.Dot(right, direction));
                        position += target.rotation * new Vector3(side * 0.1f - 0.05f, 0.05f, 0.09f);
                    }
                    data.transform.position = Vector3.Lerp(data.transform.position, position, weight);
                    data.transform.rotation = Quaternion.Slerp(data.transform.rotation, target.rotation, weight);
                }
            }

            public FocusedEyeBoneResult()
            {
            }
        }

        private class HipsPosXZResult : IBindResult
        {
            public Transform hips;
            public void LateUpdate(BindData data)
            {
                if (hips == null) return;
                float height = data.transform.position.y;
                var position = hips.position;
                position.y = height;
                data.transform.position = position;
                data.transform.rotation = Quaternion.AngleAxis(hips.eulerAngles.y, Vector3.up);
            }

            public HipsPosXZResult()
            {
            }
        }

        public class ScaleResult : IBindResult
        {
            public float humanScale;
            public void LateUpdate(BindData data)
            {
                data.transform.localScale = Vector3.one * (humanScale / CampusActorController.HeightCoefficient);
            }

            public ScaleResult()
            {
            }
        }

        private const string OptionPrefix = "Opt_";
        [SerializeField]
        private Color _color = Color.white;
        [SerializeField]
        private Color _outlineColor = Color.white;
        [SerializeField]
        [Range(0f, 1f)]
        private float _sweatWeight;
        [SerializeField]
        [Range(0f, 2f)]
        private float _highlightWeight = 1f;
        [SerializeField]
        [Range(0f, 1f)]
        private float _targetCorrectionWeight = 1f;
        private ICampusActorController _hipRootController;
        private Transform _hipTransformCache;
        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public Color OutlineColor
        {
            get
            {
                return _outlineColor;
            }

            set
            {
                _outlineColor = value;
            }
        }

        public float SweatWeight
        {
            get
            {
                return _sweatWeight;
            }

            set
            {
                _sweatWeight = value;
            }
        }

        public float HighlightWeight
        {
            get
            {
                return _highlightWeight;
            }

            set
            {
                _highlightWeight = value;
            }
        }

        public float TargetCorrectionWeight
        {
            get
            {
                return _targetCorrectionWeight;
            }

            set
            {
                _targetCorrectionWeight = value;
            }
        }

        private Transform HipRootTransform
        {
            get
            {
                if (controllerBase == null || !ReferenceEquals(_hipRootController, controllerBase)) _hipTransformCache = null;
                if (_hipTransformCache == null && controllerBase != null)
                {
                    _hipTransformCache = controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.Hips);
                    _hipRootController = controllerBase;
                }
                return _hipTransformCache;
            }
        }

        public float HumanScale
        {
            get
            {
                return controllerBase != null ? controllerBase.GetHumanScale() : 1f;
            }
        }

        public ICampusActorController ActorController
        {
            get
            {
                return controllerBase;
            }
        }

        protected override Vector3 rootPosition
        {
            get
            {
                if (HipRootTransform != null)
                {
                    var position = HipRootTransform.position;
                    position.y = controllerBase != null ? controllerBase.position.y : transform.position.y;
                    return position;
                }
                return transform.position;
            }
        }

        protected override Quaternion rootRotation
        {
            get
            {
                return HipRootTransform != null ? Quaternion.AngleAxis(HipRootTransform.eulerAngles.y, Vector3.up) : transform.rotation;
            }
        }

        protected override void Setup()
        {
            AddBone("Head");
            AddBone("HeadFace");
            AddBone("RightHand");
            AddBone("LeftHand");
            AddBone("FocusedEye");
            AddBone("Hips-PosXZ");
            AddBone("Scale");
        }

        protected override IBindResult OnBind(BindData boneBind)
        {
            if (controllerBase == null) return new ErrorResult();
            switch (boneBind.name)
            {
                case "Head":
                    return new BoneResult(boneBind, controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.Head), 1f, 0f, new Vector3(0f, 0.2f, 0f), Vector3.zero);
                case "HeadFace":
                    return new BoneResult(boneBind, controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.Head), 1f, 1f, Vector3.zero, Vector3.zero);
                case "RightHand":
                    return new BoneResult(boneBind, controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.RightHand), 1f, 1f, Vector3.zero, Vector3.zero);
                case "LeftHand":
                    return new BoneResult(boneBind, controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.LeftHand), 1f, 1f, Vector3.zero, Vector3.zero);
                case "FocusedEye":
                    return new FocusedEyeBoneResult { target = controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.Head), weight = 1f };
                case "Hips-PosXZ":
                    return new HipsPosXZResult { hips = controllerBase.GetHumanBodyBoneTransform(HumanBodyBones.Hips) };
                case "Scale":
                    return new ScaleResult { humanScale = HumanScale };
            }
            if (boneBind.name != null && boneBind.name.StartsWith(OptionPrefix, global::System.StringComparison.Ordinal))
            {
                var target = controllerBase.GetBoneTransformByName(boneBind.name.Remove(0, OptionPrefix.Length));
                if (target != null) return new BoneResult(boneBind, target, 1f, 1f, Vector3.zero, Vector3.zero);
            }
            return null;
        }

        protected override void OnLateUpdate()
        {
            if (controllerBase == null) return;
            controllerBase.color = _color;
            controllerBase.outlineColor = _outlineColor;
            controllerBase.SweatWeight = _sweatWeight;
            controllerBase.HighlightWeight = _highlightWeight;
            controllerBase.TargetCorrectionWeight = _targetCorrectionWeight;
        }

        public CampusVirtualActorController()
        {
        }
    }
}
