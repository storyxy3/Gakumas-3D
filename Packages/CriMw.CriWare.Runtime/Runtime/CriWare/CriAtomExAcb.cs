namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExAcb : CriDisposable
    {
        private IntPtr handle;
        private GCHandle dataHandle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public bool isAvailable
        {
            get
            {
                return default(bool);
            }
        }

        public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath)
        {
            return null;
        }

        public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath)
        {
            return null;
        }

        public static CriAtomExAcb LoadAcbData(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath)
        {
            return null;
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        public bool Exists(string cueName)
        {
            return default(bool);
        }

        public bool Exists(int cueId)
        {
            return default(bool);
        }

        public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info)
        {
            throw null;
        }

        public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info)
        {
            throw null;
        }

        public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info)
        {
            throw null;
        }

        public CriAtomEx.CueInfo[] GetCueInfoList()
        {
            return null;
        }

        public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info)
        {
            throw null;
        }

        public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info)
        {
            throw null;
        }

        public int GetNumCuePlaying(string name)
        {
            return default(int);
        }

        public int GetNumCuePlaying(int id)
        {
            return default(int);
        }

        public int GetBlockIndex(string cueName, string blockName)
        {
            return default(int);
        }

        public int GetBlockIndex(int cueId, string blockName)
        {
            return default(int);
        }

        public int GetNumUsableAisacControls(string cueName)
        {
            return default(int);
        }

        public int GetNumUsableAisacControls(int cueId)
        {
            return default(int);
        }

        public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info)
        {
            throw null;
        }

        public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info)
        {
            throw null;
        }

        public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName)
        {
            return null;
        }

        public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId)
        {
            return null;
        }

        public void ResetCueTypeState(string cueName)
        {
        }

        public void ResetCueTypeState(int cueId)
        {
        }

        public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name)
        {
        }

        public void DetachAwbFile(string awb_name)
        {
        }

        public bool IsReadyToRelease()
        {
            return default(bool);
        }

        public bool IsAttachedAwbFile(string awbName)
        {
            return default(bool);
        }

        public float GetLoadProgress()
        {
            return default(float);
        }

        public void Decrypt(ulong key, ulong nonce)
        {
        }

        internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle)
        {
        }

        ~CriAtomExAcb()
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);
        [PreserveSig]
        private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomExAcb_Release(IntPtr acb_hn);
        [PreserveSig]
        private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn);
        [PreserveSig]
        private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id);
        [PreserveSig]
        private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name);
        [PreserveSig]
        private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id);
        [PreserveSig]
        private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info);
        [PreserveSig]
        private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name);
        [PreserveSig]
        private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id);
        [PreserveSig]
        private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name);
        [PreserveSig]
        private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name);
        [PreserveSig]
        private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name);
        [PreserveSig]
        private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id);
        [PreserveSig]
        private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name);
        [PreserveSig]
        private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn);
        [PreserveSig]
        private static extern bool criAtomExAcb_IsAttachedAwbFile(IntPtr acbHn, string awbName);
    }
}
