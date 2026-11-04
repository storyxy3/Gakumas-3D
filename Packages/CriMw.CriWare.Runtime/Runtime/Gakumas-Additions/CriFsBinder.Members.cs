// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public partial class CriFsBinder
    {


        public uint BindCpk(CriFsBinder srcBinder, string path)
        {
            return default(uint);
        }



        public uint BindDirectory(CriFsBinder srcBinder, string path)
        {
            return default(uint);
        }



        public uint BindFile(CriFsBinder srcBinder, string path)
        {
            return default(uint);
        }



        public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName)
        {
            return default(uint);
        }



        public static void Unbind(uint bindId)
        {
        }



        public static Status GetStatus(uint bindId)
        {
            return default(Status);
        }



        public long GetFileSize(string path)
        {
            return default(long);
        }



        public long GetFileSize(int id)
        {
            return default(long);
        }



        public bool GetContentsFileInfo(string path, out ContentsFileInfo info)
        {
            throw null;
        }



        public bool GetContentsFileInfo(int id, out ContentsFileInfo info)
        {
            throw null;
        }



        public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info)
        {
            throw null;
        }



        public static int GetNumContentsFiles(uint bindId)
        {
            return default(int);
        }



        public static void SetPriority(uint bindId, int priority)
        {
        }


        [PreserveSig]
        private static uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { throw new NotSupportedException("native criFsBinder_BindCpk (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { throw new NotSupportedException("native criFsBinder_BindDirectory (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { throw new NotSupportedException("native criFsBinder_BindFile (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId) { throw new NotSupportedException("native criFsBinder_BindFileSection (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_Unbind(uint bindId) { throw new NotSupportedException("native criFsBinder_Unbind (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetStatus(uint bindId, out Status status) { throw new NotSupportedException("native criFsBinder_GetStatus (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetFileSize(IntPtr binder, string path, out long size) { throw new NotSupportedException("native criFsBinder_GetFileSize (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size) { throw new NotSupportedException("native criFsBinder_GetFileSizeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_SetPriority(uint bindId, int priority) { throw new NotSupportedException("native criFsBinder_SetPriority (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info) { throw new NotSupportedException("native criFsBinder_GetContentsFileInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info) { throw new NotSupportedException("native criFsBinder_GetContentsFileInfoById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num) { throw new NotSupportedException("native criFsBinder_GetContentsFileInfoByIndex (game P/Invoke; not part of the managed port)"); }
    }
}
