namespace Titan
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Titan;

    public static class IExpressionHolderExtensions
    {
        public static Value GetExpressionValue(this IExpressionHolder expressionHolder, string name, IValueResolver resolver)
        {
            return null;
        }

        public static bool TryGetExpressionFloatValue(this IExpressionHolder expressionHolder, string name, IValueResolver resolver, out float result)
        {
            throw null;
        }

        public static bool TryGetExpressionBoolValue(this IExpressionHolder expressionHolder, string name, IValueResolver resolver, out bool result)
        {
            throw null;
        }

        public static bool TryGetExpressionIntValue(this IExpressionHolder expressionHolder, string name, IValueResolver resolver, out int result)
        {
            throw null;
        }

        public static bool TryGetExpressionValue<T>(this IExpressionHolder expressionHolder, string name, IValueResolver resolver, out T result)
        {
            throw null;
        }

        public static void LogCastError(IExpressionHolder expressionHolder, string name, [Optional] Type expected, [Optional] Type actual)
        {
        }
    }
}
