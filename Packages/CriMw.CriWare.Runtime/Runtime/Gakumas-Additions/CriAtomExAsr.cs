// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public static partial class CriAtomExAsr
    {

        private struct BusAnalyzerConfig
        {
            public int interval;
            public int peakHoldTime;
        }



        public struct BusAnalyzerInfo
        {
            public int numChannels;
            public float[] rmsLevels;
            public float[] peakLevels;
            public float[] peakHoldLevels;
            public BusAnalyzerInfo(byte[] data)
            {
                this = default;
            }
        }
    }
}
