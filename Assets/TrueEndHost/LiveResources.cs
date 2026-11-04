using System;
using UnityEngine;

namespace TrueEnd.Host
{
    // Preserve the game's Resources.Load entry point while serving its original
    // built-in resources from the standalone content bundle.
    internal sealed class LiveResources : ResourcesAPI
    {
        private readonly AssetBundle bundle;

        public LiveResources(AssetBundle bundle)
        {
            this.bundle = bundle;
        }

        protected override UnityEngine.Object Load(string path, Type systemTypeInstance)
        {
            string asset = "resources/" + path.ToLowerInvariant();
            return bundle.Contains(asset) ? bundle.LoadAsset(asset, systemTypeInstance) : base.Load(path, systemTypeInstance);
        }
    }
}
