namespace Qua.UI.Internal
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    internal static class QuittingState
    {
        [CompilerGenerated]
        private static bool _003CIsQuitting_003Ek__BackingField;
        private static bool IsQuitting
        {
            [CompilerGenerated]
            set
            {
                _003CIsQuitting_003Ek__BackingField = value;
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void OnInitialize()
        {
            Application.quitting += OnQuitting;
            IsQuitting = false;
        }

        private static void OnQuitting()
        {
            IsQuitting = true;
            Application.quitting -= OnQuitting;
        }
    }
}
