namespace Campus.Common.UIRenderer
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;

    public class FinalUIRenderPassData : IUIRenderPassData
    {
        private UIRenderPassData _srcData;
        [CompilerGenerated]
        private UIRenderPassType _003CRenderPassType_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CBackgroundBlurRefCount_003Ek__BackingField;
        public int LayerValue
        {
            get
            {
                return _srcData.LayerValue;
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
            [CompilerGenerated]
            get
            {
                return _003CBackgroundBlurRefCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CBackgroundBlurRefCount_003Ek__BackingField = value;
            }
        }

        public int BackgroundBlurSize
        {
            get
            {
                return _srcData.BackgroundBlurSize;
            }
        }

        public Vector3 HsvOffset
        {
            get
            {
                return _srcData.HsvOffset;
            }
        }

        public void Initialize(UIRenderPassData target)
        {
            _srcData = target;
            RenderPassType = target.RenderPassType;
            BackgroundBlurRefCount = target.BackgroundBlurRefCount;
        }

        public void Reset()
        {
            _srcData = null;
            RenderPassType = UIRenderPassType.None;
            BackgroundBlurRefCount = 0;
        }

        public bool HasRenderPassType(UIRenderPassType flag)
        {
            return (RenderPassType & flag) == flag;
        }

        public void RemoveBackgroundBlur()
        {
            RenderPassType &= ~UIRenderPassType.BackgroundBlur;
            BackgroundBlurRefCount--;
        }

        public FinalUIRenderPassData()
        {
        }
    }
}
