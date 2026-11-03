namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncStartTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private bool called;
        private void Start()
        {
        }

        public UniTask StartAsync()
        {
            return default(UniTask);
        }

        public AsyncStartTrigger()
        {
        }
    }
}
