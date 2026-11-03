namespace Campus.Titan
{
    using global::System;

    [Serializable]
    public class ReportData
    {
        public float radarChartParameter1;
        public float radarChartParameter2;
        public float radarChartParameter3;
        public float radarChartParameter4;
        public float radarChartParameter5;
        public int graphBgNumber;
        public int textNumber;
        public int compareGraphNumber;
        public int[] redPenTextNumbers;
        public float[] GetRadarChartParameter()
        {
            return null;
        }

        public bool HasReportText()
        {
            return default(bool);
        }

        public bool HasGraphBgAsset()
        {
            return default(bool);
        }

        public bool HasCompareGraphAsset()
        {
            return default(bool);
        }

        public bool IsDuplicateOrNullOrEmptyRedPenTexts()
        {
            return default(bool);
        }

        public ReportData()
        {
        }
    }
}
