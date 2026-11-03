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
            }

            public ScaleResult()
            {
            }
        }

        private const string OptionPrefix = "Opt_";
        [SerializeField]
        private Color _color;
        [SerializeField]
        private Color _outlineColor;
        [SerializeField]
        [Range(0f, 1f)]
        private float _sweatWeight;
        [SerializeField]
        [Range(0f, 2f)]
        private float _highlightWeight;
        [SerializeField]
        [Range(0f, 1f)]
        private float _targetCorrectionWeight;
        private ICampusActorController _hipRootController;
        private Transform _hipTransformCache;
        public Color Color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Color OutlineColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public float SweatWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float HighlightWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float TargetCorrectionWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        private Transform HipRootTransform
        {
            get
            {
                return null;
            }
        }

        public float HumanScale
        {
            get
            {
                return default(float);
            }
        }

        public ICampusActorController ActorController
        {
            get
            {
                return null;
            }
        }

        protected override Vector3 rootPosition
        {
            get
            {
                return default(Vector3);
            }
        }

        protected override Quaternion rootRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        protected override void Setup()
        {
        }

        protected override IBindResult OnBind(BindData boneBind)
        {
            return null;
        }

        protected override void OnLateUpdate()
        {
        }

        public CampusVirtualActorController()
        {
        }
    }
}
