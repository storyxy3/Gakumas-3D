namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    [RequireComponent(typeof(VLActorController))]
    public class VLActorExtension : MonoBehaviour, IComparable<VLActorExtension>, IDisposable
    {
        private VLActorController _controller;
        protected VLActorController controller
        {
            get
            {
                if (_controller == null) _controller = GetComponent<VLActorController>();
                return _controller;
            }
        }

        public virtual int order
        {
            get
            {
                return default(int);
            }
        }

        public virtual bool runtimeOnly
        {
            get
            {
                return default(bool);
            }
        }

        public virtual void OnUpdate()
        {
        }

        public virtual void OnLateUpdate()
        {
        }

        public virtual void Initialize()
        {
        }

        public virtual void Dispose()
        {
        }

        public virtual void OnRendererActiveChanged(bool active)
        {
        }

        private void OnDestroy()
        {
        }

        public int CompareTo(VLActorExtension other)
        {
            return default(int);
        }

        public VLActorExtension()
        {
        }
    }
}
