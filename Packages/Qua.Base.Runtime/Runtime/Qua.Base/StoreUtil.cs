namespace Qua.Base
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Qua.Base;
    using global::UnityEngine;

    public static class StoreUtil
    {
        private interface IBridge
        {
            bool IsRequestReviewSupported { get; }

            void RequestReview();
        }

        private class DummyBridge : IBridge
        {
            public bool IsRequestReviewSupported
            {
                get
                {
                    return default(bool);
                }
            }

            public void RequestReview()
            {
            }

            public DummyBridge()
            {
            }
        }

        private class ReviewRequester : MonoBehaviour
        {
            public ReviewRequester()
            {
            }
        }

        private class AndroidBridge : IBridge
        {
            [CompilerGenerated]
            private sealed class _003CRequestReviewAndroid_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public GameObject runner;
                private object /* TODO(qa-recon): Google.Play.Review.ReviewManager excluded from rendering closure. */ _003CreviewManager_003E5__2;
                private object /* TODO(qa-recon): Google.Play.Common.PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> excluded from rendering closure. */ _003CrequestFlowOperation_003E5__3;
                private object /* TODO(qa-recon): Google.Play.Common.PlayAsyncOperation<VoidResult, ReviewErrorCode> excluded from rendering closure. */ _003ClaunchFlowOperation_003E5__4;
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
                public _003CRequestReviewAndroid_003Ed__3(int _003C_003E1__state)
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

                [DebuggerHidden]
                void System.Collections.IEnumerator.Reset()
                {
                }
            }

            public bool IsRequestReviewSupported
            {
                get
                {
                    return default(bool);
                }
            }

            public void RequestReview()
            {
            }

            [IteratorStateMachine(typeof(_003CRequestReviewAndroid_003Ed__3))]
            private IEnumerator RequestReviewAndroid(GameObject runner)
            {
                return null;
            }

            public AndroidBridge()
            {
            }
        }

        private static IBridge bridge;
        public static bool IsRequestReviewSupported
        {
            get
            {
                return default(bool);
            }
        }

        public static void RequestReview()
        {
        }

        static StoreUtil()
        {
        }
    }
}
