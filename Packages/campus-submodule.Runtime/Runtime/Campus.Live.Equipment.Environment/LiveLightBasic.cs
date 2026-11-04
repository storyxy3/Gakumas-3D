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
    using global::VL.Core;
    using global::VLB;

    [AddComponentMenu("Equipment/Light Basic")]
    public class LiveLightBasic : EnvironmentBase
    {
        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__13 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public LiveLightBasic _003C_003E4__this;
            private Light _003CrealLight_003E5__2;
            private int _003Ci_003E5__3;
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
            public _003Cget_GatherProperties_003Ed__13(int _003C_003E1__state)
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
                        if (owner.horizontal != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner.horizontal, "m_LocalRotation");
                            _003C_003E1__state = 1;
                            return true;
                        }
                        goto case 1;
                    case 1:
                        _003C_003E1__state = -1;
                        if (owner.vertical != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner.vertical, "m_LocalRotation");
                            _003C_003E1__state = 2;
                            return true;
                        }
                        goto case 2;
                    case 2:
                        _003C_003E1__state = -1;
                        if (owner.beam == null) goto StartFlares;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "color");
                        _003C_003E1__state = 3;
                        return true;
                    case 3:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "spotAngle");
                        _003C_003E1__state = 4;
                        return true;
                    case 4:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "fresnelPow");
                        _003C_003E1__state = 5;
                        return true;
                    case 5:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "fallOffEnd");
                        _003C_003E1__state = 6;
                        return true;
                    case 6:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "noiseIntensity");
                        _003C_003E1__state = 7;
                        return true;
                    case 7:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "colorFromLight");
                        _003C_003E1__state = 8;
                        return true;
                    case 8:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "intensityFromLight");
                        _003C_003E1__state = 9;
                        return true;
                    case 9:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "spotAngleFromLight");
                        _003C_003E1__state = 10;
                        return true;
                    case 10:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.beam, "fallOffEndFromLight");
                        _003C_003E1__state = 11;
                        return true;
                    case 11:
                        _003C_003E1__state = -1;
                        _003CrealLight_003E5__2 = owner.beam.lightSpotAttached;
                        if (_003CrealLight_003E5__2 == null) goto case 18;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_Enabled");
                        _003C_003E1__state = 12;
                        return true;
                    case 12:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_Color");
                        _003C_003E1__state = 13;
                        return true;
                    case 13:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_Intensity");
                        _003C_003E1__state = 14;
                        return true;
                    case 14:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_Range");
                        _003C_003E1__state = 15;
                        return true;
                    case 15:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_SpotAngle");
                        _003C_003E1__state = 16;
                        return true;
                    case 16:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(_003CrealLight_003E5__2, "m_InnerSpotAngle");
                        _003C_003E1__state = 17;
                        return true;
                    case 17:
                        _003C_003E1__state = -1;
                        var lightData = _003CrealLight_003E5__2.GetUniversalAdditionalLightData();
                        if (lightData == null) goto case 18;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(lightData, "m_SpecularStrength");
                        _003C_003E1__state = 18;
                        return true;
                    case 18:
                        _003C_003E1__state = -1;
                        _003CrealLight_003E5__2 = null;
                        goto StartFlares;
                    case 19:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.flares[_003Ci_003E5__3].transform, "m_LocalScale");
                        _003C_003E1__state = 20;
                        return true;
                    case 20:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner.flares[_003Ci_003E5__3], "GlobalTintColor");
                        _003C_003E1__state = 21;
                        return true;
                    case 21:
                        _003C_003E1__state = -1;
                        _003Ci_003E5__3++;
                        goto NextFlare;
                    default: return false;
                }
                StartFlares:
                if (owner.flares == null) return false;
                _003Ci_003E5__3 = 0;
                NextFlare:
                if (_003Ci_003E5__3 >= owner.flares.Length) return false;
                _003C_003E2__current = new LiveEquipmentComponentProperty(owner.flares[_003Ci_003E5__3], "isVisible");
                _003C_003E1__state = 19;
                return true;
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
                return new _003Cget_GatherProperties_003Ed__13(0) { _003C_003E4__this = _003C_003E4__this };
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<ILiveEquipmentProperty>)this).GetEnumerator();
            }
        }

        public Transform horizontal;
        public Transform vertical;
        public VolumetricLightBeamSD beam;
        public ProFlare[] flares;
        public Renderer renderer;
        private float _spotAngle;
        private float _fallOffEnd;
        private float _fresnelPow;
        private MaterialInfo _materialInfo;
        private static readonly int _EmissionColor = Shader.PropertyToID("_EmissionColor");
        [NonSerialized]
        private UniversalAdditionalLightData _lightDataCache;
        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__13))]
            get
            {
                return new _003Cget_GatherProperties_003Ed__13(-2) { _003C_003E4__this = this };
            }
        }

        private void OnEnable()
        {
            if (beam != null)
            {
                beam.colorFromLight = false;
                beam.intensityFromLight = false;
                beam.spotAngleFromLight = false;
                beam.fallOffEndFromLight = false;
            }
        }

        public unsafe override void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
            global::Unity.Mathematics.quaternion inverse = Quaternion.Inverse(transform.rotation);
            var position = vertical != null ? vertical.position : transform.position;
            pInitial->position = position;
            pInitial->v0 = inverse.value;
            float fresnel = beam != null ? Mathf.Clamp01(beam.fresnelPow / -10f + 1f) : 0f;
            float distance = beam != null ? beam.fallOffEnd : 0f;
            float spotAngle = beam != null ? beam.spotAngle : 0f;
            pInitial->v1 = new global::Unity.Mathematics.float4(fresnel, 0f, distance, spotAngle);
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
            float red = data.color.r * data.intensity;
            float green = data.color.g * data.intensity;
            float blue = data.color.b * data.intensity;
            var color = new Color(red > 0.004f ? red : 0f, green > 0.004f ? green : 0f,
                blue > 0.004f ? blue : 0f, data.intensity > 0.004f ? data.intensity : 0f);
            if (horizontal != null)
                horizontal.localRotation = new Quaternion(data.rotationYaw.x, data.rotationYaw.y, data.rotationYaw.z, data.rotationYaw.w);
            if (vertical != null)
                vertical.localRotation = new Quaternion(data.rotationPitch.x, data.rotationPitch.y, data.rotationPitch.z, data.rotationPitch.w);
            if (beam != null)
            {
                beam.color = color;
                int spotAngle = data.valueInt.w;
                float distance = data.valueFloat.z;
                if (spotAngle >= 1) beam.spotAngle = spotAngle;
                if (data.valueFloat.z > 0.01f) beam.fallOffEnd = distance;
                if (data.valueFloat.x > 0.01f) beam.fresnelPow = (1f - data.valueFloat.x) * 10f;
                beam.noiseIntensity = data.valueFloat.w;
                var realLight = beam.lightSpotAttached;
                bool enabled = data.lightParam.x > 0f && realLight != null;
                if (realLight != null) realLight.enabled = enabled;
                if (enabled)
                {
                    realLight.color = color;
                    realLight.intensity = data.lightParam.x;
                    realLight.spotAngle = spotAngle;
                    realLight.range = distance;
                    if (_lightDataCache == null) _lightDataCache = realLight.GetUniversalAdditionalLightData();
                    _lightDataCache.specularStrength = data.lightParam.y;
                }
            }
            if (flares != null)
            {
                int index = Mathf.Clamp(data.valueInt.y, 0, flares.Length);
                float scale = data.valueFloat.y;
                for (int i = 0; i < flares.Length; i++)
                {
                    if (i == index)
                    {
                        flares[index].isVisible = true;
                        flares[index].thisTransform.localScale = new Vector3(scale, scale, scale);
                        flares[index].GlobalTintColor = color;
                    }
                    else flares[i].isVisible = false;
                }
            }
            ApplyMaterial(color);
        }

        private void ApplyMaterial(Color color)
        {
            if (_materialInfo == null)
            {
                if (renderer == null) return;
                _materialInfo = GetMaterialInfo(renderer, 0);
            }
            _materialInfo.SetColor(_EmissionColor, color * 3f, true);
            _materialInfo.ApplyProperty();
        }

        public LiveLightBasic()
        {
        }
    }
}
