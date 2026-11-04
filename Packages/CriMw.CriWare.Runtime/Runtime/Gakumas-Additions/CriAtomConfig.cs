// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class CriAtomConfig
    {


        [Serializable]
        public class Switch2OpusVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public Switch2OpusVoicePoolConfig()
            {
            }
        }
    }
}
