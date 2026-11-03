namespace Octo
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    internal struct AsyncLoadResult<T>
    {
        [CompilerGenerated]
        private readonly string _003CName_003Ek__BackingField;
        [CompilerGenerated]
        private readonly T _003CLoadObject_003Ek__BackingField;
        [CompilerGenerated]
        private readonly LoadError _003CError_003Ek__BackingField;
        public readonly T LoadObject
        {
            [CompilerGenerated]
            get
            {
                return default(T);
            }
        }

        public readonly LoadError Error
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public AsyncLoadResult(string name, T loadObject, LoadError error)
        {
            this = default;
        }
    }
}
