namespace CriWare.CriMana.Detail
{
    using global::System;
    using global::CriWare.CriMana;
    using global::CriWare.CriMana.Detail;
    using global::UnityEngine;

    public class RendererResourceSofdecPrimeYuvRawData : RendererResource
    {
        private int width;
        private int height;
        private int chromaWidth;
        private int chromaHeight;
        private int alphaWidth;
        private int alphaHeight;
        private bool useUserShader;
        private CodecType codecType;
        private Vector4 movieTextureST;
        private Vector4 movieChromaTextureST;
        private Vector4 movieAlphaTextureST;
        private Texture2D[][] textures;
        private int currentTextureSet;
        private int drawTextureSet;
        private IntPtr[] nativePixels;
        private int playerID;
        private bool hasTextureUpdated;
        private bool isTextureReady;
        private bool hasRenderedNewFrame;
        private static int NumTextureSets
        {
            get
            {
                return default(int);
            }
        }

        public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
        }

        protected override void OnDisposeManaged()
        {
        }

        protected override void OnDisposeUnmanaged()
        {
        }

        public override bool IsPrepared()
        {
            return default(bool);
        }

        public override bool ContinuePreparing()
        {
            return default(bool);
        }

        public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            return default(bool);
        }

        public override bool OnPlayerStopForSeek()
        {
            return default(bool);
        }

        public override bool HasRenderedNewFrame()
        {
            return default(bool);
        }

        public override void AttachToPlayer(int playerId)
        {
        }

        public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
        {
            return default(bool);
        }

        public override bool UpdateMaterial(Material material)
        {
            return default(bool);
        }

        private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
        {
        }

        public override void UpdateTextures()
        {
        }

        private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma)
        {
        }
    }
}
