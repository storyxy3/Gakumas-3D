namespace VL
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;

    public class VLActorCollider : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public Collider col;
            public _003C_003Ec__DisplayClass6_0()
            {
            }

            internal bool _003CGetBodyType_003Eb__0(Collider c)
            {
                return default(bool);
            }
        }

        [SerializeField]
        [HideInInspector]
        private List<Collider> _colliderList;
        [SerializeField]
        [HideInInspector]
        private List<HumanBodyBones> _hbbList;
        public void UpdateCollider(VLActorColliderType colliderType, Dictionary<HumanBodyBones, Transform> humanBodyBoneMap, bool isTrigger = true)
        {
            if (_colliderList != null)
            {
                foreach (var collider in _colliderList)
                    if (collider != null) DestroyImmediate(collider);
                _colliderList.Clear();
            }
            else _colliderList = new List<Collider>();
            if (_hbbList != null) _hbbList.Clear();
            else _hbbList = new List<HumanBodyBones>();
            if (humanBodyBoneMap == null) return;
            foreach (var item in humanBodyBoneMap) _ApplyCollider(colliderType, item.Key, item.Value, isTrigger);
        }

        private void _ApplyCollider(VLActorColliderType colliderType, HumanBodyBones type, Transform t, bool isTrigger)
        {
            if (_hbbList.Contains(type)) return;
            Collider collider = null;
            if (collider != null) DestroyImmediate(collider);
            if (colliderType == VLActorColliderType.NONE) return;
            if (colliderType == VLActorColliderType.HUMAN)
            {
                switch (type)
                {
                    case HumanBodyBones.LeftUpperLeg:
                    case HumanBodyBones.RightUpperLeg:
                    case HumanBodyBones.LeftLowerLeg:
                    case HumanBodyBones.RightLowerLeg:
                    {
                        var capsule = t.gameObject.AddComponent<CapsuleCollider>();
                        capsule.center = new Vector3(type == HumanBodyBones.RightLowerLeg || type == HumanBodyBones.RightUpperLeg ? 0.2f : -0.2f, 0, 0);
                        capsule.radius = 0.07f;
                        capsule.height = 0.4f;
                        capsule.direction = 0;
                        collider = capsule;
                        break;
                    }
                    case HumanBodyBones.LeftUpperArm:
                    case HumanBodyBones.RightUpperArm:
                    {
                        var capsule = t.gameObject.AddComponent<CapsuleCollider>();
                        capsule.center = new Vector3(type == HumanBodyBones.RightUpperArm ? 0.1f : -0.1f, 0, 0);
                        capsule.radius = 0.04f;
                        capsule.height = 0.25f;
                        capsule.direction = 0;
                        collider = capsule;
                        break;
                    }
                    case HumanBodyBones.LeftLowerArm:
                    case HumanBodyBones.RightLowerArm:
                    {
                        var capsule = t.gameObject.AddComponent<CapsuleCollider>();
                        capsule.center = new Vector3(type == HumanBodyBones.RightLowerArm ? 0.15f : -0.15f, 0, 0);
                        capsule.radius = 0.03f;
                        capsule.height = 0.3f;
                        capsule.direction = 0;
                        collider = capsule;
                        break;
                    }
                    case HumanBodyBones.LeftHand:
                    case HumanBodyBones.RightHand:
                    {
                        var sphere = t.gameObject.AddComponent<SphereCollider>();
                        sphere.center = new Vector3(type == HumanBodyBones.RightHand ? 0.05f : -0.05f, 0, 0);
                        sphere.radius = 0.05f;
                        collider = sphere;
                        break;
                    }
                    case HumanBodyBones.Hips:
                    {
                        var sphere = t.gameObject.AddComponent<SphereCollider>();
                        sphere.center = new Vector3(0, -0.08f, 0.05f);
                        sphere.radius = 0.13f;
                        collider = sphere;
                        break;
                    }
                    case HumanBodyBones.Spine:
                    {
                        var box = t.gameObject.AddComponent<BoxCollider>();
                        box.center = new Vector3(0, 0.08f, -0.02f);
                        box.size = new Vector3(0.28f, 0.45f, 0.12f);
                        collider = box;
                        break;
                    }
                    case HumanBodyBones.Chest:
                    {
                        var capsule = t.gameObject.AddComponent<CapsuleCollider>();
                        capsule.center = new Vector3(0, 0.1f, 0.05f);
                        capsule.radius = 0.07f;
                        capsule.height = 0.23f;
                        capsule.direction = 0;
                        collider = capsule;
                        break;
                    }
                    case HumanBodyBones.Head:
                    {
                        var sphere = t.gameObject.AddComponent<SphereCollider>();
                        sphere.center = new Vector3(0, 0.1f, 0);
                        sphere.radius = 0.15f;
                        collider = sphere;
                        break;
                    }
                }
            }
            if (collider != null)
            {
                collider.isTrigger = isTrigger;
                collider.enabled = false;
                _colliderList.Add(collider);
                _hbbList.Add(type);
            }
        }

        public void SetEnableColliders(bool active)
        {
            if (_colliderList == null) return;
            foreach (var collider in _colliderList) collider.enabled = active;
        }

        public Transform GetBodyTransform(HumanBodyBones bone)
        {
            return null;
        }

        public VLActorBodyType GetBodyType(Collider col)
        {
            return default(VLActorBodyType);
        }

        public VLActorCollider()
        {
        }
    }
}
