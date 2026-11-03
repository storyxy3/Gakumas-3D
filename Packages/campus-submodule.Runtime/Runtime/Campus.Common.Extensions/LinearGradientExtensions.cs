namespace Campus.Common.Extensions
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::UnityEngine;

    public static class LinearGradientExtensions
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public LinearGradient.ColorStep[] startValues;
            public LinearGradient target;
            public int count;
            public LinearGradient.ColorStep[] temp;
            public float progress;
            public LinearGradient.ColorStep[] colorSteps;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal float _003CDOColorSteps_003Eb__0()
            {
                return default(float);
            }

            internal void _003CDOColorSteps_003Eb__1(float value)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public Color[] startValues;
            public LinearGradient target;
            public int count;
            public Color[] temp;
            public float progress;
            public Color[] colors;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal float _003CDOColors_003Eb__0()
            {
                return default(float);
            }

            internal void _003CDOColors_003Eb__1(float value)
            {
            }
        }

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
