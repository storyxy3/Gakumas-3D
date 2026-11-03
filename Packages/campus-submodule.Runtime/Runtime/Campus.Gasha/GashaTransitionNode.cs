namespace Campus.Gasha
{
    using global::System;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    public class GashaTransitionNode : IDisposable
    {
        public GashaTransitionNode next;
        public GashaTransitionNode skipped;
        public GashaSequenceBase sequence;
        public Action<GashaPlayer> onPlay;
        public void Dispose()
        {
        }

        public GashaTransitionNode()
        {
        }
    }
}
