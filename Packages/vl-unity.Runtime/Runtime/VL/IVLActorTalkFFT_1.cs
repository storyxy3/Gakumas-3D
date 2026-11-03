namespace VL
{
    using global::UnityEngine;

    public interface IVLActorTalkFFT<T>
        where T : Component
    {
        T audioSource { get; }

        bool isTalk { get; }

        bool isPlaying { get; }

        void SetAudioSource(T source);
        void UpdateFFT();
        void Reset();
    }
}
