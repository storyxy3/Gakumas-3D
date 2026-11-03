namespace VLB
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
    public class EffectPulse : EffectAbstractBase
    {
        [CompilerGenerated]
        private sealed class _003CCoUpdate_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public EffectPulse _003C_003E4__this;
            private float _003Ct_003E5__2;
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
            public _003CCoUpdate_003Ed__4(int _003C_003E1__state)
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

        public new const string ClassName = "EffectPulse";
        [Range(0.1f, 60f)]
        public float frequency;
        [MinMaxRange(-5f, 5f)]
        public MinMaxRangeFloat intensityAmplitude;
        protected override void OnEnable()
        {
        }

        [IteratorStateMachine(typeof(_003CCoUpdate_003Ed__4))]
        private IEnumerator CoUpdate()
        {
            return null;
        }

        public EffectPulse()
        {
        }
    }
}
