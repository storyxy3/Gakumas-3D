namespace Campus.Rendering
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class CampusActorParameterSettings
    {
        [Header("アウトライン最小サイズ")]
        public float outlineRangeMinSize;
        [Header("アウトライン最大サイズ")]
        public float outlineRangeMaxSize;
        [Header("アウトラインサイズ影響距離")]
        public float outlineRangeDistance;
        [Header("アウトラインの焦点距離による補正")]
        public AnimationCurve outlineFocalLengthScale;
        public CampusActorParameterSettings()
        {
        }
    }
}
