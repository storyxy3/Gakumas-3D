namespace VL.Rendering
{
    using global::UnityEngine;

    public class DownscaleSystemData : ScriptableObject
    {
        public Shader downscaleShader;
        public Shader fogShader;
        public Shader ssaoShader;
        public Shader subWorldShader;
        public ComputeShader hizComputeShader;
        public ComputeShader flareComputeShader;
        public Shader flareShader;
        public Shader amplifyOcclusionShader;
        public Shader amplifyOcclusionBlurShader;
        public Shader amplifyOcclusionApplyShader;
        public DownscaleSystemData()
        {
        }
    }
}
