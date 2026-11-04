// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::UnityEngine;

namespace CriWare
{
    public partial class Common
    {

        public const string engineName = "Unity";



        public static string installTargetPath
        {
            get
            {
                return null;
            }
        }



        public static string installCachePath
        {
            get
            {
                return null;
            }
        }



        public static string GetScriptVersionString()
        {
            return null;
        }



        public static int GetBinaryVersionNumber()
        {
            return default(int);
        }



        public static int GetRequiredBinaryVersionNumber()
        {
            return default(int);
        }



        public static uint GetFsMemoryUsage()
        {
            return default(uint);
        }



        public static uint GetAtomMemoryUsage()
        {
            return default(uint);
        }



        public static uint GetManaMemoryUsage()
        {
            return default(uint);
        }



        public static CpuUsage GetAtomCpuUsage()
        {
            return default(CpuUsage);
        }


        public Common()
        {
        }
    }
}
