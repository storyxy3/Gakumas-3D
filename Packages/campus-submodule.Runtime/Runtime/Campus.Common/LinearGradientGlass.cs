namespace Campus.Common
{
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::UnityEngine;

    [RequireComponent(typeof(LinearGradient))]
    public class LinearGradientGlass : CampusGlass
    {
        private LinearGradient _gradient;
        protected override void Awake()
        {
        }

        public override void SetGlassType(CampusGlassType glassType)
        {
        }

        private void EnsureColorSteps(ref LinearGradient.ColorStep[] input)
        {
        }

        public override Tween DOGlassType(CampusGlassType glassType, float duration)
        {
            return null;
        }

        private static void SetColorSteps(LinearGradient.ColorStep[] colorSteps, CampusGlassType glassType)
        {
        }

        private static void SetColorStep(LinearGradient.ColorStep colorStep, float alpha, Vector2 position)
        {
        }

        private static void SetColorStep(LinearGradient.ColorStep colorStep, Color color, Vector2 position)
        {
        }

        public LinearGradientGlass()
        {
        }
    }
}
