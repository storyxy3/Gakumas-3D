namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Qua.Utility;

    public class CampusVideoManager : Singleton<CampusVideoManager>
    {
        private float _globalVolume;
        [CompilerGenerated]
        private bool _003CIsGlobalVolumeDirty_003Ek__BackingField;
        public bool IsGlobalVolumeDirty
        {
            [CompilerGenerated]
            get
            {
                return _003CIsGlobalVolumeDirty_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsGlobalVolumeDirty_003Ek__BackingField = value;
            }
        }

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnInitialize()
        {
        }

        public static void SetGlobalVolume(float volume)
        {
        }

        public static float GetGlobalVolume()
        {
            return default(float);
        }

        public CampusVideoManager()
        {
        }
    }
}
