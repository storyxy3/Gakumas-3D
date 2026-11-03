namespace Qua.UI
{
    using global::Qua.UI;

    public class WindowStateBase<T> : WindowNodeState<T> where T : WindowStateBase<T>, new()
    {
        private const string LoadPath = "Prefabs/Window/";
        protected string _windowNameCache;
        protected WindowStateBase()
        {
        }

        public override string GetPrefabName()
        {
            return null;
        }

        public override string GetLoadPath()
        {
            return null;
        }
    }
}
