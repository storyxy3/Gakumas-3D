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
                return default(bool);
            }
        }

        public static IVLCameraController Instance
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }
    }
}
