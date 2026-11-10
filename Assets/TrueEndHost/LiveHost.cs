using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Campus.Common;
using Campus.Common.Extensions;
using Campus.Common.Live;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using VL.Animation;

namespace TrueEnd.Host
{
    // File access and process lifetime belong to this standalone host.
    // Game binding and playback belong to the reconstructed Campus assemblies.
    public sealed class LiveHost : MonoBehaviour
    {
        [Serializable]
        private sealed class ContentManifest
        {
            public string sample;
            public BundleEntry[] bundles;
        }

        [Serializable]
        private sealed class BundleEntry
        {
            public string name;
            public string file;
            public string source;
        }

        private readonly Dictionary<string, AssetBundle> bundles = new Dictionary<string, AssetBundle>();
        private const string ResourcesBundleName = "trueend-resources";
        private static AssetBundle startupResources;

        // The client's Resources (VLBConfigOverride, Game3DManager, ...) are part of its player data, so every game
        // [RuntimeInitializeOnLoadMethod] (e.g. VLB.Config.OnStartup, AfterSceneLoad) already finds them. This host serves them
        // from the original resources bundle, so install it before any game startup method runs (BeforeSplashScreen precedes
        // BeforeSceneLoad / AfterSceneLoad).
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        private static void InstallResourcesBeforeGameStartup()
        {
            try
            {
                var options = LiveOptions.Parse(Environment.GetCommandLineArgs());
                string manifestPath = Path.Combine(options.DataDirectory, "manifest.json");
                if (!File.Exists(manifestPath)) return;
                var manifest = JsonUtility.FromJson<ContentManifest>(File.ReadAllText(manifestPath));
                var entry = manifest.bundles?.FirstOrDefault(bundle => bundle.name == ResourcesBundleName);
                if (entry == null) return;
                startupResources = AssetBundle.LoadFromFile(Path.Combine(options.DataDirectory, entry.file));
                if (startupResources != null) ResourcesAPI.overrideAPI = new LiveResources(startupResources);
                Debug.Log($"LIVE_RESOURCES_EARLY {(startupResources != null ? "installed" : "failed")}");
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
            }
        }
        // LiveDefine.TimelineEndMargin / FadeDuration in APK 3.5.3.
        private const float TimelineEndMargin = 0.4f;
        private const float FadeDuration = 0.3f;
        // LiveScenePresenter.<Bind>b__16_1 (DMM PC RVA 0x2941360): when the timeline time crosses Duration - 0.8 the black tint
        // fades in (LiveSceneView.FadeBlackTintAsync 0x2941d20: black image, 0.3 s DOFadeBlocking), before CheckLiveEnd pauses at -0.4.
        private const float BlackTintMargin = 0.8f;
        private CanvasGroup fadeGroup;
        private UniversalRenderPipelineAsset pipelineAsset;
        private LiveOptions options;
        private CampusLiveTimelineController timeline;
        private VL.Rendering.VLSRPCameraController cameraController;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Boot()
        {
            var host = new GameObject("True End Host");
            DontDestroyOnLoad(host);
            host.AddComponent<LiveHost>();
        }

        // CampusQualityManager.set_TargetFrameRate + ApplyVsync: with vsync on, every refresh when the display is not faster than
        // the target (1), every second refresh when it is at least twice as fast (2), otherwise off; a 179 Hz display at 60 gives
        // vSyncCount 2 = ~89.5 fps. Same float/double compares as the client (refresh rate as numerator / denominator in double).
        private static void ApplyFrameRate(float targetFrameRate, bool enableVsync)
        {
            Application.targetFrameRate = (int)targetFrameRate;
            int vSyncCount = 0;
            if (enableVsync)
            {
                var ratio = Screen.currentResolution.refreshRateRatio;
                double refreshRate = (double)(int)ratio.numerator / (int)ratio.denominator;
                if (targetFrameRate >= refreshRate - 0.1f) vSyncCount = 1;
                else if (targetFrameRate > 30f && refreshRate + 0.1f >= (float)(targetFrameRate + targetFrameRate)) vSyncCount = 2;
            }
            QualitySettings.vSyncCount = vSyncCount;
            Application.targetFrameRate = (int)targetFrameRate;
            Debug.Log($"LIVE_FRAME_RATE target={Application.targetFrameRate} vSyncCount={QualitySettings.vSyncCount} vsync={enableVsync} refresh={Screen.currentResolution.refreshRateRatio.value:F2}");
        }

