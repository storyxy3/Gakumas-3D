// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class CriFsBinder
    {

        public enum Status
        {
            None,
            Analyze,
            Complete,
            Unbind,
            Removed,
            Invalid,
            Error
        }



        public struct ContentsFileInfo
        {
            public readonly string directory;
            public readonly string fileName;
            public uint readSize;
            public uint extractSize;
            public ulong offset;
            public int fileId;
            private string userStr;
            public ContentsFileInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }
    }
}
