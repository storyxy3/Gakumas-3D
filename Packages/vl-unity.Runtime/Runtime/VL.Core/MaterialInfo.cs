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
                return _originalMaterial != null ? _originalMaterial.name : "Null";
            }
        }

        public Renderer renderer
        {
            get
            {
                return _renderer;
            }
        }

        public int materialIndex
        {
            get
            {
                return _materialIndex;
            }
        }

        public MaterialPropertyBlock materialProperty
        {
            [CompilerGenerated]
            get
            {
                return _003CmaterialProperty_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CmaterialProperty_003Ek__BackingField = value;
            }
        }

        public MaterialInfo(Material material, Renderer renderer, int materialIndex, [Optional] Material instancedMaterial)
        {
            bool isModifiable = instancedMaterial != null;
            _isModifiable = isModifiable;
            _originalMaterial = material;
            _instancedMaterial = isModifiable ? instancedMaterial : null;
            _renderer = renderer;
            _materialIndex = materialIndex;
        }

        public void Dispose()
        {
            if (_isModifiable)
            {
                UnityEngine.Object.DestroyImmediate(_instancedMaterial);
                _instancedMaterial = null;
            }
        }

        public void SetKeyword(string keyword, bool enable)
        {
            if (!_isModifiable) return;
            if (enable) _instancedMaterial.EnableKeyword(keyword);
            else _instancedMaterial.DisableKeyword(keyword);
        }

        public void InitializeProperty()
        {
            if (_initialized) return;
            if (!_isModifiable && _renderer != null)
            {
                if (materialProperty == null) materialProperty = new MaterialPropertyBlock();
                _renderer.GetPropertyBlock(materialProperty);
            }
            _initialized = true;
        }

        public void SetColor(int nameID, Color value, bool convertLinear = false)
        {
            if (materialProperty != null) materialProperty.SetColor(nameID, value);
            else if (_isModifiable) _instancedMaterial.SetColor(nameID, convertLinear ? value.linear : value);
        }

        public void SetFloat(int nameID, float value)
        {
            if (materialProperty != null) materialProperty.SetFloat(nameID, value);
            else if (_isModifiable) _instancedMaterial.SetFloat(nameID, value);
        }

        public void SetMatrix(int nameID, Matrix4x4 value)
        {
            if (materialProperty != null) materialProperty.SetMatrix(nameID, value);
            else if (_isModifiable) _instancedMaterial.SetMatrix(nameID, value);
        }

        public void SetTexture(int nameID, Texture value)
        {
            if (materialProperty != null) materialProperty.SetTexture(nameID, value);
            else if (_isModifiable) _instancedMaterial.SetTexture(nameID, value);
        }

        public void SetVector(int nameID, Vector4 value)
        {
            if (materialProperty != null) materialProperty.SetVector(nameID, value);
            else if (_isModifiable) _instancedMaterial.SetVector(nameID, value);
        }

        public Texture GetTexture(int nameID)
        {
            if (materialProperty != null) return materialProperty.GetTexture(nameID);
            return _isModifiable ? _instancedMaterial.GetTexture(nameID) : _originalMaterial.GetTexture(nameID);
        }

        public void ApplyProperty()
        {
            if (materialProperty != null) _renderer.SetPropertyBlock(materialProperty, _materialIndex);
            _initialized = false;
        }

        public void ClearProperty()
        {
            if (materialProperty != null && _renderer != null) _renderer.SetPropertyBlock(null, _materialIndex);
            _initialized = false;
        }
    }
}
