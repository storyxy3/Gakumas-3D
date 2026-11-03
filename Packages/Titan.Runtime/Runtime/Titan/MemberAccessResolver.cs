namespace Titan
{
    using global::Titan;

    public class MemberAccessResolver : IMemberAccessResolver
    {
        private static MemberAccessResolver _default;
        public static IMemberAccessResolver Default
        {
            get
            {
                return null;
            }
        }

        public virtual Value GetFieldValue(Value value, string fieldName)
        {
            return null;
        }

        public MemberAccessResolver()
        {
        }
    }
}
