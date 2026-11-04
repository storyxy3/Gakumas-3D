namespace VL
{
    using global::VL;

    public static class VLCameraController
    {
        private static IVLCameraController _instance;
        public static bool HasInstance
        {
            get
            {
                return _instance != null;
            }
        }

        public static IVLCameraController Instance
        {
            get
            {
                return _instance;
            }

            internal set
            {
                _instance = value;
            }
        }
    }
}
