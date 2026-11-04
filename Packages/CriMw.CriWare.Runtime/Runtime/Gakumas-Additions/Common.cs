// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class Common
    {

        public struct CpuUsage
        {
            public float last;
            public float average;
            public float peak;
        }
    }
}
