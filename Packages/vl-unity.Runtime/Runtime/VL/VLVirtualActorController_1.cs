namespace VL
{
    using global::UnityEngine;
    using global::VL;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1000)]
    public class VLVirtualActorController<TController> : VLVirtualActorController where TController : IVLActorController
    {
        protected TController controllerBase;
        protected override Vector3 rootPosition
        {
            get
            {
                return controllerBase != null ? controllerBase.position : base.rootPosition;
            }
        }

        protected override Quaternion rootRotation
        {
            get
            {
                return controllerBase != null ? controllerBase.rotation : base.rootRotation;
            }
        }

        public void SetActorController(TController controller)
        {
            controllerBase = controller;
            if (controller != null) Bind();
            else UnBind();
        }

        public VLVirtualActorController()
        {
        }
    }
}
