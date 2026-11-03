namespace VL
{
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    public class VLCameraControllerSingleton<T> : VLMonoBehaviourSingleton<T> where T : MonoBehaviour, IVLCameraController
    {
        protected override void OnEnable()
        {
        }

        protected override void OnDestroy()
        {
        }

        public VLCameraControllerSingleton()
        {
        }
    }
}
