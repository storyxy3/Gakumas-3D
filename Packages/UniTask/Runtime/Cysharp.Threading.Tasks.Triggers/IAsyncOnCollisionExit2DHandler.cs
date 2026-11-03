namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnCollisionExit2DHandler
    {
        UniTask<Collision2D> OnCollisionExit2DAsync();
    }
}
