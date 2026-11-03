namespace Campus.Common
{
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
