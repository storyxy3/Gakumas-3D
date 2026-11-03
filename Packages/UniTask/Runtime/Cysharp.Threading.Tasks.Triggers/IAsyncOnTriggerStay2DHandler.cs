namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnTriggerStay2DHandler
    {
        UniTask<Collider2D> OnTriggerStay2DAsync();
    }
}
