namespace Campus.DecalLight
{
    using global::System.Runtime.CompilerServices;
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
        private Vector3 _size;
        [SerializeField]
        private Vector2 _area;
        [SerializeField]
        private Vector2 _uvSize;
        [SerializeField]
        private Vector2 _uvPivot;
        [SerializeField]
        private bool _isFlatColor;
        [SerializeField]
        private float _intensity;
        [SerializeField]
        private Color _color;
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
                return default(LightShapeType);
            }

            set
            {
            }
        }

        public Vector3 Size
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector2 Area
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector3 BoxSize
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 Pivot
        {
            get
            {
                return default(Vector3);
            }
        }

        public float4x4 SizeOffset
        {
            get
            {
                return default(float4x4);
            }
        }

        public Vector4 UvScaleBias
        {
            get
            {
                return default(Vector4);
            }

            set
            {
            }
        }

        public bool IsFlatColor
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float Intensity
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Color Color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public bool SpecularOn
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Entity entity
        {
            [CompilerGenerated]
            get
            {
                return default(Entity);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int chunkKey
        {
            get
            {
                return default(int);
            }
        }

        public int oldChunkKey
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool isChunkChanged
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

        private void OnValidate()
        {
        }

        public CampusDecalLight()
        {
        }

        Transform VL.EntitySystem.IEntityComponent.transform
        {
            get
            {
                return null;
            }
        }
    }
}
