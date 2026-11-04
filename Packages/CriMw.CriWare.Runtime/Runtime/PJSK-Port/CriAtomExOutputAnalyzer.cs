using System;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomExOutputAnalyzer (TypeDefIndex 31779), the members on the game's paths (the BGM and voice player
    // analyzers, VL lip sync GetRms). PCM capture callbacks and spectrum reads are not reached there.
    public partial class CriAtomExOutputAnalyzer : CriDisposable
    {
        public struct Config
        {
            public bool enableLevelmeter;
            public bool enableSpectrumAnalyzer;
            public bool enablePcmCapture;
            public bool enablePcmCaptureCallback;
            public int numSpectrumAnalyzerBands;
            public int numCapturedPcmSamples;
        }

        public const int MaximumSpectrumBands = 512;
        protected IntPtr handle = IntPtr.Zero;
        protected CriAtomExPlayer player;
        protected string busName;
        protected int numBands = 8;
        protected int numCapturedPcmSamples = 4096;
        protected float[] dataL;
        protected float[] dataR;
        protected const int pcmCapturerNumMaxData = 512;

        public IntPtr nativeHandle => handle;

        public CriAtomExOutputAnalyzer(Config config)
        {
            InitializeWithConfig(config);
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Atom);
        }

        private void InitializeWithConfig(Config config)
        {
            handle = criAtomExOutputAnalyzer_Create(ref config);
            if (handle == IntPtr.Zero)
                throw new Exception("criAtomExOutputAnalyzer_Create() failed.");
            numBands = config.numSpectrumAnalyzerBands;
            numCapturedPcmSamples = config.numCapturedPcmSamples;
            if (config.enablePcmCaptureCallback && dataL == null)
            {
                dataL = new float[pcmCapturerNumMaxData];
                dataR = new float[pcmCapturerNumMaxData];
            }
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            CriDisposableObjectManager.Unregister(this);
            if (handle != IntPtr.Zero)
            {
                DetachExPlayer();
                DetachDspBus();
                criAtomExOutputAnalyzer_Destroy(handle);
                handle = IntPtr.Zero;
            }
            if (disposing)
                GC.SuppressFinalize(this);
        }

        public bool AttachExPlayer(CriAtomExPlayer player)
        {
            if (player == null || player.nativeHandle == IntPtr.Zero || handle == IntPtr.Zero)
                return false;
            DetachExPlayer();
            DetachDspBus();
            if (player.GetStatus() != CriAtomExPlayer.Status.Stop)
                return false;
            criAtomExOutputAnalyzer_AttachExPlayer(handle, player.nativeHandle);
            this.player = player;
            return true;
        }

        public void DetachExPlayer()
        {
            if (player == null || player.nativeHandle == IntPtr.Zero || handle == IntPtr.Zero)
                return;
            if (player.GetStatus() != CriAtomExPlayer.Status.Stop)
            {
                Debug.LogWarning(
                    "[CRIWARE] Warning: CriAtomExPlayer is forced to stop for detaching CriAtomExOutputAnalyzer.");
                player.StopWithoutReleaseTime();
            }
            criAtomExOutputAnalyzer_DetachExPlayer(handle, player.nativeHandle);
            player = null;
        }

        // 0x66C07D8: 0 without an attached player/bus or handle, and 0 while the
        // attached player is neither Prep nor Playing; otherwise the native
        // level meter (published RMS, peak and hold slots).
        public float GetRms(int channel)
        {
            if (player == null && busName == null || handle == IntPtr.Zero)
                return 0f;
            if (player != null && player.GetStatus() != CriAtomExPlayer.Status.Playing &&
                player.GetStatus() != CriAtomExPlayer.Status.Prep)
                return 0f;
            return criAtomExOutputAnalyzer_GetRms(handle, channel);
        }

        public void DetachDspBus()
        {
            if (busName == null || handle == IntPtr.Zero)
                return;
            criAtomExOutputAnalyzer_DetachDspBusByName(handle, busName);
            busName = null;
        }

        ~CriAtomExOutputAnalyzer()
        {
            Dispose(false);
        }

        private static IntPtr criAtomExOutputAnalyzer_Create(ref Config config) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_Create(ref config);
        private static void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_Destroy(analyzer);
        private static void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_AttachExPlayer(analyzer, player);
        private static void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_DetachExPlayer(analyzer, player);
        private static float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_GetRms(analyzer, channel);
        private static void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName) =>
            CriWareNative.Native.criAtomExOutputAnalyzer_DetachDspBusByName(analyzer, busName);
    }
}
