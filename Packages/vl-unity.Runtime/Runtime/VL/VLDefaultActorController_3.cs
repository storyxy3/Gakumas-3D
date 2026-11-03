namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    public class VLDefaultActorController<TModelParts, TDescriptor, TIDescriptor> : VLActorController<TModelParts, TDescriptor, TIDescriptor> where TModelParts : VLActorModelParts<TDescriptor> where TDescriptor : VLDefaultActorDescriptor, TIDescriptor where TIDescriptor : IVLDefaultActorDescriptor
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<VLActorModelParts, int> _003C_003E9__25_0;
            public _003C_003Ec()
            {
            }

            internal int _003CBuildAvatar_003Eb__25_0(VLActorModelParts x)
            {
                return default(int);
            }
        }

        [SerializeField]
        protected Color _color;
        [SerializeField]
        protected Color _outlineColor;
        private bool _colorChange;
        [SerializeField]
        protected HumanBodyBoneMapDictionary _humanBodyBoneMap;
        [SerializeField]
        [HideInInspector]
        protected VLActorCollider _collider;
        [SerializeField]
        [HideInInspector]
        protected Vector3 _headPosition;
        private int _cameraDistance;
        public Color color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Color outlineColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Vector3 headPosition
        {
            get
            {
                return default(Vector3);
            }
        }

        public float cameraDistance
        {
            get
            {
                return default(float);
            }
        }

        public VLActorBodyType GetColliderBodyType(Collider col)
        {
            return default(VLActorBodyType);
        }

        public void UpdateHeadPosition(Transform headTransform)
        {
        }

        protected void InitializeCollider()
        {
        }

        protected override void OnBuildModelSuccess()
        {
        }

        protected override void OnActorDestroy()
        {
        }

        protected override void LateUpdate()
        {
        }

        public override void BuildModel(IEnumerable<GameObject> resources)
        {
        }

        protected override void InitializeData()
        {
        }

        protected virtual void BuildAvatar()
        {
        }

        protected virtual void OnUpdateMaterial()
        {
        }

        private void UpdateMaterial()
        {
        }

        public void UpdateCameraDistance(Vector3 cameraPos)
        {
        }

        public int GetCameraDistanceMM()
        {
            return default(int);
        }

        public void SetSortOrder(int order)
        {
        }

        public override Vector3 GetAnimatedPosition()
        {
            return default(Vector3);
        }

        public override Quaternion GetAnimatedRotation()
        {
            return default(Quaternion);
        }

        public bool TryGetHumanBodyBoneTransform(HumanBodyBones hbb, out Transform t)
        {
            throw null;
        }

        public override Transform GetHumanBodyBoneTransform(HumanBodyBones hbb)
        {
            return null;
        }

        public VLDefaultActorController()
        {
        }
    }
}
