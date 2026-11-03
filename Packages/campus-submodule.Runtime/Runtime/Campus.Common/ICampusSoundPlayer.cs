namespace Campus.Common
{
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::DG.Tweening;

    public interface ICampusSoundPlayer
    {
        long GetDurationMs();
        Tween FadeVolume(float volume, float duration);
        void Play();
        void PlayWithIndex(int index);
        void Pause();
        void Unpause();
        void Stop();
        void SetStartTime(int time);
        void SetNextBlockIndex(int index);
        int GetCurrentBlockIndex();
        UniTask OnEndAsync(CancellationToken ct);
        bool IsPlaying();
        bool IsPaused();
        bool IsEnd();
        bool IsEndOrStop();
        void PlayWith(ICampusActorController actor, bool lipSyncEnabled = true);
        void PauseWith(ICampusActorController actor);
        void UnpauseWith(ICampusActorController actor);
        void StopWith(ICampusActorController actor);
    }
}
