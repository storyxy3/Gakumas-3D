namespace Octo.Util
{
    using global::System;

    internal static class OctoUtil
    {
        [ThreadStatic]
        private static char[] _sharedCharaBuffer;
        private static readonly int LookupStringToLowerLength;
        private static readonly uint[] LookupStringToHex;
        private static readonly byte[] LookupHexToString;
        private static uint[] CreateHexLookupTable()
        {
            return null;
        }

        public static string StringToHex(string input)
        {
            return null;
        }

        public static string HexToString(string hex)
        {
            return null;
        }

        private static string SlowStringToHex(string input)
        {
            return null;
        }

        private static string SlowHexToString(string hex)
        {
            return null;
        }

        private static int ConvertToBase16(char c)
        {
            return default(int);
        }

        public static string FastToLower(string s)
        {
            return null;
        }
    }
}
