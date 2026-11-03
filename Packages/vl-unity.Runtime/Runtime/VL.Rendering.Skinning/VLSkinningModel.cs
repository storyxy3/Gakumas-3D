namespace VL.Rendering.Skinning
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public abstract class VLSkinningModel : MonoBehaviour
    {
        public abstract Transform GetRootBone();
        public abstract Transform[] GetBones();
        public abstract Bounds GetLocalBounds();
        public abstract void SetupSkinning();
        internal abstract void ScheduleSkinning();
        internal abstract void ApplySkinning(CommandBuffer cmd);
        protected VLSkinningModel()
        {
        }
    }
}
