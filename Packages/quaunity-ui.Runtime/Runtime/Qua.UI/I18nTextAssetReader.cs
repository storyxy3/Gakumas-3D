namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    internal class I18nTextAssetReader : I18nTextAssetReaderBase
    {
        [SerializeField]
        private string _x;
        [SerializeField]
        private int _x2;
        [SerializeField]
        private string _y;
        private static Dictionary<int, UICrypto> _z;
        public static TextAsset TargetTextAsset
        {
            get
            {
                return null;
            }
        }

        public override string ReadFromTextAsset(TextAsset asset)
        {
            return null;
        }

        public static bool T(byte[] bytes)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static byte[] D(byte[] bytes, byte[] i, byte[] k)
        {
            return null;
        }

        [MethodImpl(256)]
        private static byte[] E(byte[] bytes, byte[] i, byte[] k)
        {
            return null;
        }

        [MethodImpl(256)]
        private (byte[], byte[]) XY(string x, string y)
        {
            return default((byte[], byte[]));
        }

        private static UICrypto Z(int size)
        {
            return null;
        }

        private byte[] B()
        {
            return null;
        }

        public I18nTextAssetReader()
        {
        }
    }
}
