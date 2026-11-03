namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;

    public static class CriFsPlugin
    {
        private static int initializationCount;
        private static bool isConfigured;
        public static int defaultInstallBufferSize;
        public static int installBufferSize;
        public static bool isInitialized
        {
            get
            {
                return default(bool);
            }
        }

        public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check)
        {
        }

        public static void SetReadDeviceEnabled(int deviceId, bool enabled)
        {
        }

        public static void SetConfigAdditionalParameters_EDITOR(int additionalLoaders)
        {
        }

        public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps)
        {
        }

        public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio)
        {
        }

        public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio)
        {
        }

        public static void InitializeLibrary()
        {
        }

        public static bool IsLibraryInitialized()
        {
            return default(bool);
        }

        public static void FinalizeLibrary()
        {
        }

        [PreserveSig]
        private static extern void CRIWARE6C41A92F(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check);
        [PreserveSig]
        private static extern void CRIWARE325BC217();
        [PreserveSig]
        public static extern bool CRIWARED6AB6192();
        [PreserveSig]
        private static extern void CRIWARE82402051();
        [PreserveSig]
        public static extern uint CRIWAREE329E9E7();
        [PreserveSig]
        public static extern uint criFsLoader_GetRetryCount();
        [PreserveSig]
        private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled);
        [PreserveSig]
        private static extern void criFsUnity_SetConfigAdditionalParameters_ANDROID(int device_read_bps);
        [PreserveSig]
        public static extern void criFsUnity_SetMemoryFileSystemThreadPriority_ANDROID(int prio);
        [PreserveSig]
        public static extern void criFsUnity_SetDataDecompressionThreadPriority_ANDROID(int prio);
        [PreserveSig]
        private static extern void criFs_EnableAssetsAccess_ANDROID(IntPtr javaVM, IntPtr staticActivityContext);
        [PreserveSig]
        private static extern void criFs_DisableAssetsAccess_ANDROID();
    }
}
