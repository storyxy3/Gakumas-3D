using System;

namespace CriWare
{
    // Original Atom fader control, libcri 314dec23..., 0xEB0A4 / 0xEB238 /
    // 0x1566F8. The owner supplies the native server clock and playback state;
    // commands describe native calls, not a Unity audio or timing implementation.
    internal sealed class CriAtomFader
    {
        internal enum Phase { Idle = 0, Waiting = 1, Running = 2, Complete = 3 }
        internal enum CommandKind { SetGain, StopPlayback, ResumePreparedPlayback, MarkIncoming, MarkOutgoing, Error }

        internal readonly struct Command
        {
            internal readonly CommandKind Kind;
            internal readonly uint PlaybackId;
            internal readonly float Gain;
            internal readonly int Argument;

            internal Command(CommandKind kind, uint playbackId = 0, float gain = 0f, int argument = 0)
            {
                Kind = kind;
                PlaybackId = playbackId;
                Gain = gain;
                Argument = argument;
            }
        }

        private readonly Func<uint, CriAtomExPlayback.Status> status;
        private readonly Action<Command> emit;
        private bool hasInterface;
        private bool paused;
        private bool outgoingStopIssued;
        private int configuredFadeIn;
        private int configuredEndDelay;
        private int activeFadeOut = 500;
        private int activeFadeIn;
        private int activeEndDelay = 500;
        private int activeOutDelay;
        private int activeInDelay;
        private float outgoingStartGain;

        // The native player setters store signed values without validation.
        // Start/Stop snapshot them into the envelope. Negative fade-in/end-delay
        // values report an error there and retain the last accepted value.
        // Negative fade-out is accepted: no outgoing gain ramp is performed.
        internal int FadeOutTimeMs { get; set; } = 500;
        internal int FadeInTimeMs { get; set; }
        internal int FadeInStartOffsetMs { get; set; }
        internal int FadeOutEndDelayMs { get; set; } = 500;
        internal Phase State { get; private set; }
        internal uint IncomingId { get; private set; }
        internal uint OutgoingId { get; private set; }
        internal float IncomingGain { get; private set; }
        internal float OutgoingGain { get; private set; }
        internal int ElapsedMs { get; private set; }

        internal CriAtomFader(Func<uint, CriAtomExPlayback.Status> status, Action<Command> emit)
        {
            this.status = status ?? throw new ArgumentNullException(nameof(status));
            this.emit = emit ?? throw new ArgumentNullException(nameof(emit));
        }

        internal bool IsFading(CriAtomExPlayer.Status playerStatus) =>
            playerStatus == CriAtomExPlayer.Status.Playing && (State == Phase.Waiting || State == Phase.Running);

        internal void SetPaused(bool value) => paused = value;

        internal void Start(uint playbackId, bool isPaused = false)
        {
            paused = isPaused;
            CancelPreviousFade();
            float previousGain = IncomingGain;
            OutgoingId = IncomingId;
            IncomingId = playbackId;
            Snapshot(previousGain, FadeInTimeMs, FadeInStartOffsetMs);
            SetGain(IncomingId, FadeInTimeMs > 0 ? 0f : 1f);
            SetGain(OutgoingId, previousGain);
            Begin();
            emit(new Command(CommandKind.MarkIncoming, IncomingId));
            emit(new Command(CommandKind.MarkOutgoing, OutgoingId));
        }

        // Called after the player's ordinary stop pass (which treats its
        // fader-owned incoming playback specially). It does not stop all IDs.
        internal void Stop()
        {
            paused = false;
            CancelPreviousFade();
            if (status(IncomingId) == CriAtomExPlayback.Status.Removed) return;
            if (IncomingGain <= 0f)
            {
                StopPlayback(IncomingId);
                return;
            }
            OutgoingId = IncomingId;
            IncomingId = CriAtomExPlayback.invalidId;
            Snapshot(IncomingGain, 0, 0);
            Begin();
            emit(new Command(CommandKind.MarkOutgoing, OutgoingId));
        }

