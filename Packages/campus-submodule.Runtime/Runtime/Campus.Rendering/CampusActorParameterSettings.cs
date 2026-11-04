namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class CampusActorParameterSettings
    {
        [Header("アウトライン最小サイズ")]
        public float outlineRangeMinSize = 0.15f;
        [Header("アウトライン最大サイズ")]
        public float outlineRangeMaxSize = 2f;
        [Header("アウトラインサイズ影響距離")]
        public float outlineRangeDistance = 10f;
        [Header("アウトラインの焦点距離による補正")]
        public AnimationCurve outlineFocalLengthScale;
        public CampusActorParameterSettings()
        {
        }
    }
}
