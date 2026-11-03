namespace Qua.UI
{
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Graphic))]
    public abstract class GraphicStyleBase<TGraphicStyleType> : UIStyleComponentBase<Graphic, TGraphicStyleType> where TGraphicStyleType : GraphicStyleTypeBase<TGraphicStyleType>, new()
    {
        public static void ApplyStyle(TGraphicStyleType styleType, Graphic graphic)
        {
        }

        protected static void ApplyGraphicStyle(GraphicStyleConfig.Style style, Graphic graphic)
        {
        }

        protected override void ApplyStyle(TGraphicStyleType style)
        {
        }

        protected GraphicStyleBase()
        {
        }
    }
}
