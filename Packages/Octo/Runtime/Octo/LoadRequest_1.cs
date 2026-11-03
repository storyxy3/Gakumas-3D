namespace Octo
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    public sealed class LoadRequest<T> : CustomYieldInstruction where T : UnityEngine.Object
    {
        private AssetBundleRequest _abr;
        private T _asset;
        [CompilerGenerated]
        private Action<AssetBundleRequest> m_OnComplete;
        public override bool keepWaiting
        {
            get
            {
                return default(bool);
            }
        }

        public T asset
        {
            get
            {
                return null;
            }
        }

        public bool isDone
        {
            get
            {
                return default(bool);
            }
        }

        public event Action<AssetBundleRequest> OnComplete
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

        public LoadRequest(AssetBundleRequest abr)
        {
        }
    }
}
