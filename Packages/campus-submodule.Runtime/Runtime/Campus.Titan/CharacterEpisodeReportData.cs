namespace Campus.Titan
{
    using global::System;
    using global::Campus.Titan;
    using global::UnityEngine;

    [Serializable]
    public class CharacterEpisodeReportData
    {
        [SerializeField]
        private string _characterId;
        [SerializeField]
        private EpisodeReportData[] _episodeData;
        public string CharacterId
        {
            get
            {
                return null;
            }
        }

        public EpisodeReportData[] EpisodeData
        {
            get
            {
                return null;
            }
        }

        public CharacterEpisodeReportData()
        {
        }
    }
}
