namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class TimelineController
    {
        private PlayableGraph _graph;
        private Playable _timelinePlayable;
        private double _waitStartTime;
        [CompilerGenerated]
        private double _003CDurationAdjustment_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsWaiting_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsComplete_003Ek__BackingField;
        [CompilerGenerated]
        private Action m_OnPlay;
        [CompilerGenerated]
        private Action m_OnStop;
        [CompilerGenerated]
        private Action<double> m_OnUpdateDuration;
        [CompilerGenerated]
        private Action<double, bool> m_OnSetTime;
        [CompilerGenerated]
        private Action<double> m_OnSetSpeed;
        [CompilerGenerated]
        private Action<DirectorUpdateMode> m_OnSetTimeUpdateMode;
        [CompilerGenerated]
        private Action<float> m_OnEvaluate;
        [CompilerGenerated]
        private Action<double> m_OnBeginWait;
        [CompilerGenerated]
        private Action<double, double> m_OnEndWait;
        [CompilerGenerated]
        private Action<double, double> m_OnOffsetClip;
        [CompilerGenerated]
        private Action<double, double, bool> m_OnSkipTime;
        [CompilerGenerated]
        private Action m_OnResetClip;
        internal double DurationAdjustment
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

        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsPlaying
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsWaiting
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsComplete
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public event Action OnPlay
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

        public event Action OnStop
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

        public event Action<double> OnUpdateDuration
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

        public event Action<double, bool> OnSetTime
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

        public event Action<double> OnSetSpeed
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

        public event Action<DirectorUpdateMode> OnSetTimeUpdateMode
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

        public event Action<float> OnEvaluate
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

        public event Action<double> OnBeginWait
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

        public event Action<double, double> OnEndWait
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

        public event Action<double, double> OnOffsetClip
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

        public event Action<double, double, bool> OnSkipTime
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

        public event Action OnResetClip
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

        public void UpdateGraph(PlayableGraph graph, Playable timelinePlayable)
        {
        }

        public PlayableGraph GetGraph()
        {
            return default(PlayableGraph);
        }

        public TimelinePlayable GetTimelinePlayable()
        {
            return null;
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }

        public double GetDuration()
        {
            return default(double);
        }

        public double CalculateDuration(GetTimeOptions options)
        {
            return default(double);
        }

        public void UpdateDuration()
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public void SetTime(double time, bool forceEvaluate = false)
        {
        }

        public double GetSpeed()
        {
            return default(double);
        }

        public void SetSpeed(double speed)
        {
        }

        public void SetTimeUpdateMode(DirectorUpdateMode mode)
        {
        }

        public void Evaluate(float deltaTime)
        {
        }

        public void BeginWait(TimelineClip clip)
        {
        }

        public void EndWait()
        {
        }

        public void OffsetClip(double fromTime, double toTime)
        {
        }

        public void SkipToTime(double time, bool forceEvaluate = false)
        {
        }

        public void ResetClip()
        {
        }

        public void Destroy()
        {
        }

        public TimelineController()
        {
        }
    }
}
