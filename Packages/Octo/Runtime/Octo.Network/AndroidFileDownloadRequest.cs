namespace Octo.Network
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Network;
    using global::UnityEngine;

    internal class AndroidFileDownloadRequest : BaseDownloadRequest<IDownloadResult>
    {
        private static class Bridge
        {
            private static AndroidJavaClass httpClass;
            public static NativeHttpAsyncTask DownloadFile(string url, string path, AndroidJavaProxy result)
            {
                return null;
            }
        }

        private abstract class NativeJavaObjectWrapper : IDisposable
        {
            protected AndroidJavaObject nativeObject;
            public NativeJavaObjectWrapper(AndroidJavaObject nativeObject)
            {
            }

            public virtual void Dispose()
            {
            }
        }

        private class NativeHttpAsyncTask : NativeJavaObjectWrapper
        {
            [CompilerGenerated]
            private NativeHttpResult _003CResult_003Ek__BackingField;
            public NativeHttpResult Result
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public NativeHttpAsyncTask(AndroidJavaObject nativeObject) : base(default)
            {
            }

            private NativeHttpResult GetResult()
            {
                return null;
            }

            public void Abort()
            {
            }

            public override void Dispose()
            {
            }
        }

        private class NativeHttpResult : NativeJavaObjectWrapper
        {
            public bool IsComplete
            {
                get
                {
                    return default(bool);
                }
            }

            public int StatusCode
            {
                get
                {
                    return default(int);
                }
            }

            public int ContentLength
            {
                get
                {
                    return default(int);
                }
            }

            public int WrittenLength
            {
                get
                {
                    return default(int);
                }
            }

            public string Md5
            {
                get
                {
                    return null;
                }
            }

            public string ErrorCode
            {
                get
                {
                    return null;
                }
            }

            public string ErrorMessage
            {
                get
                {
                    return null;
                }
            }

            public bool IsError
            {
                get
                {
                    return default(bool);
                }
            }

            public bool IsIoError
            {
                get
                {
                    return default(bool);
                }
            }

            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public NativeHttpResult(AndroidJavaObject nativeObject) : base(default)
            {
            }

            private T SafeGet<T>(string fieldName)
            {
                return default(T);
            }

            private T SafeCall<T>(string methodName)
            {
                return default(T);
            }
        }

        private class Result : IDownloadResult, IDisposable
        {
            [CompilerGenerated]
            private bool _003CIsError_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CErrorMessage_003Ek__BackingField;
            [CompilerGenerated]
            private bool _003CIsHashDiffered_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CRealHash_003Ek__BackingField;
            public bool IsError
            {
                [CompilerGenerated]
                get
                {
                    return default(bool);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public string ErrorMessage
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public bool IsHashDiffered
            {
                [CompilerGenerated]
                get
                {
                    return default(bool);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public string RealHash
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            private Result(bool isIoError, string errorMessage, string expectedHash, string realHash)
            {
            }

            public static Result CreateSuccess(string expectedHash, string realHash)
            {
                return null;
            }

            public static Result CreateError(string errorMessage)
            {
                return null;
            }

            public void Dispose()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CExecute_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AndroidFileDownloadRequest _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CExecute_003Ed__10(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            private void _003C_003Em__Finally1()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private string _path;
        private string _md5;
        private NativeHttpAsyncTask _task;
        private NativeHttpResult _result;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public AndroidFileDownloadRequest(string url, string path, string md5, Action<IDownloadResult, Error> onComplete, Action<ulong, ulong> onProgress) : base(default, default, default, default)
        {
        }

        [IteratorStateMachine(typeof(_003CExecute_003Ed__10))]
        public override IEnumerator Execute()
        {
            return null;
        }

        public override void Abort(Error err)
        {
        }

        protected override void CalculateProgress()
        {
        }
    }
}
