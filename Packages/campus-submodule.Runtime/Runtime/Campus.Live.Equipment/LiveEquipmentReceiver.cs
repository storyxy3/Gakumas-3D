// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, AddDependencyJob, ClearProperty, GetDependencyJobCount, GetMaterialInfo, GetMaterialInfoHash, OnDisable, OnEnable, StoreInitialData, Update, UpdateEquipment, get_StreamData, set_StreamData.
namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::VL.Core;

    [ExecuteAlways]
    public class LiveEquipmentReceiver : MonoBehaviour
    {
        [SerializeField]
        private List<EnvironmentBase> _equipments;
        private SerializedDictionary<int, MaterialInfo> _materialInfoTable;
        private List<Material> _tempMaterials;
        private List<Material> _tempSharedMaterials;
        [NonSerialized]
        private bool _initialized;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentStreamData> _003CStreamData_003Ek__BackingField;
        private bool _isModifiable;
        private bool _receivedFrame;
        public NativeArray<LiveEquipmentStreamData> StreamData
        {
            [CompilerGenerated]
            get
            {
                return default(NativeArray<LiveEquipmentStreamData>);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool receivedFrame
        {
            get
            {
                return _receivedFrame;
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Update()
        {
        }

        public void UpdateEquipment(NativeArray<LiveEquipmentStreamData> streamData)
        {
        }

        public void ClearProperty()
        {
        }

        public int GetDependencyJobCount()
        {
            return default(int);
        }

        public void AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData, NativeArray<JobHandle> jobHandles)
        {
        }

        [MethodImpl(256)]
        private int GetMaterialInfoHash(Renderer renderer, int materialIndex)
        {
            return default(int);
        }

        public MaterialInfo GetMaterialInfo(Renderer r, int materialIndex)
        {
            return null;
        }

        public void StoreInitialData(NativeArray<LiveEquipmentInitialData> initialData, bool forceUpdate = false)
        {
        }

        public LiveEquipmentReceiver()
        {
        }
    }
}
