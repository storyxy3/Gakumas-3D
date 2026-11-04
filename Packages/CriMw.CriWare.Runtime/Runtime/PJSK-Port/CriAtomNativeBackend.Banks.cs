using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class Bank
        {
            internal IntPtr Handle;
            internal CriAtomAcbData Sheet;
            internal readonly Dictionary<int, List<Playback>> CueLimits = new Dictionary<int, List<Playback>>();
        }
        private readonly List<Bank> banks = new List<Bank>();

        public bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize)
        {
            if (binder != IntPtr.Zero) { Report("E-HARUKI-UNSUPPORTED:CRI Fs binders are not available to the managed backend."); return false; }
            byte[] bytes;
            try { bytes = readFile(path); }
            catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException)
            { Report("E2011030340:Failed to load ACF file. (" + path + ")"); return false; }
            return bytes != null && criAtomEx_RegisterAcfData(bytes, bytes.Length, work, workSize);
        }

        public bool criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize)
        {
            RequireAutomaticWork(work, workSize);
            if (!RequireAtom()) return false;
            if (acfData == null || acfDataSize < 0 || acfDataSize > acfData.Length) return false;
            CriAtomUtf.Table table;
            try { table = CriAtomUtf.Table.Parse(new ArraySegment<byte>(acfData, 0, acfDataSize)); }
            catch (InvalidDataException exception) { Report("E2010111710:Invalid ACF data. (" + exception.Message + ")"); return false; }
            if (table.RowCount != 1) { Report("E2010111710:Invalid ACF data. (Expected one ACF header row.)"); return false; }
            var root = table.GetRow(0);
            acf = root;
            aisacControls.Clear();
            var controls = CriAtomMixer.ReadTable(root, "AisacControlNameTable");
            uint version = root.Get<uint>("Version");
            for (int i = 0; i < controls.RowCount; i++)
            {
                var row = controls.GetRow(i);
                uint id = Convert.ToUInt32(row["AisacControlId"]);
                if (version < 0x810000 && id >= 10000) id -= 10000;
                else if (version < 0x1270000 && id >= 1000) id -= 1000;
                aisacControls.Add(row.Get<string>("AisacControlName"), id + 65536);
            }
            InstallCategories(root);
            InstallAisacs(root);
            var options = CriAtomMixer.ReadTable(root, "RegistrationOption").GetRow(0);
            string setting = options.Get<string>("DefaultDspBusSettingName");
            if (!string.IsNullOrEmpty(setting)) criAtomEx_AttachDspBusSetting(setting, IntPtr.Zero, 0);
            return true;
        }

        public void criAtomEx_UnregisterAcf()
        {
            if (acf.HasValue) StopAllPlaybacks();
            acf = null;
            aisacControls.Clear();
            ClearCategories();
            ClearAisacs();
            criAtomEx_DetachDspBusSetting();
        }
        public void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize)
        {
            RequireAutomaticWork(work, workSize);
            if (!RequireAtom()) return;
            CriAtomMixer value;
            try { value = new CriAtomMixer(acf, settingName, SampleRate, Report); }
            catch (Exception exception) when (exception is InvalidDataException || exception is NotSupportedException)
            {
                // C8: an unusable DSP bus setting is reported; the current mixer stays.
                Report("E-HARUKI-UNSUPPORTED:DSP bus setting " + settingName + " is not attached. (" + exception.Message + ")");
                return;
            }
            mixer = value; dspSetting = settingName;
        }
        public void criAtomEx_DetachDspBusSetting()
        {
            mixer = new CriAtomMixer(null, null, SampleRate);
            dspSetting = null;
        }

        public IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path,
            IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            if (!RequireAtom()) return IntPtr.Zero;
            if (acb_binder != IntPtr.Zero || awb_binder != IntPtr.Zero || !string.IsNullOrEmpty(awb_path))
            {
                Report("E-HARUKI-UNSUPPORTED:Binders and external AWB files are not available to the managed backend. (" + acb_path + ")");
                return IntPtr.Zero;
            }
            byte[] bytes;
            try { bytes = readFile(acb_path); }
            catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException)
            { Report("E2011030341:Failed to load ACB file. (" + acb_path + ")"); return IntPtr.Zero; }
            return LoadBank(bytes);
        }
        public IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path,
            IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            if (!RequireAtom() || acb_data == IntPtr.Zero || acb_data_size < 1) return IntPtr.Zero;
            if (awb_binder != IntPtr.Zero || !string.IsNullOrEmpty(awb_path))
            {
                Report("E-HARUKI-UNSUPPORTED:Binders and external AWB files are not available to the managed backend. (" + awb_path + ")");
                return IntPtr.Zero;
            }
            var bytes = new byte[acb_data_size];
            Marshal.Copy(acb_data, bytes, 0, bytes.Length);
            return LoadBank(bytes);
        }
        private IntPtr LoadBank(byte[] bytes)
        {
            if (bytes == null) return IntPtr.Zero;
            CriAtomAcbData sheet;
            try { sheet = CriAtomAcbData.Parse(new ArraySegment<byte>(bytes)); }
            catch (Exception exception) when (exception is InvalidDataException || exception is NotSupportedException)
            { Report("E2010111711:Invalid ACB data. (" + exception.Message + ")"); return IntPtr.Zero; }
            var value = new Bank { Sheet = sheet };
            value.Handle = AddObject(value);
            banks.Add(value);
            return value.Handle;
        }
        public void criAtomExAcb_Release(IntPtr acb_hn)
        {
            var bank = Get<Bank>(acb_hn);
            if (bank == null) return;
            StopBankPlaybacks(bank);
            DrainBankSounds(bank);
            foreach (var player in players)
                if (player.Bank == bank) { player.Bank = null; player.Cue = null; }
            banks.Remove(bank);
            objects.Remove(acb_hn);
        }
        public int criAtomExAcb_GetNumCues(IntPtr acb_hn) => Get<Bank>(acb_hn)?.Sheet.Cues.Count ?? 0;
        public bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info)
        {
            var bank = Get<Bank>(acb_hn);
            if (bank == null || index < 0 || index >= bank.Sheet.Cues.Count || info == IntPtr.Zero) return false;
            var cue = bank.Sheet.GetCue(index);
            bool wide = IntPtr.Size == 8;
            var bytes = new byte[wide ? 176 : 160];
            using (var stream = new MemoryStream(bytes))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(cue.Id); writer.Write(cue.Type);
                WritePointer(writer, StringPointer(cue.Name)); WritePointer(writer, StringPointer(cue.UserData));
                writer.Write(cue.Length);
                for (int i = 0; i < 16; i++) writer.Write(i < cue.CategoryIds.Count ? (ushort)cue.CategoryIds[i] : ushort.MaxValue);
                writer.Write(cue.NumLimits); writer.Write((ushort)0); writer.Write(cue.NumTracks); writer.Write(cue.NumRelatedWaveforms);
                writer.Write(cue.Priority); writer.Write(cue.HeaderVisibility); writer.Write(cue.IgnorePlayerParameter); writer.Write(cue.Probability);
                writer.Write(cue.PanType);
                writer.Write(cue.ConeInsideAngle); writer.Write(cue.ConeOutsideAngle);
                writer.Write(cue.MinAttenuationDistance); writer.Write(cue.MaxAttenuationDistance);
                writer.Write(cue.SourceRadius); writer.Write(cue.InteriorDistance); writer.Write(cue.DopplerFactor);
                writer.Write(0); writer.Write(-1); writer.Write(0f); writer.Write(0f); writer.Write(0f);
                for (int i = 0; i < 5; i++) writer.Write(uint.MaxValue);
                if (wide) writer.Write(0);
                WritePointer(writer, StringPointer(string.Empty)); writer.Write(65535u); writer.Write(0f);
                writer.Write(cue.Volume); writer.Write(0);
            }
            Marshal.Copy(bytes, 0, info, bytes.Length);
            return true;
        }
        public bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info)
        {
            var bank = Get<Bank>(acb_hn);
            if (bank == null || name == null || waveform_info == IntPtr.Zero || !bank.Sheet.TryGetCue(name, out var cue) ||
                !bank.Sheet.TryGetWaveformInfo(cue, out var wave)) return false;
            var bytes = new byte[32];
            using (var stream = new MemoryStream(bytes))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(wave.Id); writer.Write(wave.Format); writer.Write(wave.SamplingRate); writer.Write(wave.Channels);
                writer.Write((long)wave.NumSamples); writer.Write(wave.Streaming ? 1 : 0); writer.Write(0);
            }
            Marshal.Copy(bytes, 0, waveform_info, bytes.Length);
            return true;
        }
        private static void WritePointer(BinaryWriter writer, IntPtr pointer)
        {
            if (IntPtr.Size == 8) writer.Write(pointer.ToInt64());
            else writer.Write(pointer.ToInt32());
        }
        private Bank FindBank(IntPtr handle, string cueName, out CriAtomAcbData.Cue cue)
        {
            cue = null;
            if (cueName == null) return null;
            if (handle != IntPtr.Zero)
            {
                var selected = Get<Bank>(handle);
                return selected != null && selected.Sheet.TryGetCue(cueName, out cue) ? selected : null;
            }
            // Native global lookup is newest first. SoundManager's first-name
            // CueTable remains a separate, unchanged game-level lookup.
            for (int i = banks.Count - 1; i >= 0; i--)
                if (banks[i].Sheet.TryGetCue(cueName, out cue)) return banks[i];
            return null;
        }
    }
}
