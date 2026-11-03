namespace VL.Preset
{
    using global::System;
    using global::System.Collections.Generic;
    using global::VL.Preset;

    [Serializable]
    public class PresetModelData
    {
        public List<PresetFile> models;
        public Layout layout;
        public PresetModelData()
        {
        }
    }
}
