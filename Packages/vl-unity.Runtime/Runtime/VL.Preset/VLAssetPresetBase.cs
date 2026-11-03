namespace VL.Preset
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL.Core;
    using global::VL.Preset;

    public abstract class VLAssetPresetBase : ScriptableObject
    {
        public abstract int GetPresetCount();
        public abstract IEnumerable<PresetFile> GetPresetModelFiles(int index);
        public abstract VLActorController UpdateActor(int index, VLActorController controller, PresetActorDescriptor descriptor);
        public abstract void DestroyActor(int index, VLActorController controller);
        public abstract Layout GetLayout(int index);
        public abstract void SetLayout(int index, Layout layout);
        protected VLAssetPresetBase()
        {
        }
    }
}
