namespace Campus.Common.LookAt
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::DG.Tweening;
    using global::UnityEngine;

    public class CampusActorLookAtController : MonoBehaviour
    {
        protected float _overwriteEyeLookOutVirtualAngle;
        protected float _overwriteEyeLookAgainVirtualAngle;
        protected float _overwriteEyeLookOutHorizontalAngle;
        protected float _overwriteEyeLookAgainHorizontalAngle;
        protected CampusCustomLookAtEffector _customLookAtEffector;
        [CompilerGenerated]
        private ICampusActorController _003CActor_003Ek__BackingField;
        protected float _eyeWeight;
        protected float _bodyWeight;
        protected bool _shouldLookEnabled;
        protected bool _isFixedConstraint;
        private Sequence _currentSequence;
        [CompilerGenerated]
        private Action<bool> _003COnConstrainStatusChange_003Ek__BackingField;
        [CompilerGenerated]
        private Func<bool> _003CIsLookAtCamera_003Ek__BackingField;
        [CompilerGenerated]
        private Func<LookTargetType> _003CGetActorLookTargetType_003Ek__BackingField;
        [CompilerGenerated]
        private Func<Transform> _003CGetActorLookTargetTransform_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsDisableAutoUpdate_003Ek__BackingField;
        public CampusCustomLookAtEffector CustomLookAtEffector
        {
            get
            {
                return null;
            }
        }

        public bool HasLookAtWeight
        {
            get
            {
                return default(bool);
            }
        }

        public ICampusActorController Actor
        {
            [CompilerGenerated]
            get
            {
                return _003CActor_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CActor_003Ek__BackingField = value;
            }
        }

        public bool IsFixedConstraint
        {
            get
            {
                return default(bool);
            }
        }

        public Action<bool> OnConstrainStatusChange
        {
            [CompilerGenerated]
            get
            {
                return _003COnConstrainStatusChange_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnConstrainStatusChange_003Ek__BackingField = value;
            }
        }

        public Func<bool> IsLookAtCamera
        {
            [CompilerGenerated]
            get
            {
                return _003CIsLookAtCamera_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsLookAtCamera_003Ek__BackingField = value;
            }
        }

        public Func<LookTargetType> GetActorLookTargetType
        {
            [CompilerGenerated]
            get
            {
                return _003CGetActorLookTargetType_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetActorLookTargetType_003Ek__BackingField = value;
            }
        }

        public Func<Transform> GetActorLookTargetTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CGetActorLookTargetTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetActorLookTargetTransform_003Ek__BackingField = value;
            }
        }

        public bool IsDisableAutoUpdate
        {
            [CompilerGenerated]
            get
            {
                return _003CIsDisableAutoUpdate_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsDisableAutoUpdate_003Ek__BackingField = value;
            }
        }

        private bool HasEyeLookAtAngleOverwrite
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize(ICampusActorController actor, CampusCustomLookAtEffector customLookAtEffector)
        {
        }

        private void Update()
        {
        }

        public void ManualUpdate()
        {
        }

        private void UpdateLookAt()
        {
        }

        public void SetFixedConstraint(bool isFixedConstraint)
        {
        }

        private void TrySetLookAtStatus(bool isEnable)
        {
        }

        protected void ApplyWeightSettings()
        {
        }

        public void SetLookAtTarget(bool isBody)
        {
        }

        public void SetLookAtTarget(bool isBody, float duration)
        {
        }

        public void SetLookAtTarget(bool isBody, float duration, Ease toBodyEaseType, Ease toEyeEaseType)
        {
        }

        public void SetLookAtEnable(bool isEnable)
        {
        }

        public bool IsWithinLookAtAngleRange(Transform targetTransform)
        {
            return default(bool);
        }

        public bool GetLookAtEnable()
        {
            return default(bool);
        }

        public void ManualUpdateLookAtWeight()
        {
        }

        public void OnLookTargetTypeChange(LookTargetType type)
        {
        }

        public bool IsLookingOtherTarget()
        {
            return default(bool);
        }

        public bool IsBetweenZeroOne()
        {
            return default(bool);
        }

        private bool IsBetweenZeroOne(float value)
        {
            return default(bool);
        }

        protected virtual float GetLookAtTypeEaseDuration()
        {
            return default(float);
        }

        protected virtual Ease GetLookAtTypeEaseToBodyEaseType()
        {
            return default(Ease);
        }

        protected virtual Ease GetLookAtTypeEaseToEyeEaseType()
        {
            return default(Ease);
        }

        protected virtual (bool, bool, float) CheckLookTargetLimitAngle([Optional] Transform targetTransform)
        {
            return default((bool, bool, float));
        }

        protected virtual (bool, bool, float) CheckLookTargetLimitAngleWithOverwrite([Optional] Transform targetTransform)
        {
            return default((bool, bool, float));
        }

        public void SetEyeLookAtAngleOverwrite(float eyeLookOutVirtualAngle, float eyeLookAgainVirtualAngle, float eyeLookOutHorizontalAngle, float eyeLookAgainHorizontalAngle)
        {
        }

        private bool CheckLookAtCameraSafeInvoke()
        {
            return default(bool);
        }

        public CampusActorLookAtController()
        {
        }

        [CompilerGenerated]
        private float _003CSetLookAtTarget_003Eb__51_0()
        {
            return default(float);
        }

        [CompilerGenerated]
        private void _003CSetLookAtTarget_003Eb__51_1(float weight)
        {
        }

        [CompilerGenerated]
        private float _003CSetLookAtTarget_003Eb__51_2()
        {
            return default(float);
        }

        [CompilerGenerated]
        private void _003CSetLookAtTarget_003Eb__51_3(float weight)
        {
        }

        [CompilerGenerated]
        private void _003CSetLookAtTarget_003Eb__51_4()
        {
        }

        [CompilerGenerated]
        private bool _003CIsBetweenZeroOne_003Eb__58_0(CampusCustomLookAtEffector.CampusCustomLookAtEffectorPoseSettingWeight setting)
        {
            return default(bool);
        }
    }
}
