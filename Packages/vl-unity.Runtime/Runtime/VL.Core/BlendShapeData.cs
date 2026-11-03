namespace VL.Core
{
    using global::System;
    using global::UnityEngine;
    using global::VL.Core;

    [Serializable]
    public class BlendShapeData
    {
        public string blendShapeName;
        [NonReorderable]
        public BlendShapeLayout[] blendShapeVertices;
        public BlendShapeData()
        {
        }
    }
}
