namespace CriWare
{
    using global::System.Runtime.InteropServices;

    public class CriFs
    {
        private class NativeMethods
        {
            [PreserveSig]
            internal static extern int criFs_GetNumUsedBinders(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumUsedLoaders(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumUsedGroupLoaders(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumUsedStdioHandles(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumUsedInstallers(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumBinds(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetNumOpenedFiles(ref int curNum, ref int maxNum, ref int limit);
            [PreserveSig]
            internal static extern int criFs_GetMaxPathLength(ref int length);
            public NativeMethods()
            {
            }
        }

        public static bool GetNumUsedBinders(out int curNum, out int maxNum, out int limit)
        {
            throw null;
        }

        public static bool GetNumUsedLoaders(out int curNum, out int maxNum, out int limit)
        {
            throw null;
        }

        public static bool GetNumUsedInstallers(out int curNum, out int maxNum, out int limit)
        {
            throw null;
        }

        public static bool GetNumBinds(out int curNum, out int maxNum, out int limit)
        {
            throw null;
        }

        public static bool GetNumOpenedFiles(out int curNum, out int maxNum, out int limit)
        {
            throw null;
        }

        public static bool GetMaxPathLength(out int length)
        {
            throw null;
        }

        public CriFs()
        {
        }
    }
}
