// TODO(qa-recon): The native generic constructor inlines the base constructor differently from APK; its raw semantic flag remains open (TASK_D_REPORT.md).
namespace VL
{
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    public class VLCameraControllerSingleton<T> : VLMonoBehaviourSingleton<T> where T : MonoBehaviour, IVLCameraController
    {
        protected override void OnEnable()
        {
            if (!gameObject.scene.IsValid() || (_instance != null && _instance != this && FindObjectsOfType<T>().Length > 1))
            {
                DestroyImmediate(gameObject);
                return;
            }
            _instance = GetComponent<T>();
            VLCameraController.Instance = _instance;
        }

        protected override void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
                VLCameraController.Instance = null;
            }
        }

        public VLCameraControllerSingleton()
        {
        }
    }
}
