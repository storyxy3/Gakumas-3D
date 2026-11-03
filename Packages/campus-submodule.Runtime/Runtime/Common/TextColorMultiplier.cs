namespace Common
{
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;

    public class TextColorMultiplier : QuaUIBehaviour
    {
        [SerializeField]
        protected Color _multiplyColor;
        private CampusText _textCache;
        private Color _defaultFaceColor;
        private Color _defaultOutlineColor;
        public Color MultiplyColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public CampusText TextCache
        {
            get
            {
                return null;
            }
        }

        private void ResetColor()
        {
        }

        public void SetColor()
        {
        }

        protected override void OnDestroy()
        {
        }

        public TextColorMultiplier()
        {
        }
    }
}
