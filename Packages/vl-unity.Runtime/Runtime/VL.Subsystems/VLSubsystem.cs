namespace VL.Subsystems
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering.Skinning;

    public static class VLSubsystem
    {
        private static readonly ProfilingSampler _scheduleSkinningSampler = new ProfilingSampler("Schedule Skinning");
        private static readonly ProfilingSampler _applySkinningSampler = new ProfilingSampler("Apply Skinning");
        private static List<VLSkinningModel> _skinningModels = new List<VLSkinningModel>();
        public static void RegisterSkinningModel(VLSkinningModel model)
        {
            _skinningModels.Add(model);
        }

        internal static void LastLateUpdate()
        {
            if (_skinningModels == null) return;
            using (new ProfilingScope(null, _scheduleSkinningSampler))
            {
                foreach (var model in _skinningModels)
                    if (model != null) model.ScheduleSkinning();
            }
            Unity.Jobs.JobHandle.ScheduleBatchedJobs();
        }

        internal static void BeforeRendering()
        {
        }

        internal static void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
        {
            if (_skinningModels == null) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _applySkinningSampler))
            {
                foreach (var model in _skinningModels)
                    if (model != null) model.ApplySkinning(cmd);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
            _skinningModels.Clear();
        }
    }
}
