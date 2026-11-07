namespace Qua.Utility
{
    using global::System.IO;
    using global::Qua.Utility;
    using global::UnityEngine;
    using global::UnityEngine.Scripting;

    [Preserve]
    public class SingletonResourcePathAttribute : SingletonCreatorAttribute
    {
        public readonly string path;
        public readonly bool canRaiseNotFoundException;
        public SingletonResourcePathAttribute(string path, bool raiseNotFoundException = true)
        {
            this.path = path;
            canRaiseNotFoundException = raiseNotFoundException;
        }

        public override T CreateInstance<T>()
        {
            T prefab = Resources.Load<T>(path);
            if (prefab != null)
                return Instantiate(prefab);
            if (canRaiseNotFoundException)
                throw new FileNotFoundException("Not found prefab: " + path);
            return null;
        }
    }
}
