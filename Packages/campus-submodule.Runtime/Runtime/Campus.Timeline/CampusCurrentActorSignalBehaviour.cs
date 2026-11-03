namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusCurrentActorSignalBehaviour : PlayableBehaviour
    {
        public int currentActorIndex;
        public CampusCurrentActorSignalBehaviour()
        {
        }
    }
}
