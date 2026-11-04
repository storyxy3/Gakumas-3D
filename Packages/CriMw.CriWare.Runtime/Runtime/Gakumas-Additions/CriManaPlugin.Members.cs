// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare.CriMana;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine.Rendering;

namespace CriWare
{
    public partial class CriManaPlugin
    {


        public static bool isMultithreadedRenderingEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public static event Action OnBeforeInitialize;

        public static event Action OnInitialized;

        public static event Action OnBeforeFinalize;

        public static event Action OnFinalized;



        private static void SetupAV1()
        {
        }



        [Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
        public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height)
        {
        }



        public static void SetConfigAdditonalParameters_PC(bool use_h264_playback)
        {
        }



        public static void UseLegacyDecoder_PC(bool useLegacyDecoder)
        {
        }



        public static bool IsLegacyDecoderUsed_PC()
        {
            return default(bool);
        }



        public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize)
        {
        }



        public static bool IsCodecSupported(CodecType codecType)
        {
            return default(bool);
        }



        private static Type GetAV1ExpansionClass()
        {
            return null;
        }



        private static bool IsAV1CodecSupported()
        {
            return default(bool);
        }



        private static bool IsH264CodecSupported()
        {
            return default(bool);
        }



        public static void SetDecodeThreadPriorityAndroidExperimental(int prio)
        {
        }



        public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr)
        {
            return default(bool);
        }



        public static bool IsStreamerManagerUsed()
        {
            return default(bool);
        }



        public static void Lock()
        {
        }



        public static void Unlock()
        {
        }



        public static bool AnalyzeMovieHeader(IntPtr data, out MovieInfo movieInfo)
        {
            throw null;
        }


        [PreserveSig]
        public static bool criMana_IsStreamerManagerUsed() { throw new NotSupportedException("native criMana_IsStreamerManagerUsed (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static void criManaUnity_SetDecodeThreadPriority_ANDROID(int prio) { throw new NotSupportedException("native criManaUnity_SetDecodeThreadPriority_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static void criManaUnity_EnableSwitchTextureSampleColorGLES30_ANDROID() { throw new NotSupportedException("native criManaUnity_EnableSwitchTextureSampleColorGLES30_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criManaUnity_ShouldSwitchTextureSampleColorToRedGLES30_ANDROID(IntPtr tex_ptr) { throw new NotSupportedException("native criManaUnity_ShouldSwitchTextureSampleColorToRedGLES30_ANDROID (game P/Invoke; not part of the managed port)"); }


        public CriManaPlugin()
        {
        }
    }
}
