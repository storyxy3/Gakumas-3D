namespace VL.Preset
{
    using global::UnityEngine;
    using global::VL.Preset;

    public abstract class VLLayoutPresetBase : ScriptableObject
    {
        public abstract Layout GetLayout(int index);
        protected VLLayoutPresetBase()
        {
        }
    }
}
