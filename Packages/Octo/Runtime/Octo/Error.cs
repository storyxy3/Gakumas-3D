namespace Octo
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    internal sealed class Error
    {
        [CompilerGenerated]
        private string _003CCode_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CMessage_003Ek__BackingField;
        public string Code
        {
            [CompilerGenerated]
            get
            {
                return _003CCode_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCode_003Ek__BackingField = value;
            }
        }

        public string Message
        {
            [CompilerGenerated]
            get
            {
                return _003CMessage_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CMessage_003Ek__BackingField = value;
            }
        }

        public Error(string code, string message)
        {
        }

        public static Error CreateWithFormat(string code, string format, params string[] args)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
