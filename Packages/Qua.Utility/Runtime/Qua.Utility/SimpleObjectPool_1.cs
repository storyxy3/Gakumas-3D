namespace Qua.Utility
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Qua.Utility;

    public class SimpleObjectPool<T> : ObjectPool<T> where T : class, new()
    {
        private readonly Action<T> _onBeforeRent;
        private readonly Action<T> _onBeforeReturn;
        public SimpleObjectPool([Optional] Action<T> onBeforeRent, [Optional] Action<T> onBeforeReturn)
        {
        }

        protected override T CreateInstance()
        {
            return null;
        }

        protected override void OnBeforeRent(T instance)
        {
        }

        protected override void OnBeforeReturn(T instance)
        {
        }
    }
}
