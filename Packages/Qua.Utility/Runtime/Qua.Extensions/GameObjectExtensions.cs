namespace Qua.Extensions
{
    using global::UnityEngine;

    public static class GameObjectExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject go)
            where T : Component
        {
            return null;
        }

        public static void SetLayerRecursive(this GameObject target, int layer)
        {
        }

        public static void TrySetActive(this GameObject target, bool isActive)
        {
        }
    }
}
