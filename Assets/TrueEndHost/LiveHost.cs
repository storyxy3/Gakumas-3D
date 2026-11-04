using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Campus.Common.Live;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        private LiveOptions options;
        private CampusLiveTimelineController timeline;

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

                var stage = await LoadScene("env_3d_live_ttmr001-00-noon");
                SceneManager.SetActiveScene(stage);
                var live = await LoadScene("tln_live_ttmr-001");
                timeline = live.GetRootGameObjects().SelectMany(root => root.GetComponentsInChildren<CampusLiveTimelineController>(true)).Single();
                LightProbes.Tetrahedralize();
                Debug.Log($"LIVE_LOADED bundles={bundles.Count} stage={stage.name} timeline={live.name} duration={timeline.master.duration}");
                // TODO(qa-recon): restore CampusLiveBinder.SetupAsync and the client actor construction before playback.
                throw new NotSupportedException("Live assets loaded. Campus client binding reconstruction is pending.");
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
                Application.Quit(1);
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
