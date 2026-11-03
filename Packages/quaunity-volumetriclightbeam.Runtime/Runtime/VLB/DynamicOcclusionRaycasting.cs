namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VLB;

    [ExecuteInEditMode]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/")]
    public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
    {
        public struct HitResult
        {
            public Vector3 point;
            public Vector3 normal;
            public float distance;
            private Collider2D collider2D;
            private Collider collider3D;
            public bool hasCollider
            {
                get
                {
                    return default(bool);
                }
            }

            public HitResult(ref RaycastHit hit3D)
            {
                this = default;
            }

            public HitResult(ref RaycastHit2D hit2D)
            {
                this = default;
            }

            public void SetNull()
            {
            }
        }

        public new const string ClassName = "DynamicOcclusionRaycasting";
        public Dimensions dimensions;
        public LayerMask layerMask;
        public bool considerTriggers;
        public float minOccluderArea;
        public float minSurfaceRatio;
        public float maxSurfaceDot;
        public PlaneAlignment planeAlignment;
        public float planeOffset;
        [FormerlySerializedAs("fadeDistanceToPlane")]
        public float fadeDistanceToSurface;
        private HitResult m_CurrentHit;
        private float m_RangeMultiplier;
        [CompilerGenerated]
        private Plane _003CplaneEquationWS_003Ek__BackingField;
        private uint m_PrevNonSubHitDirectionId;
        [Obsolete("Use 'fadeDistanceToSurface' instead")]
        public float fadeDistanceToPlane
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Plane planeEquationWS
        {
            [CompilerGenerated]
            get
            {
                return default(Plane);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        private QueryTriggerInteraction queryTriggerInteraction
        {
            get
            {
                return default(QueryTriggerInteraction);
            }
        }

        private float raycastMaxDistance
        {
            get
            {
                return default(float);
            }
        }

        public bool IsColliderHiddenByDynamicOccluder(Collider collider)
        {
            return default(bool);
        }

        protected override string GetShaderKeyword()
        {
            return null;
        }

        protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
        {
            return default(MaterialManager.SD.DynamicOcclusion);
        }

        protected override void OnValidateProperties()
        {
        }

        protected override void OnEnablePostValidate()
        {
        }

        protected override void OnDisable()
        {
        }

        private void Start()
        {
        }

        private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
        {
            return default(Vector3);
        }

        private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
        {
            return default(HitResult);
        }

        private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
        {
            return default(HitResult);
        }

        private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
        {
            return default(HitResult);
        }

        private uint GetDirectionCount()
        {
            return default(uint);
        }

        private Vector3 GetDirection(uint dirInt)
        {
            return default(Vector3);
        }

        private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
        {
            return default(bool);
        }

        protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
        {
            return default(bool);
        }

        private void SetHit(ref HitResult hit)
        {
        }

        private void SetHitNull()
        {
        }

        protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
        {
        }

        private void SetClippingPlane(Plane planeWS)
        {
        }

        private void SetClippingPlaneOff()
        {
        }

        private void SetPlaneWS(Plane planeWS)
        {
        }

        public DynamicOcclusionRaycasting()
        {
        }
    }
}
