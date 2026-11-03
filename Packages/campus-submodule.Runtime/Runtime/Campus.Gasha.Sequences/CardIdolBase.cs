namespace Campus.Gasha.Sequences
{
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::JetBrains.Annotations;
    using global::Titan;
    using global::TMPro;

    public abstract class CardIdolBase : GashaSequenceBase
    {
        [CanBeNull]
        public GashaResourceView idolCard;
        [CanBeNull]
        public GashaResourceView idolCardName;
        [CanBeNull]
        public GashaResourceView sign;
        [CanBeNull]
        public TextMeshProUGUI subNameText;
        [CanBeNull]
        public TitanPlayer isNewTitanPlayer;
        protected CardIdolBase()
        {
        }
    }
}
