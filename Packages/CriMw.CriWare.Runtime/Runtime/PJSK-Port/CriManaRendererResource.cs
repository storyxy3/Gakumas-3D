// 官方 CRI 插件按平台各编一套渲染资源工厂：JP 7.0.0 iOS 是 SofdecPrimeYuv(5000) / IOSH264Yuv(7000) /
// SofdecPrimeYuvRawData(10000)（dump TypeDefIndex 31994-31996），Android 是 AndroidH264Rgb(7000) /
// AndroidSofdecPrimeYuv(5050) / AndroidSofdecPrimeYuvLegacyGles2(5060) / SofdecPrimeYuvRawData(10000)。
// 复刻一份源码出多个平台的包，这里按编译平台选集：iOS/macOS（Metal）走 iOS 集，其余（Android、WebGL）沿用 Android 集。
#if UNITY_IOS || UNITY_STANDALONE_OSX
#define CRI_MANA_IOS_RENDERER_SET
#endif
using System;
using System.Runtime.InteropServices;
using CriWare.CriMana;
using UnityEngine;
using UnityEngine.Rendering;

namespace CriWare.CriMana.Detail
{
    // 复刻宿主胶水：给 StageManager.SetupMovie（官方 7.0.0 iOS 0x31DA868）和 SekaiManaClip.SetupManaMaterial
    // （0x2CB9820）提供与本次编译的工厂集配套的 Grid 影片 shader 名。官方 iOS 两处都是字面量
    // StringLiteral_12803 "Sekai/SekaiRP/Movie/Grid-SofdecPrimeYuv-CrossFade" 与 StringLiteral_12804
    // "...-CrossFade-Transparent"；Android 集的渲染资源写 _TextureUV/CRI_UV_FORMAT，须配 Grid-AndroidSofdecPrimeYuv-*。
    public static class RendererResourcePlatform
    {
#if CRI_MANA_IOS_RENDERER_SET
        public static readonly bool IsIosRendererSet = true;
        public const string GridCrossFadeShaderName = "Sekai/SekaiRP/Movie/Grid-SofdecPrimeYuv-CrossFade";
        public const string GridCrossFadeTransparentShaderName =
            "Sekai/SekaiRP/Movie/Grid-SofdecPrimeYuv-CrossFade-Transparent";
#else
        public static readonly bool IsIosRendererSet = false;
        public const string GridCrossFadeShaderName = "Sekai/SekaiRP/Movie/Grid-AndroidSofdecPrimeYuv-CrossFade";
        public const string GridCrossFadeTransparentShaderName =
            "Sekai/SekaiRP/Movie/Grid-AndroidSofdecPrimeYuv-CrossFade-Transparent";
#endif
    }

    // CriWare.CriMana.Detail.RendererResource (TypeDefIndex 31976): the textures and material setup of one movie
    // player; the native player decodes into the native textures on the render thread.
    public abstract partial class RendererResource : IDisposable
    {
        private bool disposed;
        protected Shader shader;
        protected Material currentMaterial;
        protected bool hasAlpha;
        protected bool additive;
        protected bool applyTargetAlpha;
        protected bool ui;

        ~RendererResource()
        {
            if (!disposed)
            {
                OnDisposeUnmanaged();
                disposed = true;
            }
        }

        public void Dispose()
        {
            if (!disposed)
            {
                OnDisposeManaged();
                OnDisposeUnmanaged();
                disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        public int GetNumberOfFrameBeforeDestroy(int playerId)
        {
            return CRIWARE412BF0B2(playerId);
        }

        protected void SetupStaticMaterialProperties()
        {
            if (currentMaterial == null)
                return;
            GetBlendModes(out var srcBlendMode, out var dstBlendMode);
            if (currentMaterial.shader != shader)
                currentMaterial.shader = shader;
            currentMaterial.SetInt("_SrcBlendMode", srcBlendMode);
            currentMaterial.SetInt("_DstBlendMode", dstBlendMode);
            currentMaterial.SetInt("_CullMode", ui ? 0 : 2);
            currentMaterial.SetInt("_ZWriteMode", ui ? 0 : 1);
            SetKeyword(currentMaterial, "CRI_ALPHA_MOVIE", hasAlpha);
            SetKeyword(currentMaterial, "CRI_APPLY_TARGET_ALPHA", applyTargetAlpha);
            SetKeyword(currentMaterial, "CRI_LINEAR_COLORSPACE", QualitySettings.activeColorSpace == ColorSpace.Linear);
        }

        // BlendMode One / SrcAlpha, One / OneMinusSrcAlpha.
        private void GetBlendModes(out int srcBlendMode, out int dstBlendMode)
        {
            srcBlendMode = additive ? (int)BlendMode.One : (int)BlendMode.SrcAlpha;
            dstBlendMode = additive && !hasAlpha ? (int)BlendMode.One : (int)BlendMode.OneMinusSrcAlpha;
        }

        public virtual void SetApplyTargetAlpha(bool flag)
        {
            applyTargetAlpha = flag;
            SetupStaticMaterialProperties();
        }

        public virtual void SetUiRenderMode(bool flag)
        {
            ui = flag;
            SetupStaticMaterialProperties();
        }

        protected abstract void OnDisposeManaged();

        protected abstract void OnDisposeUnmanaged();

        public abstract bool IsPrepared();

        public abstract bool ContinuePreparing();

        public abstract void AttachToPlayer(int playerId);

        public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);

        public abstract bool UpdateMaterial(Material material);

        public abstract void UpdateTextures();

        public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);

        public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause)
        {
        }

        public virtual void OnPlayerStop()
        {
        }

        public virtual bool OnPlayerStopForSeek()
        {
            return false;
        }

        public virtual void OnPlayerStart()
        {
        }

        public virtual bool ShouldSkipDestroyOnStopForSeek()
        {
            return false;
        }

        public virtual bool HasRenderedNewFrame()
        {
            return true;
        }

        public virtual int GetDisplayedFrameNo()
        {
            return -1;
        }

