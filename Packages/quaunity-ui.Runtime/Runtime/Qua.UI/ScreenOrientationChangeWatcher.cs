namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class ScreenOrientationChangeWatcher : Singleton<ScreenOrientationChangeWatcher>
    {
        private ScreenOrientation _prevOrientation;
        [CompilerGenerated]
        private Action<ScreenOrientation> m_onOrientationChanged;
        public event Action<ScreenOrientation> onOrientationChanged
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

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnInitialize()
        {
        }

        private void Update()
        {
        }

        public ScreenOrientationChangeWatcher()
        {
        }
    }
}
