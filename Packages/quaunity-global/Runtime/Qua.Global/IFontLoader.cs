namespace Qua.Global
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::TMPro;

    public interface IFontLoader
    {
        UniTask<TMP_FontAsset> LoadAsync(string loadKey, CancellationToken cancellationToken);
        void Unload(string loadKey, TMP_FontAsset loadedFontAsset);
    }
}