        public static uint NextPowerOfTwo(uint x)
        {
            x--;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        public static int NextPowerOfTwo(int x)
        {
            var v = (uint)(x - 1);
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            return (int)(v + 1);
        }

        public static int CeilingWith(int x, int ceilingValue)
        {
            return (x + ceilingValue - 1) & -ceilingValue;
        }

        public static int Ceiling16(int x)
        {
            return (x + 15) & -16;
        }

        public static int Ceiling32(int x)
        {
            return (x + 31) & -32;
        }

        public static int Ceiling64(int x)
        {
            return (x + 63) & -64;
        }

        public static int Ceiling256(int x)
        {
            return (x + 255) & -256;
        }

        protected static void DisposeTextures(Texture[] textures)
        {
            if (textures == null)
                return;
            for (var i = 0; i < textures.Length; i++)
            {
                if (textures[i] != null)
                {
                    if (CriWareNative.Native is CriAtomNativeBackend managed)
                        managed.UnregisterManaTexture(textures[i]);
                    if (CriWareNative.Native is CriAtomNativeBackend && !Application.isPlaying)
                        UnityEngine.Object.DestroyImmediate(textures[i]);
                    else
                        UnityEngine.Object.Destroy(textures[i]);
                    textures[i] = null;
                }
            }
        }

        protected static IntPtr RegisterNativeTexture(Texture2D texture)
        {
            var pointer = texture.GetNativeTexturePtr();
            if (CriWareNative.Native is CriAtomNativeBackend managed)
                managed.RegisterManaTexture(pointer, texture);
            return pointer;
        }

        protected static void SetKeyword(Material material, string keyword, bool flag)
        {
            if (flag)
                material.EnableKeyword(keyword);
            else
                material.DisableKeyword(keyword);
        }

        protected static bool CRIWARE9F502893(int player_id, int num_textures, IntPtr[] tex_ptrs, FrameInfo frame_info,
            ref bool frame_drop) =>
            CriWareNative.Native.CRIWARE9F502893(player_id, num_textures, tex_ptrs, frame_info, ref frame_drop);
        protected static bool CRIWARE1A1436DD(int player_id, int num_textures, IntPtr[] tex_ptrs) =>
            CriWareNative.Native.CRIWARE1A1436DD(player_id, num_textures, tex_ptrs);
        protected static bool CRIWAREDEF25F94(int player_id, int num_textures, IntPtr[] tex_ptrs) =>
            CriWareNative.Native.CRIWAREDEF25F94(player_id, num_textures, tex_ptrs);
        protected static bool CRIWARE5F215F75(int player_id, int num_textures, IntPtr[] tex_ptrs) =>
            CriWareNative.Native.CRIWARE5F215F75(player_id, num_textures, tex_ptrs);
        protected static sbyte CRIWARE412BF0B2(int player_id) => CriWareNative.Native.CRIWARE412BF0B2(player_id);
    }

    // CriWare.CriMana.Detail.RendererResourceAndroidSofdecPrimeYuvLegacyGles2 (TypeDefIndex 31975): the renderer the
    // Android build uses for Sofdec Prime (and VP9) movies: Y/U/V (or Y/UV) Alpha8/RG16 textures in two sets the
    // native player decodes into, with the shader "CriMana/AndroidSofdecPrimeYuvLegacy".
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
        private const TextureFormat format = TextureFormat.Alpha8;
        private const TextureFormat formatUV = TextureFormat.RG16;
        private Vector4 movieTextureST = Vector4.zero;
        private Vector4 movieChromaTextureST = Vector4.zero;
        private Vector4 movieAlphaTextureST = Vector4.zero;
        private Texture2D[][] textures;
        private RenderTexture[] renderTextures;
        private IntPtr[][] nativeTextures;
        private int numImages = -1;
        private int numImagesForYUV = -1;
        private int numTextureSets = 2;
        private int currentTextureSet;
        private int drawTextureSet = -1;
        private int playerID;
        private bool isStoppingForSeek;

        public RendererResourceAndroidSofdecPrimeYuvLegacyGles2(int playerId, MovieInfo movieInfo, bool additive,
            Shader userShader)
        {
            hasAlpha = movieInfo.numAlphaStreams != 0;
            this.additive = additive;
            useUserShader = userShader != null;
            movieWidth = (int)movieInfo.width;
            movieHeight = (int)movieInfo.height;
            if (userShader == null)
                userShader = Shader.Find("CriMana/AndroidSofdecPrimeYuvLegacy");
            shader = userShader;
            textures = new Texture2D[numTextureSets][];
            for (var i = 0; i < numTextureSets; i++)
            {
                textures[i] = new Texture2D[4];
                for (var j = 0; j < 4; j++)
                    textures[i][j] = null;
            }
            nativeTextures = new IntPtr[numTextureSets][];
            for (var i = 0; i < numTextureSets; i++)
            {
                nativeTextures[i] = new IntPtr[4];
                for (var j = 0; j < 4; j++)
                    nativeTextures[i][j] = IntPtr.Zero;
            }
            playerID = playerId;
            codecType = movieInfo.codecType;
        }

        protected override void OnDisposeManaged()
        {
        }

        protected override void OnDisposeUnmanaged()
        {
            CRIWARE5F215F75(playerID, 0, null);
            for (var i = 0; i < numTextureSets; i++)
                DisposeTextures(textures[i]);
            textures = null;
            nativeTextures = null;
        }

        public override bool IsPrepared()
        {
            return true;
        }

        public override bool ContinuePreparing()
        {
            return true;
        }

