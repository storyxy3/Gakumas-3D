namespace Qua.UI
{
    using global::Qua.UI;
    using global::Qua.UI.Internal;

    public abstract class WindowNodeState<T> : ClassEnum<T>, IWindowNodeState where T : WindowNodeState<T>, new()
    {
        protected WindowNodeState()
        {
        }

        public abstract string GetPrefabName();
        public abstract string GetLoadPath();
    }
}
