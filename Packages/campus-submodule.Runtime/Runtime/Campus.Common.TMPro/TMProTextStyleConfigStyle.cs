namespace Campus.Common.TMPro
{
    using global::System;
    using global::Qua.UI.Internal;
    using global::TMPro;
    using global::UnityEngine;

    [Serializable]
    public class TMProTextStyleConfigStyle : IUIStyle
    {
        [SerializeField]
        protected string _name;
        [SerializeField]
        private string _popUpLabel;
        [SerializeField]
        protected FontStyles _fontStyle;
        [SerializeField]
        protected float _lineSpacing;
        [SerializeField]
        protected float _characterSpacing;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public string PopUpLabel
        {
            get
            {
                return null;
            }
        }

        public FontStyles FontStyle
        {
            get
            {
                return default(FontStyles);
            }
        }

        public float LineSpacing
        {
            get
            {
                return default(float);
            }
        }

        public float CharacterSpacing
        {
            get
            {
                return default(float);
            }
        }

        public TMProTextStyleConfigStyle()
        {
        }
    }
}
