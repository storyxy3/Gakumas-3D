namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/Lit Color Parameter")]
    public class CampusLitColorParameter : VolumeComponent
    {
        [Tooltip("LitColorのレンダリング結果に対して乗算します")]
        public ColorParameter multiplyColor = new ColorParameter(Color.white, false, false, false, false);
        public CampusLitColorParameter()
        {
        }
    }
}
