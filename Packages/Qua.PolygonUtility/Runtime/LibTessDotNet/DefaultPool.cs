namespace LibTessDotNet
{
    using global::System;
    using global::System.Collections.Generic;
    using global::LibTessDotNet;

    internal class DefaultPool : IPool
    {
        private IDictionary<Type, ITypePool> _register;
        public override void Register<T>(ITypePool typePool)
        {
        }

        public override T Get<T>()
        {
            return null;
        }

        public override void Return<T>(ref T obj)
        {
        }

        public DefaultPool()
        {
        }
    }
}
