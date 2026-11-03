namespace Qua.Extensions
{
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;

    public static class IListExtensions
    {
        public static T PopLastOrDefault<T>(this IList<T> list, [Optional] T defaultValue)
        {
            return default(T);
        }
    }
}
