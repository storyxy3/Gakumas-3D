namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    public abstract class I18nTextBase : QuaUIBehaviour
    {
        [SerializeField]
        protected string _localizeKey;
        public string LocalizeKey
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected sealed override void Awake()
        {
        }

        protected abstract void ApplyLocalize();
        protected I18nTextBase()
        {
        }
    }
}
