namespace Campus.Gasha
{
    using global::System;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::JetBrains.Annotations;

    [Serializable]
    public class GashaCardParam
    {
        public CardType cardType;
        public RarityType rarityType;
        public string characterId;
        public string cardAssetName;
        public string idolCardSignAssetName;
        public string idolCardRainbowSignAssetName;
        public string idolCardNameAssetName;
        [CanBeNull]
        public CampusActorDescriptor idolCardActorDescriptor;
        [CanBeNull]
        public string idolCardMusicAssetName;
        public int pickupBgmStartTimeMs;
        [CanBeNull]
        public string idolCardMovieAssetName;
        [CanBeNull]
        public string idolCardMovieLoopAssetName;
        public string name;
        public string subName;
        public string skinName;
        public string[] supportFlavorVoices;
        public string idolCardVoiceAssetName;
        public string liveVideoAssetName;
        public int idolCardSsrAnimationStartMilliseconds;
        public int gashaAnimationNumber;
        public string[] flavorTexts;
        public bool isPickUp;
        public bool isNew;
        [NonSerialized]
        public Func<CancellationToken, UniTask> onProduceCardSkinCutIn;
        public GashaCardParam()
        {
        }
    }
}
