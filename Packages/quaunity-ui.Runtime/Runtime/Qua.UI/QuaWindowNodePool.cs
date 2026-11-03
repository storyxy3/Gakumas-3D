namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::Qua.Utility;

    public class QuaWindowNodePool : Singleton<QuaWindowNodePool>, IWindowNodePool
    {
        private Dictionary<IWindowNodeState, List<WindowNode>> _stateToNodes;
        protected override void OnInitialize()
        {
        }

        public WindowNode Get(IWindowNodeState state)
        {
            return null;
        }

        public void Add(IWindowNodeState state, WindowNode windowNode)
        {
        }

        public bool RemoveSingle(IWindowNodeState state)
        {
            return default(bool);
        }

        public void Remove(IWindowNodeState state)
        {
        }

        public void Clear()
        {
        }

        public QuaWindowNodePool()
        {
        }
    }
}
