using System;
using System.Collections.Generic;

namespace CriWare
{
    // Original libcri 314dec23...: category notifications 0x1010AC/0x101524,
    // REACT phase 0x1017F4, automation 0xD5338/0xD55B8, cue limit 0x102D7C.
    // The backend supplies native server time and playback lifecycle events.
    internal sealed class CriAtomCategoryState
    {
        internal readonly struct CategoryConfig
        {
            internal readonly float Volume;
            internal readonly int CueLimit;
            internal readonly ushort LimitListIndex;
            internal readonly bool DistancePriority;

            internal CategoryConfig(float volume, int cueLimit = 0, ushort limitListIndex = ushort.MaxValue, bool distancePriority = false)
            {
                Volume = volume;
                CueLimit = cueLimit;
                LimitListIndex = limitListIndex;
                DistancePriority = distancePriority;
            }
        }

        internal struct ReactConfig
        {
            internal int SourceCategory, DestinationCategory;
            internal uint ParameterId;
            internal float Level, StartCurveStrength, EndCurveStrength;
            internal ushort DecrementTimeMs, IncrementTimeMs, HoldTimeMs;
            internal byte StartCurveType, EndCurveType;
            internal bool FixedHold, CountPausingCue;
        }

        internal enum ReactPhase { Idle = 0, Decrement = 1, Hold = 2, Increment = 3 }

        private sealed class React
        {
            internal ReactConfig Config;
            internal ReactPhase Phase;
            internal int Remaining = -1;
            internal bool Attached, Automating;
            internal float Gain = 1f, Start, Difference, Strength;
            internal uint StartTime, Duration;
            internal byte Curve;
        }

        private sealed class Category
        {
            internal CategoryConfig Config;
            internal float Volume;
            internal ushort Playing, Unpaused;
            internal readonly List<React> ReactChain = new List<React>();
        }

        private sealed class LimitPool
        {
            internal int Capacity;
            internal readonly List<Reservation> Active = new List<Reservation>();
        }

        private readonly struct Reservation
        {
            internal readonly uint Id;
            internal readonly int Priority;
            internal Reservation(uint id, int priority) { Id = id; Priority = priority; }
        }

        private readonly Category[] categories;
        private readonly React[] reacts;
        private readonly Dictionary<ushort, LimitPool> limits = new Dictionary<ushort, LimitPool>();
        private readonly Func<uint, float?> distance;
        private uint nowMs;

        internal CriAtomCategoryState(CategoryConfig[] categoryConfigs, ReactConfig[] reactConfigs, Func<uint, float?> distance = null)
        {
            if (categoryConfigs == null) throw new ArgumentNullException(nameof(categoryConfigs));
            if (reactConfigs == null) throw new ArgumentNullException(nameof(reactConfigs));
            this.distance = distance;
            categories = new Category[categoryConfigs.Length];
            for (int i = 0; i < categories.Length; i++)
            {
                var config = categoryConfigs[i];
                categories[i] = new Category { Config = config, Volume = config.Volume };
                if (config.CueLimit <= 0 || config.LimitListIndex == ushort.MaxValue) continue;
                if (!limits.TryGetValue(config.LimitListIndex, out var pool))
                    limits.Add(config.LimitListIndex, pool = new LimitPool());
                pool.Capacity += config.CueLimit;
            }
            reacts = new React[reactConfigs.Length];
            for (int i = 0; i < reacts.Length; i++)
            {
                var config = reactConfigs[i];
                if ((uint)config.SourceCategory >= categories.Length || (uint)config.DestinationCategory >= categories.Length)
                    throw new ArgumentException("REACT references an absent category.");
                // All eight original ProjectSekai REACT rows target volume and
                // use these two curve modes. Other target types need their own
                // parameter consumer, not an accidental volume approximation.
                if (config.ParameterId != 0 || (config.StartCurveType != 0 && config.StartCurveType != 2) ||
                    (config.EndCurveType != 0 && config.EndCurveType != 2) ||
                    config.StartCurveStrength < 0f || config.StartCurveStrength > 1f ||
                    config.EndCurveStrength < 0f || config.EndCurveStrength > 1f)
                    throw new NotSupportedException("REACT configuration is outside the original StreamingLive volume-curve contract.");
                reacts[i] = new React { Config = config };
            }
        }

