namespace VL.LimitedLisp
{
    using global::System.Collections.Generic;
    using global::Unity.Collections;
    using global::VL.LimitedLisp;

    public static class LispParser
    {
        public enum ParseMode
        {
            None,
            Symbol
        }

        public static List<TSymbol> ParseManaged<TSymbol, T>(string text)
            where TSymbol : struct, ISymbol<T>
        {
            return null;
        }

        public static NativeArray<TSymbol> ParseNative<TSymbol, T>(string text, Allocator allocator = Allocator.Persistent)
            where TSymbol : struct, ISymbol<T>
        {
            return default(NativeArray<TSymbol>);
        }
    }
}
