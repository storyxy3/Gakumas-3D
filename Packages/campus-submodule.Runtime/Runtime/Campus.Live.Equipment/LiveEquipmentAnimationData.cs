namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public struct LiveEquipmentAnimationData : IUseFlags
    {
        [CompilerGenerated]
        private int _003CUseFlags_003Ek__BackingField;
        public LiveEquipmentStreamJobType jobType;
        public int processedInstanceID;
        public float intensity;
        public Color color;
        public float bpmTime;
        public float v0;
        public float v1;
        public float v2;
        public float v3;
        public float3 position;
        public float4 lookAtParam;
        public float4 lightParam;
        public int4 valueInt;
        public float4 valueFloat;
        public int UseFlags
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CUseFlags_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CUseFlags_003Ek__BackingField = value;
            }
        }
    }
}
