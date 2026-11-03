namespace CriWare
{
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::UnityEngine;

    public class Common
    {
        public struct CpuUsage
        {
            public float last;
            public float average;
            public float peak;
        }

        private const string scriptVersionString = "2.44.49";
        public const bool supportsCriFsInstaller = true;
        public const bool supportsCriFsWebInstaller = true;
        public const string pluginName = "cri_ware_unity";
        public const CallingConvention pluginCallingConvention = CallingConvention.Winapi;
        public const string engineName = "Unity";
        private static GameObject _managerObject;
        public static string streamingAssetsPath
        {
            get
            {
                return null;
            }
        }

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

        public static GameObject managerObject
        {
            get
            {
                return null;
            }
        }

        public static bool IsStreamingAssetsPath(string path)
        {
            return default(bool);
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

        public static bool CheckBinaryVersionCompatibility()
        {
            return default(bool);
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

        [PreserveSig]
        public static extern int CRIWARE98F02F7C();
        [PreserveSig]
        public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset);
        public Common()
        {
        }
    }
}
