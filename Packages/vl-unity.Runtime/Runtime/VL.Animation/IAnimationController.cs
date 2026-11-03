namespace VL.Animation
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public interface IAnimationController
    {
        double length { get; }

        void Play();
        UniTask WaitForCompletionAsync(CancellationToken ct);
        bool IsPlaying();
        void Pause();
        void Resume();
        void Stop();
        void SetWeight(float weight);
        float GetWeight();
        void SetTime(double time);
        double GetTime();
        bool IsPlayingLayer(string otherLayerName);
        float GetLayerWeight(string otherLayerName);
        bool IsValid();
    }
}
