namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::uPalette.Generated;

    public class CampusColorManager : PureSingleton<CampusColorManager>
    {
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
