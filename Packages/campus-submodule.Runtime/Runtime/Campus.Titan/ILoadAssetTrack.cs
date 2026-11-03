namespace Campus.Titan
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Titan;

    public interface ILoadAssetTrack
    {
        UniTask LoadAsync(TitanPlayer titanPlayer, CancellationToken ct);
    }
}
