namespace Campus.Gasha
{
    using global::System;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<CardInfo, RarityType> _003C_003E9__3_0;
            public static Func<CardInfo, bool> _003C_003E9__8_0;
            public static Func<GashaCardParam, CardInfo> _003C_003E9__10_0;
            public _003C_003Ec()
            {
            }

            internal RarityType _003Cget_MaximumRarityOnReversal_003Eb__3_0(CardInfo x)
            {
                return default(RarityType);
            }

            internal bool _003CTryGetPickupSsrCardInfo_003Eb__8_0(CardInfo x)
            {
                return default(bool);
            }

            internal CardInfo _003C_002Ector_003Eb__10_0(GashaCardParam x)
            {
                return null;
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
