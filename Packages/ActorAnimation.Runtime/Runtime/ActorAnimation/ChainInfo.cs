namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ActorAnimation;

    [Serializable]
    public class ChainInfo
    {
        public List<ChainLayerInfo> layers = new List<ChainLayerInfo>();
        public ChainInfo()
        {
        }
    }
}
