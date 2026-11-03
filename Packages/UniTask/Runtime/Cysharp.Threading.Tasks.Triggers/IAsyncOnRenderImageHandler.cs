namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnRenderImageHandler
    {
        UniTask<(RenderTexture, RenderTexture)> OnRenderImageAsync();
    }
}