        public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            var isSameSize = movieWidth == movieInfo.width && movieHeight == movieInfo.height;
            var isSameCodec = codecType == movieInfo.codecType;
            var isSameShader = useUserShader ? userShader == shader : true;
            return isSameSize && isSameCodec && this.additive == additive &&
                hasAlpha == (movieInfo.numAlphaStreams != 0) && isSameShader;
        }

        public override bool OnPlayerStopForSeek()
        {
            isStoppingForSeek = drawTextureSet >= 0;
            return true;
        }

        public override void AttachToPlayer(int playerId)
        {
            CRIWAREDEF25F94(playerID, 0, new IntPtr[1]);
            drawTextureSet = -1;
        }

        public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
        {
            var isFrameUpdated = CRIWARE9F502893(playerId, 0, null, frameInfo, ref frameDrop);
            if (!isFrameUpdated)
                return false;
            if (!frameDrop)
            {
                isStoppingForSeek = false;
                drawTextureSet = currentTextureSet;
                currentTextureSet = (currentTextureSet + 1) % numTextureSets;
            }
            if (textures[0][0] == null)
            {
                numImages = (int)frameInfo.numImages;
                numImagesForYUV = numImages - (hasAlpha ? 1 : 0);
                CalculateTextureSize(ref width, ref height, (int)frameInfo.width, (int)frameInfo.height, codecType,
                    false);
                CalculateTextureSize(ref chromaWidth, ref chromaHeight, (int)frameInfo.width, (int)frameInfo.height,
                    codecType, true);
                if (hasAlpha)
                {
                    alphaWidth = Ceiling32(Ceiling16(CeilingWith((int)frameInfo.width, 8)));
                    alphaHeight = CeilingWith((int)frameInfo.height, 8);
                }
                UpdateMovieTextureST(frameInfo.dispWidth, frameInfo.dispHeight);
                for (var i = 0; i < numTextureSets; i++)
                {
                    textures[i][0] = new Texture2D(width, height, format, false, true);
                    textures[i][0].wrapMode = TextureWrapMode.Clamp;
                    if (numImagesForYUV == 3)
                    {
                        textures[i][1] = new Texture2D(chromaWidth, chromaHeight, format, false, true);
                        textures[i][1].wrapMode = TextureWrapMode.Clamp;
                        textures[i][2] = new Texture2D(chromaWidth, chromaHeight, format, false, true);
                        textures[i][2].wrapMode = TextureWrapMode.Clamp;
                    }
                    else
                    {
                        textures[i][1] = new Texture2D(chromaWidth, chromaHeight, formatUV, false, true);
                        textures[i][1].wrapMode = TextureWrapMode.Clamp;
                    }
                    for (var j = 0; j < numImagesForYUV; j++)
                        nativeTextures[i][j] = RegisterNativeTexture(textures[i][j]);
                    if (hasAlpha)
                    {
                        textures[i][numImages - 1] = new Texture2D(alphaWidth, alphaHeight, format, false, true);
                        textures[i][numImages - 1].wrapMode = TextureWrapMode.Clamp;
                        nativeTextures[i][numImages - 1] = RegisterNativeTexture(textures[i][numImages - 1]);
                    }
                }
            }
            return true;
        }

        private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type,
            bool isChroma)
        {
            switch (type)
            {
                case CodecType.SofdecPrime:
                {
                    var alignedWidth = Ceiling16(CeilingWith(videoWidth, 8));
                    if (isChroma)
                    {
                        w = Ceiling32(alignedWidth / 2);
                        h = CeilingWith(videoHeight, 8) / 2;
                    }
                    else
                    {
                        w = Ceiling32(alignedWidth);
                        h = CeilingWith(videoHeight, 8);
                    }
                    break;
                }
                case CodecType.H264:
                    if (isChroma)
                    {
                        w = CeilingWith(CeilingWith(videoWidth, 2) / 2, 8);
                        h = CeilingWith(CeilingWith(videoHeight, 2) / 2, 8);
                    }
                    else
                    {
                        w = CeilingWith(videoWidth, 8);
                        h = CeilingWith(videoHeight, 8);
                    }
                    break;
                case CodecType.VP9:
                {
                    var alignedWidth = CeilingWith(videoWidth, 2);
                    if (isChroma)
                    {
                        w = CeilingWith(alignedWidth / 2, 8);
                        h = CeilingWith(CeilingWith(videoHeight, 2) / 2, 8);
                    }
                    else
                    {
                        w = CeilingWith(alignedWidth, 8);
                        h = CeilingWith(CeilingWith(videoHeight, 2), 8);
                    }
                    break;
                }
            }
        }

        // _ST = (scale x, -scale y, 0, scale y): the movie is flipped vertically.
        private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
        {
            var scaleX = dispWidth != width ? (float)(dispWidth - 1) / width : 1f;
            var scaleY = dispHeight != height ? (float)(dispHeight - 1) / height : 1f;
            movieTextureST.x = scaleX;
            movieTextureST.y = -scaleY;
            movieTextureST.z = 0f;
            movieTextureST.w = scaleY;
            var chromaWidth2 = 2 * chromaWidth;
            var chromaScaleX = 1f;
            if (dispWidth != chromaWidth2)
            {
                var halfScaleX = (float)((dispWidth >> 1) - 1) / chromaWidth2;
                chromaScaleX = halfScaleX + halfScaleX;
            }
            var chromaHeight2 = 2 * chromaHeight;
            var chromaScaleY = 1f;
            if (dispHeight != chromaHeight2)
            {
                var halfScaleY = (float)((dispHeight >> 1) - 1) / chromaHeight2;
                chromaScaleY = halfScaleY + halfScaleY;
            }
            movieChromaTextureST.x = chromaScaleX;
            movieChromaTextureST.y = -chromaScaleY;
            movieChromaTextureST.z = 0f;
            movieChromaTextureST.w = chromaScaleY;
            if (hasAlpha)
            {
                var alphaScaleX = dispWidth != alphaWidth ? (float)(dispWidth - 1) / alphaWidth : 1f;
                var alphaScaleY = dispHeight != alphaHeight ? (float)(dispHeight - 1) / alphaHeight : 1f;
                movieAlphaTextureST.x = alphaScaleX;
                movieAlphaTextureST.y = -alphaScaleY;
                movieAlphaTextureST.z = 0f;
                movieAlphaTextureST.w = alphaScaleY;
            }
        }

        public override bool UpdateMaterial(Material material)
        {
            if (isStoppingForSeek)
                return true;
            if (drawTextureSet < 0)
                return false;
            if (currentMaterial != material)
            {
                currentMaterial = material;
                SetupStaticMaterialProperties();
                if (material == null)
                    return false;
                if (numImagesForYUV == 3)
                    material.DisableKeyword("CRI_UV_FORMAT");
                else
                    material.EnableKeyword("CRI_UV_FORMAT");
            }
            material.SetVector("_MovieTexture_ST", movieTextureST);
            material.SetVector("_MovieChromaTexture_ST", movieChromaTextureST);
            material.SetTexture("_TextureY", textures[drawTextureSet][0]);
            if (numImagesForYUV == 3)
            {
                material.SetTexture("_TextureU", textures[drawTextureSet][1]);
                material.SetTexture("_TextureV", textures[drawTextureSet][2]);
            }
            else
            {
                material.SetTexture("_TextureUV", textures[drawTextureSet][1]);
            }
            if (!hasAlpha)
                return true;
            material.SetVector("_MovieAlphaTexture_ST", movieAlphaTextureST);
            material.SetTexture("_TextureA", textures[drawTextureSet][numImages - 1]);
            return true;
        }

        public override void UpdateTextures()
        {
            if (drawTextureSet < 0)
                return;
            CRIWARE1A1436DD(playerID, numImages, nativeTextures[drawTextureSet]);
        }
    }

    // CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuv（JP 7.0.0 iOS TypeDefIndex 32002）：iOS 构建给 Sofdec Prime
    // 影片用的渲染资源，shader "CriMana/SofdecPrimeYuv"。三组 Y/U/V(/A) Alpha8 纹理在构造时一次分配好；
    // UpdateFrame 决定原生侧下一帧写进哪组（currentTextureSet），UpdateTextures 上传成功后 drawTextureSet 才跟上并置
    // hasTextureUpdated，UpdateMaterial 再把 drawTextureSet 记成 displayedTextureSet 并置 hasRenderedNewFrame。
    // 复刻的 Android LegacyGles2 两组纹理、IsPrepared/HasRenderedNewFrame 恒 true，与此不同（报告 M2）。
    public class RendererResourceSofdecPrimeYuv : RendererResource
    {
        private int width;
        private int height;
        private bool useUserShader;
        private CodecType codecType;
        private Vector4 movieTextureST = Vector4.zero;
        private Vector4 movieChromaTextureST = Vector4.zero;
        private Texture2D[] textureY = new Texture2D[NumTextureSets];
        private Texture2D[] textureU = new Texture2D[NumTextureSets];
        private Texture2D[] textureV = new Texture2D[NumTextureSets];
        private Texture2D[] textureA = new Texture2D[NumTextureSets];
        private IntPtr[] nativeTextures;
        private int[] frameNumbers = new int[NumTextureSets];
        private int currentTextureSet = -1;
        private int drawTextureSet = -1;
        private int displayedTextureSet = -1;
        private int playerID;
        private bool hasTextureUpdated;
        private bool hasRenderedNewFrame;
        private bool isStoppingForSeek;

        // 0x44EB2D8
        private static int NumTextureSets => 3;

        // 0x44EB3B4：iOS 包里恒 false。
        private static bool IsEditor => false;

        // 0x44E8504：纹理尺寸 NextPowerOfTwo(Ceiling64(w)) x NextPowerOfTwo(Ceiling16(h))，色度为其一半；
        // Texture2D(w, h, Alpha8, mipChain: false)，wrapMode = Clamp。
        public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            width = NextPowerOfTwo(Ceiling64((int)movieInfo.width));
            height = NextPowerOfTwo(Ceiling16((int)movieInfo.height));
            this.additive = additive;
            hasAlpha = movieInfo.numAlphaStreams != 0;
            useUserShader = userShader != null;
            codecType = movieInfo.codecType;
            if (!useUserShader)
                userShader = Shader.Find("CriMana/SofdecPrimeYuv");
            shader = userShader;
            UpdateMovieTextureST(movieInfo.dispWidth, movieInfo.dispHeight);
            for (var i = 0; i < NumTextureSets; i++)
            {
                textureY[i] = new Texture2D(width, height, TextureFormat.Alpha8, false);
                textureY[i].wrapMode = TextureWrapMode.Clamp;
                textureU[i] = new Texture2D(width / 2, height / 2, TextureFormat.Alpha8, false);
                textureU[i].wrapMode = TextureWrapMode.Clamp;
                textureV[i] = new Texture2D(width / 2, height / 2, TextureFormat.Alpha8, false);
                textureV[i].wrapMode = TextureWrapMode.Clamp;
                if (hasAlpha)
                {
                    textureA[i] = new Texture2D(width, height, TextureFormat.Alpha8, false);
                    textureA[i].wrapMode = TextureWrapMode.Clamp;
                }
            }
            nativeTextures = new IntPtr[4];
            playerID = playerId;
        }

        // 0x44EB3B0
        protected override void OnDisposeManaged()
        {
        }

        // 0x44EB3BC：先让原生侧放手，再逐组销毁纹理并置空（数组本身保留）。
        protected override void OnDisposeUnmanaged()
        {
            CRIWARE5F215F75(playerID, 0, null);
            for (var i = 0; i < NumTextureSets; i++)
            {
                if (textureY[i] != null)
                {
                    UnityEngine.Object.Destroy(textureY[i]);
                    textureY[i] = null;
                }
                if (textureU[i] != null)
                {
                    UnityEngine.Object.Destroy(textureU[i]);
                    textureU[i] = null;
                }
                if (textureV[i] != null)
                {
                    UnityEngine.Object.Destroy(textureV[i]);
                    textureV[i] = null;
                }
                if (textureA[i] != null)
                {
                    UnityEngine.Object.Destroy(textureA[i]);
                    textureA[i] = null;
                }
            }
        }

        // 0x44EB708：第一次 UpdateTextures 上传成功前都是 false。
        public override bool IsPrepared()
        {
            return hasTextureUpdated;
        }

        // 0x44EB710
        public override bool ContinuePreparing()
        {
            return true;
        }

        // 0x44EB718：二的幂纹理能装下新影片即可复用（>=，不要求相等）。
        public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            var isSuitableSize = width >= (int)movieInfo.width && height >= (int)movieInfo.height;
            var isSameCodec = codecType == movieInfo.codecType;
            var isSameAlpha = hasAlpha == (movieInfo.numAlphaStreams != 0);
            var isSameAdditive = this.additive == additive;
            var isSuitableShader = useUserShader ? userShader == shader : true;
            return isSuitableShader && isSameCodec && isSameAlpha && isSameAdditive && isSuitableSize;
        }

        // 0x44EB824
        public override bool OnPlayerStopForSeek()
        {
            hasRenderedNewFrame = false;
            isStoppingForSeek = true;
            return true;
        }

        // 0x44EB834
        public override bool HasRenderedNewFrame()
        {
            return hasRenderedNewFrame;
        }

        // 0x44EB83C
        public override int GetDisplayedFrameNo()
        {
            if (displayedTextureSet < 0)
                return -1;
            return frameNumbers[displayedTextureSet];
        }

        // 0x44EB884：非 seek 重连时三组状态全部回到 -1。
        public override void AttachToPlayer(int playerId)
        {
            CRIWAREDEF25F94(playerID, 0, new IntPtr[1]);
            hasTextureUpdated = false;
            hasRenderedNewFrame = false;
            if (!isStoppingForSeek)
            {
                currentTextureSet = -1;
                drawTextureSet = -1;
                displayedTextureSet = -1;
            }
            isStoppingForSeek = false;
        }

        // 0x44EB918：取帧成功且未丢帧时按显示尺寸重算 ST；currentTextureSet 只在尚未开始（<0）或上一组已上传
        // （hasTextureUpdated）时前进一格，否则覆盖当前组；drawTextureSet 不在这里更新。
        public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
        {
            var isFrameUpdated = CRIWARE9F502893(playerId, 0, null, frameInfo, ref frameDrop);
            var textureSet = currentTextureSet;
            if (isFrameUpdated && !frameDrop)
            {
                UpdateMovieTextureST(frameInfo.dispWidth, frameInfo.dispHeight);
                if (textureSet < 0 || hasTextureUpdated)
                    textureSet = (textureSet + 1) % NumTextureSets;
                frameNumbers[textureSet] = frameInfo.frameNo;
            }
            currentTextureSet = textureSet;
            return isFrameUpdated;
        }

        // 0x44EBACC：drawTextureSet < 0 返回 false（没有 isStoppingForSeek 早退）；alpha 的 ST 复用 movieTextureST。
        public override bool UpdateMaterial(Material material)
        {
            var textureSet = drawTextureSet;
            if (textureSet < 0)
                return false;
            if (currentMaterial != material)
            {
                currentMaterial = material;
                SetupStaticMaterialProperties();
            }
            if (material == null)
                return false;
            material.SetTexture("_TextureY", textureY[drawTextureSet]);
            material.SetTexture("_TextureU", textureU[drawTextureSet]);
            material.SetTexture("_TextureV", textureV[drawTextureSet]);
            material.SetVector("_MovieTexture_ST", movieTextureST);
            material.SetVector("_MovieChromaTexture_ST", movieChromaTextureST);
            if (hasAlpha)
            {
                material.SetTexture("_TextureA", textureA[drawTextureSet]);
                material.SetVector("_MovieAlphaTexture_ST", movieTextureST);
            }
            hasRenderedNewFrame = textureSet >= 0;
            displayedTextureSet = drawTextureSet;
            return true;
        }

        // 0x44EB2E0：_ST = (sx, -sy, 0, sy)，影片上下翻转；色度按亮度纹理尺寸算 2 * ((disp >> 1) - 1) / tex。
        private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
        {
            var scaleX = dispWidth != width ? (float)(dispWidth - 1) / width : 1f;
            var scaleY = dispHeight != height ? (float)(dispHeight - 1) / height : 1f;
            movieTextureST.x = scaleX;
            movieTextureST.y = -scaleY;
            movieTextureST.z = 0f;
            movieTextureST.w = scaleY;
            var chromaScaleX = 1f;
            if (dispWidth != width)
            {
                var halfScaleX = (float)((dispWidth >> 1) - 1) / width;
                chromaScaleX = halfScaleX + halfScaleX;
            }
            var chromaScaleY = 1f;
            if (dispHeight != height)
            {
                var halfScaleY = (float)((dispHeight >> 1) - 1) / height;
                chromaScaleY = halfScaleY + halfScaleY;
            }
            movieChromaTextureST.x = chromaScaleX;
            movieChromaTextureST.y = -chromaScaleY;
            movieChromaTextureST.z = 0f;
            movieChromaTextureST.w = chromaScaleY;
        }

        // 0x44EBDA4：把 currentTextureSet 那组的原生纹理指针（3 张，有 alpha 时 4 张）交给原生侧；成功后
        // drawTextureSet = currentTextureSet，hasTextureUpdated = true。
        public override void UpdateTextures()
        {
            if (currentTextureSet < 0)
                return;
            nativeTextures[0] = textureY[currentTextureSet].GetNativeTexturePtr();
            nativeTextures[1] = textureU[currentTextureSet].GetNativeTexturePtr();
            nativeTextures[2] = textureV[currentTextureSet].GetNativeTexturePtr();
            var numTextures = 3;
            if (hasAlpha)
            {
                nativeTextures[3] = textureA[currentTextureSet].GetNativeTexturePtr();
                numTextures = 4;
            }
            if (CRIWARE1A1436DD(playerID, numTextures, nativeTextures))
            {
                drawTextureSet = currentTextureSet;
                hasTextureUpdated = true;
            }
        }
    }

    // JP7 RVAs 0x66EA8C8, 0x66EB8AC..0x66ECCB0. Android MediaCodec owns the
    // external RGB texture; the resource wraps it and retains it across seeks.
    public class RendererResourceAndroidH264Rgb : RendererResource
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct NativeTexture
        {
            public uint nativePtrRGB;
            public uint nativePtrA;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] texCoords;
        }

        private const int RenderEventAction_ATTACH = 769;
        private int playerId, width, height, dispWidth, dispHeight, alphaWidth, alphaHeight;
        private bool useUserShader;
        private Vector4 movieTextureST = new Vector4(1f, -1f, 0f, 1f);
        private Vector4 alphaTextureST = Vector4.zero;
        private Texture2D[] textures;
        private IntPtr[] nativePtrs = new IntPtr[1];
        private bool needsUpdateTexture, needsToDetachInitTexture, areTexturesUpdated, isStoppingForSeek;
        private bool isStartTriggered = true;
        private uint nativeTextureId;

        public RendererResourceAndroidH264Rgb(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            this.playerId = playerId;
            width = (int)movieInfo.width; height = (int)movieInfo.height;
            dispWidth = (int)movieInfo.dispWidth; dispHeight = (int)movieInfo.dispHeight;
            hasAlpha = movieInfo.numAlphaStreams != 0;
            if (hasAlpha)
            {
                alphaWidth = Ceiling32(Ceiling16(CeilingWith(width, 8)));
                alphaHeight = Ceiling16(height);
            }
            this.additive = additive;
            useUserShader = userShader != null;
            shader = userShader != null ? userShader : Shader.Find("CriMana/AndroidH264Rgb");
        }

        protected override void OnDisposeManaged() { }
        protected override void OnDisposeUnmanaged() { DisposeTextures(textures); textures = null; }
        public override bool IsPrepared() => true;
        public override bool ContinuePreparing() => true;

        public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            return width == movieInfo.width && height == movieInfo.height && this.playerId == playerId &&
                movieInfo.codecType == CodecType.H264 && this.additive == additive &&
                hasAlpha == (movieInfo.numAlphaStreams != 0) && (!useUserShader || userShader == shader);
        }

        public override bool OnPlayerStopForSeek()
        {
            if (textures != null) { isStoppingForSeek = true; isStartTriggered = false; }
            return true;
        }

        public override void OnPlayerStart() => isStartTriggered = true;
        public override bool ShouldSkipDestroyOnStopForSeek() => true;

        private void forceUpdateMaterialTextures(Texture[] newTextures)
        {
            if (currentMaterial == null) return;
            currentMaterial.mainTexture = newTextures[0];
            currentMaterial.SetTexture("_TextureRGB", newTextures[0]);
            if (hasAlpha) currentMaterial.SetTexture("_TextureA", newTextures[1]);
        }

        public override void AttachToPlayer(int playerId)
        {
            if (!isStoppingForSeek) nativeTextureId = uint.MaxValue;
            criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(playerId, nativeTextureId);
            needsToDetachInitTexture = true;
        }

        public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
        {
            if (needsToDetachInitTexture)
            {
                needsToDetachInitTexture = false;
                criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(playerId, uint.MaxValue);
            }
            bool updated = CRIWARE9F502893(playerId, 0, null, frameInfo, ref frameDrop);
            if (updated && !frameDrop) needsUpdateTexture = true;
            return updated;
        }

        public override bool UpdateMaterial(Material material)
        {
            if (!areTexturesUpdated) return false;
            if (currentMaterial != material)
            {
                currentMaterial = material;
                SetupStaticMaterialProperties();
            }
            if (material == null) return false;
            if (textures != null)
            {
                material.mainTexture = textures[0];
                material.SetTexture("_TextureRGB", textures[0]);
                if (hasAlpha && textures[1] != null) material.SetTexture("_TextureA", textures[1]);
            }
            material.SetVector("_MovieTexture_ST", movieTextureST);
            if (hasAlpha) material.SetVector("_AlphaTexture_ST", alphaTextureST);
            return true;
        }

        private void UpdateMovieTextureST(float[] texCoords, float dispWidth, float dispHeight)
        {
            movieTextureST = new Vector4(texCoords[0], texCoords[1], texCoords[2], texCoords[3]);
            float x = alphaWidth != dispWidth ? (float)((float)(dispWidth - 0.5f) / alphaWidth) : 1f;
            float y = alphaHeight != dispHeight ? (float)((float)(dispHeight - 0.5f) / alphaHeight) : 1f;
            alphaTextureST = new Vector4(x, -y, 0f, y);
        }

        public override void UpdateTextures()
        {
            if (!needsUpdateTexture) return;
            nativePtrs[0] = IntPtr.Zero;
            bool updated = CRIWARE1A1436DD(playerId, hasAlpha ? 2 : 1, nativePtrs);
            areTexturesUpdated |= updated;
            if (!updated || nativePtrs[0] == IntPtr.Zero || !isStartTriggered) return;
            needsUpdateTexture = false;
            var native = (NativeTexture)Marshal.PtrToStructure(nativePtrs[0], typeof(NativeTexture));
            if (textures == null)
            {
                textures = new Texture2D[2];
                textures[0] = Texture2D.CreateExternalTexture(width, height, TextureFormat.ARGB32, false, false,
                    new IntPtr((long)native.nativePtrRGB));
                textures[0].wrapMode = TextureWrapMode.Clamp;
                if (hasAlpha)
                {
                    textures[1] = Texture2D.CreateExternalTexture(alphaWidth, alphaHeight, TextureFormat.R8, false,
                        false, new IntPtr((long)native.nativePtrA));
                    textures[1].wrapMode = TextureWrapMode.Clamp;
                }
                if (currentMaterial != null) forceUpdateMaterialTextures(textures);
                nativeTextureId = native.nativePtrRGB;
            }
            else
            {
                textures[0].UpdateExternalTexture(new IntPtr((long)native.nativePtrRGB));
                if (hasAlpha) textures[1].UpdateExternalTexture(new IntPtr((long)native.nativePtrA));
            }
            UpdateMovieTextureST(native.texCoords, dispWidth, dispHeight);
            isStoppingForSeek = false;
        }

        public static bool IsSupported()
        {
            if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Vulkan)
            {
                Debug.Log("[CRIWARE] Another RendererResource will be used for Vulkan. Please use CriManaPlugin.IsCodecSupported instead.");
                return true;
            }
            if (!criManaUnity_IsMediaCodecSupported_ANDROID((int)SystemInfo.graphicsDeviceType))
            {
                Debug.Log("[CRIWARE] criManaUnity_IsMediaCodecSupported_ANDROID returned false.");
                return false;
            }
            if ((int)SystemInfo.graphicsDeviceType == 8) return true;
            var supportShader = Shader.Find("CriMana/AndroidH264DummySupportCheck");
            if (!supportShader.isSupported) return false;
            var previous = RenderTexture.active;
            var texture = new Texture2D(1, 1, TextureFormat.ARGB32, false);
            var target = new RenderTexture(1, 1, 0);
            target.Create();
            var material = new Material(supportShader);
            Graphics.Blit(texture, target, material, 0);
            RenderTexture.active = target;
            texture.ReadPixels(new Rect(0f, 0f, target.width, target.height), 0, 0);
            texture.Apply();
            var pixel = texture.GetPixel(0, 0);
            bool supported = pixel.r == 1f && pixel.g == 1f && pixel.b == 1f;
            RenderTexture.active = previous;
            UnityEngine.Object.Destroy(material);
            UnityEngine.Object.Destroy(texture);
            UnityEngine.Object.Destroy(target);
            return supported;
        }

        private static bool criManaUnity_IsMediaCodecSupported_ANDROID(int device_type) =>
            CriWareNative.Native.criManaUnity_IsMediaCodecSupported_ANDROID(device_type);
        private static uint criManaUnity_MediaCodecCreateTexture_ANDROID() =>
            CriWareNative.Native.criManaUnity_MediaCodecCreateTexture_ANDROID();
        private static void criManaUnity_MediaCodecDeleteTexture_ANDROID(uint oes_texture) =>
            CriWareNative.Native.criManaUnity_MediaCodecDeleteTexture_ANDROID(oes_texture);
        private static bool criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(int player_id, uint oes_texture) =>
            CriWareNative.Native.criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(player_id, oes_texture);
        private static void criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(int player_id, uint oes_texture) =>
            CriWareNative.Native.criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(player_id, oes_texture);
    }

    // CriWare.CriMana.Detail.RendererResourceIOSH264Yuv（JP 7.0.0 iOS TypeDefIndex 31998，.ctor 0x44E8180）：
    // 只给 H.264 影片用（工厂 0x44E80D0 仅 codecType == 5 时创建）。StreamingLive 的 USM 全是 Sofdec Prime，
    // 这里只移植工厂判定，资源本体未移植。
    public class RendererResourceIOSH264Yuv
    {
        public RendererResourceIOSH264Yuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            throw new NotSupportedException("RendererResourceIOSH264Yuv is not on the StreamingLive paths (no H.264 movies).");
        }
    }

    // JP7 RVAs 0x66EB308, 0x66EF330..0x66EFE2C. This factory is shadowed by
    // LegacyGles2 on Android. Its CPU upload path uses one texture set in JP7.
    public partial class RendererResourceSofdecPrimeYuvRawData : RendererResource
    {
        private int width, height, chromaWidth, chromaHeight, alphaWidth, alphaHeight;
        private bool useUserShader;
        private CodecType codecType;
        private Vector4 movieTextureST = Vector4.zero;
        private Vector4 movieChromaTextureST = Vector4.zero;
        private Vector4 movieAlphaTextureST = Vector4.zero;
        private static int NumTextureSets => 1;
        private Texture2D[][] textures = new Texture2D[NumTextureSets][];
        private int currentTextureSet, drawTextureSet;
        private IntPtr[] nativePixels;
        private int playerID;
        private bool hasTextureUpdated, hasRenderedNewFrame, isStoppingForSeek;

        public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            CalculateTextureSize(ref width, ref height, (int)movieInfo.width, (int)movieInfo.height, movieInfo.codecType, false);
            CalculateTextureSize(ref chromaWidth, ref chromaHeight, (int)movieInfo.width, (int)movieInfo.height, movieInfo.codecType, true);
            CalculateTextureSize(ref alphaWidth, ref alphaHeight, (int)movieInfo.width, (int)movieInfo.height, CodecType.SofdecPrime, false);
            hasAlpha = movieInfo.numAlphaStreams != 0;
            this.additive = additive;
            useUserShader = userShader != null;
            codecType = movieInfo.codecType;
            shader = useUserShader ? userShader : Shader.Find("CriMana/SofdecPrimeYuv");
            UpdateMovieTextureST(movieInfo.dispWidth, movieInfo.dispHeight);
            for (int i = 0; i < NumTextureSets; i++)
            {
                textures[i] = new Texture2D[hasAlpha ? 4 : 3];
                textures[i][0] = new Texture2D(width, height, TextureFormat.Alpha8, false);
                textures[i][1] = new Texture2D(chromaWidth, chromaHeight, TextureFormat.Alpha8, false);
                textures[i][2] = new Texture2D(chromaWidth, chromaHeight, TextureFormat.Alpha8, false);
                if (hasAlpha) textures[i][3] = new Texture2D(alphaWidth, alphaHeight, TextureFormat.Alpha8, false);
                foreach (var texture in textures[i]) texture.wrapMode = TextureWrapMode.Clamp;
            }
            nativePixels = new IntPtr[hasAlpha ? 4 : 3];
            playerID = playerId;
        }

        protected override void OnDisposeManaged() { }
        protected override void OnDisposeUnmanaged()
        {
            CRIWARE5F215F75(playerID, 0, null);
            for (int i = 0; i < NumTextureSets; i++) DisposeTextures(textures[i]);
            textures = null;
        }
        public override bool IsPrepared() => hasTextureUpdated;
        public override bool ContinuePreparing() => true;

        public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            int w = 0, h = 0;
            CalculateTextureSize(ref w, ref h, (int)movieInfo.width, (int)movieInfo.height, movieInfo.codecType, false);
            return width == w && height >= h && codecType == movieInfo.codecType && this.additive == additive &&
                hasAlpha == (movieInfo.numAlphaStreams != 0) && (!useUserShader || userShader == shader);
        }

        public override bool OnPlayerStopForSeek()
        {
            isStoppingForSeek = hasTextureUpdated;
            hasTextureUpdated = false;
            hasRenderedNewFrame = false;
            return true;
        }
        public override bool HasRenderedNewFrame() => hasRenderedNewFrame;
        public override void AttachToPlayer(int playerId)
        {
            CRIWAREDEF25F94(playerID, 0, new IntPtr[1]);
            hasTextureUpdated = hasRenderedNewFrame = false;
        }

        public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
        {
            bool updated = CRIWARE9F502893(playerId, 0, null, frameInfo, ref frameDrop);
            if (updated && !frameDrop)
            {
                UpdateMovieTextureST(frameInfo.dispWidth, frameInfo.dispHeight);
                drawTextureSet = currentTextureSet;
                currentTextureSet = (currentTextureSet + 1) % NumTextureSets;
            }
            return updated;
        }

        public override bool UpdateMaterial(Material material)
        {
            if (currentMaterial != material)
            {
                currentMaterial = material;
                SetupStaticMaterialProperties();
            }
            if (material == null) return false;
            material.SetTexture("_TextureY", textures[drawTextureSet][0]);
            material.SetTexture("_TextureU", textures[drawTextureSet][1]);
            material.SetTexture("_TextureV", textures[drawTextureSet][2]);
            material.SetVector("_MovieTexture_ST", movieTextureST);
            material.SetVector("_MovieChromaTexture_ST", movieChromaTextureST);
            if (hasAlpha)
            {
                material.SetTexture("_TextureA", textures[drawTextureSet][3]);
                material.SetVector("_MovieAlphaTexture_ST", movieAlphaTextureST);
            }
            hasRenderedNewFrame = hasTextureUpdated;
            return hasTextureUpdated || isStoppingForSeek;
        }

        private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
        {
            float x = dispWidth != width ? (float)((float)(dispWidth - 1) / width) : 1f;
            float y = dispHeight != height ? (float)((float)(dispHeight - 1) / height) : 1f;
            movieTextureST = new Vector4(x, -y, 0f, y);
            float halfX = (float)((float)((dispWidth >> 1) - 1) / (2 * chromaWidth));
            float halfY = (float)((float)((dispHeight >> 1) - 1) / (2 * chromaHeight));
            x = dispWidth != 2 * chromaWidth ? (float)(halfX + halfX) : 1f;
            y = dispHeight != 2 * chromaHeight ? (float)(halfY + halfY) : 1f;
            movieChromaTextureST = new Vector4(x, -y, 0f, y);
            if (hasAlpha)
            {
                x = dispWidth != alphaWidth ? (float)((float)(dispWidth - 1) / alphaWidth) : 1f;
                y = dispHeight != alphaHeight ? (float)((float)(dispHeight - 1) / alphaHeight) : 1f;
                movieAlphaTextureST = new Vector4(x, -y, 0f, y);
            }
        }

        public override void UpdateTextures()
        {
            nativePixels[0] = IntPtr.Zero;
            hasTextureUpdated |= CRIWARE1A1436DD(playerID, hasAlpha ? 4 : 3, nativePixels);
            if (!hasTextureUpdated || nativePixels[0] == IntPtr.Zero) return;
            var current = textures[currentTextureSet];
            current[0].LoadRawTextureData(nativePixels[0], width * height);
            current[1].LoadRawTextureData(nativePixels[1], chromaWidth * chromaHeight);
            current[2].LoadRawTextureData(nativePixels[2], chromaWidth * chromaHeight);
            current[0].Apply(); current[1].Apply(); current[2].Apply();
            if (hasAlpha)
            {
                current[3].LoadRawTextureData(nativePixels[3], alphaWidth * alphaHeight);
                current[3].Apply();
            }
            isStoppingForSeek = false;
        }

        private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type,
            bool isChroma)
        {
            switch (type)
            {
                case CodecType.SofdecPrime:
                    int alignment = (int)CriManaPlugin.GetPrimeBufferAlignmentSize();
                    w = CeilingWith(isChroma ? Ceiling16(videoWidth) / 2 : Ceiling16(videoWidth), alignment);
                    h = isChroma ? CeilingWith(videoHeight, 8) / 2 : CeilingWith(videoHeight, 8);
                    break;
                case CodecType.H264:
                    w = isChroma ? CeilingWith(videoWidth / 2, 8) : videoWidth;
                    h = isChroma ? CeilingWith(videoHeight, 2) / 2 : videoHeight;
                    break;
                case CodecType.VP9:
                    w = CeilingWith(isChroma ? CeilingWith(videoWidth, 2) / 2 : CeilingWith(videoWidth, 2), 8);
                    h = isChroma ? CeilingWith(videoHeight, 2) / 2 : CeilingWith(videoHeight, 2);
                    break;
            }
        }
    }

    public abstract partial class RendererResourceFactory
    {
        public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive,
            Shader userShader)
        {
            foreach (var factory in factoryList)
            {
                var rendererResource = factory.Value.CreateRendererResource(playerId, movieInfo, additive, userShader);
                if (rendererResource != null)
                    return rendererResource;
            }
            Debug.LogError("[CRIWARE] unsupported movie.");
            return null;
        }

        public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
            Shader userShader);
    }

    public static partial class AutoResisterRendererResourceFactories
    {
#if CRI_MANA_IOS_RENDERER_SET
        // JP 7.0.0 iOS 的工厂集（按优先级升序尝试）：5000 SofdecPrimeYuv、7000 IOSH264Yuv，加上下面共用的 10000 RawData。
        // 0x44E8454：只接 codecType == 1（Sofdec Prime）；VP9 落到 10000。
        [RendererResourceFactoryPriority(5000)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                if (movieInfo.codecType != CodecType.SofdecPrime)
                    return null;
                return new RendererResourceSofdecPrimeYuv(playerId, movieInfo, additive, userShader);
            }

            // 0x44E8AA8
            protected override void OnDisposeManaged()
            {
            }

            // 0x44E8AAC
            protected override void OnDisposeUnmanaged()
            {
            }
        }

        // 0x44E80D0：只接 codecType == 5（H.264）。
        [RendererResourceFactoryPriority(7000)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactoryIOSH264Yuv : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                if (movieInfo.codecType != CodecType.H264)
                    return null;
                new RendererResourceIOSH264Yuv(playerId, movieInfo, additive, userShader);
                return null;
            }

            // 0x44E83BC
            protected override void OnDisposeManaged()
            {
            }

            // 0x44E83C0
            protected override void OnDisposeUnmanaged()
            {
            }
        }
