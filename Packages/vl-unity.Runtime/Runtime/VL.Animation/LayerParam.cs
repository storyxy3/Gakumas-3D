namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;

    [Serializable]
    public class LayerParam
    {
        [SerializeField]
        private string _layerName;
        [SerializeField]
        private bool _isAdditive;
        [SerializeField]
        private bool _isBaseLayer;
        [SerializeField]
        private AvatarMask _mask;
        [SerializeField]
        private double _length;
        [SerializeField]
        private double _delay;
        [SerializeField]
        private List<ClipParam> _clips;
        [SerializeField]
        private AnimationData[] _defaultAnimations;
        [SerializeField]
        private bool _externalControl;
        [CompilerGenerated]
        private bool _003CisLoop_003Ek__BackingField;
        private AnimationData overrideMotion;
        [CompilerGenerated]
        private ClipEvent _003ConPlay_003Ek__BackingField;
        [CompilerGenerated]
        private ClipEvent _003ConComplete_003Ek__BackingField;
        [CompilerGenerated]
        private PrepareFrameEvent _003ConPrepareFrame_003Ek__BackingField;
        public bool isLoop
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }
        }

        public bool isBaseLayer
        {
            get
            {
                return default(bool);
            }
        }

        public string layerName
        {
            get
            {
                return null;
            }
        }

        public bool isAdditive
        {
            get
            {
                return default(bool);
            }
        }

        public AvatarMask mask
        {
            get
            {
                return null;
            }
        }

        public int clipCount
        {
            get
            {
                return default(int);
            }
        }

        public IReadOnlyList<AnimationData> defaultAnimations
        {
            get
            {
                return null;
            }
        }

        public double length
        {
            get
            {
                return default(double);
            }
        }

        public ClipEvent onPlay
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public ClipEvent onComplete
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public PrepareFrameEvent onPrepareFrame
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public bool externalControl
        {
            get
            {
                return default(bool);
            }
        }

        public LayerParam()
        {
        }

        public LayerParam(MotionDefine motionDefine)
        {
        }

        public LayerParam(IEnumerable<MotionDefine> motionDefines)
        {
        }

        public LayerParam(IEnumerable<ClipParam> clips)
        {
        }

        public LayerParam Append(IEnumerable<ClipParam> clips)
        {
            return null;
        }

        public LayerParam Append(ClipParam clip)
        {
            return null;
        }

        public LayerParam SetLayerName(string layerName)
        {
            return null;
        }

        public LayerParam SetLayerAdditive(bool isAdditive)
        {
            return null;
        }

        public LayerParam SetDefaultAnimations(DefaultAnimationData data)
        {
            return null;
        }

        public LayerParam SwitchToExternalControl()
        {
            return null;
        }

        public ClipParam GetClipParam(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public void SetOverrideMotion(MotionDefine motionDefine)
        {
        }
    }
}
