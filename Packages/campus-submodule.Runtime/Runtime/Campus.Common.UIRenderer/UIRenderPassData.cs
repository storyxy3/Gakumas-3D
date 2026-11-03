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
        private static readonly Vector3 DefaultHsvOffset;
        [CompilerGenerated]
        private int _003CLayerId_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLayerValue_003Ek__BackingField;
        [CompilerGenerated]
        private UIRenderPassType _003CRenderPassType_003Ek__BackingField;
        private HashSet<CampusCanvas> _backgroundBlurRefs;
        private int LayerId
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public int LayerValue
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public UIRenderPassType RenderPassType
        {
            [CompilerGenerated]
            get
            {
                return default(UIRenderPassType);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public int BackgroundBlurRefCount
        {
            get
            {
                return default(int);
            }
        }

        public int BackgroundBlurSize
        {
            get
            {
                return default(int);
            }
        }

        public Vector3 HsvOffset
        {
            get
            {
                return default(Vector3);
            }
        }

        public void Initialize(CampusCanvas canvas)
        {
        }

        public void Reset()
        {
        }

        public void AddBackgroundBlur(CampusCanvas canvas)
        {
        }

        public void RemoveBackgroundBlur(CampusCanvas canvas)
        {
        }

        private int GetBackgroundBlurSize()
        {
            return default(int);
        }

        private Vector3 GetHsvOffset()
        {
            return default(Vector3);
        }

        public bool HasRenderPassType(UIRenderPassType flag)
        {
            return default(bool);
        }

        public int CompareTo(UIRenderPassData other)
        {
            return default(int);
        }

        public UIRenderPassData()
        {
        }
    }
}
