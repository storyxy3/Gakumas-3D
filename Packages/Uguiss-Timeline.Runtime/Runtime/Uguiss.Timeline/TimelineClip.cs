namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine;

    [Serializable]
    public class TimelineClip
    {
        private enum WaitType
        {
            None,
            Start,
            Duration
        }

        private class MergeData
        {
            [CompilerGenerated]
            private EasingType _003CMixOutEaseType_003Ek__BackingField;
            [CompilerGenerated]
            private AnimationCurve _003CMixOutCurve_003Ek__BackingField;
            [CompilerGenerated]
            private double _003CBlendOutDuration_003Ek__BackingField;
            [CompilerGenerated]
            private double _003CAdditionalDuration_003Ek__BackingField;
            public EasingType MixOutEaseType
            {
                [CompilerGenerated]
                get
                {
                    return default(EasingType);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public AnimationCurve MixOutCurve
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

            public double BlendOutDuration
            {
                [CompilerGenerated]
                get
                {
                    return default(double);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public double AdditionalDuration
            {
                [CompilerGenerated]
                get
                {
                    return default(double);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public MergeData()
            {
            }
        }

        [SerializeField]
        private double _startTime;
        [SerializeField]
        private double _duration;
        [SerializeField]
        private double _clipIn;
        [SerializeField]
        private double _easeInDuration;
        [SerializeField]
        private double _easeOutDuration;
        [SerializeField]
        private double _blendInDuration;
        [SerializeField]
        private double _blendOutDuration;
        [SerializeField]
        private EasingType _mixInEaseType;
        [SerializeField]
        private AnimationCurve _mixInCurve;
        [SerializeField]
        private EasingType _mixOutEaseType;
        [SerializeField]
        private AnimationCurve _mixOutCurve;
        [SerializeField]
        private double _timeScale;
        private bool _isDisabled;
        private WaitType _waitType;
        private double _startTimeOffset;
        private double _durationOffset;
        private double _clipInOffset;
        private double _clipOutOffset;
        private double _elapsedTimeOffset;
        private MergeData _mergeData;
        public double StartTime
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double EndTime
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double Duration
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double ClipIn
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double EaseInDuration
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double EaseOutDuration
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double BlendInDuration
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public double BlendOutDuration
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public EasingType MixInEaseType
        {
            get
            {
                return default(EasingType);
            }

            set
            {
            }
        }

        public AnimationCurve MixInCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public EasingType MixOutEaseType
        {
            get
            {
                return default(EasingType);
            }

            set
            {
            }
        }

        public AnimationCurve MixOutCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public double TimeScale
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public bool IsDisabled
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool HasBlendIn
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasBlendOut
        {
            get
            {
                return default(bool);
            }
        }

        public double MixInDuration
        {
            get
            {
                return default(double);
            }
        }

        public double MixOutDuration
        {
            get
            {
                return default(double);
            }
        }

        internal float GetMixInWeight(double time)
        {
            return default(float);
        }

        internal float GetMixOutWeight(double time)
        {
            return default(float);
        }

        public double GetStartTime(GetTimeOptions options)
        {
            return default(double);
        }

        public double GetEndTime(GetTimeOptions options)
        {
            return default(double);
        }

        public double GetDuration(GetTimeOptions options)
        {
            return default(double);
        }

        public double GetRelativeTime(double time)
        {
            return default(double);
        }

        public float GetProgress(double time, bool useBaseDuration = true)
        {
            return default(float);
        }

        public void BeginWait(double waitStartTime, WaitMode waitMode)
        {
        }

        public void EndWait(double waitStartTime, double waitEndTime)
        {
        }

        public void OffsetClip(double fromTime, double toTime)
        {
        }

        public void OffsetElapsedTime(double fromTime, double toTime, SkipTargets targets)
        {
        }

        public void MergeClip(TimelineClip clip)
        {
        }

        public void ResetClip()
        {
        }

        private static double ClampOffsetTime(double time)
        {
            return default(double);
        }

        public TimelineClip()
        {
        }
    }
}
