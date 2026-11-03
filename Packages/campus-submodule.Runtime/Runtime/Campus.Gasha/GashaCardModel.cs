namespace Campus.Gasha
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Gasha;

    public class GashaCardModel
    {
        public class CardInfo
        {
            public GashaCardParam cardParam;
            public CardReversalType CardReversalType;
            [CompilerGenerated]
            private RarityType _003CReversalRarity_003Ek__BackingField;
            public RarityType ReversalRarity
            {
                [CompilerGenerated]
                get
                {
                    return default(RarityType);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public RarityType OriginalRarity
            {
                get
                {
                    return default(RarityType);
                }
            }

            public CardInfo(GashaCardParam cardParam)
            {
            }
        }

        public class PickupSsrCardInfo
        {
            public string characterId;
            public string musicId;
            public int musicStartMs;
            public CampusActorDescriptor actorDescriptor;
            public PickupSsrCardInfo()
            {
            }
        }

        private GashaCardParam[] _cardParams;
        [CompilerGenerated]
        private readonly CardInfo[] _003CCardInfos_003Ek__BackingField;
        public RarityType MaximumRarityOnReversal
        {
            get
            {
                return default(RarityType);
            }
        }

        public CardInfo[] CardInfos
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public bool TryGetPickupSsrCardInfo(out PickupSsrCardInfo info)
        {
            throw null;
        }

        private GashaCardModel(GashaCardParam[] cardParams)
        {
        }

        public static GashaCardModel BuildCardModel(GashaCardParam[] cardParams)
        {
            return null;
        }
    }
}
