namespace Qua.VectorUI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;

    public class RoundedPolylineOutlineSetter : GraphicOutlineSetterBase<RoundedPolyline>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass0_0
        {
            public IList<RoundedPolylineMesh.PartsMeshInfoBase> meshes;
            public float thickness;
            public List<RoundedPolyline.Vertex> list;
        }

        protected override void UpdateVertices(List<RoundedPolyline.Vertex> list)
        {
        }

        public RoundedPolylineOutlineSetter()
        {
        }

        [CompilerGenerated]
        private static void _003CUpdateVertices_003Eg__AddVertexFromMesh_007C0_0(int index, bool reversed, ref _003C_003Ec__DisplayClass0_0 P_2)
        {
        }

        [CompilerGenerated]
        private static void _003CUpdateVertices_003Eg__AddVertex_007C0_1(Vector2 point, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(0f)] float radius, ref _003C_003Ec__DisplayClass0_0 P_2)
        {
        }
    }
}
