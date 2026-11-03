namespace Qua.UI
{
    using global::System.Runtime.InteropServices;
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Text))]
    public abstract class TextStyleBase<TTextStyleType> : UIStyleComponentBase<Text, TTextStyleType>, ITextStyleMask where TTextStyleType : TextStyleTypeBase<TTextStyleType>, new()
    {
        [SerializeField]
        protected bool _ignoreLineSpacing;
        [SerializeField]
        protected bool _ignoreOutline;
        protected Outline2D _outlineEffect;
        public bool IgnoreLineSpacing
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreOutline
        {
            get
            {
                return default(bool);
            }
        }

        private Outline2D OutlineEffect
        {
            get
            {
                return null;
            }
        }

        public static void ApplyStyle(TTextStyleType styleType, Text text, [Optional] ITextStyleMask styleMask)
        {
        }

        protected static void ApplyTextStyle(TextStyleConfigStyle style, Font defaultFont, Text text, ITextStyleMask styleMask)
        {
        }

        protected static void ApplyOutlineStyle(TextStyleConfigStyle style, Text text, ITextStyleMask styleMask)
        {
        }

        protected override void ApplyStyle(TTextStyleType style)
        {
        }

        protected TextStyleBase()
        {
        }
    }
}
