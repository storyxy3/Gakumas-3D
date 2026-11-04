// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;

namespace CriWare
{
    public static partial class CriFsUtility
    {

        public const int DefaultReadUnitSize = 1048576;


        public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576)
        {
            return null;
        }



        public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576)
        {
            return null;
        }



        public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576)
        {
            return null;
        }



        public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576)
        {
            return null;
        }



        public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576)
        {
            return null;
        }



        public static CriFsInstallRequest Install(string srcPath, string dstPath)
        {
            return null;
        }



        public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }



        public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath)
        {
            return null;
        }



        public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }



        public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
        {
            return null;
        }



        public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }



        public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }



        public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }



        public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }



        public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath)
        {
            return null;
        }



        public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
        {
            return null;
        }



        public static void SetProxyServer(string proxyPath, ushort proxyPort)
        {
        }



        public static void SetPathSeparator(string filter)
        {
        }
    }
}
