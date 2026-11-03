namespace Campus.Common.TMPro
{
    using global::Qua.UI;
    using global::TMPro;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    [RequireComponent(typeof(TMP_Text))]
    public class I18nTMProText : I18nTextBase
    {
        private TMP_Text _targetTextCache;
        private TMP_Text TargetText
        {
            get
            {
                return null;
            }
        }

        protected override void ApplyLocalize()
        {
        }

        public I18nTMProText()
        {
        }
    }
}
