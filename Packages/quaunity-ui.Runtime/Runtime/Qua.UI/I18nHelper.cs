namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;

    public class I18nHelper
    {
        private static I18nHelper _instance;
        private readonly I18n _i18n;
        private bool _isInitialized;
        public static I18nHelper Instance
        {
            get
            {
                return null;
            }
        }

        public static II18n I18n
        {
            get
            {
                return null;
            }
        }

        public static void SetValue(string key, string value)
        {
        }

        private static bool IsCommentLine(string line)
        {
            return default(bool);
        }

        public void AddLocalizationText(string lang, string localizationText)
        {
        }

        public void SetUpI18n(string lang, string localizationText, StringComparison keyComparison = StringComparison.Ordinal)
        {
        }

        [MethodImpl(256)]
        public static string Get(string key)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string Get<T0>(string key, T0 value)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string Get<T0, T1>(string key, T0 v1, T1 v2)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string Get<T0, T1, T2>(string key, T0 v1, T1 v2, T2 v3)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string Get(string key, params object[] values)
        {
            return null;
        }

        private void AutoInitialize()
        {
        }

        public I18nHelper()
        {
        }
    }
}
