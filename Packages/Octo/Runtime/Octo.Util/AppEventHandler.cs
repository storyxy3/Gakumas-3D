namespace Octo.Util
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    public class AppEventHandler : MonoBehaviour
    {
        [CompilerGenerated]
        private static Action m_OnApplicationQuitEvent;
        public static event Action OnApplicationQuitEvent
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        private void OnApplicationQuit()
        {
        }

        public AppEventHandler()
        {
        }
    }
}
