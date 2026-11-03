namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::Campus.Common.TMPro;
    using global::TMPro;

    public class TMProFontManager : PureSingleton<TMProFontManager>
    {
        private TMP_FontAsset _dynamicNormalFontAsset;
        public HashSet<CampusText> _existsTexts;
        public static void CreateInstance()
        {
        }

        protected override void Initialize()
        {
        }

        private void SetupGlobalFontLoader()
        {
        }

        public static string GetFontId(TMProTextStyleConfigStyle styleType, string langType = "Ja")
        {
            return null;
        }

        private string GetFontIdImpl(TMProTextStyleConfigStyle styleType, string langType = "Ja")
        {
            return null;
        }

        public static void RegisterCampusText(CampusText text)
        {
        }

        public static void UnregisterCampusText(CampusText text)
        {
        }

        public static void ClearDynamicFontTexture(bool isRebuild = true)
        {
        }

        public static void RebuildAllTextMesh()
        {
        }

        public TMProFontManager()
        {
        }
    }
}
