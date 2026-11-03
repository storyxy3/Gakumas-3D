namespace DG.Tweening.Core
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening.Core;

    internal struct SafeModeReport
    {
        internal enum SafeModeReportType
        {
            Unset,
            TargetOrFieldMissing,
            Callback,
            StartupFailure
        }

        [CompilerGenerated]
        private int _003CtotMissingTargetOrFieldErrors_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CtotCallbackErrors_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CtotStartupErrors_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CtotUnsetErrors_003Ek__BackingField;
        public int totMissingTargetOrFieldErrors
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int totCallbackErrors
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int totStartupErrors
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int totUnsetErrors
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public void Add(SafeModeReportType type)
        {
        }

        public int GetTotErrors()
        {
            return default(int);
        }
    }
}
