namespace Campus.Common.LookAt
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::UnityEngine;

    public class CampusLookAtConstraint : MonoBehaviour
    {
        private Transform _currentTarget;
        private Transform _nextTarget;
        private CampusActorLookAtController _moveTargetController;
        private Transform _moveTarget;
        private Vector3 _switchStartPosition;
        private float _weightRatio;
        private float _switchDuration;
        public Func<bool> isLookAtEnabled;
        [CompilerGenerated]
        private bool _003CIsDisabled_003Ek__BackingField;
        private ICampusActorController _relativeActor;
        private (Vector3 forward, Vector3 direction, float distance)? _relativePosition;
        public bool IsDisabled
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public void Initialize()
        {
        }

        public void SetRelativeActor(ICampusActorController relativeActor)
        {
        }

        private void Update()
        {
        }

        public void UpdatePosition()
        {
        }

        private void SetPosition(Vector3 position, bool isForce = false)
        {
        }

        private void CacheRelativePosition()
        {
        }

        private void ApplyRelativePosition()
        {
        }

        public void SetTarget(ICampusActorController actor, Transform lookTarget, bool isChangeTargetImmediate)
        {
        }

        public ICampusActorController GetTargetActor()
        {
            return null;
        }

        public void SetMoveTarget(Transform targetTransform)
        {
        }

        public bool IsMovingTarget()
        {
            return default(bool);
        }

        public void SetDisabled(bool isDisabled)
        {
        }

        protected virtual bool IsEnableUpdate()
        {
            return default(bool);
        }

        protected virtual float GetLookAtEasingMaxAngle()
        {
            return default(float);
        }

        protected virtual float GetLookAtEasingMinSpeed()
        {
            return default(float);
        }

        protected virtual float GetLookAtEasingMaxSpeed()
        {
            return default(float);
        }

        protected virtual AnimationCurve GetLookAtEasingAnimationCurve()
        {
            return null;
        }

        public CampusLookAtConstraint()
        {
        }
    }
}