        internal float GetVolume(int category) => categories[category].Volume;
        internal void SetVolume(int category, float value) => categories[category].Volume = value;
        internal ushort GetPlayingCount(int category) => categories[category].Playing;
        internal ushort GetUnpausedCount(int category) => categories[category].Unpaused;
        internal ReactPhase GetReactPhase(int react) => reacts[react].Phase;
        internal int GetReactHoldRemainingMs(int react) => reacts[react].Remaining;
        internal float GetReactGain(int react) => reacts[react].Gain;
        internal bool IsReactAttached(int react) => reacts[react].Attached;
        internal bool IsReactAutomating(int react) => reacts[react].Automating;

        // These are the native +62/+64 counters, not allocated/preparing cues
        // (+60). Pause/resume changes only Unpaused. The backend owns +60.
        internal void ChangePlayingCount(int category, bool increment, bool includesPaused = true, bool unpaused = true)
        {
            var current = categories[category];
            if (increment)
            {
                if (includesPaused) current.Playing = unchecked((ushort)(current.Playing + 1));
                if (unpaused) current.Unpaused = unchecked((ushort)(current.Unpaused + 1));
            }
            else
            {
                if (includesPaused && current.Playing != 0) current.Playing--;
                if (unpaused && current.Unpaused != 0) current.Unpaused--;
            }
            foreach (var react in reacts)
            {
                var config = react.Config;
                if (config.SourceCategory != category) continue;
                int count = config.CountPausingCue ? current.Playing : current.Unpaused;
                // Native tests the resulting count even if that particular
                // counter was not changed by this notification.
                if (increment && count == 1)
                {
                    react.Phase = ReactPhase.Decrement;
                    Attach(react, 1f);
                    Begin(react, config.Level, config.DecrementTimeMs, config.StartCurveType, config.StartCurveStrength);
                }
                else if (!increment && count == 0 && !config.FixedHold)
                {
                    react.Phase = ReactPhase.Hold;
                    react.Remaining = config.HoldTimeMs;
                }
            }
        }

        // Native server advances parameter automations before category REACTs,
        // then processes cue lifecycle events later in the same server pass.
        internal void Tick(uint currentTimeMs, uint elapsedMs)
        {
            nowMs = currentTimeMs;
            foreach (var react in reacts)
            {
                if (!react.Automating) continue;
                uint elapsed = unchecked(nowMs - react.StartTime);
                float t = elapsed >= react.Duration ? 1f : (float)((float)elapsed / react.Duration);
                float curve = react.Curve == 0 ? t : (float)(t * (float)((float)((float)(1f - t) * react.Strength) + 1f));
                react.Gain = (float)(react.Start + (float)(curve * react.Difference));
                if (elapsed >= react.Duration) react.Automating = false;
            }
            if (elapsedMs == 0) return;
            // Original walks source categories by index, then their REACT rows.
            for (int category = 0; category < categories.Length; category++)
                foreach (var react in reacts)
                {
                    var config = react.Config;
                    if (config.SourceCategory != category) continue;
                    if (config.FixedHold && react.Phase == ReactPhase.Decrement && !react.Automating)
                    {
                        react.Phase = ReactPhase.Hold;
                        react.Remaining = config.HoldTimeMs;
                    }
                    if (react.Phase == ReactPhase.Hold && react.Remaining >= 0)
                    {
                        int remaining = unchecked(react.Remaining - (int)elapsedMs);
                        react.Remaining = remaining < 0 ? 0 : remaining;
                        if (remaining > 0) continue;
                        react.Phase = ReactPhase.Increment;
                        Attach(react, config.Level);
                        Begin(react, 1f, config.IncrementTimeMs, config.EndCurveType, config.EndCurveStrength);
                        react.Remaining = -1;
                    }
                    else if (react.Phase == ReactPhase.Idle && react.Attached)
                    {
                        categories[config.DestinationCategory].ReactChain.Remove(react);
                        react.Attached = false;
                        react.Gain = 1f;
                        react.Automating = false;
                    }
                    if (react.Phase == ReactPhase.Increment && !react.Automating) react.Phase = ReactPhase.Idle;
                }
        }

