namespace Campus.Photography
{
    using global::System.Collections.Generic;

    public static class PhotographyDefine
    {
        private static float _initialFocalLength;
        private static readonly float _zoomRatioBase;
        private static readonly float _zoomChangeControllRatio;
        public static readonly List<float> CameraFNumberSteps;
        public static float DefaultFocalLength
        {
            get
            {
                return default(float);
            }
        }

        public static float GetZoomRatio(float focalLength)
        {
            return default(float);
        }

        public static float GetFocalLength(float zoomRatio)
        {
            return default(float);
        }

        public static void SetDefaultFocalLength(bool isLandScape)
        {
        }
    }
}
