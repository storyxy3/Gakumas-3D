namespace Campus.Timeline
{
    using global::System.Collections.Generic;
    using global::Campus.Common.Panorama;

    public interface IPanoramaCameraController
    {
        void SetUserCamera(SwitchPanoramaCamera camera);
        SwitchPanoramaCamera ResolveCamera(PanoramaCameraType type, int index);
        IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> GetAllPanoramaCameras();
    }
}
