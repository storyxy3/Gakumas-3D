namespace Campus.Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::Qua.VectorUI;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class CharacterDearnessReportView : QuaUIBehaviour
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<EpisodeReportData, int> _003C_003E9__26_2;
            public static Func<EpisodeReportData, int> _003C_003E9__26_5;
            public static Func<EpisodeReportData, int> _003C_003E9__26_6;
            public static Func<EpisodeReportData, int> _003C_003E9__30_2;
            public _003C_003Ec()
            {
            }

            internal int _003CGetBeforeEpisodeReportData_003Eb__26_2(EpisodeReportData x)
            {
                return default(int);
            }

            internal int _003CGetBeforeEpisodeReportData_003Eb__26_5(EpisodeReportData x)
            {
                return default(int);
            }

            internal int _003CGetBeforeEpisodeReportData_003Eb__26_6(EpisodeReportData x)
            {
                return default(int);
            }

            internal int _003CSetDataAndLoadAssetAsync_003Eb__30_2(EpisodeReportData x)
            {
                return default(int);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass26_0
        {
            public string characterId;
            public int episode;
            public int index;
            public _003C_003Ec__DisplayClass26_0()
            {
            }

            internal bool _003CGetBeforeEpisodeReportData_003Eb__0(CharacterEpisodeReportData x)
            {
                return default(bool);
            }

            internal bool _003CGetBeforeEpisodeReportData_003Eb__1(EpisodeReportData x)
            {
                return default(bool);
            }

            internal bool _003CGetBeforeEpisodeReportData_003Eb__3(EpisodeReportData x)
            {
                return default(bool);
            }

            internal bool _003CGetBeforeEpisodeReportData_003Eb__4(EpisodeReportData x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass27_0
        {
            public string characterId;
            public int episode;
            public int index;
            public _003C_003Ec__DisplayClass27_0()
            {
            }

            internal bool _003CGetEpisodeReportData_003Eb__0(CharacterEpisodeReportData x)
            {
                return default(bool);
            }

            internal bool _003CGetEpisodeReportData_003Eb__1(EpisodeReportData x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass30_0
        {
            public string characterId;
            public int episode;
            public _003C_003Ec__DisplayClass30_0()
            {
            }

            internal bool _003CSetDataAndLoadAssetAsync_003Eb__0(CharacterEpisodeReportData x)
            {
                return default(bool);
            }

            internal bool _003CSetDataAndLoadAssetAsync_003Eb__1(EpisodeReportData x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass31_0
        {
            public string characterId;
            public _003C_003Ec__DisplayClass31_0()
            {
            }

            internal bool _003CGetAllEpisodeReportDatas_003Eb__0(CharacterEpisodeReportData x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadTextureAsync_003Ed__28 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Texture2D> _003C_003Et__builder;
            public string assetName;
            public CharacterDearnessReportView _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<Texture2D>.Awaiter _003C_003Eu__1;
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
        private struct _003CSetDataAndLoadAssetAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string characterId;
            public int episode;
            public CharacterDearnessReportView _003C_003E4__this;
            public CancellationToken ct;
            private EpisodeReportData _003CafterEpisodeReportData_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        private CanvasGroup _rootCanvasGroup;
        [SerializeField]
        private RawImage _characterImage;
        [SerializeField]
        private RawImage _beforeGraphBg;
        [SerializeField]
        private RawImage _afterGraphBg;
        [SerializeField]
        private RawImage _beforeTextImage;
        [SerializeField]
        private RawImage _afterTextImage;
        [SerializeField]
        private CanvasGroup _beforeRedPenImage1CanvasGroup;
        [SerializeField]
        private CanvasGroup _beforeRedPenImage2CanvasGroup;
        [SerializeField]
        private CanvasGroup _beforeRedPenImage3CanvasGroup;
        [SerializeField]
        private CanvasGroup _currentRedPenImageCanvasGroup;
        [SerializeField]
        private CanvasGroup _addRedPenImageCanvasGroup;
        [SerializeField]
        private RawImage _addRedPenImage;
        [SerializeField]
        private RawImage _currentRedPenImage;
        [SerializeField]
        private RawImage[] _beforeRedPenImages;
        [SerializeField]
        private RawImage _compareGraphImage;
        [SerializeField]
        private CharacterEpisodeReportData[] _characterEpisodeReportData;
        [SerializeField]
        private TitanPlayer _titanPlayer;
        [SerializeField]
        private GameObject _backgroundBg;
        [SerializeField]
        private RadarChart _beforeRadarchart;
        [SerializeField]
        private RadarChart _afterRadarchart;
        [SerializeField]
        private CanvasGroup _compareGraphImageCanvasGroup;
        [SerializeField]
        private RoundedPolyline _beforeGraphOutline;
        [SerializeField]
        private RoundedPolyline _afterGraphOutline;
        private ReusableAssetKeeper _reusableAssetKeeper;
        private const int AssetKeeperCapacity = 10;
        public void Initialize()
        {
        }

        public EpisodeReportData GetBeforeEpisodeReportData(string characterId, int episode, int index)
        {
            return null;
        }

        public EpisodeReportData GetEpisodeReportData(string characterId, int episode, int index)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadTextureAsync_003Ed__28))]
        public UniTask<Texture2D> LoadTextureAsync(string assetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }

        public void SetTexture(Texture2D characterBgTexture, Texture2D beforeGraphBgTexture, Texture2D afterGraphBgTexture, Texture2D beforeTextBgTexture, Texture2D afterTextBgTexture, Texture2D[] redPenTextures, Texture2D compareGraphTexture, bool isAllShowRedPen)
        {
        }

        [AsyncStateMachine(typeof(_003CSetDataAndLoadAssetAsync_003Ed__30))]
        public UniTask SetDataAndLoadAssetAsync(string characterId, int episode, CancellationToken ct)
        {
            return default(UniTask);
        }

        public IReadOnlyList<EpisodeReportData> GetAllEpisodeReportDatas(string characterId)
        {
            return null;
        }

        public CharacterDearnessReportView()
        {
        }
    }
}
