using UnityEngine;

namespace CriWare
{
    // CriWare.CriFsPlugin (TypeDefIndex 31848), the members on the library initialization path.
    public static class CriFsPlugin
    {
        private static int initializationCount = 0;
        private static bool isConfigured = false;
        public static int defaultInstallBufferSize = 4194304;
        public static int installBufferSize = 4194304;

        public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers,
            int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check)
        {
            CRIWARED671D92C(num_loaders, num_binders, num_installers, max_path, minimize_file_descriptor_usage,
                enable_crc_check);
            installBufferSize = argInstallBufferSize;
            isConfigured = true;
        }

        public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps)
        {
            criFsUnity_SetConfigAdditionalParameters_ANDROID(device_read_bps);
        }

        public static void InitializeLibrary()
        {
            initializationCount++;
            if (initializationCount != 1)
                return;
            if (IsLibraryInitialized())
            {
                FinalizeLibrary();
                initializationCount = 1;
            }
            if (!isConfigured)
                Debug.Log("[CRIWARE] FileSystem initialization parameters are not configured. Initializes FileSystem by default parameters.");
            CRIWARE8B8CF7AE();
        }

        public static bool IsLibraryInitialized()
        {
            return CRIWARE7DA1D7FD();
        }

        public static void FinalizeLibrary()
        {
            initializationCount--;
            if (initializationCount < 0)
            {
                initializationCount = 0;
                if (!IsLibraryInitialized())
                    return;
            }
            if (initializationCount != 0)
                return;
            CriFsServer.DestroyInstance();
            installBufferSize = defaultInstallBufferSize;
            CriDisposableObjectManager.CallOnModuleFinalization(CriDisposableObjectManager.ModuleType.Fs);
            CRIWARE60FEBD39();
        }

        private static void CRIWARED671D92C(int num_loaders, int num_binders, int num_installers, int max_path,
            bool minimize_file_descriptor_usage, bool enable_crc_check) =>
            CriWareNative.Native.CRIWARED671D92C(num_loaders, num_binders, num_installers, max_path,
                minimize_file_descriptor_usage, enable_crc_check);
        private static void criFsUnity_SetConfigAdditionalParameters_ANDROID(int device_read_bps) =>
            CriWareNative.Native.criFsUnity_SetConfigAdditionalParameters_ANDROID(device_read_bps);
        private static void CRIWARE8B8CF7AE() => CriWareNative.Native.CRIWARE8B8CF7AE();
        private static void CRIWARE60FEBD39() => CriWareNative.Native.CRIWARE60FEBD39();
        private static bool CRIWARE7DA1D7FD() => CriWareNative.Native.CRIWARE7DA1D7FD();
    }

    // CriWare.CriFsUtility: the user agent setter used by CriWareInitializer.
    public static class CriFsUtility
    {
        public static bool SetUserAgentString(string userAgentString)
        {
            return CRIWARED4C30199(userAgentString);
        }

        private static bool CRIWARED4C30199(string userAgentString) =>
            CriWareNative.Native.CRIWARED4C30199(userAgentString);
    }

    // CriWare.CriFsServer: only DestroyInstance is on the StreamingLive paths (the server is created lazily by the file
    // system request API, which is not used there).
    public class CriFsServer : CriMonoBehaviour
    {
        private static CriFsServer _instance;

        public static void DestroyInstance()
        {
            if (_instance != null)
                Destroy(_instance);
        }

        public override void CriInternalUpdate()
        {
            throw new System.NotSupportedException("CriFsServer is not used on the StreamingLive paths.");
        }

        public override void CriInternalLateUpdate()
        {
        }
    }
}
