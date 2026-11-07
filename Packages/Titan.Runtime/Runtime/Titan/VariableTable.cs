namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Titan;

    public class VariableTable : IVariableTable
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Callable _003C_003E9__2_0;
            public _003C_003Ec()
            {
            }

            internal Value _003CGetValue_003Eb__2_0(IReadOnlyList<Value> args)
            {
                return null;
            }
        }

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
