namespace Common.Live
{
    using global::System;
    using global::Common.Live;

    [Serializable]
    public class MuteTrackDisableSetting
    {
        public string trackName;
        public bool disableTrackBinding;
        public MuteTrackComponentDisableTarget componentDisableTarget;
        public MuteTrackDisableSetting()
        {
        }
    }
}
