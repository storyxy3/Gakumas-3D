namespace Qua.UI
{
    using global::UnityEngine;

    public abstract class I18nValueConverterBase : ScriptableObject
    {
        public abstract string ConvertValue(string key, string value);
        protected I18nValueConverterBase()
        {
        }
    }
}
