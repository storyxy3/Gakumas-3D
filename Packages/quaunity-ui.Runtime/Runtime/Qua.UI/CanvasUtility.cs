namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::UnityEngine;

    public static class CanvasUtility
    {
        private class CameraComparer : IComparer<Camera>
        {
            public int Compare(Camera x, Camera y)
            {
                return default(int);
            }

            public CameraComparer()
            {
            }
        }

        private static readonly CameraComparer UICameraComparer;
        public static bool TryGetRootCanvas(Component canvasChild, ref Canvas cachedRootCanvas)
        {
            return default(bool);
        }

        public static bool TryGetRootCanvas(Component canvasChild, Canvas cachedRootCanvas, out Canvas outRootCanvas)
        {
            throw null;
        }
    }
}
