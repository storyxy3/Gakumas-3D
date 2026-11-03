namespace CriWare
{
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public static class CriFsUtility
    {
        public const int DefaultReadUnitSize = 1048576;
        public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576)
        {
            return null;
        }

        public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576)
        {
            return null;
        }

        public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576)
        {
            return null;
        }

        public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576)
        {
            return null;
        }

        public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576)
        {
            return null;
        }

        public static CriFsInstallRequest Install(string srcPath, string dstPath)
        {
            return null;
        }

        public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }

        public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath)
        {
            return null;
        }

        public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }

        public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }

        public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }

        public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }

        public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }

        public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }

        public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }

        public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }

        public static void SetUserAgentString(string userAgentString)
        {
        }

        public static void SetProxyServer(string proxyPath, ushort proxyPort)
        {
        }

        public static void SetPathSeparator(string filter)
        {
        }

        [PreserveSig]
        private static extern bool CRIWARE0F8EC4EF(string userAgentString);
        [PreserveSig]
        private static extern bool CRIWARE82A4937D(string proxyPath, ushort proxyPort);
        [PreserveSig]
        private static extern bool CRIWARE016569D0(string filter);
    }
}
