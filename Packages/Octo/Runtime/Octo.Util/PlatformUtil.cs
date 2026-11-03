namespace Octo.Util
{
    using global::UnityEngine;

    internal static class PlatformUtil
    {
        public static class Android
        {
            public static string GetInternalFilesDir()
            {
                return null;
            }

            public static string GetExternalFilesDir()
            {
                return null;
            }

            public static bool IsExternalStorageWritable()
            {
                return default(bool);
            }

            public static AndroidJavaObject GetActivity()
            {
                return null;
            }
        }

        public static void SafeDontDestroyOnLoad(GameObject target)
        {
        }
    }
}
