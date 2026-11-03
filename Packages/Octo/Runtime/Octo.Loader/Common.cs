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
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<T> _003C_003E9__6_0;
                public static OnDownloadProgress _003C_003E9__6_1;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__6_0(T _003Cp0_003E)
                {
                }

                internal void _003C_002Ector_003Eb__6_1(string _003Cp0_003E, ulong _003Cp1_003E, ulong _003Cp2_003E)
                {
                }
            }

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

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0<T>
        {
            public Action<T, LoadError> action;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal void _003CConvertToSafeResultAction_003Eb__0(Result<T> result)
            {
            }
        }

        public static Action<Result<T>> ConvertToSafeResultAction<T>(Action<T, LoadError> action)
        {
            return null;
        }
    }
}
