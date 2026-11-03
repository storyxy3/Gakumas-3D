namespace Campus.Timeline
{
    internal interface ICurrentActorSignalNotifier
    {
        void InitializeSlotDefault(int slotIndex, int defaultActorIndex);
        void NotifyCurrentActorSignal(int slotIndex, int nextActorIndex);
    }
}
