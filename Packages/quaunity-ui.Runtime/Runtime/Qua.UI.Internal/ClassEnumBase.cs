namespace Qua.UI.Internal
{
    using global::System;
    using global::System.Reflection;
    using global::Qua.UI.Internal;
    using global::UnityEngine;
    using global::UnityEngine.Scripting;

    [Serializable]
    public class ClassEnumBase
    {
        protected const BindingFlags PropertyBindingFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy;
        [SerializeField]
        protected string _id;
        [Preserve]
        protected string Id
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static explicit operator string (ClassEnumBase state)
        {
            return null;
        }

        public static bool operator ==(ClassEnumBase x, ClassEnumBase y)
        {
            return default(bool);
        }

        public static bool operator !=(ClassEnumBase x, ClassEnumBase y)
        {
            return default(bool);
        }

        protected ClassEnumBase()
        {
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
