namespace Octo.Network
{
    using global::System;

    [Serializable]
    public struct ErrorReportLog
    {
        public long sinceStartupMilliseconds;
        public string level;
        public string tag;
        public string message;
    }
}
