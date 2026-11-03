namespace Campus.Common.TMPro
{
    using global::Qua.UI.Internal;

    public abstract class TMProTextStyleConfigBase<T, TStyle> : UIStyleConfigBase<T, TStyle> where T : UIStyleConfigBase<T, TStyle> where TStyle : IUIStyle
    {
        protected TMProTextStyleConfigBase()
        {
        }
    }
}
