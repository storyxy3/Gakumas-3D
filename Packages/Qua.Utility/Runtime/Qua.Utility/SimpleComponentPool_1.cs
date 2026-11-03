namespace Qua.Utility
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class SimpleComponentPool<T> : ComponentPool<T> where T : Component
    {
        private readonly Func<T> _createInstance;
        private readonly Action<T> _onBeforeRent;
        private readonly Action<T> _onBeforeReturn;
        public SimpleComponentPool(Func<T> createInstance, [Optional] Action<T> onBeforeRent, [Optional] Action<T> onBeforeReturn)
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
