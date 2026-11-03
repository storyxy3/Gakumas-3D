namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    [RequireComponent(typeof(MeshRenderer), typeof(Volume))]
    public class VolumetricHeightFogVolume : MonoBehaviour
    {
        private static class ShaderIDs
        {
            internal static readonly int _Color;
            internal static readonly int _RaymarchParameter;
            internal static readonly int _NoiseSpeed;
        }

        public float Density;
        public Color Color;
        public float BaseHeight;
        public float Height;
        public float Tiling;
        public Vector2 Direction;
        public float Speed;
        public float Fade;
        [SerializeField]
        [HideInInspector]
        private MeshRenderer _meshRenderer;
        [SerializeField]
        [HideInInspector]
        private Volume _volume;
        private MaterialPropertyBlock _mpb;
        private VolumetricHeightFog _fogVolume;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void LateUpdate()
        {
        }

        public VolumetricHeightFogVolume()
        {
        }
    }
}
