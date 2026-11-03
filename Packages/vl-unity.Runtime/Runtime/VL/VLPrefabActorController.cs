namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    public class VLPrefabActorController : VLActorController, IVLActorController, IVLTransform
    {
        [Serializable]
        public class PrefabParts
        {
            public string name;
            public GameObject root;
            public List<Transform> transforms;
            public PrefabParts()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass8_0
        {
            public string resourceName;
            public _003C_003Ec__DisplayClass8_0()
            {
            }

            internal bool _003CBuildModel_003Eb__0(PrefabParts p)
            {
                return default(bool);
            }
        }

        public List<PrefabParts> parts;
        [SerializeField]
        protected HumanBodyBoneMapDictionary _humanBodyBoneMap;
        [SerializeField]
        private VLSkinningModel[] _skinningModels;
        public bool forceGenericAvatar;
        public override Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        public override bool IsRendererActive()
        {
            return default(bool);
        }

        public override void BuildModel(IEnumerable<GameObject> resources)
        {
        }

        protected override void InitializeData()
        {
        }

        protected override void LateUpdate()
        {
        }

        private void BuildAvatar()
        {
        }

        protected SkeletonBone GetSkeleton(Transform trans, bool initialize = false)
        {
            return default(SkeletonBone);
        }

        public override void SetRendererActive(bool active)
        {
        }

        public override void DestroyActor()
        {
        }

        private InitialTransform GetInitialTransform(Transform bone)
        {
            return default(InitialTransform);
        }

        public static VLPrefabActorController Create(int index)
        {
            return null;
        }

        public VLPrefabActorController()
        {
        }

        bool VL.IVLActorController.TryGetComponent<T>(out T component)
        {
            throw null;
        }
    }
}
