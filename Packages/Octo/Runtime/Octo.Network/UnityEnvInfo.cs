namespace Octo.Network
{
    using global::System;

    [Serializable]
    public struct UnityEnvInfo
    {
        public string unityVersion;
        public string platform;
        public bool isEditor;
    }
}
