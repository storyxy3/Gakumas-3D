namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriFsInstaller : CriDisposable
    {
        public enum Status
        {
            Stop,
            Busy,
            Complete,
            Error
        }

        private enum CopyPolicy
        {
            Always
        }

        private byte[] installBuffer;
        private GCHandle installBufferGch;
        private IntPtr handle;
        public CriFsInstaller()
        {
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize)
        {
        }

        public void Stop()
        {
        }

        public Status GetStatus()
        {
            return default(Status);
        }

        public float GetProgress()
        {
            return default(float);
        }

        public static void ExecuteMain()
        {
        }

        ~CriFsInstaller()
        {
        }

        [PreserveSig]
        private static extern int criFsInstaller_ExecuteMain();
        [PreserveSig]
        private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option);
        [PreserveSig]
        private static extern int criFsInstaller_Destroy(IntPtr installer);
        [PreserveSig]
        private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size);
        [PreserveSig]
        private static extern int criFsInstaller_Stop(IntPtr installer);
        [PreserveSig]
        private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status);
        [PreserveSig]
        private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress);
    }
}
