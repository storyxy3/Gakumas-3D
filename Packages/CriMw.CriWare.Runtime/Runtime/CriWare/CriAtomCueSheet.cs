namespace CriWare
{
    using global::System;
    using global::CriWare;

    [Serializable]
    public class CriAtomCueSheet
    {
        public string name;
        public string acbFile;
        public string awbFile;
        public CriAtomExAcb acb;
        public CriAtomExAcbLoader.Status loaderStatus;
        public bool IsLoading
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsError
        {
            get
            {
                return default(bool);
            }
        }

        public CriAtomCueSheet()
        {
        }
    }
}
