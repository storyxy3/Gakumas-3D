namespace CriWare
{
    using global::System;
    using global::CriWare;

    [Serializable]
    public class CriManaConfig
    {
        [Serializable]
        public class PCH264PlaybackConfig
        {
            public bool useH264Playback;
            public PCH264PlaybackConfig()
            {
            }
        }

        [Serializable]
        public class VitaH264PlaybackConfig
        {
            public bool useH264Playback;
            public int maxWidth;
            public int maxHeight;
            public bool getMemoryFromTexture;
            public VitaH264PlaybackConfig()
            {
            }
        }

        [Serializable]
        public class WebGLConfig
        {
            public string webworkerPath;
            public int heapSize;
            public WebGLConfig()
            {
            }
        }

        public int numberOfDecoders;
        public int numberOfMaxEntries;
        public readonly bool graphicsMultiThreaded;
        public bool useStreamerManager;
        public PCH264PlaybackConfig pcH264PlaybackConfig;
        public VitaH264PlaybackConfig vitaH264PlaybackConfig;
        public WebGLConfig webglConfig;
        public CriManaConfig()
        {
        }
    }
}
