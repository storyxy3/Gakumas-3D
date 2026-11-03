namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    public class VLActorCollider : MonoBehaviour
    {
        [SerializeField]
        [HideInInspector]
        private List<Collider> _colliderList;
        [SerializeField]
        [HideInInspector]
        private List<HumanBodyBones> _hbbList;
        public void UpdateCollider(VLActorColliderType colliderType, Dictionary<HumanBodyBones, Transform> humanBodyBoneMap, bool isTrigger = true)
        {
        }

        private void _ApplyCollider(VLActorColliderType colliderType, HumanBodyBones type, Transform t, bool isTrigger)
        {
        }

        public void SetEnableColliders(bool active)
        {
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
