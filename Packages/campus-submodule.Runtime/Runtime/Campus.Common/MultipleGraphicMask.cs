namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::UnityEngine;

    [ExecuteAlways]
    public class MultipleGraphicMask : GraphicMaskBase
    {
        [SerializeField]
        private GraphicMaskTarget[] _targets;
        private float[] _prevDistances;
        private int[] _prevHashCodes;
        protected override void AddTargetEvent()
        {
        }

        protected override void RemoveTargetEvent()
        {
        }

        protected override bool IsTargetValid()
        {
            return default(bool);
        }

        protected override bool IsTargetCull()
        {
            return default(bool);
        }

        protected override bool IsGpuMode()
        {
            return default(bool);
        }

        protected override MaskGpuUtility.GpuData GetGpuData()
        {
            return default(MaskGpuUtility.GpuData);
        }

        protected override bool IsMaskAreaChanged()
        {
            return default(bool);
        }

        protected override Texture GetTargetTexture()
        {
            return null;
        }

        protected override MaskUtility.ClippingType GetTargetClippingType()
        {
            return default(MaskUtility.ClippingType);
        }

        protected override bool IsTargetHullCheck()
        {
            return default(bool);
        }

        protected override void ProcessUIQuads(List<MaskUtility.UIQuad> source, List<MaskUtility.UIQuad> output)
        {
        }

        protected override void ProcessUIVertices(List<MaskUtility.UIVertexMini> source, bool isHullOnly, List<MaskUtility.UIVertexMini> output)
        {
        }

        public MultipleGraphicMask()
        {
        }
    }
}
