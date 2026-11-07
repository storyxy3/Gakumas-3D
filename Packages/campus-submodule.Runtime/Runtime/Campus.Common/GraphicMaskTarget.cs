namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class GraphicMaskTarget : BaseMeshEffect
    {
        [CompilerGenerated]
        private MaskUtility.ClippingType _003CClippingType_003Ek__BackingField;
        private List<MaskUtility.UIQuad> _uiQuads;
        private List<MaskUtility.UIVertexMini> _uiVertices;
        protected UISharedHub _hub;
        private bool _isGpuMode;
        private bool _isCpuMode;
        [CompilerGenerated]
        private Action m_shouldSetMaterialDirty;
        [CompilerGenerated]
        private Action m_shouldSetVerticesDirty;
        public Graphic Graphic
        {
            get
            {
                return null;
            }
        }

        public Texture MainTexture
        {
            get
            {
                return null;
            }
        }

        public MaskUtility.ClippingType ClippingType
        {
            [CompilerGenerated]
            get
            {
                return _003CClippingType_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CClippingType_003Ek__BackingField = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsCull
        {
            get
            {
                return default(bool);
            }
        }

        public IReadOnlyList<MaskUtility.UIVertexMini> UIVertices
        {
            get
            {
                return null;
            }
        }

        public event Action shouldSetMaterialDirty
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

        public event Action shouldSetVerticesDirty
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

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        public void EnableGpuMode()
        {
        }

        public void EnableCpuMode()
        {
        }

        protected override void OnDisable()
        {
        }

        private void OnVerticesDirty()
        {
        }

        private void OnMaterialDirty()
        {
        }

        private void OnTransformChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public IReadOnlyList<MaskUtility.UIQuad> GetUIQuads()
        {
            return null;
        }

        public bool CanGpuMode()
        {
            return default(bool);
        }

        public bool IsHullCheck()
        {
            return default(bool);
        }

        private void Release<T>(ref List<T> list)
        {
        }

        public GraphicMaskTarget()
        {
        }
    }
}
