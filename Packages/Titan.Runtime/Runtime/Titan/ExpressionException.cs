namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;

    public class ExpressionException : Exception
    {
        [CompilerGenerated]
        private readonly string _003CExpression_003Ek__BackingField;
        [CompilerGenerated]
        private readonly Exception _003CInternalException_003Ek__BackingField;
        public string Expression
        {
            [CompilerGenerated]
            get
            {
                return _003CExpression_003Ek__BackingField;
            }
        }

        public Exception InternalException
        {
            [CompilerGenerated]
            get
            {
                return _003CInternalException_003Ek__BackingField;
            }
        }
    }
}
