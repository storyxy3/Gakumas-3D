namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine;

    [RequireComponent(typeof(TextMeshProUGUI))]
    [ExecuteAlways]
    public class TextMeshProCharMeshModifier : MonoBehaviour
    {
        [Serializable]
        public class ModificationData
        {
            public Vector2 offset;
            public Quaternion rotation;
            public Vector2 scale;
            public Vector2 pivot;
            public Color color;
            public ModificationData()
            {
            }
        }

        [SerializeField]
        private bool _serializeModification;
        [SerializeField]
        private List<ModificationData> _modifications;
        private List<ModificationData> _currentModifications;
        private TMP_Text _text;
        private TMP_VertexDataUpdateFlags _dirty;
        private bool _isApplyingOnTextChange;
        public bool SerializeModification
        {
            get
            {
                return default(bool);
            }
        }

        private List<ModificationData> CurrentModifications
        {
            get
            {
                return null;
            }
        }

        public TMP_Text Text
        {
            get
            {
                return null;
            }
        }

        public int CharacterCount
        {
            get
            {
                return default(int);
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private bool TryGetModificationData(int index, out ModificationData value)
        {
            throw null;
        }

        private void OnTextChanged(UnityEngine.Object obj)
        {
        }

        private void LateUpdate()
        {
        }

        public void SetCharOffset(int index, Vector2 offset)
        {
        }

        public Vector2 GetCharOffset(int index)
        {
            return default(Vector2);
        }

        public void SetCharScale(int index, Vector2 scale)
        {
        }

        public Vector2 GetCharScale(int index)
        {
            return default(Vector2);
        }

        public void SetCharRotation(int index, Quaternion rotation)
        {
        }

        public Quaternion GetCharRotation(int index)
        {
            return default(Quaternion);
        }

        public void SetCharPivot(int index, Vector2 pivot)
        {
        }

        public Vector2 GetCharPivot(int index)
        {
            return default(Vector2);
        }

        public void SetCharColor(int index, Color color)
        {
        }

        public Color GetCharColor(int index)
        {
            return default(Color);
        }

        public void SetCharAlpha(int index, float alpha)
        {
        }

        public float GetCharAlpha(int index)
        {
            return default(float);
        }

        private void AddElementIfNeed(int index)
        {
        }

        private Color GetCharVertexColor(int charIndex)
        {
            return default(Color);
        }

        private void ApplyForce()
        {
        }

        private void Apply()
        {
        }

        private void UpdateCharVertex(in TMP_TextInfo textInfo, in TMP_CharacterInfo charInfo, int index)
        {
        }

        private void ApplyCharColor(in TMP_TextInfo textInfo, in TMP_CharacterInfo charInfo, int index)
        {
        }

        public TextMeshProCharMeshModifier()
        {
        }
    }
}
