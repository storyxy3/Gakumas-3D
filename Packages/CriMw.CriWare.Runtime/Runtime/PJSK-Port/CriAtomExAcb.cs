using System;
using System.Runtime.InteropServices;

namespace CriWare
{
    // CriWare.CriAtomExAcb (TypeDefIndex 31751): a loaded cue sheet. LoadAcbData pins the ACB bytes for the life of
    // the handle.
    public class CriAtomExAcb : CriDisposable
    {
        private IntPtr handle;
        private GCHandle dataHandle;

        public IntPtr nativeHandle => handle;

        internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle)
        {
            this.handle = handle;
            if (dataHandle.HasValue)
                this.dataHandle = dataHandle.Value;
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Atom);
        }

        public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath)
        {
            if (!Common.CheckBinaryVersionCompatibility())
                return null;
            var binderHandle = binder != null ? binder.nativeHandle : IntPtr.Zero;
            var acbHandle = criAtomExAcb_LoadAcbFile(binderHandle, acbPath, binderHandle, awbPath, IntPtr.Zero, 0);
            if (acbHandle == IntPtr.Zero)
                return null;
            return new CriAtomExAcb(acbHandle, null);
        }

        public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath)
        {
            if (!Common.CheckBinaryVersionCompatibility())
                return null;
            var awbBinderHandle = awbBinder != null ? awbBinder.nativeHandle : IntPtr.Zero;
            var gch = GCHandle.Alloc(acbData, GCHandleType.Pinned);
            var acbHandle = criAtomExAcb_LoadAcbData(gch.AddrOfPinnedObject(), acbData.Length, awbBinderHandle,
                awbPath, IntPtr.Zero, 0);
            if (acbHandle == IntPtr.Zero)
                return null;
            return new CriAtomExAcb(acbHandle, gch);
        }

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            CriDisposableObjectManager.Unregister(this);
            if (handle != IntPtr.Zero)
            {
                criAtomExAcb_Release(handle);
                handle = IntPtr.Zero;
            }
            if (disposing && dataHandle.IsAllocated)
                dataHandle.Free();
        }

        ~CriAtomExAcb()
        {
            Dispose(false);
        }

        public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info)
        {
            using (var mem = new CriStructMemory<CriAtomEx.CueInfo>())
            {
                var result = criAtomExAcb_GetCueInfoByIndex(handle, index, mem.ptr);
                info = new CriAtomEx.CueInfo(mem.bytes, 0);
                return result;
            }
        }

        public CriAtomEx.CueInfo[] GetCueInfoList()
        {
            var numCues = criAtomExAcb_GetNumCues(handle);
            var list = new CriAtomEx.CueInfo[numCues];
            for (var i = 0; i < numCues; i++)
                GetCueInfoByIndex(i, out list[i]);
            return list;
        }

        public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info)
        {
            using (var mem = new CriStructMemory<CriAtomEx.WaveformInfo>())
            {
                var result = criAtomExAcb_GetWaveformInfoByName(handle, cueName, mem.ptr);
                info = new CriAtomEx.WaveformInfo(mem.bytes, 0);
                return result;
            }
        }

        private static IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder,
            string awb_path, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomExAcb_LoadAcbFile(acb_binder, acb_path, awb_binder, awb_path, work, work_size);
        private static IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder,
            string awb_path, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomExAcb_LoadAcbData(acb_data, acb_data_size, awb_binder, awb_path, work, work_size);
        private static void criAtomExAcb_Release(IntPtr acb_hn) => CriWareNative.Native.criAtomExAcb_Release(acb_hn);
        private static int criAtomExAcb_GetNumCues(IntPtr acb_hn) => CriWareNative.Native.criAtomExAcb_GetNumCues(acb_hn);
        private static bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info) =>
            CriWareNative.Native.criAtomExAcb_GetCueInfoByIndex(acb_hn, index, info);
        private static bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info) =>
            CriWareNative.Native.criAtomExAcb_GetWaveformInfoByName(acb_hn, name, waveform_info);
    }
}
