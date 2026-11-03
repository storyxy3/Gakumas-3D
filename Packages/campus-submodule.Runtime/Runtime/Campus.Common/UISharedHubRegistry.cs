namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;

    public static class UISharedHubRegistry
    {
        private static readonly HashSet<Action> _onLayoutCompleteActions;
        private static bool _isOnLayoutCompleteRegistered;
        public static void AddOnLayoutComplete(Action action)
        {
        }

        private static void OnLayoutComplete()
        {
        }

        public static void RemoveOnLayoutComplete(Action action)
        {
        }
    }
}
