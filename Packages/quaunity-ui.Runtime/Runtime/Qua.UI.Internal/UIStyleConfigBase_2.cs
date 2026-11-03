namespace Qua.UI.Internal
{
    using global::System.Collections.Generic;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    public abstract class UIStyleConfigBase<T, TStyle> : ScriptableObject where T : UIStyleConfigBase<T, TStyle> where TStyle : IUIStyle
    {
        private static T _instance;
        [SerializeField]
        protected ColorSpaceConversion _colorSpaceConversion;
        [SerializeField]
        protected List<TStyle> _styles;
        private Dictionary<string, TStyle> _styleNameToStyleEntriesCache;
        public static T Instance
        {
            get
            {
                return null;
            }
        }

        public TStyle FindStyle(string styleName)
        {
            return default(TStyle);
        }

        public List<(string, string)> GetStyleNameAndLabels()
        {
            return null;
        }

        public Color AdjustColorSpace(Color color)
        {
            return default(Color);
        }

        protected UIStyleConfigBase()
        {
        }
    }
}
