namespace VL
{
    using global::VL;

    public static class VLExtension
    {
        public static bool IsValid(this IVLActorController actor)
        {
            return actor != null && actor as UnityEngine.MonoBehaviour != null;
        }
    }
}