        private async void Start()
        {
            try
            {
                options = LiveOptions.Parse(Environment.GetCommandLineArgs());
                Application.runInBackground = true;
                if (options.CaptureFps > 0) Time.captureFramerate = options.CaptureFps;
                if (options.Mute) AudioListener.volume = 0;
                Debug.Log($"LIVE_HOST sample=ttmr001 mute={options.Mute} data={options.DataDirectory}");
                var manifest = JsonUtility.FromJson<ContentManifest>(File.ReadAllText(Path.Combine(options.DataDirectory, "manifest.json")));
                if (manifest.sample != "ttmr001" || manifest.bundles == null)
                    throw new InvalidDataException("Expected a ttmr001 content manifest.");
                foreach (var entry in manifest.bundles)
                {
                    Debug.Log($"LIVE_LOADING {entry.name}");
                    if (entry.name == ResourcesBundleName && startupResources != null)
                    {
                        bundles.Add(entry.name, startupResources);
                        Debug.Log($"LIVE_BUNDLE {entry.name} source={entry.source} (loaded before game startup)");
                        continue;
                    }
                    var request = AssetBundle.LoadFromFileAsync(Path.Combine(options.DataDirectory, entry.file));
                    await request;
                    if (request.assetBundle == null)
                        throw new InvalidDataException("Cannot load bundle " + entry.name);
                    bundles.Add(entry.name, request.assetBundle);
                    Debug.Log($"LIVE_BUNDLE {entry.name} source={entry.source}");
                }

                var resources = bundles[ResourcesBundleName];
                if (resources != startupResources) ResourcesAPI.overrideAPI = new LiveResources(resources);
                var pipeline = resources.LoadAsset<UniversalRenderPipelineAsset>("assets/campusrenderpipelineultimateasset");
                if (pipeline == null)
                    throw new InvalidDataException("Original Ultimate pipeline asset is missing. Available assets " + string.Join(", ", resources.GetAllAssetNames()));
                pipelineAsset = pipeline;
                // DMM PC CampusQualityManager.SetQuality (GameAssembly 2026-11-08 RVA 0x2b412e0): QualitySettings level of the
                // tier, then a fixed 1024 MB texture streaming budget (the Android build uses 320/128 by system memory). DMM
                // logs "[Quality Level] Ultimate (4)" = QualityLevel.VeryHigh. Level data: DMM's own QualitySettings.asset.
                var tier = QualityTier.Get(options.QualityTier);
                QualitySettings.SetQualityLevel(tier.qualitySettingsLevel);
                QualitySettings.streamingMipmapsMemoryBudget = 1024f;
                // DMM PC GameSetting.ApplySetting (RVA 0x15df700), after the quality level: frame rate 60 (high) or 30, stored by
                // CampusQualityManager.set_TargetFrameRate (0x2b424e0), which runs ApplyVsync (0x2b40cf0) and then sets
                // Application.targetFrameRate. Capture runs keep the capture clock instead.
                if (options.CaptureFps == 0) ApplyFrameRate(options.HighFrameRate ? 60f : 30f, options.Vsync);
                Debug.Log($"LIVE_QUALITY level={QualitySettings.GetQualityLevel()} name={QualitySettings.names[QualitySettings.GetQualityLevel()]} budget={QualitySettings.streamingMipmapsMemoryBudget}");
                GraphicsSettings.defaultRenderPipeline = pipeline;
                QualitySettings.renderPipeline = pipeline;
                Debug.Log($"LIVE_PIPELINE {pipeline.name} renderer={pipeline.scriptableRenderer.GetType().FullName}");
                if (Resources.Load<ScriptableObject>("VLBConfigOverride") == null)
                    throw new InvalidDataException("Original VLB configuration is missing.");
                var cameraObject = Instantiate(Resources.Load<GameObject>("Game3DManager"));
                cameraController = cameraObject.GetComponent<VL.Rendering.VLSRPCameraController>();
                // DMM PC CampusInitializer.AfterSceneLoad (GameAssembly 2026-11-08 RVA 0x159b3a0; APK 3.5.3 0x7074C70): the 3D
                // camera's serialized FXAA becomes TAA at quality Low, then VLSRPCameraController.bufferScale = 4 (the buffer is
                // capped by maxBufferPixel). The only TAA writer in the client; CampusQualityManager only sets renderScale and
                // maxBufferPixel. Confirmed at runtime by the DMM RenderDoc capture (TemporalAA pass at EID 6436 of 5.5.rdc).
                var additionalCameraData = cameraController.additionalCameraData;
                if (additionalCameraData != null)
                {
                    additionalCameraData.antialiasing = AntialiasingMode.TemporalAntiAliasing;
                    additionalCameraData.taaSettings.quality = TemporalAAQuality.Low;
                }
                cameraController.bufferScale = 4f;
                cameraController.aspectRatio = new Vector2(2.35f, 1f);
                ApplyQualityTier(tier);
                cameraController.UpdateRenderTarget();
                var stage = await LoadScene("env_3d_live_ttmr001-00-noon");
                SceneManager.SetActiveScene(stage);
                var live = await LoadScene("tln_live_ttmr-001");
                timeline = live.GetRootGameObjects().SelectMany(root => root.GetComponentsInChildren<CampusLiveTimelineController>(true)).Single();
                LightProbes.Tetrahedralize();
                Debug.Log($"LIVE_LOADED bundles={bundles.Count} stage={stage.name} timeline={live.name} duration={timeline.master.duration}");

                string[] actorAssets = { "mdl_chr_ttmr-cstm-0003_body", "mdl_chr_ttmr-cstm-0003_hair", "mdl_chr_ttmr-base-0000_face" };
                var models = Enumerable.Select(actorAssets, asset => bundles[asset].LoadAllAssets<GameObject>().Single()).ToList();
                models.AddRange(timeline.GetProps(0));
                // Like CampusActorUtility.CreateActorDescriptor (APK 3.5.3 0x70eb774): humanoid, HUMAN collider; colliderTrigger keeps the constructor's true.
                var descriptor = new CampusActorDescriptor
                {
                    humanoid = true,
                    colliderType = VL.VLActorColliderType.HUMAN,
                    name = "ttmr",
                    assets = Enumerable.Select(models, model => model.name).ToList(),
                    gameObjects = models,
                    propIndexList = Enumerable.Range(0, models.Count).Where(index => models[index].name.StartsWith("mdl_prp", StringComparison.Ordinal)).ToList(),
                    correctSkeletonToCmmnHeight = timeline.IsCmmnHeightCorrectionNeededForActorSwing
                };
                var actor = VL.Core.VLActorController<CampusActorModelParts, CampusActorDescriptor, ICampusActorDescriptor>.Create<CampusActorController>(0);
                var actorSettings = resources.LoadAsset<CampusActorSettings>("assets/campusactorsettings");
                if (!actor.Build(actorSettings, descriptor)) throw new InvalidDataException("Cannot build Temari's actor.");
                Debug.Log($"LIVE_ACTOR {actor.name} avatar={actor.avatar.isValid} humanoid={actor.avatar.isHuman} parts={actor.GetModelPartsList().Count} renderers={actor.GetComponentsInChildren<Renderer>().Length} layer={actor.gameObject.layer} cameraMask={cameraController.mainCamera.cullingMask}");
                var music = bundles["sud_music_live_ttmr-001-ttmr_true-001"].LoadAllAssets<AudioClip>().Single();
                var musicSource = gameObject.AddComponent<AudioSource>();
                musicSource.playOnAwake = false;
                musicSource.mute = options.Mute;
                musicSource.outputAudioMixerGroup = resources.LoadAsset<UnityEngine.Audio.AudioMixerGroup>("assets/campuslivemixergroup");
                // The native live uses DSP time. Linux's disabled audio device needs a running frame clock.
                // The capture clock only drives GameTime; the audio clock would keep wall-clock pace.
                var updateMode = Application.platform == RuntimePlatform.LinuxPlayer || options.CaptureFps > 0
                    ? DirectorUpdateMode.GameTime : DirectorUpdateMode.DSPClock;
                Debug.Log($"LIVE_AUDIO clip={music.name} duration={music.length} frequency={music.frequency} channels={music.channels} clock={updateMode}");
                var binder = new CampusLiveBinder(new CampusLiveBinder.BindParams
                {
                    timeline = timeline,
                    campusTimeline = timeline,
                    environment = stage.GetRootGameObjects().SelectMany(root => root.GetComponentsInChildren<CampusLiveEnvironment>(true)).SingleOrDefault(),
                    actors = new List<ICampusActorController> { actor },
                    overrideDirectorUpdateMode = updateMode,
                    bgmAudioSource = musicSource,
                    bgmAudioClip = music,
                    initialTime = (float)options.StartTime,
                    exposedLayoutMotion = bundles["mot_live_ttmr-001_in_layout"].LoadAllAssets<LayoutMotionDefine>().Single(),
                    exposedActorMotions = bundles["mot_live_chr_ttmr_ttmr-001_00_in"].LoadAllAssets<VL.ActorMotionDefine>()
                });
                await binder.SetupAsync(this.GetCancellationTokenOnDestroy());
                // Live3DPresenter.SetActorsActive dispatches this interface call after loading.
                actor.SetRendererActive(true);
                fadeGroup = gameObject.AddComponent<CanvasGroup>();
                fadeGroup.SetBlockingAlpha(0f);
                using var poseRecorder = options.PoseLog == null ? null : new LivePoseRecorder(actor, options.PoseLog);
                using var frameRecorder = options.FrameDirectory == null ? null : new LiveFrameRecorder(options.FrameDirectory, options.FrameWidth);
                timeline.Play();
                Debug.Log($"LIVE_PLAYING time={timeline.master.time} duration={timeline.master.duration}");
                double started = Time.realtimeSinceStartupAsDouble;
                int screenshotIndex = 0;
                Directory.CreateDirectory(options.CaptureDirectory);
                double presentationTime = timeline.master.time;
                double fadeStartedAt = -1;
                double pausedAt = 0;
                float previousTime = (float)timeline.master.time;
                // Match LivePresenter.CheckLiveEnd's float duration and subtraction.
                float endTime = (float)timeline.master.duration - TimelineEndMargin;
                while (presentationTime < Math.Min(timeline.master.duration, options.StopTime) && Time.realtimeSinceStartupAsDouble - started < options.QuitAfter)
                {
                    await UniTask.WaitForEndOfFrame(this);
                    poseRecorder?.Record(timeline.master.time);
                    // The client pauses its director in OnEndLiveSequence, then fades the UI.
                    // Keep a host presentation clock so captures can also cover that paused fade.
                    presentationTime = fadeStartedAt < 0 ? timeline.master.time : pausedAt + Time.timeAsDouble - fadeStartedAt;
                    // Pairwise (previous, current) of the timeline time, as the client's subscription sees it.
                    float tintTime = (float)timeline.master.duration - BlackTintMargin, currentTime = (float)timeline.master.time;
                    if (tintTime > previousTime && currentTime >= tintTime)
                    {
                        fadeGroup.DOFadeBlocking(1f, FadeDuration);
                        Debug.Log($"LIVE_BLACK_TINT time={timeline.master.time} duration={FadeDuration}");
                    }
                    previousTime = currentTime;
                    if (fadeStartedAt < 0 && (float)timeline.master.time >= endTime)
                    {
                        pausedAt = timeline.master.time;
                        fadeStartedAt = Time.timeAsDouble;
                        timeline.master.Pause();
                        musicSource.Pause();
                        fadeGroup.DOFadeBlocking(1f, FadeDuration);
                        Debug.Log($"LIVE_END_FADE time={pausedAt} duration={FadeDuration}");
                    }
                    frameRecorder?.Record(cameraController.targetTexture, presentationTime, fadeGroup.alpha);
                    // Capture clock only: the monitors' VideoPlayers run Freerun on their own clock; let them follow game
                    // time and wait for each frame so the dumped monitor content matches the timeline (host glue).
                    if (options.CaptureFps > 0)
                        foreach (var video in FindObjectsByType<UnityEngine.Video.VideoPlayer>(FindObjectsInactive.Include, FindObjectsSortMode.None))
                        {
                            video.timeUpdateMode = UnityEngine.Video.VideoTimeUpdateMode.GameTime;
                            video.skipOnDrop = false;
                        }
                    if (screenshotIndex < options.ScreenshotTimes.Length && presentationTime >= options.ScreenshotTimes[screenshotIndex])
                    {
                        double requested = options.ScreenshotTimes[screenshotIndex++];
                        string path = Path.Combine(options.CaptureDirectory, $"ttmr001-{requested:F3}.png");
                        var capture = ScreenCapture.CaptureScreenshotAsTexture();
                        File.WriteAllBytes(path, capture.EncodeToPNG());
                        Destroy(capture);
                        Debug.Log($"LIVE_CAPTURE requested={requested} actual={presentationTime} path={path}");
                    }
                }
                // Finish the frame dump before shutdown starts.
                frameRecorder?.Dispose();
                Debug.Log($"LIVE_STOPPED time={timeline.master.time} presentation={presentationTime} fadeAlpha={fadeGroup.alpha}");
                timeline.master.Pause();
                musicSource.Stop();
                if (options.QuitAtEnd || Time.realtimeSinceStartupAsDouble - started >= options.QuitAfter)
                {
                    // Release renderer-owned buffers synchronously; quit never waits on scene unloading.
                    ReleaseRendering();
                    Debug.Log("LIVE_QUIT");
                    Application.Quit();
                }
                else Debug.Log("LIVE_IDLE close the window to exit, or use --quit-at-end");
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
                Application.Quit(1);
            }
        }

