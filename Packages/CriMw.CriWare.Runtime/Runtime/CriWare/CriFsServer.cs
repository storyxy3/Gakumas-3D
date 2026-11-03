namespace CriWare
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;

    public class CriFsServer : CriMonoBehaviour
    {
        private static CriFsServer _instance;
        private List<CriFsRequest> requestList;
        [CompilerGenerated]
        private int _003CinstallBufferSize_003Ek__BackingField;
        public static CriFsServer instance
        {
            get
            {
                return null;
            }
        }

        public int installBufferSize
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public static void CreateInstance()
        {
        }

        public static void DestroyInstance()
        {
        }

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        public void AddRequest(CriFsRequest request)
        {
        }

        public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize)
        {
            return null;
        }

        public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize)
        {
            return null;
        }

        public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate)
        {
            return null;
        }

        public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate)
        {
            return null;
        }

        public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
        {
            return null;
        }

        public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
        {
            return null;
        }

        public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
        {
            return null;
        }

        public CriFsServer()
        {
        }
    }
}
