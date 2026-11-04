using System.IO;
using UnityEngine;

namespace CriWare
{
    // CriWare.Common (TypeDefIndex 31868), the members on the game's paths. The game's plugin is the custom
    // "1.02.02(2.42.33_GetTimeAndScaleSyncedWithAudio)" build; its binary version differs between Android and iOS.
    public partial class Common
    {
        private const string scriptVersionString = "1.02.02(2.42.33_GetTimeAndScaleSyncedWithAudio)";
        public const bool supportsCriFsInstaller = true;
        public const bool supportsCriFsWebInstaller = true;
        public const string pluginName = "cri_ware_unity";
        public const System.Runtime.InteropServices.CallingConvention pluginCallingConvention =
            System.Runtime.InteropServices.CallingConvention.Winapi;
        private static GameObject _managerObject;

        public static GameObject managerObject
        {
            get
            {
                if (_managerObject == null)
                {
                    _managerObject = GameObject.Find("/CRIWARE");
                    if (_managerObject == null)
                        _managerObject = new GameObject("CRIWARE");
                    Object.DontDestroyOnLoad(_managerObject);
                }
                return _managerObject;
            }
        }

        public static string streamingAssetsPath
        {
            get
            {
                if (Application.platform == RuntimePlatform.Android)
                    return "";
                return Application.streamingAssetsPath;
            }
        }

        public static bool IsStreamingAssetsPath(string path)
        {
            if (Path.IsPathRooted(path))
                return false;
            return path.IndexOf(':') < 0;
        }

        // JP 7.0.0 iOS 0x44D21D0 compares with 0x01010101; Android 0x66D7EB8
        // compares with 0x01010301. Other hosts retain the Android-compatible backend contract.
        public static bool CheckBinaryVersionCompatibility()
        {
#if UNITY_IOS
            const int requiredVersion = 0x01010101;
#else
            const int requiredVersion = 0x01010301;
#endif
            var version = CRIWARECE8DBD94();
            if (version != requiredVersion)
                Debug.LogError("CRI runtime library is not compatible. Confirm the version number.");
            return version == requiredVersion;
        }

        private static int CRIWARECE8DBD94() => CriWareNative.Native.CRIWARECE8DBD94();

        internal static void criWareUnity_SetRenderingEventOffsetForMana(int offset) =>
            CriWareNative.Native.criWareUnity_SetRenderingEventOffsetForMana(offset);
    }
}