        private void OnApplicationQuit()
        {
            ReleaseRendering();
        }

        private void ReleaseRendering()
        {
            if (pipelineAsset == null) return;
            if (cameraController != null) cameraController.mainCamera.enabled = false;
            // UniversalRenderPipelineAsset owns its renderer array. This is the same cleanup
            // called by its OnDisable, dispatched now before the process tears down graphics.
            typeof(UniversalRenderPipelineAsset).GetMethod("DestroyRenderers",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(pipelineAsset, null);
            QualitySettings.renderPipeline = null;
            GraphicsSettings.defaultRenderPipeline = null;
            pipelineAsset = null;
        }

        private void OnGUI()
        {
            if (cameraController != null && cameraController.targetTexture != null)
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), cameraController.targetTexture, ScaleMode.ScaleToFit, false);
            // Host compositor for LiveSceneView's black Image / CanvasGroup overlay.
            if (fadeGroup != null && fadeGroup.alpha > 0f)
            {
                Color previous = GUI.color;
                GUI.color = new Color(0f, 0f, 0f, fadeGroup.alpha);
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.whiteTexture);
                GUI.color = previous;
            }
        }

        // The rest of DMM PC CampusQualityManager.SetQuality: enable override volume [volumeIndex] (global, priority 10000,
        // profiles from DMM resources.assets), then the camera's render scale and VLSRPCameraController.maxBufferPixel.
        private void ApplyQualityTier(QualityTier tier)
        {
            var profile = ScriptableObject.CreateInstance<VolumeProfile>();
            var crowd = profile.Add<Campus.Crowd.Crowd>();
            switch (tier.volumeIndex)
            {
                case 3: // CampusQualityManagerVeryHighProfile
                    crowd.drawDetailCount.Override(1024);
                    crowd.billboardQuality.Override((Campus.Crowd.BillboardQuality)3);
                    break;
                case 4: // CampusQualityManagerRecordingProfile
                    crowd.drawDetailCount.Override(32768);
                    crowd.billboardQuality.Override((Campus.Crowd.BillboardQuality)0);
                    profile.Add<VL.Rendering.VLScreenSpaceReflection>().quality.Override((VL.Rendering.VLSSRQualitySetting)3);
                    break;
                default: throw new ArgumentException("No override profile for volume index " + tier.volumeIndex);
            }
            // The client's override volumes sit on its volume layer; the camera only blends volumes on its volumeLayerMask.
            var volumeObject = new GameObject("QualityOverrideVolume");
            int volumeMask = cameraController.additionalCameraData.volumeLayerMask.value;
            for (int layer = 0; layer < 32; layer++) if ((volumeMask & (1 << layer)) != 0) { volumeObject.layer = layer; break; }
            var volume = volumeObject.AddComponent<Volume>();
            volume.isGlobal = true;
            volume.priority = 10000f;
            volume.sharedProfile = profile;
            cameraController.additionalCameraData.renderScale = tier.renderScale;
            cameraController.maxBufferPixel = tier.maxBufferPixel;
            Debug.Log($"LIVE_QUALITY_TIER {tier.name} renderScale={tier.renderScale} maxBufferPixel={tier.maxBufferPixel} volume={tier.volumeIndex} layer={volumeObject.layer}");
        }

        private async UniTask<Scene> LoadScene(string bundleName)
        {
            string scenePath = bundles[bundleName].GetAllScenePaths().Single();
            await SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Additive);
            var scene = SceneManager.GetSceneByPath(scenePath);
            if (!scene.isLoaded) throw new InvalidDataException("Cannot load scene " + scenePath);
            return scene;
        }
    }
}
