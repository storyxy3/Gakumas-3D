namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.UI;

    public class I18n : II18n
    {
        private Dictionary<string, string> _i18nKeyValues;
        private static string _debugFormat;
        public void Initialize(StringComparison keyComparison)
        {
        }

        public string Get(string key)
        {
            return null;
        }

        public string GetOrDefault(string key, string defaultValue)
        {
            return null;
        }

        public string GetWithParams<T0>(string key, T0 v1)
        {
            return null;
        }

        public string GetWithParams<T0, T1>(string key, T0 v1, T1 v2)
        {
            return null;
        }

        public string GetWithParams<T0, T1, T2>(string key, T0 v1, T1 v2, T2 v3)
        {
            return null;
        }

        public string GetWithParams(string key, params object[] values)
        {
            return null;
        }

        public bool ContainsKey(string key)
        {
            return default(bool);
        }

        public void SetValue(string key, string value)
        {
        }

        public I18n()
        {
        }
    }
}
