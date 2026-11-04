// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial struct CriAtomExPlayback
    {


        public struct TrackInfo
        {
            public uint id;
            public CriAtomEx.CueType sequenceType;
            public IntPtr playerHn;
            public ushort trackNo;
            public ushort reserved;
        }
    }
}
