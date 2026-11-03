namespace Qua.Utility
{
    using global::System.Collections.Generic;
    using global::Qua.Utility;
    using global::UnityEngine;

    public abstract class ComponentPool<T> : ObjectPool<T> where T : Component
    {
        private readonly List<T> _actives;
        protected override void OnBeforeRent(T instance)
        {
        }

        protected override void OnBeforeReturn(T instance)
        {
        }

        protected override void OnClear(T instance)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public void GetActives(List<T> list)
        {
        }

        public void ReturnAll()
        {
        }

        protected ComponentPool()
        {
        }
    }
}