        // 0xEC94C removes the player's actual playbacks without release first,
        // then invokes its fader stop callback twice. The owner must perform
        // that removal before this method; these callbacks must see Removed.
        internal void AfterStopWithoutReleaseTime()
        {
            Stop();
            Stop();
        }

        internal void Tick(uint nativeDeltaMs)
        {
            if (!hasInterface) return;
            // These writes occur even when idle/completed/paused, and before a
            // waiting transition or elapsed-time advance (0x156708–0x156744).
            SetGain(IncomingId, activeFadeIn < 1 ? 1f : IncomingGain);
            SetGain(OutgoingId, OutgoingGain);
            if (State == Phase.Waiting)
            {
                if (status(IncomingId) != CriAtomExPlayback.Status.Prep)
                {
                    ElapsedMs = 0;
                    State = Phase.Running;
                }
                return;
            }
            if (State != Phase.Running || paused) return;
            int elapsed = unchecked(ElapsedMs + (int)Math.Min(nativeDeltaMs, 67u));
            int outTime = unchecked(elapsed - activeOutDelay);
            int inTime = unchecked(elapsed - activeInDelay);
            if (activeFadeOut >= 0 && elapsed >= activeOutDelay)
            {
                OutgoingGain = Clamp(activeFadeOut > 0 ? (float)((float)(1f - (float)((float)outTime / activeFadeOut)) * outgoingStartGain) : 0f);
                SetGain(OutgoingId, OutgoingGain);
            }
            if (elapsed >= activeInDelay)
            {
                float gain = Clamp(activeFadeIn > 0 ? (float)((float)inTime / activeFadeIn) : 1f);
                SetGain(IncomingId, gain);
                if (IncomingGain <= 0f && gain > 0f)
                    emit(new Command(CommandKind.ResumePreparedPlayback, IncomingId, argument: 3));
                IncomingGain = gain;
            }
            ElapsedMs = elapsed;
            if (outTime >= unchecked(activeEndDelay + activeFadeOut))
            {
                if (!outgoingStopIssued)
                {
                    // Both native fader stop wrappers (0xF2310/0xF2430) call
                    // 0xFF56C with reason 53 in this binary. Neither is the
                    // public StopWithoutReleaseTime path (0xFF9AC).
                    StopPlayback(OutgoingId);
                    outgoingStopIssued = true;
                }
                if (status(OutgoingId) != CriAtomExPlayback.Status.Playing && inTime >= activeFadeIn)
                    State = Phase.Complete;
            }
        }

        private void Snapshot(float previousGain, int fadeIn, int offset)
        {
            hasInterface = true;
            outgoingStartGain = previousGain;
            if (fadeIn < 0) emit(new Command(CommandKind.Error, argument: 2010052503));
            else configuredFadeIn = fadeIn;
            if (FadeOutEndDelayMs < 0) emit(new Command(CommandKind.Error, argument: 2010052509));
            else configuredEndDelay = FadeOutEndDelayMs;
            activeFadeOut = FadeOutTimeMs;
            activeFadeIn = configuredFadeIn;
            activeEndDelay = configuredEndDelay;
            activeOutDelay = offset < 0 ? unchecked(-offset) : 0;
            activeInDelay = offset < 0 ? 0 : offset;
        }

        private void Begin()
        {
            outgoingStopIssued = false;
            IncomingGain = 0f;
            OutgoingGain = outgoingStartGain;
            State = Phase.Waiting;
        }

        private void CancelPreviousFade()
        {
            if (State != Phase.Waiting && State != Phase.Running) return;
            State = Phase.Idle;
            StopPlayback(OutgoingId);
        }

        private void SetGain(uint id, float gain) => emit(new Command(CommandKind.SetGain, id, gain));
        private void StopPlayback(uint id) => emit(new Command(CommandKind.StopPlayback, id, argument: 53));
        private static float Clamp(float value)
        {
            float result = Math.Max(0f, Math.Min(1f, value));
            return result == 0f ? 0f : result;
        }
    }
}
