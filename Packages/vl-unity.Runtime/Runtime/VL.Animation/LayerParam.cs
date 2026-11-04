namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Text;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;

    [Serializable]
    public class LayerParam
    {
        [SerializeField]
        private string _layerName = "";
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
                return _003CisLoop_003Ek__BackingField;
            }
        }

        public bool isBaseLayer
        {
            get
            {
                return _isBaseLayer;
            }
        }

        public string layerName
        {
            get
            {
                return _layerName;
            }
        }

        public bool isAdditive
        {
            get
            {
                return _isAdditive;
            }
        }

        public AvatarMask mask
        {
            get
            {
                return _mask;
            }
        }

        public int clipCount
        {
            get
            {
                return _clips?.Count ?? 0;
            }
        }

        public IReadOnlyList<AnimationData> defaultAnimations
        {
            get
            {
                return _defaultAnimations;
            }
        }

        public double length
        {
            get
            {
                return _length;
            }
        }

        public ClipEvent onPlay
        {
            [CompilerGenerated]
            get
            {
                return _003ConPlay_003Ek__BackingField;
            }
        }

        public ClipEvent onComplete
        {
            [CompilerGenerated]
            get
            {
                return _003ConComplete_003Ek__BackingField;
            }
        }

        public PrepareFrameEvent onPrepareFrame
        {
            [CompilerGenerated]
            get
            {
                return _003ConPrepareFrame_003Ek__BackingField;
            }
        }

        public bool externalControl
        {
            get
            {
                return _externalControl;
            }
        }

        public LayerParam()
        {
            _clips = new List<ClipParam>();
            _length = 0;
        }

        public LayerParam(MotionDefine motionDefine) : this()
        {
            Append(new ClipParam(motionDefine));
        }

        public LayerParam(IEnumerable<MotionDefine> motionDefines) : this()
        {
            foreach (MotionDefine motion in motionDefines)
                Append(new ClipParam(motion));
        }

        public LayerParam(IEnumerable<ClipParam> clips) : this()
        {
            Append(clips);
        }

        public LayerParam Append(IEnumerable<ClipParam> clips)
        {
            foreach (ClipParam clip in clips)
                Append(clip);
            return this;
        }

        public LayerParam Append(ClipParam clip)
        {
            if (clip.motionDefine == null)
            {
                Debug.LogError("MotionDefineが指定されていません");
                return this;
            }
            MotionDefine motion = clip.motionDefine;
            if (_clips.Count == 0)
            {
                _layerName = motion.layerName ?? "";
                _isAdditive = motion.isAdditive;
                _isBaseLayer = string.IsNullOrEmpty(_layerName);
            }
            else
            {
                if (motion.isAdditive != _isAdditive)
                {
                    Debug.LogError("加算フラグを一致させる必要があります: " + clip.motionDefine.name);
                    return this;
                }
                if (motion.layerName != _layerName)
                {
                    Debug.LogError("Layer名が一致しません: " + motion.name + " LayerName=" + _layerName + ", " + motion.layerName);
                    return this;
                }
                if (clip.length < clip.transitionTime)
                    clip.SetLength(clip.transitionTime);
                ClipParam previous = _clips[_clips.Count - 1];
                double minimumLength = previous.transitionTime + clip.transitionTime;
                if (previous.length < minimumLength)
                {
                    _length += minimumLength - previous.length;
                    previous.SetLength(minimumLength);
                }
                _length -= clip.transitionTime;
            }
            _length += clip.length;
            _clips.Add(clip);
            return this;
        }

        public LayerParam SetLayerName(string layerName)
        {
            _layerName = layerName;
            _isBaseLayer = string.IsNullOrEmpty(_layerName);
            return this;
        }

        public LayerParam SetLayerAdditive(bool isAdditive)
        {
            _isAdditive = isAdditive;
            return this;
        }

        public LayerParam SetDefaultAnimations(DefaultAnimationData data)
        {
            if (data != null)
                _defaultAnimations = data.defaultAnimations.ToArray();
            if (overrideMotion != null)
                _defaultAnimations[1] = overrideMotion;
            return this;
        }

        public LayerParam SwitchToExternalControl()
        {
            _externalControl = true;
            return this;
        }

        public ClipParam GetClipParam(int index)
        {
            return index < 0 || _clips == null || index >= _clips.Count ? null : _clips[index];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("ClipParam:");
            foreach (ClipParam clip in _clips)
                builder.Append(clip.name).Append(",");
            return builder.ToString();
        }

        public void SetOverrideMotion(MotionDefine motionDefine)
        {
            if (motionDefine != null)
                overrideMotion = motionDefine.count == 2 ? motionDefine[1] : motionDefine.baseAnimation;
        }
    }
}
