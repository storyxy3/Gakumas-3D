namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnTriggerEnter2DHandler
    {
        UniTask<Collider2D> OnTriggerEnter2DAsync();
    }
}
