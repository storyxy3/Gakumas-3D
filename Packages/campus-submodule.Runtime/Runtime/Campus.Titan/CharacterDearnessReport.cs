namespace Campus.Titan
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class CharacterDearnessReport : QuaUIBehaviour
    {
        [SerializeField]
        private RectTransform _reportBg;
        [SerializeField]
        private RawImage _reportImage;
        [SerializeField]
        private RawImage _beforeReportGraphTextImage;
        [SerializeField]
        private RawImage _afterReportGraphTextImage;
        [SerializeField]
        private RawImage _compareGraphImage;
        [SerializeField]
        private CanvasGroup _compareGraphImageCanvasGroup;
        private const int BasisReportBgHeight = 1920;
        public void SetTexture(Texture2D bgTexture, Texture2D beforeGraphTextTexture, Texture2D afterGraphTextTexture, Texture2D compareGraphTexture)
        {
        }

        public CharacterDearnessReport()
        {
        }
    }
}
