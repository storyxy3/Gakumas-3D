namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public abstract class BlockingManagerBase<TBlockingManager, TBlockingType> : Singleton<TBlockingManager> where TBlockingManager : BlockingManagerBase<TBlockingManager, TBlockingType> where TBlockingType : IComparable
    {
        protected IBlockingProvider _overrideBlockingProvider;
        protected Dictionary<TBlockingType, int> _blockingCounter;
        protected Dictionary<TBlockingType, IBlockingPresenter> _blocking;
        public virtual IBlockingProvider BlockingProvider
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected override void OnInitialize()
        {
        }

        protected override void OnFinalize()
        {
        }

        public bool IsBlockingActive(TBlockingType blockingType)
        {
            return default(bool);
        }

        public static bool IsAnyActive()
        {
            return default(bool);
        }

        protected void Show(TBlockingType blockingType, int depth)
        {
        }

        protected void Hide(TBlockingType blockingType)
        {
        }

        protected IBlockingPresenter GetBlockingPresenter(TBlockingType blockingType)
        {
            return null;
        }

        protected virtual IBlockingPresenter CreateBlockingPresenter(TBlockingType blockingType, int depth)
        {
            return null;
        }

        protected abstract Transform GetRoot(TBlockingType blockingType);
        protected BlockingManagerBase()
        {
        }
    }
}
