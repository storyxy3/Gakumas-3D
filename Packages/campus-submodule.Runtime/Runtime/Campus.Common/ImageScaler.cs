namespace Campus.Common
{
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    public class ImageScaler : QuaUIBehaviour
    {
        private enum Direction
        {
            Vertical,
            Horizontal
        }

        [SerializeField]
        private RectTransform _target;
        [SerializeField]
        private Direction _direction;
        private static readonly int AdjustSize;
        protected override void OnRectTransformDimensionsChange()
        {
        }

        public ImageScaler()
        {
        }
    }
}
