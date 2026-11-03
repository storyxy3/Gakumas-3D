namespace VL.Subsystems
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering.Skinning;

    public static class VLSubsystem
    {
        private static readonly ProfilingSampler _scheduleSkinningSampler;
        private static readonly ProfilingSampler _applySkinningSampler;
        private static List<VLSkinningModel> _skinningModels;
        public static void RegisterSkinningModel(VLSkinningModel model)
        {
        }

        internal static void LastLateUpdate()
        {
        }

        internal static void BeforeRendering()
        {
        }

        internal static void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
        {
        }
    }
}
