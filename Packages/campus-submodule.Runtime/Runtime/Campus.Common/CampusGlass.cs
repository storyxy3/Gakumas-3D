namespace Campus.Common
{
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(BackgroundBlur))]
    public class CampusGlass : QuaUIBehaviour
    {
        protected BackgroundBlur _backgroundBlur;
        [SerializeField]
        protected CampusGlassType _glassType;
        [SerializeField]
        private Graphic _frame;
        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        public virtual void SetGlassType(CampusGlassType glassType)
        {
        }

        public virtual Tween DOGlassType(CampusGlassType glassType, float duration)
        {
            return null;
        }

        private static (int, float, float, Color) GetValue(CampusGlassType glassType)
        {
            return default((int, float, float, Color));
        }

        private static Color GetFrameColor(CampusGlassType glassType)
        {
            return default(Color);
        }

        public CampusGlass()
        {
        }
    }
}
