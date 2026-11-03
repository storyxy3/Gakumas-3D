namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VLB;

    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(VolumetricLightBeamSD))]
    public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
    {
        protected enum ProcessOcclusionSource
        {
            RenderLoop,
            OnEnable,
            EditorUpdate,
            User
        }

        public const string ClassName = "DynamicOcclusionAbstractBase";
        public DynamicOcclusionUpdateRate updateRate;
        [FormerlySerializedAs("waitFrameCount")]
        public int waitXFrames;
        [CompilerGenerated]
        private Action m_onOcclusionProcessed;
        public static bool _INTERNAL_ApplyRandomFrameOffset;
        private TransformUtils.Packed m_TransformPacked;
        private int m_LastFrameRendered;
        protected VolumetricLightBeamSD m_Master;
        protected MaterialModifier.Callback m_MaterialModifierCallbackCached;
        public int _INTERNAL_LastFrameRendered
        {
            get
            {
                return default(int);
            }
        }

        public event Action onOcclusionProcessed
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public void ProcessOcclusionManually()
        {
        }

        protected void ProcessOcclusion(ProcessOcclusionSource source)
        {
        }

        protected abstract string GetShaderKeyword();
        protected abstract MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();
        protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);
        protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);
        protected abstract void OnEnablePostValidate();
        protected virtual void OnValidateProperties()
        {
        }

        protected virtual void Awake()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        private void OnWillCameraRender(Camera cam)
        {
        }

        private void DisableOcclusion()
        {
        }

        protected DynamicOcclusionAbstractBase()
        {
        }
    }
}
