namespace CriWare
{
    using global::System;
    using global::CriWare;

    public class CriAtomServer : CriMonoBehaviour
    {
        private static CriAtomServer _instance;
        private static CriWareProfilerReporter profilerReporterInstance;
        public Action<bool> onApplicationPausePreProcess;
        public Action<bool> onApplicationPausePostProcess;
        public static bool KeepPlayingSoundOnPause;
        public static bool EnableAutoConsumePcmOutput;
        public static bool EnableBackgroundPlayback_ANDROID;
        public static CriAtomServer instance
        {
            get
            {
                return null;
            }
        }

        public static void CreateInstance()
        {
        }

        public static void DestroyInstance()
        {
        }

        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void ConsumePcmOutput()
        {
        }

        private void OnApplicationPause(bool appPause)
        {
        }

        private void ProcessApplicationPause(bool appPause)
        {
        }

        public CriAtomServer()
        {
        }
    }
}
