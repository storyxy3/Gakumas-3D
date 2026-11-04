using System;

namespace CriWare
{
    // Original DEDE8 / E13A4 clock for unpaused sequences, including the initial
    // SetStartTime preparation of the reached single-wave tracks. Transitions,
    // explicit pause and fader-held branches require separate caller handling.
    internal sealed class CriAtomSequenceClock
    {
        public long NativeClockLast { get; private set; }       // sequence +56
        public long NativeClockPredicted { get; private set; }  // sequence +64
        public int NativeClockCorrection { get; private set; }  // sequence +72
        public long NativeClockSequence { get; private set; } = -1; // sequence +88
        public long NativeClockTrack { get; private set; }      // accumulated track +160
        public long NativeClockElapsed { get; private set; }    // accumulated sequence time read by DE694 (+40)
        public long PreparationTimeUs { get; private set; }     // current tick's context +136, before track waits
        private long pendingPreparationUs;                     // initial sequence +80 / +108
        private double fractionalUs;                           // sequence +224

        public CriAtomSequenceClock(long startTimeUs = 0)
        {
            if (startTimeUs < 0) throw new ArgumentOutOfRangeException(nameof(startTimeUs));
            pendingPreparationUs = startTimeUs;
        }

        public long Advance(long currentAsrUs, long previousAsrUs, double periodUs, float ratio = 1.5f, float speed = 1f)
            => Advance(currentAsrUs, previousAsrUs, periodUs, false, true, ratio, speed);

        // paused: playback pause mask is nonzero. trackActive: E13A4 runs for
        // the track (DF2D0: skipped while mask bit 0 or bit 1 is set).
        public long Advance(long currentAsrUs, long previousAsrUs, double periodUs, bool paused, bool trackActive,
            float ratio = 1.5f, float speed = 1f)
        {
            long delta = 0;
            // Zero is the native sentinel, including subsequent ticks whose
            // ASR clock is still zero. An initialized bool changes cold starts.
            if (NativeClockLast == 0)
            {
                NativeClockLast = previousAsrUs;
                if (NativeClockSequence != -1) delta = unchecked((int)NativeClockSequence);
                NativeClockSequence = 0;
            }

            PreparationTimeUs = pendingPreparationUs;
            if (NativeClockSequence == 0) delta = unchecked(delta + pendingPreparationUs);
            if (paused)
            {
                NativeClockPredicted = 0;
                NativeClockLast = currentAsrUs;
                NativeClockSequence = unchecked(NativeClockSequence + delta);
                NativeClockElapsed = unchecked(NativeClockElapsed + delta);
                if (trackActive) NativeClockTrack = unchecked(NativeClockTrack + delta);
                return delta;
            }
            pendingPreparationUs = 0;

            double budget = fractionalUs + periodUs * (double)ratio;
            double whole = Math.Truncate(budget);
            fractionalUs = budget - whole;
            if (NativeClockPredicted != 0)
            {
                NativeClockCorrection = unchecked((int)(NativeClockPredicted - currentAsrUs));
                whole -= NativeClockCorrection;
            }
            else NativeClockPredicted = currentAsrUs;

            // DF1B8 uses unsigned FCVTZU for the prediction; DF1D4 uses signed
            // FCVTZS for the track delta. Preserve the former's negative clamp.
            NativeClockPredicted = unchecked(NativeClockPredicted + (long)(ulong)Math.Max(0, whole));
            delta = unchecked(delta + (long)(whole * (double)speed));
            NativeClockLast = currentAsrUs;
            NativeClockSequence = unchecked(NativeClockSequence + delta);
            NativeClockElapsed = unchecked(NativeClockElapsed + delta);
            if (trackActive) NativeClockTrack = unchecked(NativeClockTrack + delta);
            return delta;
        }

        // criAtomExPlayback_GetTime 0xF2F48 -> F2F8C -> DE694/DFF84:
        // (sequence +40 - track correction +72) / 1000 with unsigned division;
        // a set bit 31 selects the caller's sound-group fallback.
        public bool TryGetTimeMs(out int timeMs)
        {
            ulong quotient = unchecked((ulong)(NativeClockElapsed - NativeClockCorrection)) / 1000UL;
            timeMs = unchecked((int)quotient);
            return (quotient & 0x80000000UL) == 0;
        }

        public int EventDelay(long authoredTimeUs, long lastDelta, float speed = 1f)
        {
            long remainder = unchecked(NativeClockTrack - authoredTimeUs);
            // E17EC removes the original preparation budget. Wait commands
            // consume per-track preparation; the remaining positive amount is
            // passed to the wave's source seek, never to its output delay.
            long extra = unchecked(lastDelta - PreparationTimeUs - remainder);
            int delay = NativeClockCorrection;
            if (extra > 0) delay = unchecked(delay + (int)(float)((float)extra / speed));
            return Math.Max(0, delay);
        }

        // E34B4's absolute branch when playback +280 is -1; -1 means immediate.
        public long AbsoluteSample(int delay, int rate) => delay <= 0 ? -1 :
            (long)((rate / 1000000.0) * (NativeClockLast + delay));
    }
}
