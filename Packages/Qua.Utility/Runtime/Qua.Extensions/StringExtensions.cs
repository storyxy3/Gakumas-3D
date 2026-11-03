namespace Qua.Extensions
{
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Runtime.CompilerServices;
    using global::JetBrains.Annotations;

    public static class StringExtensions
    {
        [MethodImpl(256)]
        [ContractAnnotation("self:null=>true", true)]
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string self)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        [ContractAnnotation("self:null=>true", true)]
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string self)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        [ContractAnnotation("self:null=>false")]
        public static bool FastStartsWith([NotNullWhen(true)] this string self, [JetBrains.Annotations.NotNull] string value)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        [ContractAnnotation("self:null=>false")]
        public static bool FastEndsWith([NotNullWhen(true)] this string self, [JetBrains.Annotations.NotNull] string value)
        {
            return default(bool);
        }

        [ContractAnnotation("s:null=>null")]
        public static string FastToLower(this string s)
        {
            return null;
        }
    }
}
