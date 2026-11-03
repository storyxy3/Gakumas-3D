namespace Campus.Common.UIRenderer
{
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class KawaseBlur
    {
        private static int BlitScaleBiasId;
        private static int BlitTextureId;
        private static int BlurOffsetId;
        private static int HsvOffsetId;
        public static readonly (float min, float max)[] OffsetRanges;
        private (int interation, float offset)[] _stepOffsets;
        private Material _material;
        private string[] _renderTargetNames;
        private int MaxPassCount
        {
            get
            {
                return default(int);
            }
        }

        public KawaseBlur(Material material, int maxStepCount = 51)
        {
        }

        private void PrecalculateOffsets(int maxStepCount)
        {
        }

        public void ApplyBlur(CommandBuffer cmd, Texture source, RTHandle destination, RTHandle[] blurTargets, int blurSize, RenderTextureDescriptor descriptor, [Optional] Vector3 hsvOffset)
        {
        }

        public static void BlitTexture(CommandBuffer cmd, Texture source, RTHandle destination, Material material, int pass)
        {
        }
    }
}
