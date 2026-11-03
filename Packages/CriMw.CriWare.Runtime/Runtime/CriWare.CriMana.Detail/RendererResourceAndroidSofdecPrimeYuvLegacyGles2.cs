namespace CriWare.CriMana.Detail
{
    using global::System;
    using global::CriWare.CriMana;
    using global::CriWare.CriMana.Detail;
    using global::UnityEngine;

    public class RendererResourceAndroidSofdecPrimeYuvLegacyGles2 : RendererResource
    {
        private int width;
        private int height;
        private int chromaWidth;
        private int chromaHeight;
        private int alphaWidth;
        private int alphaHeight;
        private bool useUserShader;
        private CodecType codecType;
        private int movieWidth;
        private int movieHeight;
        private const TextureFormat format = TextureFormat.R8;
        private const TextureFormat formatUV = TextureFormat.RG16;
        private Vector4 movieTextureST;
        private Vector4 movieChromaTextureST;
        private Vector4 movieAlphaTextureST;
        private Texture2D[][] textures;
        private RenderTexture[] renderTextures;
        private IntPtr[][] nativeTextures;
        private int numImages;
        private int numImagesForYUV;
        private int numTextureSets;
        private int currentTextureSet;
        private int drawTextureSet;
        private int playerID;
        private bool isStoppingForSeek;
        public RendererResourceAndroidSofdecPrimeYuvLegacyGles2(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
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
