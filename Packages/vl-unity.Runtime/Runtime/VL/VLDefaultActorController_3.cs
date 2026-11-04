namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<VLActorModelParts, int> _003C_003E9__25_0;
            public _003C_003Ec()
            {
            }

            internal int _003CBuildAvatar_003Eb__25_0(VLActorModelParts x)
            {
                return x.boneCount;
            }
        }

        [SerializeField]
        protected Color _color = Color.white;
        [SerializeField]
        protected Color _outlineColor = Color.white;
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
                return _color;
            }

            set
            {
                _color = value;
                _colorChange = true;
            }
        }

        public Color outlineColor
        {
            get
            {
                return _outlineColor;
            }

            set
            {
                _outlineColor = value;
                _colorChange = true;
            }
        }

        public Vector3 headPosition
        {
            get
            {
                return _headPosition;
            }
        }

        public float cameraDistance
        {
            get
            {
                return _cameraDistance / 1000f;
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
            _buildResources = resources.ToArray();
            bool rendererActive = false;
            if (root != null)
            {
                rendererActive = root.rendererActive;
                foreach (var parts in _childMap.Values)
                {
                    var partsTransform = parts.transform;
                    partsTransform.SetParent(null, false);
                    foreach (var link in parts.GetBoneLinkList()) link.rootBone.SetParent(partsTransform, false);
                }
            }
            else
            {
                foreach (Transform child in transform) UnityEngine.Object.DestroyImmediate(child.gameObject);
            }

            var nextParts = new List<TModelParts>(16);
            bool first = true;
            foreach (var resource in _buildResources)
            {
                string assetName = resource.name;
                string rootName = VLActorDefine.GetRootName(assetName);
                TModelParts previous = null;
                bool reuse = false;
                if (_childMap != null)
                {
                    foreach (var pair in _childMap)
                    {
                        if (pair.Value.name != rootName) continue;
                        reuse = assetName == pair.Key;
                        if (reuse) Debug.Log("ReRegister:" + assetName);
                        previous = (TModelParts)pair.Value;
                        _childMap.Remove(pair.Key);
                        break;
                    }
                }

                TModelParts parts;
                if (reuse && previous != null)
                {
                    parts = previous;
                    parts.transform.SetParent(transform, false);
                    if (first) SetRootParts(parts);
                }
                else
                {
                    var instance = UnityEngine.Object.Instantiate(resource, transform, false);
                    instance.name = rootName;
                    parts = instance.AddComponent<TModelParts>();
                    if (first) SetRootParts(parts);
                    string partsId = VLActorDefine.GetPartsId(assetName, true);
                    CorrectSkeleton(partsId, instance);
                    parts.Initialize(partsId, assetName);
                    if (partsId == "body") parts.aabbCalcType = VLActorAABBCalcType.Bone;
                    else if (partsId == "face") parts.aabbCalcType = VLActorAABBCalcType.Local;
                    else parts.aabbCalcType = parts.skinRenderers.Count > 0 ? VLActorAABBCalcType.Default : VLActorAABBCalcType.None;
                    if (previous != null) AddDestroyParts(previous);
                }
                nextParts.Add(parts);
                first = false;
            }
            InitializeData();
            foreach (var parts in nextParts) AddParts(parts);
            InitializeAABB();
            if (!rendererActive) SetRendererActive(false);
            BuildAvatar();
        }

        protected override void InitializeData()
        {
            base.InitializeData();
            if (_humanBodyBoneMap == null) _humanBodyBoneMap = new HumanBodyBoneMapDictionary();
            else _humanBodyBoneMap.Clear();
        }

        protected virtual void BuildAvatar()
        {
            UnityEngine.Rendering.CoreUtils.Destroy(_avatar);
            if (!descriptor.humanoid)
            {
                _avatar = AvatarBuilder.BuildGenericAvatar(gameObject, "");
                _avatar.name = "Generic Avatar";
                return;
            }
            var human = new List<HumanBone>(55);
            int count = _childMap.Values.Sum(_003C_003Ec._003C_003E9__25_0 ??
                (_003C_003Ec._003C_003E9__25_0 = _003C_003Ec._003C_003E9._003CBuildAvatar_003Eb__25_0));
            var skeleton = new SkeletonBone[count + 1];
            skeleton[0] = GetSkeleton(transform, true);
            int index = 1;
            foreach (var parts in _childMap.Values)
            {
                foreach (var bone in parts.boneInfos)
                {
                    skeleton[index++] = GetSkeleton(bone);
                    if (VLActorDefine.TryGetHumanBodyBone(bone.name, out var humanBodyBone))
                    {
                        _humanBodyBoneMap[humanBodyBone] = bone.transform;
                        human.Add(new HumanBone
                        {
                            humanName = VLActorDefine.HumanBodyToString(humanBodyBone),
                            boneName = bone.name,
                            limit = new HumanLimit { useDefaultValues = true }
                        });
                    }
                }
            }
            _avatar = AvatarBuilder.BuildHumanAvatar(gameObject, GetHumanDescription(human.ToArray(), skeleton));
            _avatar.name = "Humanoid Avatar";
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
            if (_animator != null) return _animator.bodyPosition;
            Debug.LogError("SetupAnimationを先に呼び出して下さい");
            return Vector3.zero;
        }

        public override Quaternion GetAnimatedRotation()
        {
            if (_animator != null) return _animator.bodyRotation;
            Debug.LogError("SetupAnimationを先に呼び出して下さい");
            return Quaternion.identity;
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
