namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL;

    [RequireComponent(typeof(IVLCameraController))]
    [ExecuteAlways]
    public class VLOutline : MonoBehaviour
    {
        [Header("アウトライン最小サイズ")]
        public float outlineRangeMinSize;
        [Header("アウトライン最大サイズ")]
        public float outlineRangeMaxSize;
        [Header("アウトラインサイズ影響距離")]
        public float outlineRangeDistance;
        [Header("アウトラインの画角による補正")]
        public AnimationCurve outlineFOVScale;
        private IVLCameraController _controller;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void UpdateOutlineParameter(CommandBuffer cmd, Camera cam)
        {
        }

        private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
        {
        }

        public VLOutline()
        {
        }
    }
}
