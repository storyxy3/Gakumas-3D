namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    public static class MaterialModifier
    {
        public interface Interface
        {
            void SetMaterialProp(int nameID, float value);
            void SetMaterialProp(int nameID, Vector4 value);
            void SetMaterialProp(int nameID, Texture value);
        }

        public delegate void Callback(Interface owner);
    }
}
