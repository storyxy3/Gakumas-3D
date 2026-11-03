namespace Qua.UI
{
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    public abstract class TextStyleConfigBase<T, TStyle> : UIStyleConfigBase<T, TStyle> where T : UIStyleConfigBase<T, TStyle> where TStyle : IUIStyle
    {
        [SerializeField]
        protected Font _defaultFont;
        public Font DefaultFont
        {
            get
            {
                return null;
            }
        }

        protected TextStyleConfigBase()
        {
        }
    }
}
