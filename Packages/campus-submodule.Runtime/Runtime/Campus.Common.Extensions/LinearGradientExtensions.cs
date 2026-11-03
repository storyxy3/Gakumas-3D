namespace Campus.Common.Extensions
{
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::UnityEngine;

    public static class LinearGradientExtensions
    {
        public static Tweener DOColorSteps(this LinearGradient target, LinearGradient.ColorStep[] colorSteps, float duration)
        {
            return null;
        }

        public static void SetColorSteps(this LinearGradient target, LinearGradient.ColorStep[] steps)
        {
        }

        public static LinearGradient.ColorStep[] CloneColorSteps(this LinearGradient target, int count = -1)
        {
            return null;
        }

        public static Tweener DOColors(this LinearGradient target, Color[] colors, float duration)
        {
            return null;
        }

        public static Color[] CloneColors(this LinearGradient target, int count = -1)
        {
            return null;
        }

        public static void SetColors(this LinearGradient target, Color[] colors)
        {
        }

        public static void SetColors(this LinearGradient target, Color color1, Color color2)
        {
        }

        public static void SetColors(this LinearGradient target, Color color1, Color color2, Color color3)
        {
        }

        public static void SetColor(this LinearGradient target, int index, Color color)
        {
        }

        public static void SetSameColor(this LinearGradient target, Color color)
        {
        }

        public static void SetPositions(this LinearGradient target, Vector2[] positions)
        {
        }

        public static void SetPositions(this LinearGradient target, Vector2 position1, Vector2 position2)
        {
        }

        public static void SetPositions(this LinearGradient target, Vector2 position1, Vector2 position2, Vector2 position3)
        {
        }

        public static void SetPosition(this LinearGradient target, int index, Vector2 position)
        {
        }
    }
}
