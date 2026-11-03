namespace UniRx
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;

    public abstract class StableCompositeDisposable : ICancelable, IDisposable
    {
        private class Binary : StableCompositeDisposable
        {
            private int disposedCallCount;
            private IDisposable _disposable1;
            private IDisposable _disposable2;
            public override bool IsDisposed
            {
                get
                {
                    return default(bool);
                }
            }

            public Binary(IDisposable disposable1, IDisposable disposable2)
            {
            }

            public override void Dispose()
            {
            }
        }

        private class Trinary : StableCompositeDisposable
        {
            private int disposedCallCount;
            private IDisposable _disposable1;
            private IDisposable _disposable2;
            private IDisposable _disposable3;
            public override bool IsDisposed
            {
                get
                {
                    return default(bool);
                }
            }

            public Trinary(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3)
            {
            }

            public override void Dispose()
            {
            }
        }

        private class Quaternary : StableCompositeDisposable
        {
            private int disposedCallCount;
            private IDisposable _disposable1;
            private IDisposable _disposable2;
            private IDisposable _disposable3;
            private IDisposable _disposable4;
            public override bool IsDisposed
            {
                get
                {
                    return default(bool);
                }
            }

            public Quaternary(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3, IDisposable disposable4)
            {
            }

            public override void Dispose()
            {
            }
        }

        private class NAry : StableCompositeDisposable
        {
            private int disposedCallCount;
            private List<IDisposable> _disposables;
            public override bool IsDisposed
            {
                get
                {
                    return default(bool);
                }
            }

            public NAry(IDisposable[] disposables)
            {
            }

            public NAry(IEnumerable<IDisposable> disposables)
            {
            }

            public override void Dispose()
            {
            }
        }

        private class NAryUnsafe : StableCompositeDisposable
        {
            private int disposedCallCount;
            private IDisposable[] _disposables;
            public override bool IsDisposed
            {
                get
                {
                    return default(bool);
                }
            }

            public NAryUnsafe(IDisposable[] disposables)
            {
            }

            public override void Dispose()
            {
            }
        }

        public abstract bool IsDisposed { get; }

        public static ICancelable Create(IDisposable disposable1, IDisposable disposable2)
        {
            return null;
        }

        public static ICancelable Create(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3)
        {
            return null;
        }

        public static ICancelable Create(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3, IDisposable disposable4)
        {
            return null;
        }

        public static ICancelable Create(params IDisposable[] disposables)
        {
            return null;
        }

        public static ICancelable CreateUnsafe(IDisposable[] disposables)
        {
            return null;
        }

        public abstract void Dispose();
        protected StableCompositeDisposable()
        {
        }
    }
}
