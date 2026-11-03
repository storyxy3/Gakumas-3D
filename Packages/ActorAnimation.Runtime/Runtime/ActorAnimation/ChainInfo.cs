namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ActorAnimation;

    [Serializable]
    public class ChainInfo
    {
        public List<ChainLayerInfo> layers;
        public ChainInfo()
        {
        }
    }
}
