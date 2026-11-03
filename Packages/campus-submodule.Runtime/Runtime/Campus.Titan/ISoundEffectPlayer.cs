namespace Campus.Titan
{
    using global::System;

    public interface ISoundEffectPlayer : IDisposable
    {
        void Play();
        void SetStartTime(int time);
        void Stop();
    }
}
