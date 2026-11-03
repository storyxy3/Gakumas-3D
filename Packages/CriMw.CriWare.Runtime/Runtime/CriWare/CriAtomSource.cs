namespace CriWare
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CRI Atom Source")]
    public class CriAtomSource : CriAtomSourceBase
    {
        [CompilerGenerated]
        private sealed class _003CPlayAsync_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriAtomSource _003C_003E4__this;
            public string cueName;
            private CriAtomExAcb _003Cacb_003E5__2;
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
            public _003CPlayAsync_003Ed__11(int _003C_003E1__state)
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

        [SerializeField]
        private string _cueName;
        [SerializeField]
        private string _cueSheet;
        public string cueName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string cueSheet
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override CriAtomExPlayback Play()
        {
            return default(CriAtomExPlayback);
        }

        protected override CriAtomExAcb GetAcb()
        {
            return null;
        }

        protected override void PlayOnStart()
        {
        }

        [IteratorStateMachine(typeof(_003CPlayAsync_003Ed__11))]
        private IEnumerator PlayAsync(string cueName)
        {
            return null;
        }

        public CriAtomSource()
        {
        }
    }
}
