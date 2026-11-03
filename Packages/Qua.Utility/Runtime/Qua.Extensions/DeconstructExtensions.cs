namespace Qua.Extensions
{
    using global::UnityEngine;

    public static class DeconstructExtensions
    {
        public static void Deconstruct(this in Vector2 vector, out float x, out float y)
        {
            throw null;
        }

        public static void Deconstruct(this in Vector3 vector, out float x, out float y, out float z)
        {
            throw null;
        }

        public static void Deconstruct(this in Color color, out float r, out float g, out float b, out float a)
        {
            throw null;
        }

        public static void Deconstruct(this in Rect rect, out Vector2 center, out Vector2 size)
        {
            throw null;
        }
    }
}
