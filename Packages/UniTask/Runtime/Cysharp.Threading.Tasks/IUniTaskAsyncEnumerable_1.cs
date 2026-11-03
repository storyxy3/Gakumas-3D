namespace Cysharp.Threading.Tasks
{
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public interface IUniTaskAsyncEnumerable<out T>
    {
        IUniTaskAsyncEnumerator<T> GetAsyncEnumerator([Optional] CancellationToken cancellationToken);
    }
}
