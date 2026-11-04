using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class Parameters
        {
            internal readonly List<KeyValuePair<uint, float>> Values = new List<KeyValuePair<uint, float>>();
            internal Parameters() { }
            internal Parameters(Parameters source) { Values.AddRange(source.Values); }
            internal bool TryGet(uint id, out float value)
            {
                foreach (var entry in Values) if (entry.Key == id) { value = entry.Value; return true; }
                value = 0f; return false;
            }
            internal float Get(uint id, float fallback) => TryGet(id, out var value) ? value : fallback;
            internal bool Set(uint id, float value)
            {
                for (int i = 0; i < Values.Count; i++)
                    if (Values[i].Key == id) { Values[i] = new KeyValuePair<uint, float>(id, value); return true; }
                if (Values.Count == 64) return false;
                Values.Add(new KeyValuePair<uint, float>(id, value)); return true;
            }
            internal void Remove(uint id)
            {
                for (int i = 0; i < Values.Count; i++)
                    if (Values[i].Key == id) { Values[i] = Values[Values.Count - 1]; Values.RemoveAt(Values.Count - 1); return; }
            }
        }
        private sealed class Player
        {
            internal ManaAudioSource ManaAudio;
            internal CriAtomExPlayer.Config Config;
            internal Parameters Pending = new Parameters();
            internal CriAtomAcbData.SelectionState Random;
            internal readonly List<Playback> Playbacks = new List<Playback>();
            internal Bank Bank;
            internal CriAtomAcbData.Cue Cue;
            internal CriAtomFader Fader;
            internal CriAtomExPlayer.Status Status;
            internal bool Played;
            internal long StartTimeUs;
            internal IntPtr Source, Listener;
            internal CriAtomEx.SoundRendererType Renderer;
            internal bool Paused;                 // player +445
            internal uint LastStartedId = uint.MaxValue; // player +484
            internal Analyzer Analyzer;           // player +552/+560 filter callback (AttachExPlayer 0x349F0)
        }
        private sealed class Playback
        {
            internal uint Id;
            internal long SequenceOrder;
            internal Player Owner;
            internal Bank Bank;
            internal CriAtomAcbData.Cue Cue;
            internal Parameters Snapshot;
            internal IReadOnlyList<CriAtomAcbData.WaveEvent> Plan;
            internal CriAtomSequenceClock SequenceClock;
            internal readonly List<AudioGroup> AudioGroups = new List<AudioGroup>();
            internal readonly List<Voice> Voices = new List<Voice>();
            internal int NextEvent;
            internal long StartTimeUs, ElapsedFrames, FirstOutputFrame = -1;
            internal bool Prepared, Stopping, Incoming, Outgoing, Counted, CountedUnpaused, SequenceFinished;
            // playback +168: user pause 0x1, Prepare 0x2, fader hold 0x10000.
            internal uint PauseMask;
            // Attached-fader playbacks keep the established whole-plan queue;
            // their sequence clock only supplies GetTime.
            internal bool ImmediatePlan, TrackServiced;
            internal bool FaderHeld => (PauseMask & FaderHoldMask) != 0;
            internal float FaderGain = 1f;
            internal CriAtomExPlayback.Status Status = CriAtomExPlayback.Status.Prep;
            internal readonly List<int> Categories = new List<int>();
            internal readonly List<int> CueLimits = new List<int>();
        }
        private readonly List<Player> players = new List<Player>();
        private Playback[] playbacks;
        private ushort[] generations;
        private Queue<int> freePlaybackSlots;
        private CriAtomAcbData.RandomState globalRandom;
        private long nextSequenceOrder;

        private void InitializePlaybackPool()
        {
            voiceSlots = new VoiceSlot[memoryVoices + streamingVoices];
            for (int i = 0; i < voiceSlots.Length; i++) voiceSlots[i] = new VoiceSlot();
            playbacks = new Playback[virtualVoices]; generations = new ushort[virtualVoices];
            freePlaybackSlots = new Queue<int>();
            for (int i = 0; i < virtualVoices; i++) freePlaybackSlots.Enqueue(i);
            // The original default seed is the low 32 bits of monotonic ns.
            uint seed = unchecked((uint)(long)(Stopwatch.GetTimestamp() * (1000000000d / Stopwatch.Frequency)));
            globalRandom = new CriAtomAcbData.RandomState(seed);
        }
        private void ResetRandomSeed(uint seed) => globalRandom = new CriAtomAcbData.RandomState(seed);
        private Playback FindPlayback(uint id)
        {
            if ((id & 0x80000001u) != 1 || (id & 0x8000u) != 0 || playbacks == null) return null;
            int slot = (int)(id >> 16);
            return slot < playbacks.Length && generations[slot] == (id & 0x7fff) ? playbacks[slot] : null;
        }
        public IntPtr criAtomExPlayer_Create(ref CriAtomExPlayer.Config config, IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            if (!RequireAtom()) return IntPtr.Zero;
            var player = new Player { Config = config, Random = CriAtomAcbData.SelectionState.CreatePlayer(globalRandom) };
            players.Add(player);
            return AddObject(player);
        }
        public void criAtomExPlayer_Destroy(IntPtr player)
        {
            var value = Get<Player>(player);
            if (value == null) return;
            StopPlayer(value, true);
            players.Remove(value); objects.Remove(player);
        }
        public void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name)
        {
            var value = Get<Player>(player);
            if (value == null) return;
            value.Bank = FindBank(acb_hn, cue_name, out var cue); value.Cue = cue;
            if (cue == null) Report("E:Requested cue was not found: " + cue_name);
        }
        // criAtomExPlayer_Start -> sub_EFCB4. Content the managed renderer cannot
        // reproduce is reported through criErr and returns the invalid ID, the
        // form of every native Start failure (C8); it never throws into game code.
        public uint criAtomExPlayer_Start(IntPtr player)
        {
            var value = Get<Player>(player);
            if (value == null) return uint.MaxValue;
            if (value.Cue == null || value.Bank == null || !banks.Contains(value.Bank))
            {
                Report("W2010021604:Need to set data before starting playback.");
                return uint.MaxValue;
            }
            if (value.Cue.PanType == 1)
            {
                ReportOnce("W-HARUKI-POS3D", value.Bank, value.Cue, "Pos3d positioning is not rendered by the managed backend.");
                return uint.MaxValue;
            }
            if (freePlaybackSlots.Count == 0) return uint.MaxValue;
            IReadOnlyList<CriAtomAcbData.WaveEvent> plan;
            int skippedWaves;
            try { plan = value.Bank.Sheet.CreatePlan(value.Cue, value.Random, out skippedWaves); }
            catch (Exception exception) when (exception is NotSupportedException || exception is InvalidDataException)
            {
                ReportOnce("E-HARUKI-UNSUPPORTED", value.Bank, value.Cue, exception.Message);
                return uint.MaxValue;
            }
            if (skippedWaves != 0)
                ReportOnce("W-HARUKI-STREAMWAVE", value.Bank, value.Cue, skippedWaves + " streaming or non-HCA waves are skipped.");
            if (value.Fader != null)
                foreach (var wave in plan)
                    if (wave.TimeUs != 0)
                    {
                        ReportOnce("E-HARUKI-UNSUPPORTED", value.Bank, value.Cue, "Delayed waves on a fader player are not rendered by the managed backend.");
                        return uint.MaxValue;
                    }
            int slot = freePlaybackSlots.Dequeue();
            generations[slot] = (ushort)((generations[slot] + 1) & 0x7fff);
            var playback = new Playback
            {
                Id = ((uint)slot << 16) | generations[slot], Owner = value, SequenceOrder = nextSequenceOrder++,
                Bank = value.Bank, Cue = value.Cue, Snapshot = new Parameters(value.Pending),
                StartTimeUs = value.StartTimeUs, Plan = plan, ImmediatePlan = value.Fader != null,
                // EFCB4: the initial mask is the player's pause flag (+445);
                // F0F20 ORs the fader hold 0x10000 before the fader start callback.
                PauseMask = (value.Paused ? UserPauseMask : 0u) | (value.Fader != null ? FaderHoldMask : 0u),
                SequenceClock = new CriAtomSequenceClock(value.StartTimeUs)
            };
            playbacks[slot] = playback; value.Playbacks.Add(playback);
            value.Played = true; value.Status = CriAtomExPlayer.Status.Prep;
            value.LastStartedId = playback.Id;
            if (!ReserveCueLimits(playback) || !ReserveCategories(playback)) StopPlayback(playback, false);
            if (value.Fader != null)
            {
                // F0F20: the fader's own pause byte receives the start pause flag.
                value.Fader.SetPaused(value.Paused);
                value.Fader.Start(playback.Id);
            }
            return playback.Id;
        }

        private readonly HashSet<string> reportedContent = new HashSet<string>(StringComparer.Ordinal);
        private void ReportOnce(string code, Bank bank, CriAtomAcbData.Cue cue, string reason)
        {
            string key = code + ":" + bank.GetHashCode() + ":" + cue.Name;
            if (reportedContent.Add(key)) Report(code + ":" + cue.Name + ":" + reason);
        }

        public const uint UserPauseMask = 0x1, PreparePauseMask = 0x2, FaderHoldMask = 0x10000;

        // Resume mode table dword_1E3F50: AllPlayback, PausedPlayback,
        // PreparedPlayback and the internal fader mode 3.
        private static uint ResumeMask(int mode) => mode == 0 ? 0xFFFFu : mode == 1 ? UserPauseMask :
            mode == 2 ? PreparePauseMask : mode == 3 ? FaderHoldMask : 0u;

        // criAtomExPlayer_Pause 0xF2468: Pause(true) sets +445 and ORs 0x1 into
        // every linked playback; Pause(false) clears +445 and the low 16 bits.
        public void criAtomExPlayer_Pause(IntPtr player, bool sw)
        {
            var value = Get<Player>(player);
            if (value == null) { Report("E2010042120:Invalid player handle."); return; }
            value.Paused = sw;
            foreach (var playback in value.Playbacks.ToArray())
                ChangePause(playback, sw ? UserPauseMask : 0xFFFFu, sw);
        }

        // criAtomExPlayer_Resume 0xF2674: modes 0 and 1 clear the player flag;
        // mode 2 keeps it; any other value clears no playback bit.
        public void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode)
        {
            var value = Get<Player>(player);
            if (value == null) { Report("E2011101801:Invalid player handle."); return; }
            int raw = (int)mode;
            uint mask = raw == 0 ? 0xFFFFu : raw == 1 ? UserPauseMask : raw == 2 ? PreparePauseMask : 0u;
            if (raw == 0 || raw == 1) value.Paused = false;
            foreach (var playback in value.Playbacks.ToArray()) ChangePause(playback, mask, false);
        }

        // criAtomExPlayer_IsPaused 0xF25F8: without playbacks the player flag;
        // otherwise true only when every linked playback has a nonzero mask.
        public bool criAtomExPlayer_IsPaused(IntPtr player)
        {
            var value = Get<Player>(player);
            if (value == null) { Report("E2010100111:Invalid player handle."); return false; }
            if (value.Playbacks.Count == 0) return value.Paused;
            foreach (var playback in value.Playbacks) if ((ushort)playback.PauseMask == 0) return false; // reads the 16-bit word +168
            return true;
        }

        // criAtomExPlayback_Pause 0xF27EC / _Resume 0xF2A6C / _IsPaused 0xF2A48.
        public void criAtomExPlayback_Pause(uint id, bool sw)
        {
            var playback = FindPlayback(id);
            if (playback != null) ChangePause(playback, sw ? UserPauseMask : 0xFFFFu, sw);
        }
        public void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode)
        {
            var playback = FindPlayback(id);
            if (playback != null) ChangePause(playback, (uint)mode > 3 ? 0u : ResumeMask((int)mode), false);
        }
        public bool criAtomExPlayback_IsPaused(uint id)
        {
            var playback = FindPlayback(id);
            return playback != null && (ushort)playback.PauseMask != 0;
        }

        // sub_F2964: update +168, mirror the low 16 bits into the player's fader
        // pause byte when this is its current playback, and propagate a
        // zero/nonzero transition to every sound group (1000E8 -> A132C ->
        // A4F34 group +58 bit 0). Category counts follow on the next server
        // pass (FCA2C). Prepare bookkeeping (100148) needs criAtomExPlayer_Prepare,
        // which the ported game paths never call.
        private void ChangePause(Playback playback, uint mask, bool set)
        {
            uint previous = playback.PauseMask;
            uint current = set ? previous | mask : previous & ~mask;
            playback.PauseMask = current;
            var owner = playback.Owner;
            if (owner.Fader != null)
            {
                var latest = FindPlayback(owner.LastStartedId);
                if (latest == null || latest == playback) owner.Fader.SetPaused((byte)current != 0);
            }
            if ((previous == 0) == (current == 0)) return;
            foreach (var group in playback.AudioGroups) group.SoundPaused = current != 0;
            if (current == 0)
            {
                // A playback that never produced output (held from Start) begins
                // exactly like an unheld start; a paused one ramps back up.
                bool started = false;
                foreach (var voice in playback.Voices) if (voice.FirstSourceOutputFrame >= 0) { started = true; break; }
                if (!started && playback.Prepared)
                {
                    long delay = renderedFrames - playback.FirstOutputFrame;
                    playback.FirstOutputFrame = renderedFrames;
                    foreach (var voice in playback.Voices)
                    {
                        voice.StartOutputFrame += delay;
                        voice.LastGain = VoiceGain(playback, voice.Event);
                    }
                }
            }
        }
        public void criAtomExPlayer_Stop(IntPtr player) { var value = Get<Player>(player); if (value != null) StopPlayer(value, false); }
        public void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player) { var value = Get<Player>(player); if (value != null) StopPlayer(value, true); }
        private void StopPlayer(Player player, bool immediate)
        {
            if (player.ManaAudio != null) StopManaAudioSource(player.ManaAudio);
            player.Played = false;
            foreach (var playback in player.Playbacks.ToArray())
                if (immediate || player.Fader == null || !playback.Incoming) StopPlayback(playback, immediate);
            if (immediate) player.Fader?.AfterStopWithoutReleaseTime();
            else player.Fader?.Stop();
            if (player.Playbacks.Count == 0) player.Status = CriAtomExPlayer.Status.Stop;
        }
        private void StopPlayback(Playback playback, bool immediate)
        {
            if (playback == null) return;
            ReleaseCueLimits(playback);
            if (immediate) { RemovePlayback(playback); return; }
            playback.Stopping = true;
            ReleaseCategoryLimits(playback);
            foreach (var voice in playback.Voices) voice.ReleaseRequested = true;
        }
        private void StopAllPlaybacks()
        {
            foreach (var player in players.ToArray()) StopPlayer(player, true);
            ClearManaAudioSources();
        }
        private void StopBankPlaybacks(Bank bank)
        {
            if (playbacks == null) return;
            foreach (var playback in (Playback[])playbacks.Clone())
                if (playback?.Bank == bank) RemovePlayback(playback);
        }
        private void RemovePlayback(Playback playback)
        {
            int slot = (int)(playback.Id >> 16);
            if (playbacks[slot] != playback) return;
            ReleaseCueLimits(playback);
            ReleaseCategories(playback);
            foreach (var voice in playback.Voices)
                DetachVoice(voice);
            playback.Voices.Clear();
            playback.Owner.Playbacks.Remove(playback);
            playbacks[slot] = null;
            generations[slot] = (ushort)((generations[slot] + 1) & 0x7fff);
            freePlaybackSlots.Enqueue(slot);
            if (playback.Owner.Playbacks.Count == 0)
                playback.Owner.Status = playback.Owner.Played ? CriAtomExPlayer.Status.PlayEnd : CriAtomExPlayer.Status.Stop;
        }
        public CriAtomExPlayer.Status criAtomExPlayer_GetStatus(IntPtr player)
        {
            var value = Get<Player>(player);
            if (value == null) return CriAtomExPlayer.Status.Error;
            if (value.Fader != null && value.Status == CriAtomExPlayer.Status.Playing && value.Fader.State == CriAtomFader.Phase.Waiting &&
                value.Fader.IncomingId != uint.MaxValue)
                return CriAtomExPlayer.Status.Prep;
            return value.Status;
        }
        public int criAtomExPlayback_GetStatus(uint id) => (int)(FindPlayback(id)?.Status ?? CriAtomExPlayback.Status.Removed);
        public void criAtomExPlayback_Stop(uint id) => StopPlayback(FindPlayback(id), false);
        public void criAtomExPlayback_StopWithoutReleaseTime(uint id)
        {
            var playback = FindPlayback(id);
            if (playback == null) return;
            // Unlike Player.StopWithoutReleaseTime, this API releases the group
            // synchronously but leaves the public record/category counts for
            // the next sequence/public server pass.
            ReleaseCueLimits(playback);
            ReleaseCategoryLimits(playback);
            playback.Stopping = true;
            foreach (var voice in playback.Voices) DetachVoice(voice);
            playback.Voices.Clear();
        }
        // criAtomExPlayback_GetTime 0xF2F48: the sequence clock time (DE694),
        // or the first sound group's server-time accounting (A14FC) when that
        // is negative; -1 for an unknown ID.
        public long criAtomExPlayback_GetTime(uint id)
        {
            var playback = FindPlayback(id);
            if (playback == null) return -1;
            if (playback.SequenceClock != null && playback.SequenceClock.TryGetTimeMs(out int time)) return time;
            var group = playback.AudioGroups.Count == 0 ? null : playback.AudioGroups[0];
            return group == null ? -1 : unchecked((int)group.PlainTimeMs);
        }

        // criAtomExPlayback_GetTimeSyncedWithAudio 0xF3248: F32D0 / 1000 when positive.
        public long criAtomExPlayback_GetTimeSyncedWithAudio(uint id)
        {
            long time = 0; float scale = 1f;
            criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(id, ref time, ref scale);
            return time;
        }

        public void criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(uint id, ref long playbackTime, ref float timeScale)
        {
            var playback = FindPlayback(id);
            playbackTime = -1; timeScale = 1f;
            if (playback == null) return;
            if (playback.Stopping && playback.Voices.Count == 0) return;
            if (!playback.Prepared) { playbackTime = 0; return; }
            GetPlaybackAudioTime(playback, out playbackTime, out timeScale);
        }
        private void SetParameter(IntPtr player, uint id, float value)
        {
            var target = Get<Player>(player);
            if (target != null && !target.Pending.Set(id, value)) Report("E2013100924:Player parameter capacity exceeded.");
        }
        public void criAtomExPlayer_SetVolume(IntPtr player, float volume) => SetParameter(player, 0, volume);
        public void criAtomExPlayer_SetPitch(IntPtr player, float pitch)
        {
            var value = Get<Player>(player);
            if (value == null) return;
            if (value.Config.enableAudioSyncedTimer && pitch != 0f) { Report("E:Pitch cannot be changed for an audio-synced timer player."); return; }
            SetParameter(player, 3, pitch);
        }
        public void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value)
        {
            if (control_name == null || !aisacControls.TryGetValue(control_name, out uint id)) { Report("E:AISAC control was not found: " + control_name); return; }
            SetParameter(player, id, Math.Max(0f, Math.Min(1f, control_value)));
        }
        public void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms)
        {
            var value = Get<Player>(player);
            if (value == null) return;
            if (start_time_ms < 0) { Report("E:Playback start time must be nonnegative."); return; }
            value.StartTimeUs = Math.Min(start_time_ms, uint.MaxValue) * 1000;
        }
        public void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority) => SetParameter(player, 149, Math.Max(-255, Math.Min(255, priority)));
        public void criAtomExPlayer_LimitLoopCount(IntPtr player, int count)
        {
            if (count < -3) { Report("E:Invalid Atom loop limit."); return; }
            SetParameter(player, 156, count);
        }
        public IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player) => Get<Player>(player) == null ? IntPtr.Zero : player;
        public void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id) => Get<Player>(player_parameter)?.Pending.Remove(id);
        public void criAtomExPlayer_Update(IntPtr player, uint id)
        {
            var value = Get<Player>(player); var playback = FindPlayback(id);
            if (value == null || playback == null || playback.Stopping) return;
            playback.Snapshot = new Parameters(value.Pending);
            UpdatePlaybackParameters(playback);
        }
        public void criAtomExPlayer_UpdateAll(IntPtr player)
        {
            var value = Get<Player>(player);
            if (value == null) return;
            UpdateManaAudioParameters(value);
            foreach (var playback in value.Playbacks.ToArray()) criAtomExPlayer_Update(player, playback.Id);
        }
        public void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source) { var value = Get<Player>(player); if (value != null) value.Source = source; }
        public void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener) { var value = Get<Player>(player); if (value != null) value.Listener = listener; }
        public void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type) { var value = Get<Player>(player); if (value != null) value.Renderer = type; }
        public void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType type)
        {
            if ((uint)type > 2) { Report("E2011012103:Invalid pan type."); return; }
            SetParameter(player, 100, (int)type);
        }
        public void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size)
        {
            RequireAutomaticWork(work, work_size);
            var value = Get<Player>(player);
            if (value == null || value.Fader != null) return;
            // With automatic work allocation the original permits more attached
            // faders than the initialization config's max_faders value.
            value.Fader = new CriAtomFader(id => (CriAtomExPlayback.Status)criAtomExPlayback_GetStatus(id), ApplyFaderCommand);
        }
        private void ApplyFaderCommand(CriAtomFader.Command command)
        {
            var playback = FindPlayback(command.PlaybackId);
            if (command.Kind == CriAtomFader.CommandKind.Error) { Report("E" + command.Argument + ":Invalid fader configuration."); return; }
            if (playback == null) return;
            switch (command.Kind)
            {
                case CriAtomFader.CommandKind.SetGain: playback.FaderGain = command.Gain; break;
                case CriAtomFader.CommandKind.StopPlayback: StopPlayback(playback, false); break;
                case CriAtomFader.CommandKind.MarkIncoming: playback.Incoming = true; break;
                case CriAtomFader.CommandKind.MarkOutgoing: playback.Outgoing = true; break;
                case CriAtomFader.CommandKind.ResumePreparedPlayback:
                    // EC400 -> F2BF4 mode 3 clears only the fader hold bit.
                    if (!playback.FaderHeld) break;
                    ChangePause(playback, FaderHoldMask, false);
                    if (playback.Counted && playback.PauseMask == 0 && !playback.CountedUnpaused)
                    {
                        foreach (int category in playback.Categories) categories.ChangePlayingCount(category, true, false, true);
                        playback.CountedUnpaused = true;
                    }
                    break;
            }
        }
        public void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms) { var value = Get<Player>(player); if (value?.Fader != null) value.Fader.FadeOutTimeMs = ms; else Report("E:Player has no fader."); }
        public void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms) { var value = Get<Player>(player); if (value?.Fader != null) value.Fader.FadeInTimeMs = ms; else Report("E:Player has no fader."); }
        public bool criAtomExPlayer_IsFading(IntPtr player) { var value = Get<Player>(player); return value?.Fader != null && value.Fader.IsFading(criAtomExPlayer_GetStatus(player)); }
        public void CRIWARE6BA643AC(IntPtr pool) { if (pool != IntPtr.Zero) throw new NotSupportedException("Entry pools are outside the original archive player configuration."); }
        public void CRIWARED9B89F57(IntPtr pool) { if (pool != IntPtr.Zero) throw new NotSupportedException("Entry pools are outside the original archive player configuration."); }
        public void CRIWAREE3EC6941(IntPtr pool) { if (pool != IntPtr.Zero) throw new NotSupportedException("Entry pools are outside the original archive player configuration."); }
    }
}
