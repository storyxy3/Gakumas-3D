namespace VL.Unsafe.Jobs
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::VL;
    using global::VL.Unsafe.Jobs;

    public struct ActorExpressionSymbolEnumerator : IEnumerator<ActorExpressionSymbol>, IEnumerator, IDisposable
    {
        private int _index;
        private unsafe ActorExpressionSymbol* _symbols;
        private unsafe ActorExpressionSymbol* _iterator;
        private JobUtility.Array2DInfo _info;
        public ActorExpressionSymbol Current
        {
            get
            {
                return default(ActorExpressionSymbol);
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return null;
            }
        }

        public unsafe ActorExpressionSymbolEnumerator(ActorExpressionSymbol* symbols, JobUtility.Array2DInfo info)
        {
            this = default;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return default(bool);
        }

        public void Reset()
        {
        }
    }
}
