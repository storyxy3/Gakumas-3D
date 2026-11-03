namespace Qua.Utility
{
    using global::Qua.Utility;
    using global::UnityEngine.Scripting;

    [Preserve]
    public class SingletonResourcePathAttribute : SingletonCreatorAttribute
    {
        public readonly string path;
        public readonly bool canRaiseNotFoundException;
        public SingletonResourcePathAttribute(string path, bool raiseNotFoundException = true)
        {
        }

        public override T CreateInstance<T>()
        {
            return null;
        }
    }
}
