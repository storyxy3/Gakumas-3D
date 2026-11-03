namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusLookAtProhibitBehaviour : PlayableBehaviour
    {
        public bool affectsAllActors;
        public LookAtProhibitType allActorProhibitType;
        public LookAtProhibitType[] actorTypes;
        public CampusLookAtProhibitBehaviour()
        {
        }
    }
}
