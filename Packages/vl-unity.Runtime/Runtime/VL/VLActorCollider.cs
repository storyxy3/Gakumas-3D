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
