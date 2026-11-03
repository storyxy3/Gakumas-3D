namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::VL.Core;

    [ExecuteAlways]
    public class EnvironmentBase : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__11 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
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
            public _003Cget_GatherProperties_003Ed__11(int _003C_003E1__state)
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

        [Range(0f, 255f)]
        public int id;
        public bool master;
        private LiveEquipmentReceiver _receiver;
        public virtual bool UseDependencyJob
        {
            get
            {
                return default(bool);
            }
        }

        public virtual IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__11))]
            get
            {
                return null;
            }
        }

        public void Apply(NativeArray<LiveEquipmentStreamData> stream, LiveEquipmentReceiver receiver)
        {
        }

        public virtual JobHandle AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData)
        {
            return default(JobHandle);
        }

        protected MaterialInfo GetMaterialInfo(Renderer r, int materialIndex)
        {
            return null;
        }

        protected virtual void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        public unsafe virtual void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
        }

        public EnvironmentBase()
        {
        }
    }
}
