namespace Octo.Caching
{
    using global::System.Collections.Generic;
    using global::System.IO;

    public class CacheDeleteExecutor
    {
        private static readonly string Tag;
        private string _targetDirectory;
        private Queue<string> _deleteDirectories;
        private int _isDeleteDirectoryThread;
        public void Setup(string directory)
        {
        }

        public void Clean()
        {
        }

        public bool MoveDirectoryToDelete(string directory)
        {
            return default(bool);
        }

        public bool MoveDirectoryToDelete(DirectoryInfo di)
        {
            return default(bool);
        }

        private void StartDeleteDirectoryThread()
        {
        }

        private void DeleteDirectoryThread(object state)
        {
        }

        public CacheDeleteExecutor()
        {
        }
    }
}
