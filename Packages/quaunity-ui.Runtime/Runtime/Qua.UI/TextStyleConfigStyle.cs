namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    [Serializable]
    public class TextStyleConfigStyle : IUIStyle
    {
        [SerializeField]
        protected string _name;
        [SerializeField]
        private string _popUpLabel;
        [SerializeField]
        protected Font _font;
        [SerializeField]
        protected FontStyle _fontStyle;
        [SerializeField]
        protected float _lineSpacing;
        [SerializeField]
        protected Color _color;
        [SerializeField]
        protected Material _material;
        [SerializeField]
        protected Outline2D.EffectType _outlineType;
        [SerializeField]
        protected Color _outlineColor;
        [SerializeField]
        protected Vector2 _outlineDistance;
        [SerializeField]
        protected bool _useGraphicAlpha;
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

        public Font Font
        {
            get
            {
                return null;
            }
        }

        public FontStyle FontStyle
        {
            get
            {
                return default(FontStyle);
            }
        }

        public float LineSpacing
        {
            get
            {
                return default(float);
            }
        }

        public Color Color
        {
            get
            {
                return default(Color);
            }
        }

        public Material Material
        {
            get
            {
                return null;
            }
        }

        public Outline2D.EffectType OutlineType
        {
            get
            {
                return default(Outline2D.EffectType);
            }
        }

        public Color OutlineColor
        {
            get
            {
                return default(Color);
            }
        }

        public Vector2 OutlineDistance
        {
            get
            {
                return default(Vector2);
            }
        }

        public bool UseGraphicAlpha
        {
            get
            {
                return default(bool);
            }
        }

        public TextStyleConfigStyle()
        {
        }
    }
}
