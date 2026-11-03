namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnTriggerExit2DHandler
    {
        UniTask<Collider2D> OnTriggerExit2DAsync();
    }
}
