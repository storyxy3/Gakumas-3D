namespace Campus.Common.UIRenderer
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class KawaseBlur
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<int, string> _003C_003E9__10_0;
            public static Func<(float min, float max), float> _003C_003E9__11_0;
            public _003C_003Ec()
            {
            }

            internal string _003C_002Ector_003Eb__10_0(int x)
            {
                return null;
            }

            internal float _003CPrecalculateOffsets_003Eb__11_0((float min, float max) x)
            {
                return default(float);
            }
        }

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
