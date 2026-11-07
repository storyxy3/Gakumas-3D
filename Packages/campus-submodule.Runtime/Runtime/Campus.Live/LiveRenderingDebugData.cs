namespace Campus.Live
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    public static class LiveRenderingDebugData
    {
        [CompilerGenerated]
        private static int _003CLightCount_003Ek__BackingField;
        [CompilerGenerated]
        private static Light[] _003CVisibleLights_003Ek__BackingField;
        public static int LightCount
        {
            [CompilerGenerated]
            set
            {
                _003CLightCount_003Ek__BackingField = value;
            }
        }

        public static Light[] VisibleLights
        {
            [CompilerGenerated]
            get
            {
                return _003CVisibleLights_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CVisibleLights_003Ek__BackingField = value;
            }
        }
    }
}
