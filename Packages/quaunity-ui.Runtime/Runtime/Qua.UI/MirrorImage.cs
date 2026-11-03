namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class MirrorImage : Image
    {
        private struct VertRect
        {
            public float left;
            public float bottom;
            public float right;
            public float top;
            public float Height
            {
                get
                {
                    return default(float);
                }
            }

            public float Width
            {
                get
                {
                    return default(float);
                }
            }

            public VertRect(float left, float bottom, float right, float top)
            {
                this = default;
            }

            public VertRect GetInverse(bool lr, bool bt)
            {
                return default(VertRect);
            }
        }

        [Flags]
        public enum MirrorEdge
        {
            None = 0,
            Left = 1,
            Right = 2,
            Bottom = 4,
            Top = 8
        }

        private readonly UIVertex[] _quad;
        [SerializeField]
        private MirrorEdge _mirror;
        public MirrorEdge Mirror
        {
            get
            {
                return default(MirrorEdge);
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        private void PopulateMultiQuadMirror(VertexHelper vh)
        {
        }

        private void PopulateSimpleQuadMirror(VertexHelper vh)
        {
        }

        private void AddLine(ref VertRect lineRect, ref VertRect centerUv, ref VertRect sideUv, bool mirrorLeft, bool mirrorRight, VertexHelper vh)
        {
        }

        private void AddQuad(ref VertRect rect, ref VertRect uv, VertexHelper vh)
        {
        }

        public MirrorImage()
        {
        }
    }
}
