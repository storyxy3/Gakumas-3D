namespace Qua.UI.Internal
{
    using global::System.Reflection;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI.Internal;

    [DefaultMember("Item")]
    internal class CsvWrapper
    {
        private string[][] _csv;
        [CompilerGenerated]
        private int _003CLineCount_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CColumnCountPerLine_003Ek__BackingField;
        public int LineCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int ColumnCountPerLine
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public static CsvWrapper CreateCSVData(string csvText)
        {
            return null;
        }

        public CsvWrapper(string[][] csv)
        {
        }

        public string Get(int lineIndex, int columnIndex)
        {
            return null;
        }

        private T Get<T>(T[] array, int index)
        {
            return default(T);
        }
    }
}
