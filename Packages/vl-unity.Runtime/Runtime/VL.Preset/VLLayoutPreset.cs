namespace VL.Preset
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL.Preset;

    [CreateAssetMenu(fileName = "LayoutPreset.asset", menuName = "VL/Preset/Layout", order = 60010)]
    public class VLLayoutPreset : VLLayoutPresetBase
    {
        public List<Layout> layouts;
        private void OnEnable()
        {
        }

        public override Layout GetLayout(int index)
        {
            return default(Layout);
        }

        public VLLayoutPreset()
        {
        }
    }
}
