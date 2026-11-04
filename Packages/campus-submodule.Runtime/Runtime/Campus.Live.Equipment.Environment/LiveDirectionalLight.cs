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

    [RequireComponent(typeof(Light))]
    [AddComponentMenu("Equipment/Directional Light")]
    public class LiveDirectionalLight : EnvironmentBase
    {
        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__3 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public LiveDirectionalLight _003C_003E4__this;
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
            public _003Cget_GatherProperties_003Ed__3(int _003C_003E1__state)
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
                var owner = _003C_003E4__this;
                switch (_003C_003E1__state)
                {
                    case 0:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.transform, "m_LocalRotation");
                        _003C_003E1__state = 1;
                        return true;
                    case 1:
                        _003C_003E1__state = -1;
                        if (owner._light != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner._light, "m_Shadows.m_Strength");
                            _003C_003E1__state = 2;
                            return true;
                        }
                        return false;
                    case 2:
                        _003C_003E1__state = -1;
                        return false;
                    default: return false;
                }
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
                return new _003Cget_GatherProperties_003Ed__3(0) { _003C_003E4__this = _003C_003E4__this };
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<ILiveEquipmentProperty>)this).GetEnumerator();
            }
        }

        [SerializeField]
        private Light _light;
        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__3))]
            get
            {
                return new _003Cget_GatherProperties_003Ed__3(-2) { _003C_003E4__this = this };
            }
        }

        private void OnEnable()
        {
            TryGetComponent(out _light);
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
            if (data.valueInt.w == 0) return;
            transform.localRotation = new Quaternion(data.rotationYaw.x, data.rotationYaw.y, data.rotationYaw.z, data.rotationYaw.w);
            if (_light != null && data.intensity >= 0f) _light.shadowStrength = data.intensity;
        }

        public LiveDirectionalLight()
        {
        }
    }
}
