namespace Cysharp.Threading.Tasks.Internal
{
    using global::System.Runtime.CompilerServices;

    internal static class Error
    {
        [MethodImpl(256)]
        public static void ThrowArgumentNullException<T>(T value, string paramName)
            where T : class
        {
        }

        [MethodImpl(8)]
        private static void ThrowArgumentNullExceptionCore(string paramName)
        {
        }

        [MethodImpl(256)]
        public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField)
            where T : class
        {
        }

        [MethodImpl(8)]
        private static void ThrowInvalidOperationExceptionCore(string message)
        {
        }
    }
}
