namespace CriWare
{
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    public class CriFsLoadAssetBundleRequest : CriFsRequest
    {
        [CompilerGenerated]
        private string _003Cpath_003Ek__BackingField;
        [CompilerGenerated]
        private AssetBundle _003CassetBundle_003Ek__BackingField;
        private CriFsLoadFileRequest loadFileReq;
        private AssetBundleCreateRequest assetBundleReq;
        public string path
        {
            [CompilerGenerated]
            get
            {
                return _003Cpath_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Cpath_003Ek__BackingField = value;
            }
        }

        public AssetBundle assetBundle
        {
            [CompilerGenerated]
            get
            {
                return _003CassetBundle_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CassetBundle_003Ek__BackingField = value;
            }
        }

        public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize)
        {
        }

        public override void Update()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}
