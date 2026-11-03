namespace Uguiss
{
    using global::Uguiss;

    public abstract class AbstractManager<T> : AbstractManager where T : Engine
    {
        public new T Engine
        {
            get
            {
                return null;
            }
        }

        protected AbstractManager()
        {
        }
    }
}
