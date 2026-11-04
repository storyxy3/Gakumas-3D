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
            _headPosition = headTransform != null ? headTransform.position : position;
        }

        protected void InitializeCollider()
        {
            if (_collider == null)
            {
                _collider = GetComponent<VLActorCollider>();
                if (_collider == null) _collider = gameObject.AddComponent<VLActorCollider>();
            }
            _collider.UpdateCollider(descriptor.colliderType, _humanBodyBoneMap, descriptor.colliderTrigger);
            _collider.SetEnableColliders(true);
        }

        protected override void OnBuildModelSuccess()
        {
        }

        protected override void OnActorDestroy()
        {
            if (this != null) UnityEngine.Rendering.CoreUtils.Destroy(_avatar);
        }

        protected override void LateUpdate()
        {
            if (this == null) return;
            base.LateUpdate();
            UpdateMaterial();
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
            if (_children == null) return;
            Matrix4x4 reflection = Matrix4x4.identity;
            var head = GetHumanBodyBoneTransform(HumanBodyBones.Head);
            Vector3 forward = Vector3.forward;
            Vector3 up = Vector3.up;
            if (head != null)
            {
                forward = head.forward;
                up = head.up;
                reflection = head.localToWorldMatrix * Matrix4x4.Scale(new Vector3(-1, 1, 1)) * head.worldToLocalMatrix * transform.localToWorldMatrix;
            }
            UpdateHeadPosition(head);
            float alpha = _color.a;
            foreach (var child in _children)
                if (child.materials != null)
                    foreach (var material in child.materials) material.InitializeProperty();
            foreach (var child in _children)
            {
                if (child.materials == null) continue;
                bool hair = child.partsId == VLActorDefine.PARTS_HAIR_NAME;
                bool face = child.partsId == VLActorDefine.PARTS_FACE_NAME;
                foreach (var material in child.materials)
                {
                    if (_colorChange) material.SetKeyword(ShaderKeywords._DITHER_ALPHA, alpha < 1);
                    material.SetFloat(ShaderIDs._ActorIndex, _index);
                    material.SetColor(ShaderIDs._MultiplyColor, _color);
                    material.SetColor(ShaderIDs._MultiplyOutlineColor, _outlineColor);
                    if (hair)
                    {
                        material.SetVector(ShaderIDs._HeadDirection, new Vector4(forward.x, forward.y, forward.z, 1));
                        material.SetVector(ShaderIDs._HeadUpDirection, new Vector4(up.x, up.y, up.z, 1));
                    }
                    if (face) material.SetMatrix(ShaderIDs._HeadXAxisReflectionMatrix, reflection);
                }
            }
            _colorChange = false;
            OnUpdateMaterial();
            foreach (var child in _children)
                if (child.materials != null)
                    foreach (var material in child.materials) material.ApplyProperty();
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
            if (_humanBodyBoneMap != null)
            {
                if (_humanBodyBoneMap.TryGetValue(hbb, out t)) return true;
            }
            else Debug.LogError("InitializeBonesを呼び出して下さい");
            t = null;
            return false;
        }

        public override Transform GetHumanBodyBoneTransform(HumanBodyBones hbb)
        {
            TryGetHumanBodyBoneTransform(hbb, out var t);
            return t;
        }

        public VLDefaultActorController()
        {
        }
    }
}
