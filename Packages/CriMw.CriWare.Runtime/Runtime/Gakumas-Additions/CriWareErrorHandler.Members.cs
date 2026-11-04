// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Collections.Concurrent;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine;

namespace CriWare
{
    public partial class CriWareErrorHandler
    {

        private static bool _enableDebugPrintOnTerminal;



        public static event Callback OnCallback
        {
            add
            {
            }

            remove
            {
            }
        }



        public CriWareErrorHandler()
        {
        }
    }
}
