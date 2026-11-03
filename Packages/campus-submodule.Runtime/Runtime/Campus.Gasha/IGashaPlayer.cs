namespace Campus.Gasha
{
    using global::System;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public interface IGashaPlayer : IDisposable
    {
        UniTask PlayAsync(CancellationToken ct);
    }
}
