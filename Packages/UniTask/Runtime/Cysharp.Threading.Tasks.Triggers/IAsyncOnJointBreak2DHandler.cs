namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public interface IAsyncOnJointBreak2DHandler
    {
        UniTask<Joint2D> OnJointBreak2DAsync();
    }
}
