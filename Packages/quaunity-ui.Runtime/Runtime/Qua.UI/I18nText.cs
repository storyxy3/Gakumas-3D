namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [DisallowMultipleComponent]
    [RequireComponent(typeof(Text))]
    public class I18nText : I18nTextBase
    {
        private Text _targetTextCache;
        private Text TargetText
        {
            get
            {
                return null;
            }
        }

        protected override void ApplyLocalize()
        {
        }

        public I18nText()
        {
        }
    }
}
