namespace Campus.Common.Octo
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public abstract class ImageResourceViewBase<TImageAsset, TImageComponent> : CampusAssetKeeperBase<TImageAsset> where TImageAsset : UnityEngine.Object where TImageComponent : Graphic
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetAsync_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TImageAsset> _003C_003Et__builder;
            public ImageResourceViewBase<TImageAsset, TImageComponent> _003C_003E4__this;
            public string exAssetName;
            public CancellationToken ct;
            private UniTask<TImageAsset>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetAsync_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TImageAsset> _003C_003Et__builder;
            public ImageResourceViewBase<TImageAsset, TImageComponent> _003C_003E4__this;
            public string assetName;
            public string fallbackAssetName;
            public CancellationToken ct;
            private UniTask<TImageAsset>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        protected TImageComponent _image;
        [CompilerGenerated]
        private Action _003COnPostProcess_003Ek__BackingField;
        public Action OnPostProcess
        {
            [CompilerGenerated]
            private get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public TImageComponent ImageComponent
        {
            get
            {
                return null;
            }
        }

        protected override void PreProcess()
        {
        }

        protected override void PostProcess(TImageAsset asset, bool isCanceled)
        {
        }

        public void Set(string exAssetName)
        {
        }

        public void Set(string assetName, string fallbackAssetName)
        {
        }

        [AsyncStateMachine(typeof(ImageResourceViewBase<, >._003CSetAsync_003Ed__11))]
        public virtual UniTask<TImageAsset> SetAsync(string exAssetName, CancellationToken ct)
        {
            return default(UniTask<TImageAsset>);
        }

        [AsyncStateMachine(typeof(ImageResourceViewBase<, >._003CSetAsync_003Ed__12))]
        public virtual UniTask<TImageAsset> SetAsync(string assetName, string fallbackAssetName, CancellationToken ct)
        {
            return default(UniTask<TImageAsset>);
        }

        protected abstract void ApplyAsset(TImageAsset asset, TImageComponent component);
        public override void Unset()
        {
        }

        protected ImageResourceViewBase()
        {
        }
    }
}
