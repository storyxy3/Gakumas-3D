namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationIKCustomLookAtEffector : IDisposable
    {
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003CreferenceHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CuseCustomTargetPositionHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CcustomTargetPositionXHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CcustomTargetPositionYHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CcustomTargetPositionZHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CeyesWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CheadWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CbodyWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CcustomUseWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private PropertySceneHandle _003CweightHandle_003Ek__BackingField;
        public ReadOnlyTransformHandle referenceHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CreferenceHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CreferenceHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle useCustomTargetPositionHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CuseCustomTargetPositionHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CuseCustomTargetPositionHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle customTargetPositionXHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CcustomTargetPositionXHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcustomTargetPositionXHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle customTargetPositionYHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CcustomTargetPositionYHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcustomTargetPositionYHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle customTargetPositionZHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CcustomTargetPositionZHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcustomTargetPositionZHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle eyesWeightHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CeyesWeightHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CeyesWeightHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle headWeightHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CheadWeightHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CheadWeightHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle bodyWeightHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CbodyWeightHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CbodyWeightHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle customUseWeightHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CcustomUseWeightHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcustomUseWeightHandle_003Ek__BackingField = value;
            }
        }

        public PropertySceneHandle weightHandle
        {
            [CompilerGenerated]
            set
            {
                _003CweightHandle_003Ek__BackingField = value;
            }
        }

        public ActorAnimationIKCustomLookAtEffector(Animator animator)
        {
            this = default;
        }

        public void Setup(ReadOnlyTransformHandle referenceHandle, PropertySceneHandle useCustomTargetPositionHandle, PropertySceneHandle customTargetPositionXHandle, PropertySceneHandle customTargetPositionYHandle, PropertySceneHandle customTargetPositionZHandle, PropertySceneHandle eyesWeightHandle, PropertySceneHandle headWeightHandle, PropertySceneHandle bodyWeightHandle, PropertySceneHandle customUseWeightHandle, PropertySceneHandle weightHandle)
        {
            _003CreferenceHandle_003Ek__BackingField = referenceHandle;
            _003CuseCustomTargetPositionHandle_003Ek__BackingField = useCustomTargetPositionHandle;
            _003CcustomTargetPositionXHandle_003Ek__BackingField = customTargetPositionXHandle;
            _003CcustomTargetPositionYHandle_003Ek__BackingField = customTargetPositionYHandle;
            _003CcustomTargetPositionZHandle_003Ek__BackingField = customTargetPositionZHandle;
            _003CeyesWeightHandle_003Ek__BackingField = eyesWeightHandle;
            _003CheadWeightHandle_003Ek__BackingField = headWeightHandle;
            _003CbodyWeightHandle_003Ek__BackingField = bodyWeightHandle;
            _003CcustomUseWeightHandle_003Ek__BackingField = customUseWeightHandle;
            _003CweightHandle_003Ek__BackingField = weightHandle;
        }

        public void Dispose()
        {
            this = default;
        }
    }
}
