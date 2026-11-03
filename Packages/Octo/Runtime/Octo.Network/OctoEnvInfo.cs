namespace Octo.Network
{
    using global::System;

    [Serializable]
    public struct OctoEnvInfo
    {
        public string clientSdkVersion;
        public int appId;
        public int version;
        public int localDbRevision;
    }
}
