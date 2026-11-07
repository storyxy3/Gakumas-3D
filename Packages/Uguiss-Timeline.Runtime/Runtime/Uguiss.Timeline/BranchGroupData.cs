namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;

    public class BranchGroupData
    {
        [CompilerGenerated]
        private sealed class _003CGetClips_003Ed__15 : IEnumerable<TimelineClip>, IEnumerable, IEnumerator<TimelineClip>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private TimelineClip _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public BranchGroupData _003C_003E4__this;
            private List<BranchData>.Enumerator _003C_003E7__wrap1;
            private IEnumerator<TimelineClip> _003C_003E7__wrap2;
            TimelineClip System.Collections.Generic.IEnumerator<Uguiss.Timeline.TimelineClip>.Current
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
            public _003CGetClips_003Ed__15(int _003C_003E1__state)
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

            private void _003C_003Em__Finally1()
            {
            }

            private void _003C_003Em__Finally2()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }

            [DebuggerHidden]
            IEnumerator<TimelineClip> System.Collections.Generic.IEnumerable<Uguiss.Timeline.TimelineClip>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        [CompilerGenerated]
        private AbstractBranchGroupCommand _003CTargetCommand_003Ek__BackingField;
        [CompilerGenerated]
        private List<BranchData> _003CBranchList_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CSelectedIndex_003Ek__BackingField;
        public AbstractBranchGroupCommand TargetCommand
        {
            [CompilerGenerated]
            get
            {
                return _003CTargetCommand_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CTargetCommand_003Ek__BackingField = value;
            }
        }

        public List<BranchData> BranchList
        {
            [CompilerGenerated]
            get
            {
                return _003CBranchList_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CBranchList_003Ek__BackingField = value;
            }
        }

        public int SelectedIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CSelectedIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CSelectedIndex_003Ek__BackingField = value;
            }
        }

        public bool IsSelected
        {
            get
            {
                return default(bool);
            }
        }

        public void SelectBranch(int index)
        {
        }

        [IteratorStateMachine(typeof(_003CGetClips_003Ed__15))]
        public IEnumerable<TimelineClip> GetClips()
        {
            return null;
        }

        public void Reset()
        {
        }

        public BranchGroupData()
        {
        }
    }
}
