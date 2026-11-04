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
        private List<EnvironmentBase> _equipments = new List<EnvironmentBase>();
        private SerializedDictionary<int, MaterialInfo> _materialInfoTable;
        private List<Material> _tempMaterials = new List<Material>(8);
        private List<Material> _tempSharedMaterials = new List<Material>(8);
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
                return _003CStreamData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CStreamData_003Ek__BackingField = value;
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
            _initialized = false;
            _isModifiable = Application.isPlaying;
        }

        private void OnDisable()
        {
            if (_materialInfoTable == null) return;
            foreach (var entry in _materialInfoTable) entry.Value?.Dispose();
            _materialInfoTable.Clear();
        }

        private void Update()
        {
            _receivedFrame = false;
        }

        public void UpdateEquipment(NativeArray<LiveEquipmentStreamData> streamData)
        {
            StreamData = streamData;
            if (streamData.IsCreated)
            {
                for (int i = 0; i < _equipments.Count; i++)
                    if (_equipments[i] != null) _equipments[i].Apply(streamData, this);
            }
        }

        public void ClearProperty()
        {
            if (_materialInfoTable != null)
                foreach (var material in _materialInfoTable.Values) material.ClearProperty();
        }

        public int GetDependencyJobCount()
        {
            int count = 0;
            for (int i = 0; i < _equipments.Count; i++)
                if (_equipments[i] != null) count += _equipments[i].UseDependencyJob ? 1 : 0;
            return count;
        }

        public void AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData, NativeArray<JobHandle> jobHandles)
        {
            int count = 0;
            for (int i = 0; i < _equipments.Count; i++)
                if (_equipments[i] != null && _equipments[i].UseDependencyJob)
                    jobHandles[count++] = _equipments[i].AddDependencyJob(handle, streamData);
        }

        [MethodImpl(256)]
        private int GetMaterialInfoHash(Renderer renderer, int materialIndex)
        {
            return renderer.GetHashCode() * 397 ^ materialIndex;
        }

        public MaterialInfo GetMaterialInfo(Renderer r, int materialIndex)
        {
            if (_materialInfoTable == null) _materialInfoTable = new SerializedDictionary<int, MaterialInfo>();
            int key = GetMaterialInfoHash(r, materialIndex);
            if (!_materialInfoTable.TryGetValue(key, out var material))
            {
                if (_tempMaterials == null) _tempMaterials = new List<Material>(8);
                if (_tempSharedMaterials == null) _tempSharedMaterials = new List<Material>(8);
                r.GetSharedMaterials(_tempSharedMaterials);
                if (_isModifiable)
                {
                    r.GetMaterials(_tempMaterials);
                    material = new MaterialInfo(_tempSharedMaterials[materialIndex], r, materialIndex, _tempMaterials[materialIndex]);
                }
                else material = new MaterialInfo(_tempSharedMaterials[materialIndex], r, materialIndex, null);
                _materialInfoTable.Add(key, material);
            }
            return material;
        }

        public unsafe void StoreInitialData(NativeArray<LiveEquipmentInitialData> initialData, bool forceUpdate = false)
        {
            if (!initialData.IsCreated || _equipments == null || (_initialized && !forceUpdate)) return;
            _initialized = true;
            var data = (LiveEquipmentInitialData*)global::Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr(initialData);
            for (int i = 0; i < initialData.Length; i++) data[i].count = 0;
            for (int i = 0; i < _equipments.Count; i++)
            {
                var equipment = _equipments[i];
                if (equipment != null && equipment.id < initialData.Length)
                {
                    data[equipment.id].count++;
                    equipment.UpdateInitialData(data + equipment.id);
                }
            }
        }

        public LiveEquipmentReceiver()
        {

        }
    }
}
