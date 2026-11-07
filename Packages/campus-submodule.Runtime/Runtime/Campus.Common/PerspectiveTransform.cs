namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [ExecuteAlways]
    public class PerspectiveTransform : UIBehaviour
    {
        private const float FieldOfView = 60f;
        private const float NearPlane = 0.3f;
        private const float FarPlane = 1000f;
        [SerializeField]
        private Vector3 _translation;
        [SerializeField]
        private Vector3 _rotation;
        [SerializeField]
        private Vector3 _scale;
        [SerializeField]
        private PerspectiveTransform _parent;
        private readonly HashSet<PerspectiveTransform> _children;
        [CompilerGenerated]
        private RectTransform _003CViewport_003Ek__BackingField;
        [CompilerGenerated]
        private Action m_onTransformDirty;
        public Vector3 Translation
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 Rotation
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 Scale
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public PerspectiveTransform Parent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public IReadOnlyCollection<PerspectiveTransform> Children
        {
            get
            {
                return null;
            }
        }

        public RectTransform Viewport
        {
            [CompilerGenerated]
            get
            {
                return _003CViewport_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CViewport_003Ek__BackingField = value;
            }
        }

        public event Action onTransformDirty
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

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public void AddChild(PerspectiveTransform perspectiveTransform)
        {
        }

        public void RemoveChild(PerspectiveTransform perspectiveTransform)
        {
        }

        public void SetTransformDirty()
        {
        }

        public RectTransform GetViewport()
        {
            return null;
        }

        private RectTransform GetCanvasRectTransform()
        {
            return null;
        }

        public Matrix4x4 GetTransformMatrix()
        {
            return default(Matrix4x4);
        }

        public Matrix4x4 GetTransformMatrix(RectTransform rectTransform)
        {
            return default(Matrix4x4);
        }

        private Matrix4x4 GetProjectionMatrix(RectTransform rectTransform)
        {
            return default(Matrix4x4);
        }

        public Matrix4x4 GetViewMatrix(RectTransform rectTransform)
        {
            return default(Matrix4x4);
        }

        public Matrix4x4 GetModelMatrix()
        {
            return default(Matrix4x4);
        }

        public Matrix4x4 GetInverseTranslateMatrix()
        {
            return default(Matrix4x4);
        }

        private Vector3 GetDistanceFromParent()
        {
            return default(Vector3);
        }

        public PerspectiveTransform()
        {
        }
    }
}