#else
        // Factories of the Android build, tried by ascending priority.
        [RendererResourceFactoryPriority(7000)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactoryAndroidH264Rgb : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                var isH264WithoutBufferOutput = movieInfo.codecType == CodecType.H264 &&
                    !CriManaPlugin.criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
                if (!(isH264WithoutBufferOutput & (SystemInfo.graphicsDeviceType != GraphicsDeviceType.Vulkan)))
                    return null;
                return new RendererResourceAndroidH264Rgb(playerId, movieInfo, additive, userShader);
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }
        }

        // The 7.0.0 build's body never creates a renderer (its creation branch is compiled out).
        [RendererResourceFactoryPriority(5050)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactoryAndroidSofdecPrimeYuv : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                if (movieInfo.codecType != CodecType.SofdecPrime && movieInfo.codecType != CodecType.VP9)
                    CriManaPlugin.criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }
        }

        [RendererResourceFactoryPriority(5060)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2 : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                if (movieInfo.codecType == CodecType.SofdecPrime || movieInfo.codecType == CodecType.VP9)
                    return new RendererResourceAndroidSofdecPrimeYuvLegacyGles2(playerId, movieInfo, additive,
                        userShader);
                CriManaPlugin.criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }
        }
#endif

        // 两个集共用（JP 7.0.0 iOS 0x44E8B38：(codecType | 8) == 9 即 1 或 9 时创建）。
        [RendererResourceFactoryPriority(10000)]
        [UnityEngine.Scripting.Preserve]
        public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive,
                Shader userShader)
            {
                if (movieInfo.codecType != CodecType.SofdecPrime && movieInfo.codecType != CodecType.VP9)
                    return null;
                return new RendererResourceSofdecPrimeYuvRawData(playerId, movieInfo, additive, userShader);
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }
        }
    }
}
