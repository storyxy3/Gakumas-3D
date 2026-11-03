namespace Campus.Timeline
{
    internal interface ILookAtProhibitSource
    {
        void BeginLookAtProhibitSource(int sourceId);
        void SetLookAtProhibitAll(int sourceId);
        void SetLookAtEnableProhibitAll(int sourceId);
        void AddLookAtProhibitedActor(int sourceId, int actorIndex);
        void AddLookAtEnableProhibitedActor(int sourceId, int actorIndex);
        void RemoveLookAtProhibitSource(int sourceId);
        void FlushLookAtProhibitSource(int sourceId);
    }
}
