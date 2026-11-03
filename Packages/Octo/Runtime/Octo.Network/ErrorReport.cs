namespace Octo.Network
{
    using global::System;
    using global::Octo;
    using global::Octo.Network;

    [Serializable]
    internal class ErrorReport
    {
        public AppInfo appInfo;
        public UnityEnvInfo unityEnv;
        public OctoEnvInfo octoEnv;
        public ErrorReportLog log;
        public ErrorReport(IOctoSettings settings)
        {
        }

        public void SetInfo(ErrorLevel level, string tag, string message, long time)
        {
        }
    }
}
