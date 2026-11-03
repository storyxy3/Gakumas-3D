namespace Titan
{
    using global::UnityEngine.Timeline;

    public abstract class TitanTrackBase : TrackAsset
    {
        internal override void GetSequenceTime(out double outStart, out double outDuration)
        {
            throw null;
        }

        protected virtual void GetTitanSequenceTime(out double outStart, out double outDuration)
        {
            throw null;
        }

        protected static int CombineHash(int h1, int h2)
        {
            return default(int);
        }

        protected TitanTrackBase()
        {
        }
    }
}
