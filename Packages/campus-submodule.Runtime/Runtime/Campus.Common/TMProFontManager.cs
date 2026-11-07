namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.TMPro;
    using global::TMPro;

    public class TMProFontManager : PureSingleton<TMProFontManager>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Predicate<CampusText> _003C_003E9__10_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CRebuildAllTextMesh_003Eb__10_0(CampusText text)
            {
                return default(bool);
            }
        }

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
