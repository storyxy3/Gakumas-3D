namespace Campus.Common
{
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "ShaderVariantGroup.asset", menuName = "Shader Variant Group", order = 83)]
    public class ShaderVariantGroup : ScriptableObject
    {
        public ShaderVariantCollection[] collections;
        public ShaderVariantGroup()
        {
        }
    }
}
