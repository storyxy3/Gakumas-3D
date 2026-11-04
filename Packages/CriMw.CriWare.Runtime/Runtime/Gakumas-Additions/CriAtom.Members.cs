// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::AOT;
using global::CriWare;
using global::System.Collections.Generic;
using global::System.Collections;
using global::System.Diagnostics;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine;

namespace CriWare
{
    public partial class CriAtom
    {

        internal static bool HasUserCallback
        {
            get
            {
                return default(bool);
            }
        }



        internal static bool HasBeatSyncCallback
        {
            get
            {
                return default(bool);
            }
        }



        internal static bool HasCueLinkCallback
        {
            get
            {
                return default(bool);
            }
        }



        public static bool CueSheetsAreLoading
        {
            get
            {
                return default(bool);
            }
        }



        internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback
        {
            add
            {
            }

            remove
            {
            }
        }



        internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback
        {
            add
            {
            }

            remove
            {
            }
        }



        internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback
        {
            add
            {
            }

            remove
            {
            }
        }



        public static int GetThreadPriorityANDROID()
        {
            return default(int);
        }



        public static void SetThreadPriorityANDROID(int prio)
        {
        }



        public static void DetachDspBusSetting()
        {
        }



        public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder, bool loadAwbOnMemory = false)
        {
            return null;
        }



        public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder, bool loadAwbOnMemory = false)
        {
            return null;
        }



        public static void SetCategoryVolume(int id, float volume)
        {
        }



        public static float GetCategoryVolume(string name)
        {
            return default(float);
        }



        public static float GetCategoryVolume(int id)
        {
            return default(float);
        }



        public static void SetBusAnalyzer(string busName, bool sw)
        {
        }



        public static void SetBusAnalyzer(bool sw)
        {
        }



        public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName)
        {
            return default(CriAtomExAsr.BusAnalyzerInfo);
        }



        [Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
        public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId)
        {
            return default(CriAtomExAsr.BusAnalyzerInfo);
        }



        private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory)
        {
        }



        private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory)
        {
        }



        [MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCbFunc))]
        public static void SequenceEventCallbackFromNative(string eventString)
        {
        }



        [MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCallback))]
        private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo)
        {
        }



        [MonoPInvokeCallback(typeof(CriAtomExBeatSync.CbFunc))]
        public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info)
        {
        }



        [MonoPInvokeCallback(typeof(CriAtomEx.CueLinkCbFunc))]
        public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info)
        {
        }



        public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator)
        {
        }



        private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func)
        {
        }



        private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func)
        {
        }



        public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func)
        {
        }



        private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func)
        {
        }



        private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func)
        {
        }



        private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func)
        {
        }



        private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func)
        {
        }



        public CriAtom()
        {
        }
    }
}
