namespace Octo.Loader
{
    using global::Octo.Loader;

    internal sealed class LoadExecutor : BaseExecutor
    {
        private static readonly string LocalTag;
        private static readonly int LocalDefaultParallel;
        protected override string Tag
        {
            get
            {
                return null;
            }
        }

        protected override int DefaultParallel
        {
            get
            {
                return default(int);
            }
        }

        public override void AbortAll()
        {
        }

        public LoadExecutor()
        {
        }
    }
}
