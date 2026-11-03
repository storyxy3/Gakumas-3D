namespace Campus.Timeline
{
    using global::Campus.Common;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Video;

    public sealed class CampusVideoPlayerTrackBehaviour : PlayableBehaviour
    {
        public VideoPlayer VideoPlayer;
        public VideoImage VideoImage;
        public bool IsRecording;
        public bool IsPlayMode;
        public bool Loop;
        private bool _playedOnce;
        private bool _preparing;
        private bool _drifted;
        private double _driftedTime;
        private double _seekTime;
        public bool IsEditPlay
        {
            get
            {
                return default(bool);
            }
        }

        public double VideoTime
        {
            get
            {
                return default(double);
            }

            set
            {
            }
        }

        public void PrepareVideo(bool force = false)
        {
        }

        private void UpdateVideo(bool timeStopped, double time = 0.0)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        private void LoopPointReached(VideoPlayer vp)
        {
        }

        private void PrepareCompleted(VideoPlayer vp)
        {
        }

        private void SeekCompleted(VideoPlayer vp)
        {
        }

        private void ErrorReceived(VideoPlayer vp, string e)
        {
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public void PlayVideo()
        {
        }

        public void PauseVideo()
        {
        }

        public void StopVideo()
        {
        }

        private bool SyncVideoToTimeline(Playable playable)
        {
            return default(bool);
        }

        private bool TryGetClipLocalTime(Playable playable, out double clipLocalTime)
        {
            throw null;
        }

        private void EnforcePausedState(double clipLocalTime)
        {
        }

        private bool IsDriftedFromExpectedTime(double expectedTime)
        {
            return default(bool);
        }

        private double NormalizeClipTime(double time)
        {
            return default(double);
        }

        private void SyncVideoToPlayable(double time, bool hardSync = false)
        {
        }

        private bool TrySetFrame(double time)
        {
            return default(bool);
        }

        public CampusVideoPlayerTrackBehaviour()
        {
        }
    }
}
