using System;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomCueSheet (TypeDefIndex 31666).
    [Serializable]
    public partial class CriAtomCueSheet
    {
        public string name = "";
        public string acbFile = "";
        public string awbFile = "";
        public CriAtomExAcb acb;
        public CriAtomExAcbLoader.Status loaderStatus;
    }

    // CriWare.CriAtomExAcbLoader: only the status enum is on the StreamingLive paths.
    public partial class CriAtomExAcbLoader
    {
        public enum Status
        {
            Stop = 0,
            Loading = 1,
            Complete = 2,
            Error = 3
        }
    }

    // CriWare.CriAtom (TypeDefIndex 31660): the cue sheet registry component (one instance) and the static cue sheet
    // API. The user callbacks (sequence events, beat sync, cue link) are not used on the StreamingLive paths; their
    // fields are only null-checked there, so they are typed as Delegate.
    [AddComponentMenu("CRIWARE/CRI Atom")]
    public partial class CriAtom : CriMonoBehaviour
    {
        public enum SpeakerMapping
        {
            Auto = 0,
            Monaural = 1,
            Stereo = 2,
            Ch5_1 = 3,
            Ch7_1 = 4,
            Ch5_1_2 = 5,
            Ch7_1_2 = 6,
            Ch7_1_4 = 7,
            Ambisonics1p = 8
        }

        public string acfFile = "";
        private bool acfIsLoading;
        public CriAtomCueSheet[] cueSheets = new CriAtomCueSheet[0];
        public string dspBusSetting = "";
        public bool dontDestroyOnLoad;
        internal static Delegate eventUserCallback;
        internal static Delegate eventUserCbFunc;
        internal static Delegate beatsyncUserCbFunc;
        internal static Delegate obsoleteBeatSyncFunc;
        internal static Delegate cueLinkUserCbFunc;
        private GCHandle acfRegisterGCHandle;
        public bool dontRemoveExistsCueSheet;

        private static CriAtom instance { get; set; }

        public static void AttachDspBusSetting(string settingName)
        {
            instance.dspBusSetting = settingName;
            if (string.IsNullOrEmpty(settingName))
                CriAtomEx.DetachDspBusSetting();
            else
                CriAtomEx.AttachDspBusSetting(settingName);
        }

        public static CriAtomCueSheet GetCueSheet(string name)
        {
            return instance.GetCueSheetInternal(name);
        }

        public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null)
        {
            var cueSheet = instance.AddCueSheetInternal(name, acbFile, awbFile, binder);
            if (Application.isPlaying)
                cueSheet.acb = instance.LoadAcbFile(binder, acbFile, awbFile);
            return cueSheet;
        }

        public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null)
        {
            var cueSheet = instance.AddCueSheetInternal(name, "", awbFile, awbBinder);
            if (Application.isPlaying)
                cueSheet.acb = instance.LoadAcbData(acbData, awbBinder, awbFile);
            return cueSheet;
        }

        public static void RemoveCueSheet(string name)
        {
            if (instance == null)
                return;
            instance.RemoveCueSheetInternal(name);
        }

        public static CriAtomExAcb GetAcb(string cueSheetName)
        {
            foreach (var cueSheet in instance.cueSheets)
            {
                if (cueSheetName == cueSheet.name)
                    return cueSheet.acb;
            }
            Debug.LogWarning("[CRIWARE] Cue sheet named \"" + cueSheetName + "\" is not loaded.");
            return null;
        }

        public static void SetCategoryVolume(string name, float volume)
        {
            CriAtomExCategory.criAtomExCategory_SetVolumeByName(name, volume);
        }

        private void Setup()
        {
            if (instance != null && instance != this)
            {
                var obj = instance.gameObject;
                instance.Shutdown();
                CriAtomEx.UnregisterAcf();
                Destroy(obj);
            }
            instance = this;
            CriAtomPlugin.InitializeLibrary();
            if (!string.IsNullOrEmpty(acfFile))
                CriAtomEx.RegisterAcf(null, Path.Combine(Common.streamingAssetsPath, acfFile));
            if (!string.IsNullOrEmpty(dspBusSetting))
                AttachDspBusSetting(dspBusSetting);
            foreach (var cueSheet in cueSheets)
                cueSheet.acb = LoadAcbFile(null, cueSheet.acbFile, cueSheet.awbFile);
            // Haruki: on a child (CriCore.Setup's CRIWARE object) Unity ignores it with a warning; the root persists.
            if (dontDestroyOnLoad && transform.parent == null)
                DontDestroyOnLoad(gameObject);
        }

        private void Shutdown()
        {
            foreach (var cueSheet in cueSheets)
            {
                if (cueSheet.acb != null)
                {
                    cueSheet.acb.Dispose();
                    cueSheet.acb = null;
                }
            }
            CriAtomPlugin.FinalizeLibrary();
            if (instance == this)
                instance = null;
        }

        private void Awake()
        {
            if (instance == null || instance == this)
                return;
            if (instance.acfFile != acfFile)
            {
                var obj = instance.gameObject;
                instance.Shutdown();
                CriAtomEx.UnregisterAcf();
                Destroy(obj);
                return;
            }
            if (instance.dspBusSetting != dspBusSetting)
                AttachDspBusSetting(dspBusSetting);
            instance.MargeCueSheet(cueSheets, dontRemoveExistsCueSheet);
            Destroy(gameObject);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            if (instance == null)
                Setup();
        }

        private void OnDestroy()
        {
            if (this != instance)
                return;
            if (beatsyncUserCbFunc != null)
            {
                beatsyncUserCbFunc = null;
                CriAtomPlugin.CRIWARE8BB08498(IntPtr.Zero);
            }
            if (acfRegisterGCHandle.IsAllocated)
            {
                CriAtomEx.UnregisterAcf();
                acfRegisterGCHandle.Free();
            }
            Shutdown();
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet)
        {
            if (!newDontRemoveExistsCueSheet)
            {
                for (var i = 0; i < cueSheets.Length;)
                {
                    if (Array.FindIndex(newCueSheets, sheet => sheet.name == cueSheets[i].name) < 0)
                        RemoveCueSheet(cueSheets[i].name);
                    else
                        i++;
                }
            }
            foreach (var newCueSheet in newCueSheets)
            {
                if (GetCueSheetInternal(newCueSheet.name) == null)
                    AddCueSheet(null, newCueSheet.acbFile, newCueSheet.awbFile, null);
            }
        }

        private CriAtomCueSheet GetCueSheetInternal(string name)
        {
            for (var i = 0; i < cueSheets.Length; i++)
            {
                var cueSheet = cueSheets[i];
                if (cueSheet.name == name)
                    return cueSheet;
            }
            return null;
        }

        private CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder)
        {
            var newCueSheets = new CriAtomCueSheet[cueSheets.Length + 1];
            cueSheets.CopyTo(newCueSheets, 0);
            cueSheets = newCueSheets;
            var cueSheet = new CriAtomCueSheet();
            cueSheets[cueSheets.Length - 1] = cueSheet;
            if (string.IsNullOrEmpty(name))
                name = Path.GetFileNameWithoutExtension(acbFile);
            cueSheet.name = name;
            cueSheet.acbFile = acbFile;
            cueSheet.awbFile = awbFile;
            return cueSheet;
        }

        private void RemoveCueSheetInternal(string name)
        {
            var index = -1;
            for (var i = 0; i < cueSheets.Length; i++)
            {
                if (name == cueSheets[i].name)
                    index = i;
            }
            if (index < 0)
                return;
            var cueSheet = cueSheets[index];
            if (cueSheet.acb != null)
            {
                cueSheet.acb.Dispose();
                cueSheet.acb = null;
            }
            var newCueSheets = new CriAtomCueSheet[cueSheets.Length - 1];
            Array.Copy(cueSheets, 0, newCueSheets, 0, index);
            Array.Copy(cueSheets, index + 1, newCueSheets, index, cueSheets.Length - index - 1);
            cueSheets = newCueSheets;
        }

        private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile)
        {
            if (string.IsNullOrEmpty(acbFile))
                return null;
            if (binder != null)
            {
                string.IsNullOrEmpty(awbFile);
            }
            else
            {
                if (Common.IsStreamingAssetsPath(acbFile))
                    acbFile = Path.Combine(Common.streamingAssetsPath, acbFile);
                if (!string.IsNullOrEmpty(awbFile) && Common.IsStreamingAssetsPath(awbFile))
                    awbFile = Path.Combine(Common.streamingAssetsPath, awbFile);
            }
            return CriAtomExAcb.LoadAcbFile(binder, acbFile, awbFile);
        }

        private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile)
        {
            if (acbData == null)
                return null;
            if (binder == null && !string.IsNullOrEmpty(awbFile) && Common.IsStreamingAssetsPath(awbFile))
                awbFile = Path.Combine(Common.streamingAssetsPath, awbFile);
            return CriAtomExAcb.LoadAcbData(acbData, binder, awbFile);
        }
    }
}
