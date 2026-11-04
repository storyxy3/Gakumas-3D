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
    public static partial class CriAtomExLatencyEstimator
    {


        public static void InitializeModule()
        {
        }



        [PreserveSig]
        private static void criAtomLatencyEstimator_Initialize_ANDROID() { throw new NotSupportedException("native criAtomLatencyEstimator_Initialize_ANDROID (game P/Invoke; not part of the managed port)"); }
    }
}
