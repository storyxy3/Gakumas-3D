namespace VL.Animation
{
    using global::UnityEngine.Playables;

    public struct RootPlayableData
    {
        public int baseInputIndex;
        public Playable playable;
        public Playable GetBaseInput()
        {
            if (playable.IsValid()) return playable.GetInput(baseInputIndex);
            return Playable.Null;
        }

        public bool IsValid()
        {
            return playable.IsValid();
        }

        public void ConnectBaseInput(Playable child)
        {
            playable.ConnectInput(baseInputIndex, child, 0, 1f);
        }

        public void DisconnectBaseInput()
        {
            playable.DisconnectInput(baseInputIndex);
        }

        public void Destroy()
        {
            if (playable.IsValid()) playable.Destroy();
        }
    }
}
