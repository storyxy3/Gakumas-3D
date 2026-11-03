namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::uPalette.Generated;

    public class CampusColorManager : PureSingleton<CampusColorManager>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass5_0
        {
            public string colorId;
            public _003C_003Ec__DisplayClass5_0()
            {
            }

            internal bool _003CGetColor_003Eb__0(KeyValuePair<ColorEntry, Color> kvp)
            {
                return default(bool);
            }
        }

        private Dictionary<ColorEntry, Color> _colorDictionary;
        private Dictionary<ColorEntry, Color> ColorDictionary
        {
            get
            {
                return null;
            }
        }

        private void InitializeColorDictionary()
        {
        }

        public Color GetColor(ColorEntry type)
        {
            return default(Color);
        }

        public Color GetColor(string colorId)
        {
            return default(Color);
        }

        public CampusColorManager()
        {
        }
    }
}
