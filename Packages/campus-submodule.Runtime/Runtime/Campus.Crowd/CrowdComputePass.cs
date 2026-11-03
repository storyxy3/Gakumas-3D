namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CrowdComputePass : ScriptableRenderPass
    {
        private static readonly int CrowdParams;
        private CrowdSystem _system;
        private Crowd _crowd;
        private CrowdRenderingSetupData _crowdSetupData;
        public CrowdComputePass()
        {
        }

        public void Setup(CrowdSystem system, CrowdRenderingSetupData crowdSetupData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
