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
        // LiveDefine.TimelineEndMargin / FadeDuration in APK 3.5.3.
        private const float TimelineEndMargin = 0.4f;
        private const float FadeDuration = 0.3f;
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

        private async void Start()
        {
            try
            {
                options = LiveOptions.Parse(Environment.GetCommandLineArgs());
                Application.runInBackground = true;
                if (options.Mute) AudioListener.volume = 0;
                Debug.Log($"LIVE_HOST sample=ttmr001 mute={options.Mute} data={options.DataDirectory}");
                var manifest = JsonUtility.FromJson<ContentManifest>(File.ReadAllText(Path.Combine(options.DataDirectory, "manifest.json")));
                if (manifest.sample != "ttmr001" || manifest.bundles == null)
                    throw new InvalidDataException("Expected a ttmr001 content manifest.");
                foreach (var entry in manifest.bundles)
                {
                    Debug.Log($"LIVE_LOADING {entry.name}");
                    var request = AssetBundle.LoadFromFileAsync(Path.Combine(options.DataDirectory, entry.file));
                    await request;
                    if (request.assetBundle == null)
                        throw new InvalidDataException("Cannot load bundle " + entry.name);
                    bundles.Add(entry.name, request.assetBundle);
                    Debug.Log($"LIVE_BUNDLE {entry.name} source={entry.source}");
                }

                var resources = bundles["trueend-resources"];
                ResourcesAPI.overrideAPI = new LiveResources(resources);
                var pipeline = resources.LoadAsset<UniversalRenderPipelineAsset>("assets/campusrenderpipelineultimateasset");
                if (pipeline == null)
                    throw new InvalidDataException("Original Ultimate pipeline asset is missing. Available assets " + string.Join(", ", resources.GetAllAssetNames()));
                pipelineAsset = pipeline;
                GraphicsSettings.defaultRenderPipeline = pipeline;
                QualitySettings.renderPipeline = pipeline;
                Debug.Log($"LIVE_PIPELINE {pipeline.name} renderer={pipeline.scriptableRenderer.GetType().FullName}");
                // Config.OnStartup (APK 0xe0c7c64) refreshes these globals during client startup.
                // This host loads Resources asynchronously, so dispatch the same method after loading.
                var beamConfig = Resources.Load<ScriptableObject>("VLBConfigOverride");
                if (beamConfig == null) throw new InvalidDataException("Original VLB configuration is missing.");
                beamConfig.GetType().GetMethod("RefreshGlobalShaderProperties",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(beamConfig, null);
                var cameraObject = Instantiate(Resources.Load<GameObject>("Game3DManager"));
                cameraController = cameraObject.GetComponent<VL.Rendering.VLSRPCameraController>();
                cameraController.aspectRatio = new Vector2(2.35f, 1f);
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
                var descriptor = new CampusActorDescriptor
                {
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
                var updateMode = Application.platform == RuntimePlatform.LinuxPlayer ? DirectorUpdateMode.GameTime : DirectorUpdateMode.DSPClock;
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
                timeline.Play();
                Debug.Log($"LIVE_PLAYING time={timeline.master.time} duration={timeline.master.duration}");
                double started = Time.realtimeSinceStartupAsDouble;
                int screenshotIndex = 0;
                Directory.CreateDirectory(options.CaptureDirectory);
                double presentationTime = timeline.master.time;
                double fadeStartedAt = -1;
                double pausedAt = 0;
                // Match LivePresenter.CheckLiveEnd's float duration and subtraction.
                float endTime = (float)timeline.master.duration - TimelineEndMargin;
                while (presentationTime < timeline.master.duration && Time.realtimeSinceStartupAsDouble - started < options.QuitAfter)
                {
                    await UniTask.WaitForEndOfFrame(this);
                    // The client pauses its director in OnEndLiveSequence, then fades the UI.
                    // Keep a host presentation clock so captures can also cover that paused fade.
                    presentationTime = fadeStartedAt < 0 ? timeline.master.time : pausedAt + Time.timeAsDouble - fadeStartedAt;
                    if (fadeStartedAt < 0 && (float)timeline.master.time >= endTime)
                    {
                        pausedAt = timeline.master.time;
                        fadeStartedAt = Time.timeAsDouble;
                        timeline.master.Pause();
                        musicSource.Pause();
                        fadeGroup.DOFadeBlocking(1f, FadeDuration);
                        Debug.Log($"LIVE_END_FADE time={pausedAt} duration={FadeDuration}");
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
                Debug.Log($"LIVE_STOPPED time={timeline.master.time} presentation={presentationTime}");
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
                GUI.color = new Color(1f, 1f, 1f, fadeGroup.alpha);
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.blackTexture);
                GUI.color = previous;
            }
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
