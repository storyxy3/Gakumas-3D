using System;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriWareInitializer (TypeDefIndex 31900), on the APK boot prefab (fs 64 loaders, atom 32 virtual voices,
    // 16+8 standard voices, 60 Hz server, native renderer; mana 32 decoders; no decrypter).
    [AddComponentMenu("CRIWARE/Library Initializer")]
    public class CriWareInitializer : CriMonoBehaviour
    {
        public bool initializesFileSystem = true;
        public CriFsConfig fileSystemConfig = new CriFsConfig();
        public bool initializesAtom = true;
        public CriAtomConfig atomConfig = new CriAtomConfig();
        public bool initializesMana = true;
        public CriManaConfig manaConfig = new CriManaConfig();
        public bool useDecrypter;
        public CriWareDecrypter.Config DecrypterConfig = new CriWareDecrypter.Config();
        public bool dontInitializeOnAwake;
        public bool dontDestroyOnLoad;
#if UNITY_IOS
        private static int frameCnt;
#endif
        private static int initializationCount;

        private void Awake()
        {
            Common.CheckBinaryVersionCompatibility();
            if (!dontInitializeOnAwake)
                Initialize();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
        }

        private void Start()
        {
        }

        // 官方 7.0.0 iOS CriWareInitializer$$CriInternalUpdate 0x44D5FD0：静态 frameCnt 只在 <=3 时自增；
        // 自增前为 1（第 2 次调用）时 CriAtomPlugin.Pause(true)，为 2（第 3 次调用）时 Pause(false)，即启动时让 Atom 暂停一帧再恢复。
        // CriAtomPlugin.Pause 自带 isInitialized 判断，Atom 未初始化时不会触达原生后端。
        public override void CriInternalUpdate()
        {
#if UNITY_IOS
            var count = frameCnt;
            if (count > 3)
                return;
            frameCnt = count + 1;
            if (count == 2)
                CriAtomPlugin.Pause(false);
            else if (count == 1)
                CriAtomPlugin.Pause(true);
#endif
            // JP 7.0.0 Android 0x66DADB8 is RET; it has no startup pause pulse or frameCnt.
        }

        public override void CriInternalLateUpdate()
        {
        }

        public void Initialize()
        {
            var count = initializationCount;
            initializationCount++;
            if (count != 0)
            {
                Destroy(this);
                return;
            }

            if (CriFsPlugin.IsLibraryInitialized() && CriAtomPlugin.IsLibraryInitialized() &&
                CriManaPlugin.IsLibraryInitialized() ||
                CriFsPlugin.IsLibraryInitialized() && CriAtomPlugin.IsLibraryInitialized() &&
                !CriManaPlugin.IsLibraryInitialized() ||
                CriFsPlugin.IsLibraryInitialized() && !CriAtomPlugin.IsLibraryInitialized() &&
                !CriManaPlugin.IsLibraryInitialized())
            {
                if (initializesMana)
                    CriManaPlugin.FinalizeLibrary();
                if (initializesAtom)
                {
                    while (CriAtomExLatencyEstimator.GetCurrentInfo().status != CriAtomExLatencyEstimator.Status.Stop)
                        CriAtomExLatencyEstimator.FinalizeModule();
                    CriAtomPlugin.FinalizeLibrary();
                }
                if (initializesFileSystem)
                    CriFsPlugin.FinalizeLibrary();
            }

            if (initializesFileSystem)
                InitializeFileSystem(fileSystemConfig);
            if (initializesAtom)
            {
                switch (atomConfig.inGamePreviewMode)
                {
                    case CriAtomConfig.InGamePreviewSwitchMode.FollowBuildSetting:
                        atomConfig.usesInGamePreview = Debug.isDebugBuild;
                        break;
                    case CriAtomConfig.InGamePreviewSwitchMode.Enable:
                        atomConfig.usesInGamePreview = true;
                        break;
                    case CriAtomConfig.InGamePreviewSwitchMode.Disable:
                        atomConfig.usesInGamePreview = false;
                        break;
                }
                InitializeAtom(atomConfig);
            }
            if (initializesMana)
                InitializeMana(manaConfig);
            if (useDecrypter)
                CriWareDecrypter.Initialize(DecrypterConfig);
            else
                CriWareDecrypter.Initialize("0", false, false);
            // Haruki: on a child (CriCore.Setup's CRIWARE object) Unity ignores it with a warning; the root persists.
            if (dontDestroyOnLoad && transform.parent == null)
                DontDestroyOnLoad(transform.gameObject);
        }

        private void OnDestroy()
        {
            Shutdown();
        }

        private void Shutdown()
        {
            initializationCount--;
            if (initializationCount == 0)
            {
                if (initializesMana)
                    CriManaPlugin.FinalizeLibrary();
                if (initializesAtom)
                {
                    while (CriAtomExLatencyEstimator.GetCurrentInfo().status != CriAtomExLatencyEstimator.Status.Stop)
                        CriAtomExLatencyEstimator.FinalizeModule();
                    CriAtomPlugin.FinalizeLibrary();
                }
                if (initializesFileSystem)
                    CriFsPlugin.FinalizeLibrary();
            }
            else
            {
                initializationCount = Math.Max(initializationCount, 0);
            }
        }

        public static bool IsInitialized()
        {
            if (initializationCount > 0)
                return true;
            Common.CheckBinaryVersionCompatibility();
            return false;
        }

        private static bool InitializeFileSystem(CriFsConfig config)
        {
            var initialized = CriFsPlugin.IsLibraryInitialized();
            if (!initialized)
            {
                CriFsPlugin.SetConfigParameters(config.numberOfLoaders, config.numberOfBinders,
                    config.numberOfInstallers, config.installBufferSize << 10, config.maxPath,
                    config.minimizeFileDescriptorUsage, config.enableCrcCheck);
                var androidDeviceReadBitrate = config.androidDeviceReadBitrate;
                if (androidDeviceReadBitrate == 0)
                {
                    androidDeviceReadBitrate = CriFsConfig.defaultAndroidDeviceReadBitrate;
                    config.androidDeviceReadBitrate = CriFsConfig.defaultAndroidDeviceReadBitrate;
                }
                CriFsPlugin.SetConfigAdditionalParameters_ANDROID(androidDeviceReadBitrate);
                CriFsPlugin.InitializeLibrary();
                if (config.userAgentString.Length != 0)
                    CriFsUtility.SetUserAgentString(config.userAgentString);
            }
            return !initialized;
        }

        private static bool InitializeAtom(CriAtomConfig config)
        {
            var initialized = CriAtomPlugin.IsLibraryInitialized();
            if (!initialized)
            {
                var maxVirtualVoices = Math.Max(config.maxVirtualVoices, CriAtomPlugin.GetRequiredMaxVirtualVoices(config));
                CriAtomPlugin.SetConfigParameters(maxVirtualVoices, config.maxVoiceLimitGroups, config.maxCategories,
                    (byte)config.maxAisacs, (byte)config.maxBusSends, config.maxSequenceEventsPerFrame,
                    config.maxBeatSyncCallbacksPerFrame, config.maxCueLinkCallbacksPerFrame,
                    config.standardVoicePoolConfig.memoryVoices, config.standardVoicePoolConfig.streamingVoices,
                    config.hcaMxVoicePoolConfig.memoryVoices, config.hcaMxVoicePoolConfig.streamingVoices,
                    config.outputSamplingRate, config.asrOutputChannels, config.speakerMapping,
                    config.usesInGamePreview, config.serverFrequency, config.maxParameterBlocks,
                    config.categoriesPerPlayback, config.maxFaders, config.maxBuses, config.maxPitch,
                    config.soundRendererType, config.enableSonicSync);
                CriAtomPlugin.SetConfigMonitorParametes(config.inGamePreviewConfig.maxPreviewObjects,
                    config.inGamePreviewConfig.communicationBufferSize,
                    config.inGamePreviewConfig.playbackPositionUpdateInterval);
                CriAtomPlugin.SetConfigAdditionalParameters_EDITOR(config.editorPcmOutputConfig.enable,
                    config.editorPcmOutputConfig.bufferLength);
                CriAtomPlugin.SetConfigAdditionalParameters_PC(config.pcBufferingTime, config.useMicrosoftSpatialSound);
                CriAtomPlugin.SetConfigAdditionalParameters_LINUX(config.linuxOutput, config.linuxPulseLatencyUsec);
                CriAtomPlugin.SetConfigAdditionalParameters_IOS(config.iosEnableSonicSync,
                    (uint)Math.Max(config.iosBufferingTime, 16), config.iosOverrideIPodMusic);
                if (config.androidBufferingTime == 0)
                    config.androidBufferingTime = (int)(4000f / config.serverFrequency);
                if (config.androidStartBufferingTime == 0)
                    config.androidStartBufferingTime = (int)(3000f / config.serverFrequency);
                CriAtomEx.androidDefaultSoundRendererType = config.androidForceToUseAsrForDefaultPlayback
                    ? CriAtomEx.SoundRendererType.Asr
                    : CriAtomEx.SoundRendererType.Default;
                CriAtomPlugin.SetConfigAdditionalParameters_ANDROID(config.androidEnableSonicSync,
                    config.androidLowLatencyStandardVoicePoolConfig.memoryVoices,
                    config.androidLowLatencyStandardVoicePoolConfig.streamingVoices, config.androidBufferingTime,
                    config.androidStartBufferingTime, config.androidUsesAndroidFastMixer, config.androidUsesAAudio,
                    config.androidStreamType);
                CriAtomPlugin.SetConfigAdditionalParameters_VITA(config.vitaAtrac9VoicePoolConfig.memoryVoices,
                    config.vitaAtrac9VoicePoolConfig.streamingVoices,
                    config.vitaManaVoicePoolConfig.numberOfManaDecoders);
                CriAtomPlugin.SetConfigAdditionalParameters_PS4(config.ps4Atrac9VoicePoolConfig.memoryVoices,
                    config.ps4Atrac9VoicePoolConfig.streamingVoices, config.ps4Audio3dConfig.useAudio3D,
                    config.ps4Audio3dConfig.voicePoolConfig.memoryVoices,
                    config.ps4Audio3dConfig.voicePoolConfig.streamingVoices);
                CriAtomPlugin.SetConfigAdditionalParameters_PS5(config.ps5PortConfig.maxChannelPorts,
                    config.ps5PortConfig.maxObjectPorts);
                CriAtomPlugin.SetConfigAdditionalParameters_SWITCH(config.switchEnableSonicSync,
                    config.switchOpusVoicePoolConfig.memoryVoices, config.switchOpusVoicePoolConfig.streamingVoices,
                    config.switchInitializeSocket);
                CriAtomPlugin.SetConfigAdditionalParameters_WEBGL(config.webglWebAudioVoicePoolConfig.voices);
                CriAtomPlugin.InitializeLibrary();
                if (config.useRandomSeedWithTime)
                    CriAtomEx.SetRandomSeed((uint)DateTime.Now.Ticks);
                var acfFileName = config.acfFileName;
                if (acfFileName.Length != 0)
                {
                    if (Common.IsStreamingAssetsPath(config.acfFileName))
                        acfFileName = System.IO.Path.Combine(Common.streamingAssetsPath, acfFileName);
                    CriAtomEx.RegisterAcf(null, acfFileName);
                }
                CriAtomServer.KeepPlayingSoundOnPause = config.keepPlayingSoundOnPause;
            }
            return !initialized;
        }

        private static bool InitializeMana(CriManaConfig config)
        {
            var initialized = CriManaPlugin.IsLibraryInitialized();
            if (!initialized)
            {
                CriManaPlugin.SetConfigParameters(config.graphicsMultiThreaded, config.numberOfDecoders,
                    config.numberOfMaxEntries);
                CriManaPlugin.SetConfigAdditonalParameters_ANDROID(
                    SystemInfo.graphicsDeviceType != UnityEngine.Rendering.GraphicsDeviceType.OpenGLES2, false);
                CriManaPlugin.InitializeLibrary();
                CriManaPlugin.UseStreamerManager(config.useStreamerManager);
                if (QualitySettings.activeColorSpace == ColorSpace.Linear)
                    Shader.EnableKeyword("CRI_LINEAR_COLORSPACE");
            }
            return !initialized;
        }
    }
}
