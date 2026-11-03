namespace VL.Animation.Legacy
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Animation.Legacy;
    using global::VL.Ease;

    [Serializable]
    public class VLAnimationClipParam
    {
        [SerializeField]
        private AnimationClip _clip;
        [SerializeField]
        private MotionDefine _motion;
        [SerializeField]
        private float _transitionTime;
        [SerializeField]
        private float _length;
        [SerializeField]
        private EaseType _easeType;
        [SerializeField]
        private bool _isLoop;
        [CompilerGenerated]
        private VLAnimationClipParamEvent _003ConPlay_003Ek__BackingField;
        [CompilerGenerated]
        private VLAnimationClipParamEvent _003ConComplete_003Ek__BackingField;
        [CompilerGenerated]
        private VLAnimationClipParamEvent _003ConStepComplete_003Ek__BackingField;
        public EventSystem onCompleteEvent;
        private LayerParam _layerParam;
        private ClipParam _clipParam;
        public string name
        {
            get
            {
                return null;
            }
        }

        public AnimationClip clip
        {
            get
            {
                return null;
            }
        }

        public MotionDefine motion
        {
            get
            {
                return null;
            }
        }

        public float transitionTime
        {
            get
            {
                return default(float);
            }
        }

        public bool isCrossFade
        {
            get
            {
                return default(bool);
            }
        }

        public float length
        {
            get
            {
                return default(float);
            }
        }

        public EaseFunction function
        {
            get
            {
                return null;
            }
        }

        public bool isLoop
        {
            get
            {
                return default(bool);
            }
        }

        public bool ignoreAdditive
        {
            get
            {
                return default(bool);
            }
        }

        public float clipLength
        {
            get
            {
                return default(float);
            }
        }

        public VLAnimationClipParamEvent onPlay
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public VLAnimationClipParamEvent onComplete
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public VLAnimationClipParamEvent onStepComplete
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public VLAnimationClipParam(MotionDefine motion)
        {
        }
    }
}
