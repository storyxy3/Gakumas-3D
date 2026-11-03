namespace VLB
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
    public class EffectFlicker : EffectAbstractBase
    {
        [CompilerGenerated]
        private sealed class _003CCoChangeIntensity_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public EffectFlicker _003C_003E4__this;
            public float nextIntensity;
            public float expectedDuration;
            private float _003Cvelocity_003E5__2;
            private float _003Ct_003E5__3;
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
            public _003CCoChangeIntensity_003Ed__12(int _003C_003E1__state)
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
        private sealed class _003CCoFlicker_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public EffectFlicker _003C_003E4__this;
            private float _003CremainingDuration_003E5__2;
            private float _003CfreqDuration_003E5__3;
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
            public _003CCoFlicker_003Ed__11(int _003C_003E1__state)
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
        private sealed class _003CCoUpdate_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public EffectFlicker _003C_003E4__this;
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
            public _003CCoUpdate_003Ed__10(int _003C_003E1__state)
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

        public new const string ClassName = "EffectFlicker";
        [Range(1f, 60f)]
        public float frequency;
        public bool performPauses;
        [MinMaxRange(0f, 10f)]
        public MinMaxRangeFloat flickeringDuration;
        [MinMaxRange(0f, 10f)]
        public MinMaxRangeFloat pauseDuration;
        public bool restoreIntensityOnPause;
        [MinMaxRange(-5f, 5f)]
        public MinMaxRangeFloat intensityAmplitude;
        [Range(0f, 0.25f)]
        public float smoothing;
        private float m_CurrentAdditiveIntensity;
        protected override void OnEnable()
        {
        }

        [IteratorStateMachine(typeof(_003CCoUpdate_003Ed__10))]
        private IEnumerator CoUpdate()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CCoFlicker_003Ed__11))]
        private IEnumerator CoFlicker()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CCoChangeIntensity_003Ed__12))]
        private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
        {
            return null;
        }

        public EffectFlicker()
        {
        }
    }
}
