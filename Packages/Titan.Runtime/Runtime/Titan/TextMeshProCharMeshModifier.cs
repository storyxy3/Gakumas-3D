namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass36_0
        {
            public Vector3[] vertices;
            public Matrix4x4 matrix;
            public Vector3 center;
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass37_0
        {
            public Color32[] colors;
            public Color color;
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

        [CompilerGenerated]
        private static void _003CUpdateCharVertex_003Eg__Set_007C36_0(in TMP_CharacterInfo charInfo, int indexOffset, Vector3 pos, ref _003C_003Ec__DisplayClass36_0 P_3)
        {
        }

        [CompilerGenerated]
        private static void _003CApplyCharColor_003Eg__Set_007C37_0(in TMP_CharacterInfo charInfo, int indexOffset, ref _003C_003Ec__DisplayClass37_0 P_2)
        {
        }
    }
}
