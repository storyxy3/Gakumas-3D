namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusFontOutlineSetting : ScriptableObject
    {
        public enum OutlineColor
        {
            BlackOpaque,
            BlackTransparent,
            WhiteOpaque,
            WhiteTransparent
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass7_0
        {
            public float fontSize;
            public _003C_003Ec__DisplayClass7_0()
            {
            }

            internal float _003CTryGetOutlineMaterial_003Eb__0(SerializableTuple<int, Material> tuple)
            {
                return default(float);
            }
        }

        private static CampusFontOutlineSetting _setting;
        [SerializeField]
        private SerializableDictionary<string, SerializableTuple<int, Material>[]> _outlineMaterials;
        [SerializeField]
        private SerializableDictionary<string, Material> _dynamicOutlineMaterials;
        public static CampusFontOutlineSetting Setting
        {
            get
            {
                return null;
            }
        }

        public bool TryGetOutlineMaterial(CampusText text, OutlineColor color, out Material material)
        {
            throw null;
        }

        public bool TryGetOutlineMaterial(CampusText text, string category, out Material material)
        {
            throw null;
        }

        public bool TryGetDynamicOutlineMaterial(CampusText text, out Material material)
        {
            throw null;
        }

        public CampusFontOutlineSetting()
        {
        }
    }
}
