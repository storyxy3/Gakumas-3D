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
            public _003Cget_GatherProperties_003Ed__13(int _003C_003E1__state)
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

        public Transform horizontal;
        public Transform vertical;
        public VolumetricLightBeamSD beam;
        public ProFlare[] flares;
        public Renderer renderer;
        private float _spotAngle;
        private float _fallOffEnd;
        private float _fresnelPow;
        private MaterialInfo _materialInfo;
        private static readonly int _EmissionColor;
        [NonSerialized]
        private UniversalAdditionalLightData _lightDataCache;
        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__13))]
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        public unsafe override void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        private void ApplyMaterial(Color color)
        {
        }

        public LiveLightBasic()
        {
        }
    }
}
