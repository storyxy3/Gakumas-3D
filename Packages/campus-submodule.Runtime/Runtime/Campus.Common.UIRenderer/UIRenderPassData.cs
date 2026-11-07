namespace Campus.Common.UIRenderer
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;

    public class UIRenderPassData : IUIRenderPassData, IComparable<UIRenderPassData>
    {
        private const int DefaultBackgroundBlurSize = 50;
        private static readonly Vector3 DefaultHsvOffset = new Vector3(0f, 0.1f, 0.5f);
        [CompilerGenerated]
        private int _003CLayerId_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLayerValue_003Ek__BackingField;
        [CompilerGenerated]
        private UIRenderPassType _003CRenderPassType_003Ek__BackingField;
        private HashSet<CampusCanvas> _backgroundBlurRefs = new HashSet<CampusCanvas>();
        private int LayerId
        {
            [CompilerGenerated]
            set
            {
                _003CLayerId_003Ek__BackingField = value;
            }
        }

        public int LayerValue
        {
            [CompilerGenerated]
            get
            {
                return _003CLayerValue_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CLayerValue_003Ek__BackingField = value;
            }
        }

        public UIRenderPassType RenderPassType
        {
            [CompilerGenerated]
            get
            {
                return _003CRenderPassType_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CRenderPassType_003Ek__BackingField = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return RenderPassType != UIRenderPassType.None;
            }
        }

        public int BackgroundBlurRefCount
        {
            get
            {
                return _backgroundBlurRefs.Count;
            }
        }

        public int BackgroundBlurSize
        {
            get
            {
                return GetBackgroundBlurSize();
            }
        }

        public Vector3 HsvOffset
        {
            get
            {
                return GetHsvOffset();
            }
        }

        public void Initialize(CampusCanvas canvas)
        {
            LayerId = canvas.LayerId;
            LayerValue = canvas.LayerValue;
        }

        public void Reset()
        {
            LayerId = 0;
            LayerValue = 0;
            RenderPassType = UIRenderPassType.None;
            _backgroundBlurRefs.Clear();
        }

        public void AddBackgroundBlur(CampusCanvas canvas)
        {
            _backgroundBlurRefs.Add(canvas);
            RenderPassType |= UIRenderPassType.BackgroundBlur;
        }

        public void RemoveBackgroundBlur(CampusCanvas canvas)
        {
            _backgroundBlurRefs.Remove(canvas);
            if (BackgroundBlurRefCount <= 0)
                RenderPassType &= ~UIRenderPassType.BackgroundBlur;
        }

        private int GetBackgroundBlurSize()
        {
            foreach (var canvas in _backgroundBlurRefs)
            {
                var size = canvas.OverrideBlurSize;
                if (size.HasValue)
                    return size.Value;
            }
            return DefaultBackgroundBlurSize;
        }

        private Vector3 GetHsvOffset()
        {
            foreach (var canvas in _backgroundBlurRefs)
            {
                var offset = canvas.OverrideHsvOffset;
                if (offset.HasValue)
                    return offset.Value;
            }
            return DefaultHsvOffset;
        }

        public bool HasRenderPassType(UIRenderPassType flag)
        {
            return (RenderPassType & flag) == flag;
        }

        public int CompareTo(UIRenderPassData other)
        {
            return LayerValue.CompareTo(other.LayerValue);
        }

        public UIRenderPassData()
        {
        }
    }
}
