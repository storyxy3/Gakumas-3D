namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class UIDentEffect : BaseMeshEffect
    {
        [Serializable]
        private class CornerDents
        {
            [SerializeField]
            public Vector2 topLeft;
            [SerializeField]
            public Vector2 topRight;
            [SerializeField]
            public Vector2 bottomLeft;
            [SerializeField]
            public Vector2 bottomRight;
            public CornerDents()
            {
            }
        }

        [SerializeField]
        private CornerDents _dents;
        private readonly Vector3[] _localCorners;
        private RectTransform _rectTransformCache;
        public override void ModifyMesh(VertexHelper vh)
        {
        }

        protected Vector2 GetUV(Vector2 localPosition, Vector2 positionBottomLeft, Vector2 positionTopRight, Vector2 uvBottomLeft, Vector2 uvTopRight)
        {
            return default(Vector2);
        }

        protected override void OnDestroy()
        {
        }

        public UIDentEffect()
        {
        }
    }
}
