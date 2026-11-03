namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    public static class AsyncTriggerExtensions
    {
        public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this GameObject gameObject)
        {
            return null;
        }

        public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this Component component)
        {
            return null;
        }

        private static T GetOrAddComponent<T>(GameObject gameObject)
            where T : Component
        {
            return null;
        }

        public static UniTask OnDestroyAsync(this GameObject gameObject)
        {
            return default(UniTask);
        }
    }
}
