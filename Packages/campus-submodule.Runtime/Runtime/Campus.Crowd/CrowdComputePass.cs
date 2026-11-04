namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CrowdComputePass : ScriptableRenderPass
    {
        private static readonly int CrowdParams = global::UnityEngine.Shader.PropertyToID("_CrowdParams");
        private CrowdSystem _system;
        private Crowd _crowd;
        private CrowdRenderingSetupData _crowdSetupData;
        public CrowdComputePass()
        {
            profilingSampler = new ProfilingSampler("Compute Crowd");
            renderPassEvent = RenderPassEvent.BeforeRendering;
        }

        public void Setup(CrowdSystem system, CrowdRenderingSetupData crowdSetupData)
        {
            _system = system;
            _crowdSetupData = crowdSetupData;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (_system == null || _crowdSetupData == null) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                _system.CompleteJobs();
                _system.SetupComputeCrowd(cmd, _crowdSetupData.CrowdLookAt, _crowdSetupData.CrowdRandomLookAtWeight,
                    _crowdSetupData.CameraPos, _crowdSetupData.CameraForward, _crowdSetupData.OcclusionSphere);
                _system.ComputeCrowdSkinning(cmd);
                _system.ComputeCrowd(cmd);
                _system.SetupRenderingParameter();
                cmd.SetGlobalVector(CrowdParams, _crowdSetupData.CrowdParams);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
            _system.BakeBillboardCrowd(context, ref renderingData);
        }
    }
}
