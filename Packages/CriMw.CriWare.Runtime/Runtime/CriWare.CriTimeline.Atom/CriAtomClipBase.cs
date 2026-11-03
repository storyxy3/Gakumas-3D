namespace CriWare.CriTimeline.Atom
{
    using global::CriWare;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset
    {
        public bool stopWithoutRelease;
        public bool muted;
        public bool ignoreBlend;
        public bool loopWithinClip;
        public bool stopAtClipEnd;
        [SerializeField]
        [HideInInspector]
        private double clipDuration;
        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override double duration
        {
            get
            {
                return default(double);
            }
        }

        public abstract string CueName { get; }
        public abstract string AcbPath { get; }
        public abstract string AwbPath { get; }

        public void SetClipDuration(double clipDuration)
        {
        }

        public abstract CriAtomExAcb GetAcb();
        public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);
        protected CriAtomClipBase()
        {
        }
    }
}
