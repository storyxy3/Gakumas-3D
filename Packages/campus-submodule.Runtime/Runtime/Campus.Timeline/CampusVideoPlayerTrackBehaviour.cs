namespace Campus.Timeline
{
    using global::Campus.Common;
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Video;

    public sealed class CampusVideoPlayerTrackBehaviour : PlayableBehaviour
    {
        public VideoPlayer VideoPlayer;
        public VideoImage VideoImage;
        public bool IsRecording;
        public bool IsPlayMode;
        public bool Loop = true;
        private bool _playedOnce;
        private bool _preparing;
        private bool _drifted;
        private double _driftedTime;
        private double _seekTime;
        public bool IsEditPlay
        {
            get
            {
                return IsRecording || !IsPlayMode;
            }
        }

        public double VideoTime
        {
            get
            {
                return VideoPlayer.timeReference == VideoTimeReference.ExternalTime ? VideoPlayer.externalReferenceTime : VideoPlayer.time;
            }

            set
            {
                if (VideoPlayer.timeReference == VideoTimeReference.ExternalTime) VideoPlayer.externalReferenceTime = value;
                else VideoPlayer.time = value;
            }
        }

        public void PrepareVideo(bool force = false)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null || _preparing) return;
            if (!force && VideoPlayer.isPrepared) return;
            VideoPlayer.Prepare();
            _preparing = true;
        }

        private void UpdateVideo(bool timeStopped, double time = 0.0)
        {
            if (timeStopped)
            {
                EnforcePausedState(time);
                return;
            }
            if (_drifted)
            {
                SyncVideoToPlayable(time);
                VideoPlayer.StepForward();
                _drifted = false;
                _driftedTime = 0.0;
            }
            if (!IsEditPlay) PlayVideo();
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return;
            bool timeStopped = IsEditPlay || Mathf.Approximately(0f, info.deltaTime) || info.effectivePlayState == PlayState.Paused;
            int inputCount = playable.GetInputCount();
            for (int i = 0; i < inputCount; i++)
            {
                if (playable.GetInputWeight(i) <= 0f) continue;
                double time = playable.GetInput(i).GetTime();
                if (IsEditPlay || info.seekOccurred) _drifted = true;
                if (!_preparing && VideoPlayer.isPrepared) UpdateVideo(timeStopped, time);
                return;
            }
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return;
            int inputCount = playable.GetInputCount();
            int index = 0;
            while (index < inputCount && playable.GetInputWeight(index) <= 0f) index++;
            if (index == inputCount)
            {
                StopVideo();
                return;
            }
            if (IsPlayMode)
            {
                for (ushort i = 0; i < VideoPlayer.clip.audioTrackCount; i++)
                {
                    if (VideoPlayer.audioOutputMode == VideoAudioOutputMode.Direct) VideoPlayer.SetDirectAudioVolume(i, info.weight);
                    else if (VideoPlayer.audioOutputMode == VideoAudioOutputMode.AudioSource)
                    {
                        var source = VideoPlayer.GetTargetAudioSource(i);
                        if (source != null) source.volume = info.weight;
                    }
                }
            }
            PrepareVideo();
            VideoPlayer.targetCameraAlpha = info.weight;
        }

        private void LoopPointReached(VideoPlayer vp)
        {
            _playedOnce = !Loop;
            if (Loop)
            {
                UpdateVideo(false);
                _drifted = true;
            }
            else PauseVideo();
        }

        private void PrepareCompleted(VideoPlayer vp)
        {
            _preparing = false;
            VideoImage.enabled = true;
        }

        private void SeekCompleted(VideoPlayer vp)
        {
            _driftedTime = Time.realtimeSinceStartupAsDouble - _seekTime;
        }

        private void ErrorReceived(VideoPlayer vp, string e)
        {
            Debug.LogError(e);
        }

        public override void OnPlayableCreate(Playable playable)
        {
            _playedOnce = false;
            if (VideoPlayer != null)
            {
                VideoPlayer.loopPointReached += LoopPointReached;
                VideoPlayer.prepareCompleted += PrepareCompleted;
                VideoPlayer.seekCompleted += SeekCompleted;
                VideoPlayer.errorReceived += ErrorReceived;
                if (IsPlayMode) PrepareVideo();
            }
            if (IsPlayMode && VideoImage != null) VideoImage.DisableAutoResumeOnApplicationPause = true;
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            StopVideo();
            if (VideoImage != null) VideoImage.DisableAutoResumeOnApplicationPause = false;
            if (VideoPlayer != null)
            {
                VideoPlayer.loopPointReached -= LoopPointReached;
                VideoPlayer.prepareCompleted -= PrepareCompleted;
                VideoPlayer.seekCompleted -= SeekCompleted;
                VideoPlayer.errorReceived -= ErrorReceived;
            }
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            if (VideoPlayer == null) return;
            VideoPlayer.timeReference = VideoTimeReference.Freerun;
            _driftedTime = 0.0;
            _drifted = !SyncVideoToTimeline(playable);
            if (IsEditPlay) PlayVideo();
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (VideoPlayer == null) return;
            _driftedTime = 0.0;
            SyncVideoToTimeline(playable);
            PauseVideo();
        }

        public void PlayVideo()
        {
            if (VideoPlayer == null || _playedOnce) return;
            if (VideoPlayer.isPrepared) VideoImage.enabled = true;
            VideoPlayer.renderMode = VideoRenderMode.APIOnly;
            if (IsEditPlay) PauseVideo();
            else VideoPlayer.Play();
        }

        public void PauseVideo()
        {
            if (VideoPlayer != null && VideoPlayer.gameObject.activeInHierarchy) VideoPlayer.Pause();
        }

        public void StopVideo()
        {
            if (VideoPlayer == null) return;
            _playedOnce = false;
            VideoImage.enabled = false;
            VideoPlayer.targetCameraAlpha = 0f;
            VideoPlayer.Stop();
        }

        private bool SyncVideoToTimeline(Playable playable)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null || !VideoPlayer.isPrepared || !TryGetClipLocalTime(playable, out var time)) return false;
            SyncVideoToPlayable(time, true);
            VideoPlayer.StepForward();
            return true;
        }

        private bool TryGetClipLocalTime(Playable playable, out double clipLocalTime)
        {
            clipLocalTime = 0.0;
            int inputCount = playable.GetInputCount();
            for (int i = 0; i < inputCount; i++)
            {
                if (playable.GetInputWeight(i) <= 0f) continue;
                clipLocalTime = playable.GetInput(i).GetTime();
                return true;
            }
            return false;
        }

        private void EnforcePausedState(double clipLocalTime)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return;
            double expectedTime = NormalizeClipTime(clipLocalTime);
            bool drifted = IsDriftedFromExpectedTime(expectedTime);
            if (_drifted || VideoPlayer.isPlaying || drifted)
            {
                _drifted = false;
                _driftedTime = 0.0;
                SyncVideoToPlayable(expectedTime, true);
                VideoPlayer.StepForward();
            }
            PauseVideo();
        }

        private bool IsDriftedFromExpectedTime(double expectedTime)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return false;
            double length = VideoPlayer.clip.length;
            if (Mathf.Approximately(0f, (float)length)) return false;
            double actual = NormalizeClipTime(VideoTime);
            double expected = NormalizeClipTime(expectedTime);
            double difference = Math.Abs(actual - expected);
            double distance = Math.Min(difference, length - difference);
            float frameRate = VideoPlayer.frameRate;
            double tolerance = frameRate > 0f ? 3.0 / frameRate : 0.1;
            return distance > tolerance;
        }

        private double NormalizeClipTime(double time)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return time;
            double length = VideoPlayer.clip.length;
            if (Mathf.Approximately(0f, (float)length)) return 0.0;
            time %= length;
            if (time < 0.0) time += length;
            return time;
        }

        private void SyncVideoToPlayable(double time, bool hardSync = false)
        {
            if (VideoPlayer == null || VideoPlayer.clip == null) return;
            if (hardSync)
            {
                double normalizedTime = NormalizeClipTime(time);
                if (!TrySetFrame(normalizedTime)) VideoTime = normalizedTime;
            }
            else
            {
                if (!IsEditPlay) time += _driftedTime;
                VideoTime = NormalizeClipTime(time);
            }
            _seekTime = Time.realtimeSinceStartupAsDouble;
        }

        private bool TrySetFrame(double time)
        {
            if (VideoPlayer == null) return false;
            double frameRate = VideoPlayer.frameRate;
            ulong frameCount = VideoPlayer.frameCount;
            if (frameRate <= 0.0 || frameCount == 0) return false;
            long frame = (long)Math.Round(frameRate * time);
            VideoPlayer.frame = Math.Clamp(frame, 0L, (long)(frameCount - 1));
            return true;
        }

        public CampusVideoPlayerTrackBehaviour()
        {
        }
    }
}
