namespace Cysharp.Threading.Tasks
{
    using global::System.Runtime.CompilerServices;
    using global::Cysharp.Threading.Tasks;

    public static class UniTaskStatusExtensions
    {
        [MethodImpl(256)]
        public static bool IsCompleted(this UniTaskStatus status)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        public static bool IsCompletedSuccessfully(this UniTaskStatus status)
        {
            return default(bool);
        }
    }
}
