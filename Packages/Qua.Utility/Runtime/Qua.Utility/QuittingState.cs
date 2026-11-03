namespace Qua.Utility
{
    using global::UnityEngine;

    public static class QuittingState
    {
        private static bool _isQuiting;
        public static bool IsQuitting
        {
            get
            {
                return default(bool);
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void OnInitialize()
        {
        }

        private static void OnQuitting()
        {
        }
    }
}
