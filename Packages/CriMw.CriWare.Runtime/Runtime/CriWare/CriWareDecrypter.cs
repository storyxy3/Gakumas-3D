namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::AOT;
    using global::CriWare;

    public static class CriWareDecrypter
    {
        [Serializable]
        public class Config
        {
            public string key;
            public bool enableAtomDecryption;
            public bool enableManaDecryption;
            public Config()
            {
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);
        private static ulong temporalStorage;
        public static bool Initialize(Config config)
        {
            return default(bool);
        }

        public static bool Initialize(string key, bool enableAtomDecryption, bool enableManaDecryption)
        {
            return default(bool);
        }

        [MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
        private static ulong CallbackFromNative(IntPtr ptr1)
        {
            return default(ulong);
        }

        [PreserveSig]
        public static extern int CRIWARE02E4660C(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj);
    }
}
