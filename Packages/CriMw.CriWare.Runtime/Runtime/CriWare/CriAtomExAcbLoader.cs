namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExAcbLoader : CriDisposable
    {
        public enum Status
        {
            Stop,
            Loading,
            Complete,
            Error
        }

        private struct LoaderConfig
        {
            public bool shouldLoadAwbOnMemory;
        }

        private IntPtr handle;
        private GCHandle? gch;
        public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }

        public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }

        public static CriAtomExAcbLoader LoadAcbDataAsync(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }

        public Status GetStatus()
        {
            return default(Status);
        }

        public CriAtomExAcb MoveAcb()
        {
            return null;
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle)
        {
        }

        ~CriAtomExAcbLoader()
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExAcbLoader_Create([In] ref LoaderConfig config);
        [PreserveSig]
        private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader);
        [PreserveSig]
        private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path);
        [PreserveSig]
        private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path);
        [PreserveSig]
        private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader);
        [PreserveSig]
        private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader);
        [PreserveSig]
        private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader);
    }
}
