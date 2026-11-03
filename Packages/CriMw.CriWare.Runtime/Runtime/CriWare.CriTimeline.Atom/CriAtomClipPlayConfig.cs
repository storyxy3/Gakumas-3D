namespace CriWare.CriTimeline.Atom
{
    using global::CriWare.CriTimeline.Atom;

    public struct CriAtomClipPlayConfig
    {
        public readonly CriAtomClipBase clip;
        public readonly long startTimeMs;
        public readonly double speedRate;
        public readonly bool loop;
        public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop)
        {
            this = default;
        }
    }
}
