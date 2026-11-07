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
                return _isQuiting && Application.isPlaying;
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void OnInitialize()
        {
            Application.quitting += OnQuitting;
            _isQuiting = false;
        }

        private static void OnQuitting()
        {
            _isQuiting = true;
            Application.quitting -= OnQuitting;
        }
    }
}
