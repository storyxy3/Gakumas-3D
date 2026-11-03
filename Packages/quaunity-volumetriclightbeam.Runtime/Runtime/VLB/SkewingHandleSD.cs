namespace VLB
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
    public class SkewingHandleSD : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003CCoUpdate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public SkewingHandleSD _003C_003E4__this;
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
            public _003CCoUpdate_003Ed__9(int _003C_003E1__state)
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

        public const string ClassName = "SkewingHandleSD";
        public VolumetricLightBeamSD volumetricLightBeam;
        public bool shouldUpdateEachFrame;
        public bool IsAttachedToSelf()
        {
            return default(bool);
        }

        public bool CanSetSkewingVector()
        {
            return default(bool);
        }

        public bool CanUpdateEachFrame()
        {
            return default(bool);
        }

        private bool ShouldUpdateEachFrame()
        {
            return default(bool);
        }

        private void OnEnable()
        {
        }

        private void Start()
        {
        }

        [IteratorStateMachine(typeof(_003CCoUpdate_003Ed__9))]
        private IEnumerator CoUpdate()
        {
            return null;
        }

        private void SetSkewingVector()
        {
        }

        public SkewingHandleSD()
        {
        }
    }
}
