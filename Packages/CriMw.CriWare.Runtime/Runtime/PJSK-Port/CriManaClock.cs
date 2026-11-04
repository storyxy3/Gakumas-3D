namespace CriWare.CriMana
{
    // JP7 CriManaSystemTimer (0x598b0..0x59e98). The caller supplies the same
    // microsecond clock to every operation, and gates user/manual updates on
    // Playing as the original player entry points do.
    internal sealed class CriManaClock
    {
        private int mode = 2;
        private bool started, paused;
        private ulong anchorUs, stoppedUs, previousUs, systemCount, systemUnit = 1;
        private ulong userCount, userUnit = 1000, predictedCount, predictedUnit = 1000;
        private ulong manualStep, manualUnit = 1, manualUpdates;
        private int rateNumerator = 1, rateDenominator = 1;
        private uint interpolationLimitMs = 32;

        internal bool IsPaused => paused;
        internal bool UsesTime => mode != 0;

        // Values are Player.TimerType: None=0, System=1, Audio=2, User=3,
        // Manual=4. Audio without an active audio stream uses this system timer.
        internal void SetMode(int timerType) { mode = timerType; }

        internal void Start(ulong nowUs)
        {
            started = true;
            systemCount = previousUs = predictedCount = manualUpdates = 0;
            anchorUs = nowUs;
        }

        internal void Stop(ulong nowUs)
        {
            systemCount = manualUpdates = 0;
            paused = false;
            if (started) stoppedUs = nowUs;
            started = false;
        }

        internal bool SetUserTime(ulong count, ulong unit)
        {
            if (unit == 0) return false;
            userCount = count; userUnit = unit;
            return true;
        }

        internal void SetManualStep(ulong count, ulong unit) { manualStep = count; manualUnit = unit; }
        internal void AdvanceManual() { if (!paused) manualUpdates = unchecked(manualUpdates + 1); }
        internal void SetRate(int numerator, int denominator) { rateNumerator = numerator; rateDenominator = denominator; }
        internal void SetUserInterpolationLimit(uint milliseconds) { interpolationLimitMs = milliseconds; }

        internal void Pause(bool value, ulong nowUs)
        {
            if (paused == value) return;
            if (started)
            {
                if (value)
                {
                    ulong elapsed = Elapsed(nowUs);
                    systemUnit = 1000000;
                    systemCount = unchecked(systemCount + ScaleInteger(unchecked(elapsed - previousUs)));
                    stoppedUs = nowUs;
                    previousUs = elapsed;
                    if (mode == 3)
                    {
                        ulong before = predictedCount;
                        ulong next = unchecked(before + ScaleFloat(elapsed));
                        float lead = (float)next / (float)predictedUnit - (float)userCount / (float)userUnit;
                        if (lead < (float)interpolationLimitMs / 1000.0f) predictedCount = next;
                    }
                }
                else { previousUs = 0; anchorUs = nowUs; }
            }
            paused = value;
        }

        internal void Read(ulong nowUs, out ulong count, out ulong unit)
        {
            ReadTimer(nowUs, out count, out unit);
            // The core still samples its timer in None mode, then exposes 0/1
            // and disables the frame time gate (0x5f2fc, 0x5ffec).
            if (mode == 0) { count = 0; unit = 1; }
        }

        private void ReadTimer(ulong nowUs, out ulong count, out ulong unit)
        {
            if (!started) { count = 0; unit = 1000; return; }
            if (mode == 4)
            {
                count = ScaleInteger(unchecked(manualUpdates * manualStep));
                unit = manualUnit;
                return;
            }
            if (mode == 3) { ReadUser(nowUs, out count, out unit); return; }
            if (!paused)
            {
                ulong elapsed = Elapsed(nowUs);
                systemUnit = 1000000;
                systemCount = unchecked(systemCount + ScaleInteger(unchecked(elapsed - previousUs)));
                previousUs = elapsed;
            }
            count = systemCount; unit = systemUnit;
        }

        private void ReadUser(ulong nowUs, out ulong count, out ulong unit)
        {
            if (interpolationLimitMs == 0) { count = userCount; unit = userUnit; return; }
            ulong before = predictedCount;
            if (!paused)
            {
                predictedCount = unchecked(before + ScaleFloat(Elapsed(nowUs)));
                predictedUnit = 1000000;
            }
            float userSeconds = (float)userCount / (float)userUnit;
            float predictedSeconds = (float)predictedCount / (float)predictedUnit;
            if (userSeconds > predictedSeconds)
            {
                count = userCount; unit = userUnit;
                predictedCount = ToUnsigned((float)unchecked(predictedUnit * userCount) / (float)userUnit);
            }
            else
            {
                if (!paused && predictedSeconds - userSeconds >= (float)interpolationLimitMs / 1000.0f)
                    predictedCount = before;
                count = predictedCount; unit = predictedUnit;
            }
            if (!paused) anchorUs = nowUs;
        }

        private ulong Elapsed(ulong nowUs)
        {
            ulong current = paused ? stoppedUs : nowUs;
            // Original timer uses one's-complement subtraction when its
            // unsigned gettimeofday sample wraps behind the start sample.
            return unchecked(current + (current < anchorUs ? ~anchorUs : 0UL - anchorUs));
        }

        private ulong ScaleInteger(ulong value)
        {
            ulong denominator = unchecked((ulong)(long)rateDenominator);
            return denominator == 0 ? 0 : unchecked(value * (ulong)(long)rateNumerator) / denominator;
        }

        private ulong ScaleFloat(ulong value) => ToUnsigned(
            (float)unchecked(value * (ulong)(long)rateNumerator) / (float)rateDenominator);

        private static ulong ToUnsigned(float value)
        {
            if (!(value > 0)) return 0;
            if (value >= 18446744073709551616.0f) return ulong.MaxValue;
            return (ulong)value;
        }
    }
}
