namespace Campus.Titan
{
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
