namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncAwakeTrigger : AsyncTriggerBase<AsyncUnit>
    {
        public UniTask AwakeAsync()
        {
            return default(UniTask);
        }

        public AsyncAwakeTrigger()
        {
        }
    }
}
