namespace CriWare
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::AOT;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CRI Atom")]
    public class CriAtom : CriMonoBehaviour
    {
        protected class NativeMethods
        {
            [PreserveSig]
            internal static extern int criAtom_GetThreadPriority_ANDROID();
            [PreserveSig]
            internal static extern void criAtom_SetThreadPriority_ANDROID(int prio);
            public NativeMethods()
            {
            }
        }

        public enum SpeakerMapping
        {
            Auto,
            Monaural,
            Stereo,
            Ch5_1,
            Ch7_1,
            Ch5_1_2,
            Ch7_1_2,
            Ch7_1_4,
            Ch7_1_4_4,
            Ambisonics1p,
            Ambisonics2p,
            Ambisonics3p,
            Object,
            Custom
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass68_0
        {
            public CriAtom _003C_003E4__this;
            public int i;
            public Predicate<CriAtomCueSheet> _003C_003E9__0;
            public _003C_003Ec__DisplayClass68_0()
            {
            }

            internal bool _003CMargeCueSheet_003Eb__0(CriAtomCueSheet sheet)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003CLoadAcbDataCoroutine_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriAtomCueSheet cueSheet;
            public string awbPath;
            public CriFsBinder awbBinder;
            public CriAtom _003C_003E4__this;
            public byte[] acbData;
            public bool loadAwbOnMemory;
            private CriAtomExAcbLoader _003CasyncLoader_003E5__2;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CLoadAcbDataCoroutine_003Ed__74(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            private void _003C_003Em__Finally1()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CLoadAcbFileCoroutine_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriAtomCueSheet cueSheet;
            public CriFsBinder binder;
            public string acbPath;
            public string awbPath;
            public CriAtom _003C_003E4__this;
            public bool loadAwbOnMemory;
            private CriAtomExAcbLoader _003CasyncLoader_003E5__2;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CLoadAcbFileCoroutine_003Ed__72(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            private void _003C_003Em__Finally1()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public string acfFile;
        private bool acfIsLoading;
        public CriAtomCueSheet[] cueSheets;
        public string dspBusSetting;
        public bool dontDestroyOnLoad;
        private static CriAtomExSequencer.EventCallback eventUserCallback;
        private static CriAtomExSequencer.EventCbFunc eventUserCbFunc;
        [CompilerGenerated]
        private static CriAtomExBeatSync.CbFunc m_beatsyncUserCbFunc;
        private static CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc;
        [CompilerGenerated]
        private static CriAtomEx.CueLinkCbFunc m_cueLinkUserCbFunc;
        [CompilerGenerated]
        private static CriAtom _003Cinstance_003Ek__BackingField;
        private GCHandle acfRegisterGCHandle;
        public bool dontRemoveExistsCueSheet;
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

        private static CriAtom instance
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
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

        private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
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

        private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
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

        public static void AttachDspBusSetting(string settingName)
        {
        }

        public static void DetachDspBusSetting()
        {
        }

        public static CriAtomCueSheet GetCueSheet(string name)
        {
            return null;
        }

        public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder)
        {
            return null;
        }

        public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder, bool loadAwbOnMemory = false)
        {
            return null;
        }

        public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder)
        {
            return null;
        }

        public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder, bool loadAwbOnMemory = false)
        {
            return null;
        }

        public static void RemoveCueSheet(string name)
        {
        }

        public static CriAtomExAcb GetAcb(string cueSheetName)
        {
            return null;
        }

        public static void SetCategoryVolume(string name, float volume)
        {
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

        public void Setup()
        {
        }

        public void Shutdown()
        {
        }

        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        private void OnDestroy()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        public CriAtomCueSheet GetCueSheetInternal(string name)
        {
            return null;
        }

        public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder)
        {
            return null;
        }

        public void RemoveCueSheetInternal(string name)
        {
        }

        private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet)
        {
        }

        private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile)
        {
            return null;
        }

        private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile)
        {
            return null;
        }

        private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadAcbFileCoroutine_003Ed__72))]
        private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory)
        {
            return null;
        }

        private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadAcbDataCoroutine_003Ed__74))]
        private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory)
        {
            return null;
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
