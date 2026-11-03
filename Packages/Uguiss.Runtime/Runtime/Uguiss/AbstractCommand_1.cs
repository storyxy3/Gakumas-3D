namespace Uguiss
{
    using global::Uguiss;

    public abstract class AbstractCommand<T> : AbstractCommand where T : Engine
    {
        public new T Engine
        {
            get
            {
                return null;
            }
        }

        protected AbstractCommand()
        {
        }
    }
}
