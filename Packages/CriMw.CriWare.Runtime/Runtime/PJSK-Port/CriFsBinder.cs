using System;

namespace CriWare
{
    // CriWare.CriFsBinder (TypeDefIndex 31835). Only a parameter type on the StreamingLive paths (always null there).
    public partial class CriFsBinder : CriDisposable
    {
        private IntPtr handle;

        public IntPtr nativeHandle => handle;

        public CriFsBinder()
        {
            if (!CriFsPlugin.IsLibraryInitialized())
                throw new Exception("CriFsPlugin is not initialized.");
            handle = IntPtr.Zero;
            criFsBinder_Create(out handle);
            if (handle == IntPtr.Zero)
                throw new Exception("criFsBinder_Create() failed.");
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Fs);
        }

        public override void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            CriDisposableObjectManager.Unregister(this);
            if (handle != IntPtr.Zero)
            {
                criFsBinder_Destroy(handle);
                handle = IntPtr.Zero;
            }
        }

        ~CriFsBinder()
        {
            Dispose(false);
        }

        private static uint criFsBinder_Create(out IntPtr binder) => CriWareNative.Native.criFsBinder_Create(out binder);
        private static uint criFsBinder_Destroy(IntPtr binder) => CriWareNative.Native.criFsBinder_Destroy(binder);
    }
}
