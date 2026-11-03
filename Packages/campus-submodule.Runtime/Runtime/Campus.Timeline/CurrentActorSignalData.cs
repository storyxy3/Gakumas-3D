namespace Campus.Timeline
{
    public readonly struct CurrentActorSignalData
    {
        public readonly int SlotIndex;
        public readonly int Before;
        public readonly int After;
        public CurrentActorSignalData(int slotIndex, int before, int after)
        {
            this = default;
        }
    }
}
