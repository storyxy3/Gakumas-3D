namespace Qua.Utility
{
    using global::System;
    using global::UnityEngine;

    [AttributeUsage(AttributeTargets.Class)]
    public abstract class SingletonCreatorAttribute : Attribute
    {
        public abstract T CreateInstance<T>()
            where T : MonoBehaviour;
        protected static T Instantiate<T>(T prefab)
            where T : MonoBehaviour
        {
            T instance = UnityEngine.Object.Instantiate(prefab);
            instance.name = prefab.name;
            return instance;
        }

        protected SingletonCreatorAttribute()
        {
        }
    }
}
