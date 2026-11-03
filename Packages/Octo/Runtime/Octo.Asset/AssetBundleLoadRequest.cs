namespace Octo.Asset
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Asset;
    using global::Octo.Loader;
    using global::UnityEngine;

    internal sealed class AssetBundleLoadRequest : BaseRequest
    {
        [CompilerGenerated]
        private sealed class _003CExecute_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetBundleLoadRequest _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CExecute_003Ed__20(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CPrepare_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetBundleLoadRequest _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CPrepare_003Ed__19(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private static readonly string Tag;
        [CompilerGenerated]
        private LoadStaus _003Cstatus_003Ek__BackingField;
        [CompilerGenerated]
        private LoadError _003CerrorInfo_003Ek__BackingField;
        private bool _canExecute;
        public AssetBundleData assetbundledata;
        private OnDownloadProgress _onProgress;
        private bool _isNonCache;
        private byte[] _assetBundleBytes;
        public LoadStaus status
        {
            [CompilerGenerated]
            get
            {
                return default(LoadStaus);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public LoadError errorInfo
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public override string Name
        {
            get
            {
                return null;
            }
        }

        public override bool CanExecute
        {
            get
            {
                return default(bool);
            }
        }

        public AssetBundleLoadRequest(AssetBundleData data, OnDownloadProgress onProgress, bool isNonCache)
        {
        }

        [IteratorStateMachine(typeof(_003CPrepare_003Ed__19))]
        public override IEnumerator Prepare()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CExecute_003Ed__20))]
        public override IEnumerator Execute()
        {
            return null;
        }

        private void LoadCompleteCallback(AssetBundle ab, LoadError err)
        {
        }
    }
}
