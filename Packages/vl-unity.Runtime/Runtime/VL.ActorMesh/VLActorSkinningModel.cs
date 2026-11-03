namespace VL.ActorMesh
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.ActorMesh;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    [ExecuteAlways]
    public class VLActorSkinningModel : VLSkinningModel
    {
        public Transform rootBone;
        public Transform[] bones;
        public Bounds localBounds;
        private VLActorSkinningSystem _system;
        private BlendShapeWeight _blendShapeWeights;
        public bool isSystemActive
        {
            get
            {
                return default(bool);
            }
        }

        public Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void Dispose()
        {
        }

        public override Transform GetRootBone()
        {
            return null;
        }

        public override Transform[] GetBones()
        {
            return null;
        }

        public override Bounds GetLocalBounds()
        {
            return default(Bounds);
        }

        public override void SetupSkinning()
        {
        }

        internal override void ScheduleSkinning()
        {
        }

        internal override void ApplySkinning(CommandBuffer cmd)
        {
        }

        public void Setup()
        {
        }

        private void Update()
        {
        }

        public VLActorSkinningModel()
        {
        }
    }
}
