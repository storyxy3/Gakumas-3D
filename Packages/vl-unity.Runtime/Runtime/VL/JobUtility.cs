namespace VL
{
    using global::Unity.Collections;
    using global::VL;

    public static class JobUtility
    {
        public struct Array2DInfo
        {
            public int start;
            public int length;
            public int end
            {
                get
                {
                    return default(int);
                }
            }
        }

        public static void AddInfo(this NativeList<Array2DInfo> list, int length)
        {
        }
    }
}
