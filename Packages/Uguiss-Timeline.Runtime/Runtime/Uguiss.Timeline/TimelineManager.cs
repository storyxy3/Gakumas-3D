namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Uguiss;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class TimelineManager : AbstractManager<TimelineEngine>
    {
        private class OffsetRange : IComparable<OffsetRange>
        {
            [CompilerGenerated]
            private double _003CStart_003Ek__BackingField;
            [CompilerGenerated]
            private double _003CEnd_003Ek__BackingField;
            [CompilerGenerated]
            private bool _003CIsTimelineEnd_003Ek__BackingField;
            public double Start
            {
                [CompilerGenerated]
                get
                {
                    return _003CStart_003Ek__BackingField;
                }

                [CompilerGenerated]
                set
                {
                    _003CStart_003Ek__BackingField = value;
                }
            }

            public double End
            {
                [CompilerGenerated]
                get
                {
                    return _003CEnd_003Ek__BackingField;
                }

                [CompilerGenerated]
                set
                {
                    _003CEnd_003Ek__BackingField = value;
                }
            }

            public bool IsTimelineEnd
            {
                [CompilerGenerated]
                get
                {
                    return _003CIsTimelineEnd_003Ek__BackingField;
                }

                [CompilerGenerated]
                set
                {
                    _003CIsTimelineEnd_003Ek__BackingField = value;
                }
            }

            public int CompareTo(OffsetRange other)
            {
                return default(int);
            }

            public OffsetRange()
            {
            }
        }

        protected class AsyncState
        {
            public bool isPlaying;
            public bool isSeek;
            public int frame;
            public int count;
            public AsyncState()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<TimelineClip, double> _003C_003E9__10_0;
            public static Func<KeyValuePair<string, List<AbstractPlayableCommand>>, int> _003C_003E9__51_0;
            public _003C_003Ec()
            {
            }

            internal double _003COffsetDisabledBranch_003Eb__10_0(TimelineClip x)
            {
                return default(double);
            }

            internal int _003CCreateGraphInternal_003Eb__51_0(KeyValuePair<string, List<AbstractPlayableCommand>> x)
            {
                return default(int);
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__49<T>
            where T : AbstractPlayableCommand
        {
            public static readonly _003C_003Ec__49<T> _003C_003E9 = new _003C_003Ec__49<T>();
            public static Predicate<AbstractPlayableCommand> _003C_003E9__49_0;
            public _003C_003Ec__49()
            {
            }

            internal bool _003CCommandExists_003Eb__49_0(AbstractPlayableCommand x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass57_0
        {
            public string mixerId;
            public _003C_003Ec__DisplayClass57_0()
            {
            }

            internal bool _003CUpdateMixerAsync_003Eb__0(AbstractPlayableCommand x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CUpdateGraphAsync_003Ed__55 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TimelineManager _003C_003E4__this;
            public CancellationToken ct;
            private bool _003CisPlaying_003E5__2;
            private double _003Ctime_003E5__3;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003CUpdateMixerAsync_003Ed__57 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TimelineManager _003C_003E4__this;
            public CancellationToken ct;
            public IEnumerable<string> mixerIds;
            private double _003Ctime_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            private IEnumerator<string> _003C_003E7__wrap2;
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
        private struct _003CUpdatePlayableAsync_003Ed__59 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AbstractPlayableCommand playableCommand;
            public TimelineManager _003C_003E4__this;
            public CancellationToken ct;
            private string _003CmixerId_003E5__2;
            private Playable _003Cmixer_003E5__3;
            private double _003Ctime_003E5__4;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private List<OffsetRange> _offsetRanges;
        [CompilerGenerated]
        private List<BranchGroupData> _003CBranchGroupList_003Ek__BackingField;
        private List<AbstractPlayableCommand> _interactiveTargetCommands;
        protected List<AbstractPlayableCommand> playableCommands;
        protected Dictionary<string, Playable> mixerPlayables;
        protected AsyncState asyncState;
        [CompilerGenerated]
        private readonly TimelineController _003CController_003Ek__BackingField;
        [CompilerGenerated]
        private double _003CInitializeTime_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsUpdateGraph_003Ek__BackingField;
        protected virtual bool IsBranchSupported
        {
            get
            {
                return default(bool);
            }
        }

        protected List<BranchGroupData> BranchGroupList
        {
            [CompilerGenerated]
            get
            {
                return _003CBranchGroupList_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CBranchGroupList_003Ek__BackingField = value;
            }
        }

        protected List<AbstractPlayableCommand> InteractiveTargetCommands
        {
            get
            {
                return null;
            }
        }

        protected virtual string GraphName
        {
            get
            {
                return null;
            }
        }

        protected virtual double DurationAdjustment
        {
            get
            {
                return default(double);
            }
        }

        public virtual DirectorUpdateMode TimeUpdateMode
        {
            get
            {
                return default(DirectorUpdateMode);
            }
        }

        public TimelineController Controller
        {
            [CompilerGenerated]
            get
            {
                return _003CController_003Ek__BackingField;
            }
        }

        public double InitializeTime
        {
            [CompilerGenerated]
            get
            {
                return _003CInitializeTime_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CInitializeTime_003Ek__BackingField = value;
            }
        }

        public bool IsUpdateGraph
        {
            [CompilerGenerated]
            get
            {
                return _003CIsUpdateGraph_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsUpdateGraph_003Ek__BackingField = value;
            }
        }

        public bool IsPlaying
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsAsync
        {
            get
            {
                return default(bool);
            }
        }

        public void UpdateBranchGroupList()
        {
        }

        protected virtual void OnUpdateBranchGroupList()
        {
        }

        public void SelectBranch(int branchGroupIndex, int branchIndex)
        {
        }

        public void OffsetDisabledBranch(BranchGroupData branchGroup)
        {
        }

        public void OffsetDisabledClip(TimelineClip clip)
        {
        }

        protected virtual List<AbstractPlayableCommand> GetInteractiveTargetCommands()
        {
            return null;
        }

        protected virtual int CompareInteractiveTargetCommand(AbstractPlayableCommand x, AbstractPlayableCommand y)
        {
            return default(int);
        }

        protected TimelineClip GetNextInteractiveClip<T>(double time, bool includeDisabledClip = false)
            where T : AbstractPlayableCommand
        {
            return null;
        }

        protected TimelineClip GetLastInteractiveClip<T>(bool includeDisabledClip = false)
            where T : AbstractPlayableCommand
        {
            return null;
        }

        protected override void OnInitialize()
        {
        }

        protected override void OnClear()
        {
        }

        public void AddCommand(AbstractPlayableCommand command)
        {
        }

        public void RemoveCommand(AbstractPlayableCommand command)
        {
        }

        public bool ContainsCommand(AbstractPlayableCommand command)
        {
            return default(bool);
        }

        public bool CommandExists<T>()
            where T : AbstractPlayableCommand
        {
            return default(bool);
        }

        public void CreateGraph()
        {
        }

        private void CreateGraphInternal()
        {
        }

        protected virtual void SetEngine(MixerPlayableBase mixerPlayable)
        {
        }

        protected virtual void CustomizeTimelineGraph(PlayableGraph graph, Playable timelinePlayable, TimelinePlayable timelineBehaviour)
        {
        }

        public void UpdateGraph()
        {
        }

        [AsyncStateMachine(typeof(_003CUpdateGraphAsync_003Ed__55))]
        protected virtual UniTask UpdateGraphAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void UpdateMixer(IEnumerable<string> mixerIds)
        {
        }

        [AsyncStateMachine(typeof(_003CUpdateMixerAsync_003Ed__57))]
        protected virtual UniTask UpdateMixerAsync(IEnumerable<string> mixerIds, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void UpdatePlayable(AbstractPlayableCommand playableCommand)
        {
        }

        [AsyncStateMachine(typeof(_003CUpdatePlayableAsync_003Ed__59))]
        protected virtual UniTask UpdatePlayableAsync(AbstractPlayableCommand playableCommand, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual void OnCreateGraph()
        {
        }

        protected virtual UniTask OnPreUpdateGraphAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnPostUpdateGraphAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnResetGraphAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public MixerPlayableBase GetMixerPlayable(string mixerId)
        {
            return null;
        }

        public virtual void BeginAsyncMethod(bool isSeek)
        {
        }

        public virtual void EndAsyncMethod()
        {
        }

        protected virtual void OnBeginAsyncMethod()
        {
        }

        protected virtual void OnEndAsyncMethod()
        {
        }

        protected virtual void OnStartSeek()
        {
        }

        protected virtual void OnEndSeek()
        {
        }

        protected virtual void OnUpdate()
        {
        }

        protected virtual void OnTimelineComplete()
        {
        }

        public void ClearCommands()
        {
        }

        private static int CompareCommand(AbstractPlayableCommand x, AbstractPlayableCommand y)
        {
            return default(int);
        }

        protected virtual void Update()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        public TimelineManager()
        {
        }
    }
}
