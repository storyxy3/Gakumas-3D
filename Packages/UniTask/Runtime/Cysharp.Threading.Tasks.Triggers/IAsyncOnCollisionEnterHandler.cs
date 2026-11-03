namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnCollisionEnterHandler
    {
        UniTask<Collision> OnCollisionEnterAsync();
    }
}
