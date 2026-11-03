namespace Campus.Live.Equipment.Environment
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Environment;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;

    [AddComponentMenu("Equipment/Light Component")]
    public class LiveLightComponent : EnvironmentBase
    {
        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__6 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public LiveLightComponent _003C_003E4__this;
            ILiveEquipmentProperty System.Collections.Generic.IEnumerator<Campus.Live.Equipment.ILiveEquipmentProperty>.Current
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
            public _003Cget_GatherProperties_003Ed__6(int _003C_003E1__state)
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

            [DebuggerHidden]
            IEnumerator<ILiveEquipmentProperty> System.Collections.Generic.IEnumerable<Campus.Live.Equipment.ILiveEquipmentProperty>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        [SerializeField]
        private Light _light;
        [SerializeField]
        private float _intensityScale;
        [NonSerialized]
        private UniversalAdditionalLightData _lightDataCache;
        private UniversalAdditionalLightData UniversalAdditionalLightData
        {
            get
            {
                return null;
            }
        }

        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__6))]
            get
            {
                return null;
            }
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        public LiveLightComponent()
        {
        }
    }
}
