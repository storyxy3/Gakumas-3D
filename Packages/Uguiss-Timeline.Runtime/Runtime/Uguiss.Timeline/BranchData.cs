namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;
    using global::Uguiss.Timeline;

    public class BranchData
    {
        [CompilerGenerated]
        private sealed class _003CGetClips_003Ed__9 : IEnumerable<TimelineClip>, IEnumerable, IEnumerator<TimelineClip>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private TimelineClip _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public BranchData _003C_003E4__this;
            private List<AbstractCommand>.Enumerator _003C_003E7__wrap1;
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
            public _003CGetClips_003Ed__9(int _003C_003E1__state)
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
        private AbstractBranchCommand _003CTargetCommand_003Ek__BackingField;
        [CompilerGenerated]
        private List<AbstractCommand> _003CCommands_003Ek__BackingField;
        internal AbstractBranchCommand TargetCommand
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public List<AbstractCommand> Commands
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public void ToggleClips(bool isEnabled)
        {
        }

        [IteratorStateMachine(typeof(_003CGetClips_003Ed__9))]
        public IEnumerable<TimelineClip> GetClips()
        {
            return null;
        }

        public void Reset()
        {
        }

        public BranchData()
        {
        }
    }
}
