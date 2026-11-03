namespace Campus.Live.Equipment.Environment
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Environment;
    using global::UnityEngine;

    [RequireComponent(typeof(CrowdVolume))]
    [AddComponentMenu("Equipment/Psyllium")]
    public class LivePsyllium : EnvironmentBase
    {
        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__2 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public LivePsyllium _003C_003E4__this;
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
            public _003Cget_GatherProperties_003Ed__2(int _003C_003E1__state)
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

        private CrowdVolume _crowdVolume;
        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__2))]
            get
            {
                return null;
            }
        }

        public unsafe override void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        public LivePsyllium()
        {
        }
    }
}
