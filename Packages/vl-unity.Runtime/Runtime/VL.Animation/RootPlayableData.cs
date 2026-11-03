namespace VL.Animation
{
    using global::UnityEngine.Playables;

    public struct RootPlayableData
    {
        public int baseInputIndex;
        public Playable playable;
        public Playable GetBaseInput()
        {
            return default(Playable);
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void ConnectBaseInput(Playable child)
        {
        }

        public void DisconnectBaseInput()
        {
        }

        public void Destroy()
        {
        }
    }
}
