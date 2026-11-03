namespace Campus.Common
{
    using global::System;

    [Serializable]
    public readonly struct SoundInfo
    {
        public readonly string cueSheetName;
        public readonly string cueName;
        public readonly bool isAutoUnload;
        public bool IsValid
        {
            get
            {
                return default(bool);
            }
        }

        public SoundInfo(string cueSheetName, string cueName, bool isAutoUnload)
        {
            this = default;
        }

        public (string, string) GetResourceName()
        {
            return default((string, string));
        }
    }
}
