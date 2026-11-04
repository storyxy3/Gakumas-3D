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
            public _003Cget_GatherProperties_003Ed__6(int _003C_003E1__state)
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
                        if (owner._light == null) return false;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner._light.transform, "m_LocalRotation");
                        _003C_003E1__state = 1;
                        return true;
                    case 1:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner._light, "m_Color");
                        _003C_003E1__state = 2;
                        return true;
                    case 2:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner._light, "m_Intensity");
                        _003C_003E1__state = 3;
                        return true;
                    case 3:
                        _003C_003E1__state = -1;
                        var lightData = owner._light.GetUniversalAdditionalLightData();
                        if (lightData == null) return false;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(lightData, "m_SpecularStrength");
                        _003C_003E1__state = 4;
                        return true;
                    case 4:
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
                return new _003Cget_GatherProperties_003Ed__6(0) { _003C_003E4__this = _003C_003E4__this };
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<ILiveEquipmentProperty>)this).GetEnumerator();
            }
        }

        [SerializeField]
        private Light _light;
        [SerializeField]
        private float _intensityScale = 1f;
        [NonSerialized]
        private UniversalAdditionalLightData _lightDataCache;
        private UniversalAdditionalLightData UniversalAdditionalLightData
        {
            get
            {
                if (_lightDataCache == null && _light != null) _lightDataCache = _light.GetUniversalAdditionalLightData();
                return _lightDataCache;
            }
        }

        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__6))]
            get
            {
                return new _003Cget_GatherProperties_003Ed__6(-2) { _003C_003E4__this = this };
            }
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
            if (_light != null)
            {
                _light.transform.localRotation = new Quaternion(data.rotationYaw.x, data.rotationYaw.y, data.rotationYaw.z, data.rotationYaw.w)
                    * new Quaternion(data.rotationPitch.x, data.rotationPitch.y, data.rotationPitch.z, data.rotationPitch.w);
                _light.color = data.color;
                _light.intensity = _intensityScale * data.intensity;
                var lightData = UniversalAdditionalLightData;
                if (lightData != null) lightData.specularStrength = data.lightParam.y;
            }
        }

        public LiveLightComponent()
        {
        }
    }
}
