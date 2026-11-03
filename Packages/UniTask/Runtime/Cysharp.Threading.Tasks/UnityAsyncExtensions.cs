namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;
    using global::UnityEngine.Networking;
    using global::UnityEngine.Rendering;

    public static class UnityAsyncExtensions
    {
        private sealed class AsyncGPUReadbackRequestAwaiterConfiguredSource : IUniTaskSource<AsyncGPUReadbackRequest>, IUniTaskSource, IValueTaskSource, IValueTaskSource<AsyncGPUReadbackRequest>, IPlayerLoopItem, ITaskPoolNode<AsyncGPUReadbackRequestAwaiterConfiguredSource>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__11_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__11_0(object state)
                {
                }
            }

            private static TaskPool<AsyncGPUReadbackRequestAwaiterConfiguredSource> pool;
            private AsyncGPUReadbackRequestAwaiterConfiguredSource nextNode;
            private AsyncGPUReadbackRequest asyncOperation;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<AsyncGPUReadbackRequest> core;
            public unsafe ref AsyncGPUReadbackRequestAwaiterConfiguredSource NextNode
            {
                get
                {
                    throw null;
                }
            }

            static AsyncGPUReadbackRequestAwaiterConfiguredSource()
            {
            }

            private AsyncGPUReadbackRequestAwaiterConfiguredSource()
            {
            }

            public static IUniTaskSource<AsyncGPUReadbackRequest> Create(AsyncGPUReadbackRequest asyncOperation, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
            {
                throw null;
            }

            public AsyncGPUReadbackRequest GetResult(short token)
            {
                return default(AsyncGPUReadbackRequest);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            private bool TryReturn()
            {
                return default(bool);
            }
        }

        private sealed class AsyncOperationConfiguredSource : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncOperationConfiguredSource>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__14_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__14_0(object state)
                {
                }
            }

            private static TaskPool<AsyncOperationConfiguredSource> pool;
            private AsyncOperationConfiguredSource nextNode;
            private AsyncOperation asyncOperation;
            private IProgress<float> progress;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private bool completed;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            private Action<AsyncOperation> continuationAction;
            public unsafe ref AsyncOperationConfiguredSource NextNode
            {
                get
                {
                    throw null;
                }
            }

            static AsyncOperationConfiguredSource()
            {
            }

            private AsyncOperationConfiguredSource()
            {
            }

            public static IUniTaskSource Create(AsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, bool cancelImmediately, out short token)
            {
                throw null;
            }

            public void GetResult(short token)
            {
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            private bool TryReturn()
            {
                return default(bool);
            }

            private void Continuation(AsyncOperation _)
            {
            }
        }

        public struct ResourceRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private ResourceRequest asyncOperation;
            private Action<AsyncOperation> continuationAction;
            public bool IsCompleted
            {
                get
                {
                    return default(bool);
                }
            }

            public ResourceRequestAwaiter(ResourceRequest asyncOperation)
            {
                this = default;
            }

            public UnityEngine.Object GetResult()
            {
                return null;
            }

            public void OnCompleted(Action continuation)
            {
            }

            public void UnsafeOnCompleted(Action continuation)
            {
            }
        }

        public struct UnityWebRequestAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private UnityWebRequestAsyncOperation asyncOperation;
            private Action<AsyncOperation> continuationAction;
            public bool IsCompleted
            {
                get
                {
                    return default(bool);
                }
            }

            public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation)
            {
                this = default;
            }

            public UnityWebRequest GetResult()
            {
                return null;
            }

            public void OnCompleted(Action continuation)
            {
            }

            public void UnsafeOnCompleted(Action continuation)
            {
            }
        }

        private sealed class UnityWebRequestAsyncOperationConfiguredSource : IUniTaskSource<UnityWebRequest>, IUniTaskSource, IValueTaskSource, IValueTaskSource<UnityWebRequest>, IPlayerLoopItem, ITaskPoolNode<UnityWebRequestAsyncOperationConfiguredSource>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__14_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__14_0(object state)
                {
                }
            }

            private static TaskPool<UnityWebRequestAsyncOperationConfiguredSource> pool;
            private UnityWebRequestAsyncOperationConfiguredSource nextNode;
            private UnityWebRequestAsyncOperation asyncOperation;
            private IProgress<float> progress;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private bool completed;
            private UniTaskCompletionSourceCore<UnityWebRequest> core;
            private Action<AsyncOperation> continuationAction;
            public unsafe ref UnityWebRequestAsyncOperationConfiguredSource NextNode
            {
                get
                {
                    throw null;
                }
            }

            static UnityWebRequestAsyncOperationConfiguredSource()
            {
            }

            private UnityWebRequestAsyncOperationConfiguredSource()
            {
            }

            public static IUniTaskSource<UnityWebRequest> Create(UnityWebRequestAsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, bool cancelImmediately, out short token)
            {
                throw null;
            }

            public UnityWebRequest GetResult(short token)
            {
                return null;
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            private bool TryReturn()
            {
                return default(bool);
            }

            private void Continuation(AsyncOperation _)
            {
            }
        }

        public static UniTask<AsyncGPUReadbackRequest>.Awaiter GetAwaiter(this AsyncGPUReadbackRequest asyncOperation)
        {
            return default(UniTask<AsyncGPUReadbackRequest>.Awaiter);
        }

        public static UniTask<AsyncGPUReadbackRequest> ToUniTask(this AsyncGPUReadbackRequest asyncOperation, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask<AsyncGPUReadbackRequest>);
        }

        public static UniTask ToUniTask(this AsyncOperation asyncOperation, [Optional] IProgress<float> progress, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest asyncOperation)
        {
            return default(ResourceRequestAwaiter);
        }

        public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation)
        {
            return default(UnityWebRequestAsyncOperationAwaiter);
        }

        public static UniTask<UnityWebRequest> WithCancellation(this UnityWebRequestAsyncOperation asyncOperation, CancellationToken cancellationToken)
        {
            return default(UniTask<UnityWebRequest>);
        }

        public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation, [Optional] IProgress<float> progress, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask<UnityWebRequest>);
        }
    }
}
