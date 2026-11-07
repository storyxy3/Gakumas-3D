namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriFsWebInstaller : CriDisposable
    {
        public enum Status
        {
            Stop,
            Busy,
            Complete,
            Error
        }

        public enum Error
        {
            None,
            Timeout,
            Memory,
            LocalFs,
            DNS,
            Connection,
            SSL,
            HTTP,
            Internal
        }

        public struct StatusInfo
        {
            public Status status;
            public Error error;
            public int httpStatusCode;
            public long contentsSize;
            public long receivedSize;
        }

        public struct ModuleConfig
        {
            public uint numInstallers;
            public string proxyHost;
            public ushort proxyPort;
            public string userAgent;
            public uint inactiveTimeoutSec;
            public bool allowInsecureSSL;
            public bool crcEnabled;
            public ModulePlatformConfig platformConfig;
        }

        public struct ModulePlatformConfig
        {
            public byte reserved;
            public static ModulePlatformConfig defaultConfig
            {
                get
                {
                    return default(ModulePlatformConfig);
                }
            }
        }

        [CompilerGenerated]
        private static bool _003CisInitialized_003Ek__BackingField;
        [CompilerGenerated]
        private static bool _003CisCrcEnabled_003Ek__BackingField;
        public const int InvalidHttpStatusCode = -1;
        public const long InvalidContentsSize = -1L;
        private IntPtr handle;
        public static bool isInitialized
        {
            [CompilerGenerated]
            get
            {
                return _003CisInitialized_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisInitialized_003Ek__BackingField = value;
            }
        }

        public static bool isCrcEnabled
        {
            [CompilerGenerated]
            get
            {
                return _003CisCrcEnabled_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisCrcEnabled_003Ek__BackingField = value;
            }
        }

        public static ModuleConfig defaultModuleConfig
        {
            get
            {
                return default(ModuleConfig);
            }
        }

        public CriFsWebInstaller()
        {
        }

        ~CriFsWebInstaller()
        {
        }

        public override void Dispose()
        {
        }

        public void Copy(string url, string dstPath)
        {
        }

        public void Stop()
        {
        }

        public StatusInfo GetStatusInfo()
        {
            return default(StatusInfo);
        }

        public bool GetCRC32(out uint ret_val)
        {
            throw null;
        }

        public static void InitializeModule(ModuleConfig config)
        {
        }

        private static Type GetCriFsWebInstallerCurlExpansionClass()
        {
            return null;
        }

        public static void FinalizeModule()
        {
        }

        public static void ExecuteMain()
        {
        }

        public static bool SetRequestHeader(string field, string value)
        {
            return default(bool);
        }

        private void Dispose(bool disposing)
        {
        }

        [PreserveSig]
        private static extern int criFsWebInstaller_Initialize([In] ref ModuleConfig config);
        [PreserveSig]
        private static extern int criFsWebInstaller_Finalize();
        [PreserveSig]
        private static extern int criFsWebInstaller_ExecuteMain();
        [PreserveSig]
        private static extern int criFsWebInstaller_Create(out IntPtr installer);
        [PreserveSig]
        private static extern int criFsWebInstaller_Destroy(IntPtr installer);
        [PreserveSig]
        private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath);
        [PreserveSig]
        private static extern int criFsWebInstaller_Stop(IntPtr installer);
        [PreserveSig]
        private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status);
        [PreserveSig]
        private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32);
        [PreserveSig]
        private static extern int criFsWebInstaller_SetRequestHeader(string field, string value);
    }
}
