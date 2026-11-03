namespace Qua.UI.Internal
{
    using global::Qua.UI.Internal;

    public class ClassEnum<T> : ClassEnumBase where T : ClassEnumBase, new()
    {
        protected ClassEnum()
        {
        }

        protected static T GetValue(string id)
        {
            return null;
        }

        public static bool IsDefined(string name)
        {
            return default(bool);
        }

        public static T Parse(string id)
        {
            return null;
        }
    }
}
