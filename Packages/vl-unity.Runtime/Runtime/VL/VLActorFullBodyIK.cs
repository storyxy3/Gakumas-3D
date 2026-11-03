namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;
    using global::VL.IK;

    [ExecuteAlways]
    public class VLActorFullBodyIK : VLActorExtension
    {
        public const int ROOT_PLAYABLE_ORDER = 100;
        [Tooltip("0.0の場合、モーションの制限が無くなり、無理やり向こうとします。1.0の場合、可能な限りモーションを使用し少しだけ適用されます。0.5はその中間です")]
        [Range(0f, 1f)]
        public float lookAtClampWeight;
        [Range(0f, 1.5f)]
        public float stiffness;
        [Range(1f, 50f)]
        public int maxPullIteration;
        [Range(-0.2f, 0.2f)]
        public float handDown;
        [SerializeField]
        private IKBodyEffector _bodyEffector;
        [SerializeField]
        private IKGoalEffector _leftFootEffector;
        [SerializeField]
        private IKGoalEffector _rightFootEffector;
        [SerializeField]
        private IKGoalEffector _leftHandEffector;
        [SerializeField]
        private IKGoalEffector _rightHandEffector;
        [SerializeField]
        private IKHintEffector _leftKneeHintEffector;
        [SerializeField]
        private IKHintEffector _rightKneeHintEffector;
        [SerializeField]
        private IKHintEffector _leftElbowHintEffector;
        [SerializeField]
        private IKHintEffector _rightElbowHintEffector;
        [SerializeField]
        private LookAtEffector _lookAtEffector;
        [SerializeField]
        private CustomLookAtEffector _customLookAtEffector;
        [SerializeField]
        [HideInInspector]
        private List<EffectorBase> _effectors;
        [SerializeField]
        [HideInInspector]
        private Animator _animator;
        [SerializeField]
        [HideInInspector]
        private Transform _moveReference;
        [SerializeField]
        [HideInInspector]
        private Transform _moveTarget;
        [SerializeField]
        [HideInInspector]
        private Transform _skeletonRoot;
        private bool _customLookAtEffectorInitialized;
        private AnimationScriptPlayable m_IKPlayable;
        private IAnimationPlayer _animationPlayer;
        public CustomLookAtEffector CustomLookAtEffector
        {
            get
            {
                return null;
            }
        }

        public override void Initialize()
        {
        }

        public override void Dispose()
        {
        }

        public void SetMoveTransform(Transform moveReference, Transform moveTarget, Transform skeletonRoot)
        {
        }

        private void SetupEffector(ref FullBodyIKJob.EffectorHandle handle, IKGoalEffector effector)
        {
        }

        private void SetupHintEffector(ref FullBodyIKJob.HintEffectorHandle handle, IKHintEffector effector)
        {
        }

        private void SetupLookAtEffector(ref FullBodyIKJob.LookEffectorHandle handle, LookAtEffector effector)
        {
        }

        public void SetCustomLookAt(Transform t)
        {
        }

        public void SetCustomLookAt(Vector3 pos)
        {
        }

        public void ResetCustomLookAt()
        {
        }

        private void SetLocalCustomLookAtEffector()
        {
        }

        public void SetCustomLookAtEffector(CustomLookAtEffector effector)
        {
        }

        private void SetupCustomLookAtEffector()
        {
        }

        private void SetupBodyEffector(ref FullBodyIKJob.BodyEffectorHandle handle, IKBodyEffector effector)
        {
        }

        private void SetupIKLimbHandle(ref FullBodyIKJob.IKLimbHandle handle, HumanBodyBones top, HumanBodyBones middle, HumanBodyBones end)
        {
        }

        private void SetEffector(EffectorBase effector)
        {
        }

        public bool Setup(List<EffectorBase> effectors)
        {
            return default(bool);
        }

        private void SetupJob(ref FullBodyIKJob job)
        {
        }

        private RootPlayableData OnConnect(PlayableGraph graph, Playable childPlayable)
        {
            return default(RootPlayableData);
        }

        private Playable OnDisconnect(PlayableGraph graph, RootPlayableData currentData)
        {
            return default(Playable);
        }

        public VLActorFullBodyIK()
        {
        }
    }
}
