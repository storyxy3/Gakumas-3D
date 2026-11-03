namespace Campus.Common.TMPro
{
    using global::Campus.Common.TMPro;
    using global::Qua.UI.Internal;

    public class TMProTextStyleTypeBase<T> : ClassEnum<T> where T : TMProTextStyleTypeBase<T>, new()
    {
        public bool IsNone
        {
            get
            {
                return default(bool);
            }
        }

        public TMProTextStyleTypeBase()
        {
        }
    }
}