        internal float ApplyReactGains(int category, float categoryGainAfterOwnAisacs)
        {
            foreach (var react in categories[category].ReactChain) categoryGainAfterOwnAisacs = (float)(categoryGainAfterOwnAisacs * (react.Gain));
            return categoryGainAfterOwnAisacs;
        }

        // Reservations are independent of REACT counts. On success, a nonzero
        // victim must be stopped by the backend with native category reason47.
        // Distances are queried at arbitration time; do not snapshot transforms.
        internal bool TryReserve(int category, uint playbackId, int priority, bool firstPriorityWins, float? incomingDistance, out uint victim)
        {
            victim = 0;
            var config = categories[category].Config;
            if (config.CueLimit <= 0 || config.LimitListIndex == ushort.MaxValue) return true;
            var pool = limits[config.LimitListIndex];
            if (pool.Active.Count < pool.Capacity)
            {
                pool.Active.Add(new Reservation(playbackId, priority));
                return true;
            }
            bool byDistance = config.DistancePriority && incomingDistance.HasValue;
            int selected = 0;
            float selectedDistance = byDistance ? distance?.Invoke(pool.Active[0].Id) ?? -1f : -1f;
            for (int i = 1; i < pool.Active.Count; i++)
            {
                var candidate = pool.Active[i];
                if (candidate.Priority < pool.Active[selected].Priority)
                {
                    selected = i;
                    selectedDistance = byDistance ? distance?.Invoke(candidate.Id) ?? -1f : -1f;
                }
                else if (byDistance && candidate.Priority == pool.Active[selected].Priority)
                {
                    float? value = distance?.Invoke(candidate.Id);
                    if (value.HasValue && selectedDistance < value.Value) { selected = i; selectedDistance = value.Value; }
                }
            }
            var previous = pool.Active[selected];
            if (previous.Priority > priority) return false;
            if (previous.Priority == priority)
            {
                if (byDistance && selectedDistance >= 0f && incomingDistance.Value != selectedDistance)
                {
                    if (incomingDistance.Value >= selectedDistance) return false;
                }
                else if (firstPriorityWins) return false;
            }
            victim = previous.Id;
            pool.Active.RemoveAt(selected);
            pool.Active.Add(new Reservation(playbackId, priority));
            return true;
        }

        internal void Release(int category, uint playbackId)
        {
            var config = categories[category].Config;
            if (config.CueLimit <= 0 || config.LimitListIndex == ushort.MaxValue) return;
            var list = limits[config.LimitListIndex].Active;
            int index = list.FindIndex(value => value.Id == playbackId);
            if (index >= 0) list.RemoveAt(index);
        }

        private void Attach(React react, float initial)
        {
            if (react.Attached) return;
            react.Attached = true;
            react.Gain = initial;
            categories[react.Config.DestinationCategory].ReactChain.Insert(0, react);
        }

        private void Begin(React react, float target, uint duration, byte curve, float strength)
        {
            react.Start = react.Gain;
            react.Difference = (float)(target - react.Start);
            react.StartTime = nowMs;
            react.Duration = duration;
            react.Curve = curve;
            react.Strength = strength;
            react.Automating = duration != 0;
            if (duration == 0) react.Gain = (float)(react.Start + react.Difference);
        }
    }
}
