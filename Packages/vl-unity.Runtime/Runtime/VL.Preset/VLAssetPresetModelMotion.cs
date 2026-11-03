namespace VL.Preset
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL.Core;
    using global::VL.Preset;

    [CreateAssetMenu(fileName = "ModelMotionPreset.asset", menuName = "VL/Preset/Model Motion", order = 60005)]
    public class VLAssetPresetModelMotion : VLAssetPresetBase
    {
        public List<PresetModelMotionData> data;
        private void OnEnable()
        {
        }

        public override int GetPresetCount()
        {
            return default(int);
        }

        public override IEnumerable<PresetFile> GetPresetModelFiles(int index)
        {
            return null;
        }

        public override VLActorController UpdateActor(int index, VLActorController controller, PresetActorDescriptor descriptor)
        {
            return null;
        }

        public override Layout GetLayout(int index)
        {
            return default(Layout);
        }

        public override void SetLayout(int index, Layout layout)
        {
        }

        public override void DestroyActor(int index, VLActorController controller)
        {
        }

        public VLAssetPresetModelMotion()
        {
        }
    }
}
