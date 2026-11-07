namespace Qua.Utility
{
    using global::UnityEngine;

    public static class HierarchyUtility
    {
        public static Transform FindOrCreateTransform(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;
            GameObject found = GameObject.Find(path);
            if (found != null)
                return found.transform;
            Transform parent = null;
            int separator = path.LastIndexOf('/');
            if (separator != -1)
            {
                parent = FindOrCreateTransform(path.Substring(0, separator));
                path = path.Substring(separator + 1);
            }
            var created = new GameObject(path);
            created.transform.SetParent(parent);
            return created.transform;
        }

        public static void CreateDontDestroyGameObject(string name)
        {
            if (string.IsNullOrEmpty(name))
                return;
            if (GameObject.Find(name) != null)
                return;
            var created = new GameObject(name);
            Object.DontDestroyOnLoad(created);
        }
    }
}
