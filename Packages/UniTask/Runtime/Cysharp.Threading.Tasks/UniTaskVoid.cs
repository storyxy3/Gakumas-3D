namespace Cysharp.Threading.Tasks
{
    using global::System.Runtime.CompilerServices;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    [AsyncMethodBuilder(typeof(AsyncUniTaskVoidMethodBuilder))]
    public readonly struct UniTaskVoid
    {
        public void Forget()
        {
        }
    }
}
