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
                    return _003C_003E2__current;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return _003C_003E2__current;
                }
            }

            [DebuggerHidden]
            public _003Cget_GatherProperties_003Ed__11(int _003C_003E1__state)
            {
                this._003C_003E1__state = _003C_003E1__state;
                _003C_003El__initialThreadId = global::System.Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_003C_003E1__state == 0) _003C_003E1__state = -1;
                return false;
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            IEnumerator<ILiveEquipmentProperty> System.Collections.Generic.IEnumerable<Campus.Live.Equipment.ILiveEquipmentProperty>.GetEnumerator()
            {
                if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == global::System.Environment.CurrentManagedThreadId)
                {
                    _003C_003E1__state = 0;
                    return this;
                }
                return new _003Cget_GatherProperties_003Ed__11(0);
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<ILiveEquipmentProperty>)this).GetEnumerator();
            }
        }

        [Range(0f, 255f)]
        public int id;
        public bool master = true;
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
                return new _003Cget_GatherProperties_003Ed__11(-2);
            }
        }

        public void Apply(NativeArray<LiveEquipmentStreamData> stream, LiveEquipmentReceiver receiver)
        {
            if (id < 0 || id >= stream.Length) return;
            _receiver = receiver;
            var data = stream[id];
            OnApply(ref data);
            _receiver = null;
        }

        public virtual JobHandle AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData)
        {
            return handle;
        }

        protected MaterialInfo GetMaterialInfo(Renderer r, int materialIndex)
        {
            var material = _receiver.GetMaterialInfo(r, materialIndex);
            if (material != null) material.InitializeProperty();
            else UnityEngine.Debug.LogError(string.Format("InvalidMaterial {0} {1}", name, materialIndex));
            return material;
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
