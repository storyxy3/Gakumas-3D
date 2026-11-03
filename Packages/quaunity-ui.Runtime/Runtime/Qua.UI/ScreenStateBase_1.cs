namespace Qua.UI
{
    using global::Qua.UI;

    public class ScreenStateBase<T> : WindowNodeState<T> where T : ScreenStateBase<T>, new()
    {
        protected string _screenNameCache;
        protected ScreenStateBase()
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
