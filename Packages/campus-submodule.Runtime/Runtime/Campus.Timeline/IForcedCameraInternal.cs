namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::Cinemachine;

    internal interface IForcedCameraInternal
    {
        void SetForcedCamera(int sourceId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime, bool forceAuto = false);
        void RemoveForcedCameraSource(int sourceId);
        void NotifyForcedCameraChanged(ForcedCameraChangedInfo info);
    }
}
