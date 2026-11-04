// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, OnDisable, OnEnable, OnValidate, VL.EntitySystem.IEntityComponent.get_transform, get_Area, get_BoxSize, get_Color, get_Pivot, get_Size, get_SizeOffset, get_UvScaleBias, get_entity, get_isChunkChanged, set_BoxSize, set_Color, set_Intensity, set_IsFlatColor, set_LightType, set_Size, set_SpecularOn, set_UvScaleBias, set_entity.
namespace Campus.DecalLight
{
    using global::System.Runtime.CompilerServices;
    using global::System;
    using global::Campus.DecalLight;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL.EntitySystem;

    [ExecuteAlways]
    [AddComponentMenu("Rendering/Campus Decal Light")]
    public class CampusDecalLight : MonoBehaviour, IEntityComponent<int>, IEntityComponent
    {
        public enum LightShapeType
        {
            Box,
            Capsule,
            Sphere
        }

        [SerializeField]
        private LightShapeType _lightType;
        [SerializeField]
        private Vector3 _size = new Vector3(1f, 1f, 1f);
        [SerializeField]
        private Vector2 _area = new Vector2(0.5f, 0.5f);
        [SerializeField]
        private Vector2 _uvSize = new Vector2(1f, 1f);
        [SerializeField]
        private Vector2 _uvPivot = new Vector2(0.5f, 0.5f);
        [SerializeField]
        private bool _isFlatColor;
        [SerializeField]
        private float _intensity = 1f;
        [SerializeField]
        private Color _color = Color.white;
        [SerializeField]
        private bool _specularOn;
        [CompilerGenerated]
        private Entity _003Centity_003Ek__BackingField;
        [CompilerGenerated]
        private int _003ColdChunkKey_003Ek__BackingField;
        public LightShapeType LightType
        {
            get
            {
                return _lightType;
            }

            set
            {
                _lightType = value;
                OnValidate();
            }
        }

        public Vector3 Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
                OnValidate();
            }
        }

        public Vector2 Area
        {
            get
            {
                return _area;
            }
        }

        public Vector3 BoxSize
        {
            get
            {
                switch (_lightType)
                {
                    case LightShapeType.Box: return _size;
                    case LightShapeType.Capsule: return new Vector3(_size.x, _size.z * 2f, _size.z * 2f);
                    case LightShapeType.Sphere: return new Vector3(_size.x * 2f, _size.x * 2f, _size.x * 2f);
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                switch (_lightType)
                {
                    case LightShapeType.Box: _size = value; break;
                    case LightShapeType.Capsule: _size = new Vector3(value.x, value.z * 0.5f, value.z * 0.5f); break;
                    case LightShapeType.Sphere: _size = new Vector3(value.x * 0.5f, 1f, 1f); break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Vector3 Pivot
        {
            get
            {
                switch (_lightType)
                {
                    case LightShapeType.Box: return new Vector3(0f, 0f, _size.z * 0.5f);
                    case LightShapeType.Capsule:
                    case LightShapeType.Sphere: return Vector3.zero;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public float4x4 SizeOffset
        {
            get
            {
                switch (_lightType)
                {
                    case LightShapeType.Box: return float4x4.TRS(new float3(0f, _size.z * -0.5f, 0f), quaternion.identity, new float3(_size.x, _size.z, _size.y));
                    case LightShapeType.Capsule: return float4x4.TRS(float3.zero, quaternion.identity, new float3(_size.x, _size.z * 2f, _size.z * 2f));
                    case LightShapeType.Sphere: return float4x4.TRS(float3.zero, quaternion.identity, new float3(_size.x * 2f));
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Vector4 UvScaleBias
        {
            get
            {
                return new Vector4(_uvSize.x, _uvSize.y, _uvPivot.x, _uvPivot.y);
            }

            set
            {
                _uvSize = new Vector2(value.x, value.y);
                _uvPivot = new Vector2(value.z, value.w);
            }
        }

        public bool IsFlatColor
        {
            get
            {
                return _isFlatColor;
            }

            set
            {
                _isFlatColor = value;
                OnValidate();
            }
        }

        public float Intensity
        {
            get
            {
                return _intensity;
            }

            set
            {
                _intensity = value;
                OnValidate();
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
                OnValidate();
            }
        }

        public bool SpecularOn
        {
            get
            {
                return _specularOn;
            }

            set
            {
                _specularOn = value;
                OnValidate();
            }
        }

        public Entity entity
        {
            [CompilerGenerated]
            get
            {
                return _003Centity_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003Centity_003Ek__BackingField = value;
            }
        }

        public int chunkKey
        {
            get
            {
                return (int)_lightType;
            }
        }

        public int oldChunkKey
        {
            [CompilerGenerated]
            get
            {
                return _003ColdChunkKey_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003ColdChunkKey_003Ek__BackingField = value;
            }
        }

        public bool isChunkChanged
        {
            get
            {
                return chunkKey != oldChunkKey;
            }
        }

        private void OnEnable()
        {
            EntityComponentEvent<CampusDecalLight>.InvokeAdd<int>(this);
        }

        private void OnDisable()
        {
            EntityComponentEvent<CampusDecalLight>.InvokeRemove<int>(this);
        }

        private void OnValidate()
        {
            EntityComponentEvent<CampusDecalLight>.InvokePropertyChange<int>(this);
        }

        public CampusDecalLight()
        {
        }

        Transform VL.EntitySystem.IEntityComponent.transform
        {
            get
            {
                return transform;
            }
        }
    }
}
