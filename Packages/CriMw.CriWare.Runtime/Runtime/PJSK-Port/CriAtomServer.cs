using System;

namespace CriWare
{
    // CriWare.CriAtomServer (TypeDefIndex 31674), on the "CRIWARE" manager object: dispatches the queued native
    // callbacks every frame and forwards application pause according to the platform's native wrapper.
    public class CriAtomServer : CriMonoBehaviour
    {
        private static CriAtomServer _instance;
        public Action<bool> onApplicationPausePreProcess;
        public Action<bool> onApplicationPausePostProcess;
        public static bool KeepPlayingSoundOnPause = true;
        public static bool EnableAutoConsumePcmOutput = true;

        public static CriAtomServer instance
        {
            get
            {
                CreateInstance();
                return _instance;
            }
        }

        public static void CreateInstance()
        {
            if (_instance == null)
                Common.managerObject.AddComponent<CriAtomServer>();
        }

        public static void DestroyInstance()
        {
            if (_instance != null)
                Destroy(_instance);
        }

        private void Awake()
        {
            if (_instance == null)
                _instance = this;
            else
                Destroy(this);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if (_instance == this)
                _instance = null;
        }

        public override void CriInternalUpdate()
        {
            CriAtomPlugin.ExecuteQueuedCueLinkCallbacks();
            CriAtomPlugin.ExecuteQueuedEventCallbacks();
            CriAtomPlugin.ExecuteQueuedBeatSyncCallbacks();
        }

        private void ConsumePcmOutput()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void OnApplicationPause(bool appPause)
        {
            ProcessApplicationPause(appPause);
        }

        // 官方 7.0.0 iOS CriAtomServer$$ProcessApplicationPause 0x44ABB44：只依次调用 pre/post 两个回调。
        // Android 版夹在中间的 CriAtomPlugin.Pause(appPause)（暂停整个 Atom 库）在 iOS 版没有。
        private void ProcessApplicationPause(bool appPause)
        {
            if (onApplicationPausePreProcess != null)
                onApplicationPausePreProcess(appPause);
#if !UNITY_IOS
            // JP 7.0.0 Android 0x66AA290 calls Pause between the pre/post callbacks.
            CriAtomPlugin.Pause(appPause);
#endif
            if (onApplicationPausePostProcess != null)
                onApplicationPausePostProcess(appPause);
        }
    }
}
