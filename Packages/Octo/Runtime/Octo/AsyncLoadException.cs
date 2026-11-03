namespace Octo
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    public class AsyncLoadException : Exception
    {
        [CompilerGenerated]
        private readonly string _003CName_003Ek__BackingField;
        [CompilerGenerated]
        private readonly LoadError _003CError_003Ek__BackingField;
        public AsyncLoadException(string name, LoadError error)
        {
        }
    }
}
