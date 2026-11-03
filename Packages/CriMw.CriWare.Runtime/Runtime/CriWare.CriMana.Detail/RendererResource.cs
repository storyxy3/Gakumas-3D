namespace CriWare.CriMana.Detail
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare.CriMana;
    using global::UnityEngine;

    public abstract class RendererResource : IDisposable
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
        }

        public void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        public int GetNumberOfFrameBeforeDestroy(int playerId)
        {
            return default(int);
        }

        protected void SetupStaticMaterialProperties()
        {
        }

        private void GetBlendModes(out int srcBlendMode, out int dstBlendMode)
        {
            throw null;
        }

        public virtual void SetApplyTargetAlpha(bool flag)
        {
        }

        public virtual void SetUiRenderMode(bool flag)
        {
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
            return default(bool);
        }

        public virtual void OnPlayerStart()
        {
        }

        public virtual bool ShouldSkipDestroyOnStopForSeek()
        {
            return default(bool);
        }

        public virtual bool HasRenderedNewFrame()
        {
            return default(bool);
        }

        public virtual int GetDisplayedFrameNo()
        {
            return default(int);
        }

        public static uint NextPowerOfTwo(uint x)
        {
            return default(uint);
        }

        public static int NextPowerOfTwo(int x)
        {
            return default(int);
        }

        public static int CeilingWith(int x, int ceilingValue)
        {
            return default(int);
        }

        public static int Ceiling16(int x)
        {
            return default(int);
        }

        public static int Ceiling32(int x)
        {
            return default(int);
        }

        public static int Ceiling64(int x)
        {
            return default(int);
        }

        public static int Ceiling256(int x)
        {
            return default(int);
        }

        protected static void DisposeTextures(Texture[] textures)
        {
        }

        protected static void SetKeyword(Material material, string keyword, bool flag)
        {
        }

        [PreserveSig]
        protected static extern bool CRIWAREABB313CF(int player_id, int num_textures, IntPtr[] tex_ptrs, [In][Out] FrameInfo frame_info, ref bool frame_drop);
        [PreserveSig]
        protected static extern bool CRIWARE8F9CBAA0(int player_id, int num_textures, [In][Out] IntPtr[] tex_ptrs);
        [PreserveSig]
        protected static extern bool CRIWAREDD6225A1(int player_id, int num_textures, [In][Out] IntPtr[] tex_ptrs);
        [PreserveSig]
        protected static extern bool CRIWARE8CC2D8BC(int player_id, int num_textures, [In][Out] IntPtr[] tex_ptrs);
        [PreserveSig]
        protected static extern sbyte CRIWAREBFDC8F80(int player_id);
        protected RendererResource()
        {
        }
    }
}
