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
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::UnityEngine.Rendering;
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
                if (lightType == LightType.Always) return color;
                float localTime = time;
                switch (lightType)
                {
                    case LightType.Normal: localTime -= lightDelay * index; break;
                    case LightType.Reverse: localTime -= lightDelay * (laserCount - index - 1); break;
                    case LightType.Center: localTime -= lightDelay * math.abs(index - laserCount / 2); break;
                    case LightType.CenterReverse: localTime -= lightDelay * (laserCount / 2 - math.abs(index - laserCount / 2)); break;
                }
                return math.max(localTime, 0f) % (lightOnTime + lightOffTime) >= lightOffTime ? color : Color.black;
            }

            public unsafe void Execute()
            {
                var data = streamData[index];
                time = data.time;
                color = data.color * data.intensity;
                color.r = color.r > 0.004f ? color.r : 0f;
                color.g = color.g > 0.004f ? color.g : 0f;
                color.b = color.b > 0.004f ? color.b : 0f;
                color.a = color.a > 0.004f ? color.a : 0f;
                laserType = (LaserType)(data.valueInt.x & 255);
                lightType = (LightType)((data.valueInt.x >> 8) & 255);
                laserCount = (data.valueInt.x >> 16) & 255;
                radius = data.valueInt.y * 0.001f;
                length = data.valueInt.z * 0.001f;
                laserAngle = data.valueInt.w;
                randomSpeed = data.valueFloat.w;
                float rollLength = math.dot(data.rotationRoll, data.rotationRoll);
                invRoll = rollLength > math.FLT_MIN_NORMAL ? new quaternion(data.rotationRoll * new float4(-1f, -1f, -1f, 1f) * (1f / rollLength)) : quaternion.identity;
                if (lightType != LightType.Always)
                {
                    lightOnTime = data.valueFloat.x;
                    lightOffTime = data.valueFloat.y;
                    lightDelay = data.valueFloat.z;
                }
                var vertices = (VertexLayout*)vertexData.GetUnsafePtr();
                if (laserType == LaserType.Plane) UpdatePlane(vertices);
                else if (laserType == LaserType.Cone || laserType == LaserType.RandomCone) UpdateCone(vertices, laserType == LaserType.RandomCone);
            }

            private unsafe void UpdatePlane(VertexLayout* pVertexHead)
            {
                float angleStep = laserCount >= 2 ? laserAngle / (laserCount - 1) : 0f;
                float startAngle = laserCount >= 2 ? laserAngle * -0.5f : 0f;
                for (int i = 0; i < laserCount; i++)
                {
                    var rotation = LookCamera(quaternion.AxisAngle(new float3(0f, 1f, 0f), math.radians(startAngle + angleStep * i)));
                    UpdateLaserVertex(pVertexHead + i * 15, rotation, radius, length, GetLaserColor(i), new float2(0.5f, i / 16f + time * randomSpeed % 1f));
                }
            }

            private unsafe void UpdateCone(VertexLayout* pVertexHead, bool fullRandom)
            {
                for (int i = 0; i < laserCount; i++)
                {
                    float radial = 0f;
                    float z = 1f;
                    if (laserCount >= 2)
                    {
                        float halfAngle = math.radians(laserAngle * 0.5f);
                        radial = math.sin(halfAngle);
                        z = math.cos(halfAngle);
                    }
                    float angle = (float)i / laserCount * math.PI * 2f;
                    var rotation = LookCamera(quaternion.LookRotation(new float3(radial * math.cos(angle), radial * math.sin(angle), z), new float3(0f, 1f, 0f)));
                    UpdateLaserVertex(pVertexHead + i * 15, rotation, radius, length, GetLaserColor(i), new float2(0.5f, i / 16f + time * randomSpeed % 1f));
                }
            }

            [MethodImpl(256)]
            private quaternion LookCamera(quaternion rotation)
            {
                float angle = math.atan2(worldPosition.x - cameraPosition.x, worldPosition.z - cameraPosition.z);
                return math.mul(rotation, math.mul(invRoll, quaternion.AxisAngle(new float3(0f, 0f, 1f), angle)));
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
            public _003Cget_GatherProperties_003Ed__31(int _003C_003E1__state)
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
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "animationTime");
                        _003C_003E1__state = 1;
                        return true;
                    case 1:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "color");
                        _003C_003E1__state = 2;
                        return true;
                    case 2:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "laserType");
                        _003C_003E1__state = 3;
                        return true;
                    case 3:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "lightType");
                        _003C_003E1__state = 4;
                        return true;
                    case 4:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "laserCount");
                        _003C_003E1__state = 5;
                        return true;
                    case 5:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "laserAngle");
                        _003C_003E1__state = 6;
                        return true;
                    case 6:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "radius");
                        _003C_003E1__state = 7;
                        return true;
                    case 7:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "length");
                        _003C_003E1__state = 8;
                        return true;
                    case 8:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner, "randomSpeed");
                        _003C_003E1__state = 9;
                        return true;
                    case 9:
                        _003C_003E1__state = -1;
                        if (owner.horizontal != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner.horizontal, "m_LocalRotation");
                            _003C_003E1__state = 10;
                            return true;
                        }
                        goto case 10;
                    case 10:
                        _003C_003E1__state = -1;
                        if (owner.vertical != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner.vertical, "m_LocalRotation");
                            _003C_003E1__state = 11;
                            return true;
                        }
                        goto case 11;
                    case 11:
                        _003C_003E1__state = -1;
                        if (owner._renderer != null)
                        {
                            _003C_003E2__current = new LiveEquipmentComponentProperty(owner._renderer, "m_Enabled");
                            _003C_003E1__state = 12;
                            return true;
                        }
                        goto case 13;
                    case 12:
                        _003C_003E1__state = -1;
                        _003C_003E2__current = new LiveEquipmentComponentProperty(owner._renderer.transform, "m_LocalRotation");
                        _003C_003E1__state = 13;
                        return true;
                    case 13:
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
                return new _003Cget_GatherProperties_003Ed__31(0) { _003C_003E4__this = _003C_003E4__this };
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<ILiveEquipmentProperty>)this).GetEnumerator();
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
        public float animationTime = -1f;
        [FormerlySerializedAs("Color")]
        [ColorUsage(false, true)]
        public Color color;
        [FormerlySerializedAs("BeamCount")]
        [Range(1f, 16f)]
        public int laserCount = 2;
        [FormerlySerializedAs("BeamAngle")]
        [Range(0f, 179f)]
        public float laserAngle = 15f;
        [FormerlySerializedAs("Radius")]
        public float radius = 0.01f;
        [FormerlySerializedAs("Length")]
        public float length = 10f;
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
                return new _003Cget_GatherProperties_003Ed__31(-2) { _003C_003E4__this = this };
            }
        }

        public override bool UseDependencyJob
        {
            get
            {
                return true;
            }
        }

        private void OnEnable()
        {
            _mesh = new Mesh { name = "LaserMesh_" + name, hideFlags = HideFlags.DontSave };
            _mesh.SetVertexBufferParams(240,
                new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3),
                new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Float32, 4),
                new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2),
                new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float32, 2));
            _vertexData = new NativeArray<VertexLayout>(240, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            for (int laser = 0; laser < 16; laser++)
            {
                for (int i = 0; i < 15; i++)
                {
                    float t = (i / 3) / 4f;
                    int x = i % 3;
                    _vertexData[laser * 15 + i] = new VertexLayout
                    {
                        position = new float3(x / 2f - 0.5f, 0f, t),
                        color = default,
                        uv = new float2(0.75f + x * 0.124f + 0.001f, t),
                        uv2 = new float2(laser / 16f + x / 32f, t)
                    };
                }
            }
            _mesh.SetVertexBufferData(_vertexData, 0, 0, 240);
            _indexData = new NativeArray<ushort>(768, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            int offset = 0;
            for (int laser = 0; laser < 16; laser++)
            {
                for (int row = 0; row < 4; row++)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        int vertex = laser * 15 + row * 3 + x;
                        _indexData[offset++] = (ushort)vertex;
                        _indexData[offset++] = (ushort)(vertex + 3);
                        _indexData[offset++] = (ushort)(vertex + 1);
                        _indexData[offset++] = (ushort)(vertex + 1);
                        _indexData[offset++] = (ushort)(vertex + 3);
                        _indexData[offset++] = (ushort)(vertex + 4);
                    }
                }
            }
            _mesh.SetIndexBufferParams(768, IndexFormat.UInt16);
            _mesh.SetIndexBufferData(_indexData, 0, 0, 768);
            _mesh.subMeshCount = 1;
            _mesh.MarkDynamic();
            if (_renderer == null)
            {
                UnityEngine.Debug.LogError("Laser用のRendererが指定されていません");
                return;
            }
            _renderer.shadowCastingMode = ShadowCastingMode.Off;
            _renderer.lightProbeUsage = LightProbeUsage.Off;
            if (_renderer.sharedMaterial == null) UnityEngine.Debug.LogError("Materialを指定してください");
            if (!_renderer.TryGetComponent(out _meshFilter)) _meshFilter = _renderer.gameObject.AddComponent<MeshFilter>();
            _meshFilter.sharedMesh = _mesh;
        }

        private void OnDisable()
        {
            _handle.Complete();
            if (_meshFilter != null) _meshFilter.sharedMesh = null;
            if (_mesh != null)
            {
                _mesh.Clear();
                global::VL.VLUtility.DestroyObject(_mesh);
                _mesh = null;
            }
            if (_vertexData.IsCreated) _vertexData.Dispose(_handle);
            if (_indexData.IsCreated) _indexData.Dispose(_handle);
        }

        private void UpdateMesh()
        {
            _mesh.SetVertexBufferData(_vertexData, 0, 0, _vertexData.Length);
            float spread = Mathf.Sin(laserAngle * (laserCount - 1) * 0.5f * Mathf.Deg2Rad);
            var bounds = new Bounds();
            bounds.SetMinMax(new Vector3(-spread - radius, -radius, 0f), new Vector3(spread + radius, radius, length));
            _mesh.bounds = bounds;
            _renderer.enabled = laserCount > 0;
            _mesh.SetSubMesh(0, new SubMeshDescriptor(0, laserCount * 48), MeshUpdateFlags.DontRecalculateBounds);
        }

        public override JobHandle AddDependencyJob(JobHandle handle, NativeArray<LiveEquipmentStreamData> streamData)
        {
            var cameraPosition = Vector3.zero;
            if (global::VL.VLCameraController.HasInstance) cameraPosition = global::VL.VLCameraController.Instance.position;
            var job = new LaserVertexJob
            {
                streamData = streamData,
                vertexData = _vertexData,
                index = id,
                cameraPosition = cameraPosition,
                worldPosition = transform.position
            };
            _handle = job.Schedule(handle);
            return _handle;
        }

        public unsafe override void UpdateInitialData(LiveEquipmentInitialData* pInitial)
        {
            quaternion inverseRotation = Quaternion.Inverse(transform.rotation);
            float3 position = vertical != null ? vertical.position : transform.position;
            pInitial->position = position;
            pInitial->v0 = inverseRotation.value;
        }

        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
            animationTime = data.time;
            color = data.color * data.intensity;
            color.r = color.r > 0.004f ? color.r : 0f;
            color.g = color.g > 0.004f ? color.g : 0f;
            color.b = color.b > 0.004f ? color.b : 0f;
            color.a = color.a > 0.004f ? color.a : 0f;
            laserType = (LaserType)(data.valueInt.x & 255);
            lightType = (LightType)((data.valueInt.x >> 8) & 255);
            laserCount = (data.valueInt.x >> 16) & 255;
            radius = data.valueInt.y * 0.001f;
            length = data.valueInt.z * 0.001f;
            laserAngle = data.valueInt.w;
            randomSpeed = data.valueFloat.w;
            if (horizontal != null) horizontal.localRotation = new Quaternion(data.rotationYaw.x, data.rotationYaw.y, data.rotationYaw.z, data.rotationYaw.w);
            if (vertical != null) vertical.localRotation = new Quaternion(data.rotationPitch.x, data.rotationPitch.y, data.rotationPitch.z, data.rotationPitch.w);
            if (_renderer != null) _renderer.transform.localRotation = new Quaternion(data.rotationRoll.x, data.rotationRoll.y, data.rotationRoll.z, data.rotationRoll.w);
            UpdateMesh();
        }

        private unsafe static void UpdateLaserVertex(VertexLayout* pVertex, quaternion rotation, float radius, float length, Color color, float2 uvOffset)
        {
            float width = radius * 20f;
            float lengthScale = length / math.sqrt(width * width + length * length);
            for (int i = 0; i < 15; i++)
            {
                float t = (i / 3) / 4f;
                int column = i % 3;
                float halfWidth = math.lerp(width, width, t);
                float x = (halfWidth + halfWidth) * 0.5f * column - halfWidth;
                float z = math.lerp(t * length, lengthScale * (t * length), math.abs(x) / width);
                pVertex->position = math.rotate(rotation, new float3(x, 0f, z));
                pVertex->color = color;
                pVertex->uv = new float2(uvOffset.x + column * 0.124f + 0.001f, t);
                pVertex->uv2 = new float2(uvOffset.y + column / 32f, t);
                pVertex++;
            }
        }

        public LiveLaser()
        {
        }
    }
}
