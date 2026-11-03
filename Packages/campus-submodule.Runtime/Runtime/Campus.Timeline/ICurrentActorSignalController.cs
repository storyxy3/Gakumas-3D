namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;

    public interface ICurrentActorSignalController
    {
        int GetCurrentActorIndex(int slotIndex);
        IObservable<CurrentActorSignalData> OnCurrentActorSignalAsObservable();
    }
}
