namespace Octo.Loader
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Loader;

    internal class Common
    {
        public struct Result<T>
        {
            public T value;
            public LoadError error;
            public Result(T value, LoadError error)
            {
                this = default;
            }
        }

        public class CallbackEvents<T>
        {
            [CompilerGenerated]
            private Action<T> m_onComplete;
            [CompilerGenerated]
            private OnDownloadProgress m_onProgress;
            private event Action<T> onComplete
            {
                [CompilerGenerated]
                add
                {
                }

                [CompilerGenerated]
                remove
                {
                }
            }

            private event OnDownloadProgress onProgress
            {
                [CompilerGenerated]
                add
                {
                }

                [CompilerGenerated]
                remove
                {
                }
            }

            public CallbackEvents(Action<T> onComplete, OnDownloadProgress onProgress)
            {
            }

            public void Add(Action<T> onComplete, OnDownloadProgress onProgress)
            {
            }

            public void CallOnComplete(T result)
            {
            }

            public void CallOnProgress(string name, ulong receivedLength, ulong contentLength)
            {
            }
        }

        public static Action<Result<T>> ConvertToSafeResultAction<T>(Action<T, LoadError> action)
        {
            return null;
        }
    }
}
