namespace Qua.Extensions
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Runtime.InteropServices;
    using global::JetBrains.Annotations;

    public static class IDictionaryExtensions
    {
        [ContractAnnotation("self:null=>true", true)]
        public static bool IsNullOrEmpty<TKey, TValue>([NotNullWhen(false)] this IDictionary<TKey, TValue> self)
        {
            return default(bool);
        }

        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, [Optional] TValue defaultValue)
        {
            return default(TValue);
        }
    }
}
