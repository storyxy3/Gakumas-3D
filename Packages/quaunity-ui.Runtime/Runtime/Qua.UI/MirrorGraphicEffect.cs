namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class MirrorGraphicEffect : BaseMeshEffect
    {
        [SerializeField]
        private MirrorImage.MirrorEdge _mirror;
        public MirrorImage.MirrorEdge Mirror
        {
            get
            {
                return default(MirrorImage.MirrorEdge);
            }

            set
            {
            }
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public MirrorGraphicEffect()
        {
        }
    }
}
