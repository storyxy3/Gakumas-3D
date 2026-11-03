namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncAudioFilterReadTrigger : AsyncTriggerBase<(float[] data, int channels)>
    {
        private void OnAudioFilterRead(float[] data, int channels)
        {
        }

        public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler()
        {
            return null;
        }

        public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<(float[], int)> OnAudioFilterReadAsync()
        {
            return default(UniTask<(float[], int)>);
        }

        public UniTask<(float[], int)> OnAudioFilterReadAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<(float[], int)>);
        }

        public AsyncAudioFilterReadTrigger()
        {
        }
    }
}
