namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnCollisionStay2DHandler
    {
        UniTask<Collision2D> OnCollisionStay2DAsync();
    }
}
