namespace Common.Live
{
    using global::System;
    using global::Common.Live;
    using global::JetBrains.Annotations;

    [Serializable]
    public class OverrideActorMotionTrack
    {
        public string trackName;
        [CanBeNull]
        public OverrideActorMotionClip[] clips;
        public OverrideActorMotionTrack()
        {
        }
    }
}
