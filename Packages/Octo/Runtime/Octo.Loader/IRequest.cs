namespace Octo.Loader
{
    using global::System.Collections;
    using global::Octo;

    internal interface IRequest
    {
        string Name { get; }

        bool CanExecute { get; }

        bool ShouldRetry { get; }

        Error PanicError { get; }

        IEnumerator Prepare();
        IEnumerator Execute();
        IEnumerator Finish();
        IEnumerator TimeoutWatcher();
        void Abort(Error err);
        void Panic(Error err);
    }
}
