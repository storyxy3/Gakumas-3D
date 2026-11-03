namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections.Generic;

    public static class TaskPool
    {
        internal static int MaxPoolSize;
        private static Dictionary<Type, Func<int>> sizes;
        static TaskPool()
        {
        }

        public static void RegisterSizeGetter(Type type, Func<int> getSize)
        {
        }
    }
}
