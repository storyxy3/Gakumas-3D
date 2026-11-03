namespace Qua.Global
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Global;
    using global::TMPro;

    public class QuaGlobalManager
    {
        private class FontContainer
        {
            [CompilerGenerated]
            private readonly TMP_FontAsset _003Cfont_003Ek__BackingField;
            [CompilerGenerated]
            private readonly string _003CloadKey_003Ek__BackingField;
            [CompilerGenerated]
            private int _003CrefCount_003Ek__BackingField;
            public TMP_FontAsset font
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }
            }

            public string loadKey
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }
            }

            public int refCount
            {
                [CompilerGenerated]
                get
                {
                    return default(int);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public FontContainer(TMP_FontAsset font, string loadKey, int refCount)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadCorrectFontAsync_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TMP_FontAsset> _003C_003Et__builder;
            public string id;
            public CancellationToken cancellationToken;
            private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadFontAsync_003Ed__25 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TMP_FontAsset> _003C_003Et__builder;
            public string id;
            public CancellationToken cancellationToken;
            private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadFontAsyncInternal_003Ed__26 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TMP_FontAsset> _003C_003Et__builder;
            public QuaGlobalManager _003C_003E4__this;
            public string id;
            public CancellationToken cancellationToken;
            private string _003CloadKey_003E5__2;
            private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private static QuaGlobalManager _instance;
        private readonly Dictionary<string, FontContainer> _fontDictionary;
        private QuaGlobalSetting _setting;
        private IFontLoader _fontLoader;
        private string _defaultFontId;
        private readonly HashSet<Action<string>> _onDefaultFontIdChangedActions;
        public static QuaGlobalManager Instance
        {
            get
            {
                return null;
            }
        }

        public static string DefaultFontId
        {
            get
            {
                return null;
            }
        }

        public bool IsSetup
        {
            get
            {
                return default(bool);
            }
        }

        public static event Action<string> OnDefaultFontIdChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        private QuaGlobalManager()
        {
        }

        public static void Setup(QuaGlobalSetting setting, IFontLoader fontLoader)
        {
        }

        private void SetupInternal(QuaGlobalSetting setting, IFontLoader fontLoader)
        {
        }

        [AsyncStateMachine(typeof(_003CLoadCorrectFontAsync_003Ed__24))]
        internal static UniTask<TMP_FontAsset> LoadCorrectFontAsync(string id, CancellationToken cancellationToken)
        {
            return default(UniTask<TMP_FontAsset>);
        }

        [AsyncStateMachine(typeof(_003CLoadFontAsync_003Ed__25))]
        internal static UniTask<TMP_FontAsset> LoadFontAsync(string id, CancellationToken cancellationToken)
        {
            return default(UniTask<TMP_FontAsset>);
        }

        [AsyncStateMachine(typeof(_003CLoadFontAsyncInternal_003Ed__26))]
        private UniTask<TMP_FontAsset> LoadFontAsyncInternal(string id, CancellationToken cancellationToken)
        {
            return default(UniTask<TMP_FontAsset>);
        }

        private string ValidateAndGetLoadKey(string fontId)
        {
            return null;
        }

        internal static void UnloadFont(string id)
        {
        }

        private void UnloadFontInternal(string id)
        {
        }
    }
}
