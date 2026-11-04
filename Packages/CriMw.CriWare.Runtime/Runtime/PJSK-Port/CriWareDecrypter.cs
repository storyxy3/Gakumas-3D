using System;
using System.Runtime.InteropServices;

namespace CriWare
{
    // CriWare.CriWareDecrypter (TypeDefIndex 31871). The key is handed to the native side through a callback that
    // reads it from temporalStorage during the call (xor-masked), then cleared.
    public static class CriWareDecrypter
    {
        [Serializable]
        public class Config
        {
            public string key = "";
            public bool enableAtomDecryption = true;
            public bool enableManaDecryption = true;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);

        private static ulong temporalStorage;

        public static bool Initialize(Config config)
        {
            return Initialize(config.key, config.enableAtomDecryption, config.enableManaDecryption);
        }

        public static bool Initialize(string key, bool enableAtomDecryption, bool enableManaDecryption)
        {
            if (!CriFsPlugin.IsLibraryInitialized())
                return false;
            if (!Common.CheckBinaryVersionCompatibility())
                return false;
            var maskedKey = 0xD47EB533AEF7E5UL;
            if (key.Length != 0)
                maskedKey = Convert.ToUInt64(key) ^ 0xD47EB533AEF7E5UL;
            temporalStorage = maskedKey;
            CRIWARE6B3B300F(enableAtomDecryption, enableManaDecryption, CallbackFromNative, IntPtr.Zero);
            temporalStorage = 0;
            return true;
        }

        [AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
        private static ulong CallbackFromNative(IntPtr ptr1)
        {
            return temporalStorage;
        }

        private static int CRIWARE6B3B300F(bool enable_atom_decryption, bool enable_mana_decryption,
            CallbackFromNativeDelegate func, IntPtr obj) =>
            CriWareNative.Native.CRIWARE6B3B300F(enable_atom_decryption, enable_mana_decryption, func, obj);
    }
}
