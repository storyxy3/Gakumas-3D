namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.UIRenderer;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class UIRendererManager : Singleton<UIRendererManager>
    {
        public const int MaxBlurCount = 3;
        private static readonly Comparison<UIRenderPassData> RenderPassSorter;
        private SimpleObjectPool<UIRenderPassData> _renderPassDataPool;
        private SimpleObjectPool<FinalUIRenderPassData> _finalRenderPassDataPool;
        private List<UIRenderPassData> _tempList;
        private Dictionary<int, UIRenderPassData> _renderPassMap;
        private List<UIRenderPassData> _renderPassDatas;
        private List<FinalUIRenderPassData> _finalRenderPassDatas;
        [CompilerGenerated]
        private static Action m_onForceUpdateBlurTextureSize;
        public IReadOnlyList<IUIRenderPassData> FinalRenderPassDatas
        {
            get
            {
                return null;
            }
        }

        public static event Action onForceUpdateBlurTextureSize
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public int GetBackgroundBlurSize(CampusCanvas canvas)
        {
            return default(int);
        }

        public void AddBackgroundBlur(CampusCanvas canvas)
        {
        }

        public void RemoveBackgroundBlur(CampusCanvas canvas)
        {
        }

        public Vector3 GetHsvOffset(CampusCanvas canvas)
        {
            return default(Vector3);
        }

        private UIRenderPassData GetRenderPassData(CampusCanvas canvas)
        {
            return null;
        }

        private UIRenderPassData CreateRenderPassData(CampusCanvas canvas)
        {
            return null;
        }

        private int GetPassCount(UIRenderPassType passType)
        {
            return default(int);
        }

        private void RemoveInvalidPassDatas()
        {
        }

        private void ClearFinalRenderPassDatas()
        {
        }

        private void UpdateFinalPassDatas()
        {
        }

        private static int SortRenderPassDatas(UIRenderPassData a, UIRenderPassData b)
        {
            return default(int);
        }

        public void ForceUpdateBlurTextureSize()
        {
        }

        public UIRendererManager()
        {
        }
    }
}
