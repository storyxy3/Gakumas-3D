namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class UIContentArea : RectTransformModifierBase
    {
        [Tooltip("ex) iPad: 4/3 = 1.333...")]
        [SerializeField]
        private float _minAspect;
        [Tooltip("ex) iPhone6: 16/9 = 1.777...")]
        [SerializeField]
        private float _maxAspect;
        [CompilerGenerated]
        private static IQuaSafeArea _003COverrideSafeArea_003Ek__BackingField;
        private static readonly HashSet<UIContentArea> Instances;
        public float MinAspect
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float MaxAspect
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public static IQuaSafeArea OverrideSafeArea
        {
            [CompilerGenerated]
            get
            {
                return _003COverrideSafeArea_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COverrideSafeArea_003Ek__BackingField = value;
            }
        }

        private IQuaSafeArea ActiveSafeArea
        {
            get
            {
                return null;
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public static void EnableOrientationCheck()
        {
        }

        public static void DisableOrientationCheck()
        {
        }

        private static void AddOrientationChangedCallback()
        {
        }

        private static void RemoveOrientationChangedCallback()
        {
        }

        private static void OnOrientationChanged(ScreenOrientation orientation)
        {
        }

        protected override void UpdateRect(RectTransform rectTransform, RectTransform rootCanvasTransform)
        {
        }

        public UIContentArea()
        {
        }
    }
}
