namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/")]
    public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Action<Camera> _003C_003E9__15_0;
            public _003C_003Ec()
            {
            }

            internal void _003CInstantiateOrActivateDepthCamera_003Eb__15_0(Camera cam)
            {
            }
        }

        public new const string ClassName = "DynamicOcclusionDepthBuffer";
        public LayerMask layerMask;
        public bool useOcclusionCulling;
        public int depthMapResolution;
        public float fadeDistanceToSurface;
        private Camera m_DepthCamera;
        private bool m_NeedToUpdateOcclusionNextFrame;
        protected override string GetShaderKeyword()
        {
            return null;
        }

        protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
        {
            return default(MaterialManager.SD.DynamicOcclusion);
        }

        private void ProcessOcclusionInternal()
        {
        }

        protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
        {
            return default(bool);
        }

        private void Update()
        {
        }

        private void UpdateDepthCameraPropertiesAccordingToBeam()
        {
        }

        public bool HasLayerMaskIssues()
        {
            return default(bool);
        }

        protected override void OnValidateProperties()
        {
        }

        private void InstantiateOrActivateDepthCamera()
        {
        }

        protected override void OnEnablePostValidate()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void Awake()
        {
        }

        protected override void OnDestroy()
        {
        }

        private void DestroyDepthCamera()
        {
        }

        protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
        {
        }

        public DynamicOcclusionDepthBuffer()
        {
        }
    }
}
