// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Collections.Generic;
using global::System.Runtime.CompilerServices;

namespace CriWare
{
    public partial class CriFsServer
    {

        private List<CriFsRequest> requestList;


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



        private void Awake()
        {
        }



        private void OnDestroy()
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
