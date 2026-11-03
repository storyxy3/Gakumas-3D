namespace Campus.Live.Equipment.Environment
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Environment;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;

    [AddComponentMenu("Equipment/Laser")]
    [ExecuteAlways]
    public class LiveLaser : EnvironmentBase
    {
        public enum LaserType
        {
            Plane,
            Cone,
            RandomCone
        }

        public enum LightType
        {
            Always,
            Normal,
            Reverse,
            Center,
            CenterReverse
        }

        private struct VertexLayout
        {
            public float3 position;
            public Color color;
            public float2 uv;
            public float2 uv2;
        }

        [BurstCompile]
        private struct LaserVertexJob : IJob
        {
            [ReadOnly]
            public NativeArray<LiveEquipmentStreamData> streamData;
            public NativeArray<VertexLayout> vertexData;
            public int index;
            public LaserType laserType;
            public LightType lightType;
            public float radius;
            public int laserCount;
            public float laserAngle;
            public float length;
            public Color color;
            public float randomSpeed;
            public float time;
            public float lightOnTime;
            public float lightOffTime;
            public float lightDelay;
            public float3 cameraPosition;
            public float3 worldPosition;
            public quaternion invRoll;
            private Color GetLaserColor(int index)
            {
                return default(Color);
            }

            public void Execute()
            {
            }

            private unsafe void UpdatePlane(VertexLayout* pVertexHead)
            {
            }

            private unsafe void UpdateCone(VertexLayout* pVertexHead, bool fullRandom)
            {
            }

            [MethodImpl(256)]
            private quaternion LookCamera(quaternion rotation)
            {
                return default(quaternion);
            }
        }

        [CompilerGenerated]
        private sealed class _003Cget_GatherProperties_003Ed__31 : IEnumerable<ILiveEquipmentProperty>, IEnumerable, IEnumerator<ILiveEquipmentProperty>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private ILiveEquipmentProperty _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public LiveLaser _003C_003E4__this;
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
            public _003Cget_GatherProperties_003Ed__31(int _003C_003E1__state)
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

        public const int MaxLaser = 16;
        public const int SegmentSize = 4;
        public const int SizeX = 3;
        public const int LaserVertexCount = 15;
        public const float UvMargin = 0.001f;
        public const float UvDistance = 0.124f;
        public const float Uv2Distance = 1f / 32f;
        [SerializeField]
        private MeshRenderer _renderer;
        [FormerlySerializedAs("Horizontal")]
        public Transform horizontal;
        [FormerlySerializedAs("Vertical")]
        public Transform vertical;
        [FormerlySerializedAs("Type")]
        public LaserType laserType;
        public LightType lightType;
        [FormerlySerializedAs("AnimationTime")]
        public float animationTime;
        [FormerlySerializedAs("Color")]
        [ColorUsage(false, true)]
        public Color color;
        [FormerlySerializedAs("BeamCount")]
        [Range(1f, 16f)]
        public int laserCount;
        [FormerlySerializedAs("BeamAngle")]
        [Range(0f, 179f)]
        public float laserAngle;
        [FormerlySerializedAs("Radius")]
        public float radius;
        [FormerlySerializedAs("Length")]
        public float length;
        [FormerlySerializedAs("RandomSpeed")]
        public float randomSpeed;
        private Mesh _mesh;
        private MeshFilter _meshFilter;
        private NativeArray<VertexLayout> _vertexData;
        private NativeArray<ushort> _indexData;
        private JobHandle _handle;
        public override IEnumerable<ILiveEquipmentProperty> GatherProperties
        {
            [IteratorStateMachine(typeof(_003Cget_GatherProperties_003Ed__31))]
            get
            {
                return null;
            }
        }

        public override bool UseDependencyJob
        {
            get
            {
                return default(bool);
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void UpdateMesh()
        {
        }

        public override JobHandle AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData)
        {
            return default(JobHandle);
        }

        public unsafe override void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        private unsafe static void UpdateLaserVertex(VertexLayout* pVertex, quaternion rotation, float radius, float length, Color color, float2 uvOffset)
        {
        }

        public LiveLaser()
        {
        }
    }
}
