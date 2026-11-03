namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class ImageBorderGradient : BaseMeshEffect
    {
        [Serializable]
        private class Margins
        {
            public float left;
            public float right;
            public float top;
            public float bottom;
            public Margins()
            {
            }
        }

        [SerializeField]
        private Color _endColor;
        [SerializeField]
        private Margins _margins;
        private UIVertex[] _verts;
        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public ImageBorderGradient()
        {
        }
    }
}
