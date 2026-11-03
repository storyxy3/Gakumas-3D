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
                return default(Vector3);
            }
        }

        protected override Quaternion rootRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        public void SetActorController(TController controller)
        {
        }

        public VLVirtualActorController()
        {
        }
    }
}
