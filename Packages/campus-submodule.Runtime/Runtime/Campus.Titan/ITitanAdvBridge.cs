namespace Campus.Titan
{
    using global::System;

    public interface ITitanAdvBridge
    {
        bool IsPlaying { get; }

        event Action OnStop;
    }
}
