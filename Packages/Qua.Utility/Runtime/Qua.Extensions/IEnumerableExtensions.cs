namespace Qua.Extensions
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Runtime.InteropServices;
    using global::JetBrains.Annotations;

    public static class IEnumerableExtensions
    {
        [ContractAnnotation("self:null=>true", true)]
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T> self)
        {
            if (self == null) return true;
            if (self is ICollection<T> collection) return collection.Count == 0;
            if (self is IReadOnlyCollection<T> readOnlyCollection) return readOnlyCollection.Count == 0;
            return !System.Linq.Enumerable.Any(self);
        }

        public static T GetValueOrDefault<T>(this IEnumerable<T> self, int index, [Optional] T defaultValue)
        {
            return default(T);
        }

        public static T RandomOrDefault<T>(this IEnumerable<T> self, [Optional] T defaultValue)
        {
            return default(T);
        }
    }
}
