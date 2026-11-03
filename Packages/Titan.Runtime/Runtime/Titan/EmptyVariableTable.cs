namespace Titan
{
    using global::Titan;

    public class EmptyVariableTable : IVariableTable
    {
        private static EmptyVariableTable _default;
        public static EmptyVariableTable Default
        {
            get
            {
                return null;
            }
        }

        public Value GetValue(string id)
        {
            return null;
        }

        public EmptyVariableTable()
        {
        }
    }
}
