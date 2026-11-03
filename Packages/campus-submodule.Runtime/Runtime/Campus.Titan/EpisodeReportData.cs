namespace Campus.Titan
{
    using global::System;
    using global::Campus.Titan;

    [Serializable]
    public class EpisodeReportData
    {
        public int episode;
        public int index;
        public ReportData reportData;
        public EpisodeReportData()
        {
        }
    }
}
