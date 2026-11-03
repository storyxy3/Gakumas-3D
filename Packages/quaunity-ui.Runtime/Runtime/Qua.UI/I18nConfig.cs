namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::UnityEngine;

    public class I18nConfig : ScriptableObject
    {
        public const string ConfigName = "I18nConfig";
        private static I18nConfig _instance;
        [SerializeField]
        private List<SystemLanguage> _supportLanguages;
        [SerializeField]
        private SystemLanguage _defaultLanguage;
        private string _langCache;
        [SerializeField]
        private string _localizationFileName;
        [SerializeField]
        private I18nTextAssetReaderBase _localizationReader;
        [SerializeField]
        private I18nValueConverterBase _valueConverter;
        [SerializeField]
        private StringComparison _keyComparerType;
        public static I18nConfig Instance
        {
            get
            {
                return null;
            }
        }

        public static string Lang
        {
            get
            {
                return null;
            }
        }

        public string LocalizationFileName
        {
            get
            {
                return null;
            }
        }

        public I18nTextAssetReaderBase LocalizationReader
        {
            get
            {
                return null;
            }
        }

        public I18nValueConverterBase ValueConverter
        {
            get
            {
                return null;
            }
        }

        public static StringComparison KeyComparerType
        {
            get
            {
                return default(StringComparison);
            }
        }

        public static string LocalizeText
        {
            get
            {
                return null;
            }
        }

        public static bool LoadInstanceFromResources()
        {
            return default(bool);
        }

        public I18nConfig()
        {
        }
    }
}
