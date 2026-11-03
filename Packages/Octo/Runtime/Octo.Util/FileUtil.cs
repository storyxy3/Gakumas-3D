namespace Octo.Util
{
    using global::System;
    using global::System.IO;
    using global::System.Text;
    using global::Octo;

    internal static class FileUtil
    {
        private static readonly string Tag;
        private static readonly string OctoDirectory;
        private static readonly string CacheDirectory;
        private static string _mobileRootPath;
        private static readonly int PathCombinerCapacity;
        [ThreadStatic]
        private static StringBuilder _pathCombiner;
        public static string GetCachePath()
        {
            return null;
        }

        public static string GetDatabaseRoot()
        {
            return null;
        }

        private static string GetMobileOctoRoot()
        {
            return null;
        }

        private static string GetAndroidOctoRoot()
        {
            return null;
        }

        public static bool FileDelete(string filePath)
        {
            return default(bool);
        }

        public static bool DirectoryDelete(string path)
        {
            return default(bool);
        }

        public static void DeleteAllFiles(DirectoryInfo di)
        {
        }

        public static Error CreateDirectory(string filePath)
        {
            return null;
        }

        public static byte[] ReadAllBytes(string path)
        {
            return null;
        }

        public static Error WriteAllBytes(string path, params byte[][] datas)
        {
            return null;
        }

        public static string UnsafePathCombine<T>(string root, params T[] args)
            where T : class
        {
            return null;
        }

        public static string UnsafePathCombine(string root, params object[] args)
        {
            return null;
        }
    }
}
