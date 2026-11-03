namespace Titan
{
    using global::Titan;

    public class VariableTable : IVariableTable
    {
        private readonly IVariableTable _table;
        public VariableTable(IVariableTable table)
        {
        }

        public Value GetValue(string id)
        {
            return null;
        }
    }
}
