namespace Campus.Common
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class SerializableTuple<T1, T2>
    {
        [SerializeField]
        protected T1 _value1;
        [SerializeField]
        protected T2 _value2;
        public T1 Value1
        {
            get
            {
                return default(T1);
            }
        }

        public T2 Value2
        {
            get
            {
                return default(T2);
            }
        }

        protected SerializableTuple()
        {
        }
    }
}
