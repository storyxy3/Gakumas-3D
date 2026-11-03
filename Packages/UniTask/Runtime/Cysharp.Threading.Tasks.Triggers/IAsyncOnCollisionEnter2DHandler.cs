namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnCollisionEnter2DHandler
    {
        UniTask<Collision2D> OnCollisionEnter2DAsync();
    }
}
