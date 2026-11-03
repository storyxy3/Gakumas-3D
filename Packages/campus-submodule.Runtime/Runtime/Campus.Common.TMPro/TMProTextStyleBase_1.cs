namespace Campus.Common.TMPro
{
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Common.TMPro;
    using global::Qua.UI.Internal;
    using global::TMPro;
    using global::UnityEngine;

    [RequireComponent(typeof(TMP_Text))]
    public abstract class TMProTextStyleBase<TTextStyleType> : UIStyleComponentBase<CampusText, TTextStyleType>, ITMProTextStyleMask where TTextStyleType : TMProTextStyleTypeBase<TTextStyleType>, new()
    {
        [SerializeField]
        protected bool _ignoreLineSpacing;
        [SerializeField]
        protected bool _ignoreCharacterSpacing;
        public bool IgnoreLineSpacing
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreCharacterSpacing
        {
            get
            {
                return default(bool);
            }
        }

        public static void ApplyStyle(TTextStyleType styleType, CampusText text, [Optional] ITMProTextStyleMask styleMask)
        {
        }

        private static void ApplyTextStyle(TMProTextStyleConfigStyle style, CampusText text, ITMProTextStyleMask styleMask)
        {
        }

        protected override void ApplyStyle(TTextStyleType style)
        {
        }

        protected TMProTextStyleBase()
        {
        }
    }
}
