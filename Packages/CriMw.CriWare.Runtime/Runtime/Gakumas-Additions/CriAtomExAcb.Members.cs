// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public partial class CriAtomExAcb
    {


        public bool isAvailable
        {
            get
            {
                return default(bool);
            }
        }



        public static CriAtomExAcb LoadAcbData(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath)
        {
            return null;
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


        [PreserveSig]
        private static bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id) { throw new NotSupportedException("native criAtomExAcb_ExistsId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name) { throw new NotSupportedException("native criAtomExAcb_ExistsName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id) { throw new NotSupportedException("native criAtomExAcb_GetNumUsableAisacControlsById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name) { throw new NotSupportedException("native criAtomExAcb_GetNumUsableAisacControlsByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info) { throw new NotSupportedException("native criAtomExAcb_GetUsableAisacControlById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info) { throw new NotSupportedException("native criAtomExAcb_GetUsableAisacControlByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info) { throw new NotSupportedException("native criAtomExAcb_GetWaveformInfoById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info) { throw new NotSupportedException("native criAtomExAcb_GetCueInfoByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info) { throw new NotSupportedException("native criAtomExAcb_GetCueInfoById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name) { throw new NotSupportedException("native criAtomExAcb_GetNumCuePlayingCountByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id) { throw new NotSupportedException("native criAtomExAcb_GetNumCuePlayingCountById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name) { throw new NotSupportedException("native criAtomExAcb_GetBlockIndexById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name) { throw new NotSupportedException("native criAtomExAcb_GetBlockIndexByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name) { throw new NotSupportedException("native criAtomExAcb_ResetCueTypeStateByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id) { throw new NotSupportedException("native criAtomExAcb_ResetCueTypeStateById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size) { throw new NotSupportedException("native criAtomExAcb_AttachAwbFile (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name) { throw new NotSupportedException("native criAtomExAcb_DetachAwbFile (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn) { throw new NotSupportedException("native criAtomExAcb_IsReadyToRelease (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcb_IsAttachedAwbFile(IntPtr acbHn, string awbName) { throw new NotSupportedException("native criAtomExAcb_IsAttachedAwbFile (game P/Invoke; not part of the managed port)"); }
    }
}
