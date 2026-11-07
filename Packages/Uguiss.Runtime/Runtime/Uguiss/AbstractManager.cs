namespace Uguiss
{
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;
    using global::UnityEngine;

    public abstract class AbstractManager : MonoBehaviour
    {
        [CompilerGenerated]
        private Engine _003CEngine_003Ek__BackingField;
        public Engine Engine
        {
            [CompilerGenerated]
            get
            {
                return _003CEngine_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CEngine_003Ek__BackingField = value;
            }
        }

        public void Initialize(Engine engine)
        {
        }

        public void Clear()
        {
        }

        protected virtual void OnInitialize()
        {
        }

        protected virtual void OnClear()
        {
        }

        protected AbstractManager()
        {
        }
    }
}
