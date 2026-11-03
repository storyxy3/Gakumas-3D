namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnAudioFilterReadHandler
    {
        UniTask<(float[], int)> OnAudioFilterReadAsync();
    }
}
