namespace Qua.Global
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.Global;
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "QuaGlobalSetting", menuName = "Qua/Global/Create Setting")]
    public class QuaGlobalSetting : ScriptableObject
    {
        [Serializable]
        public struct FontSetting
        {
            public string Id;
            public string LoadKey;
        }

        [SerializeField]
        private string _defaultFontId;
        [SerializeField]
        private FontSetting[] _fontSettings;
        public string DefaultFontId
        {
            get
            {
                return null;
            }
        }

        public IReadOnlyList<FontSetting> FontSettings
        {
            get
            {
                return null;
            }
        }

        public string GetLoadKey(string id)
        {
            return null;
        }

        public QuaGlobalSetting()
        {
        }
    }
}
