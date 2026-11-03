namespace VL.Core
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;

    [Serializable]
    public class MaterialInfo : IDisposable
    {
        [SerializeField]
        private Material _instancedMaterial;
        [SerializeField]
        private Material _originalMaterial;
        [SerializeField]
        private Renderer _renderer;
        [SerializeField]
        private int _materialIndex;
        [SerializeField]
        private bool _isModifiable;
        [CompilerGenerated]
        private MaterialPropertyBlock _003CmaterialProperty_003Ek__BackingField;
        private bool _initialized;
        public string name
        {
            get
            {
                return null;
            }
        }

        public Renderer renderer
        {
            get
            {
                return null;
            }
        }

        public int materialIndex
        {
            get
            {
                return default(int);
            }
        }

        public MaterialPropertyBlock materialProperty
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public MaterialInfo(Material material, Renderer renderer, int materialIndex, [Optional] Material instancedMaterial)
        {
        }

        public void Dispose()
        {
        }

        public void SetKeyword(string keyword, bool enable)
        {
        }

        public void InitializeProperty()
        {
        }

        public void SetColor(int nameID, Color value, bool convertLinear = false)
        {
        }

        public void SetFloat(int nameID, float value)
        {
        }

        public void SetMatrix(int nameID, Matrix4x4 value)
        {
        }

        public void SetTexture(int nameID, Texture value)
        {
        }

        public void SetVector(int nameID, Vector4 value)
        {
        }

        public Texture GetTexture(int nameID)
        {
            return null;
        }

        public void ApplyProperty()
        {
        }

        public void ClearProperty()
        {
        }
    }
}
