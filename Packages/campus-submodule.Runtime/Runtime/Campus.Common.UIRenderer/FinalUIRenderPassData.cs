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
                return default(int);
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
                return default(bool);
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

        public void Initialize(UIRenderPassData target)
        {
        }

        public void Reset()
        {
        }

        public bool HasRenderPassType(UIRenderPassType flag)
        {
            return default(bool);
        }

        public void RemoveBackgroundBlur()
        {
        }

        public FinalUIRenderPassData()
        {
        }
    }
}
