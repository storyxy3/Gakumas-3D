namespace Octo.Util.Android
{
    using global::UnityEngine;

    public static class AndroidFileUtil
    {
        private static readonly string Tag;
        private static AndroidJavaClass fileUtilClass;
        private static AndroidJavaObject androidActivity;
        public static bool MoveAsset(string src, string dest)
        {
            return default(bool);
        }

        public static bool MovePackAsset(string src, string dest)
        {
            return default(bool);
        }

        public static bool ExistsAsset(string src)
        {
            return default(bool);
        }

        public static bool ExistsPackAsset(string src)
        {
            return default(bool);
        }

        private static void PrepareActivity()
        {
        }
    }
}
