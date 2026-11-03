namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [ExecuteAlways]
    public class ActorAnimationConstraintTransformBone : ActorAnimationConstraintBoneBase
    {
        public ActorAnimationConstraintExecuteType executeType;
        public Transform constraintSource0;
        public Transform constraintSource1;
        public Transform constraintSource2;
        public Transform constraintSource3;
        public Transform fieldConstraintSource0;
        public float3 constraintWeight0;
        public float3 constraintWeight1;
        public float3 constraintWeight2;
        public float3 constraintWeight3;
        public float3 fieldConstraintWeight0;
        public float3 offsetPosition;
        public quaternion offsetRotation;
        public float3 offsetScale;
        public override ActorAnimationConstraintBoneType GetBoneType()
        {
            return default(ActorAnimationConstraintBoneType);
        }

        public void SetSource(Transform source0, float3 weight0, Transform source1, float3 weight1, Transform source2, float3 weight2, Transform source3, float3 weight3, Transform fieldSource0, float3 fieldWeight0)
        {
        }

        public void AddSource(Transform source)
        {
        }

        public void AddSource(Transform source, float3 weight)
        {
        }

        public int GetValidSourceCount()
        {
            return default(int);
        }

        public void ClearSource()
        {
        }

        public void ClearCharacterSource()
        {
        }

        public void ClearFieldSource()
        {
        }

        public void ClearOffset()
        {
        }

        public static void Calc(float3 weight0, float3 weight1, float3 weight2, float3 weight3, float3 fieldWeight0, float3 position0, float3 position1, float3 position2, float3 position3, float3 fieldPosition0, quaternion rotation0, quaternion rotation1, quaternion rotation2, quaternion rotation3, quaternion fieldRotation0, float3 scale0, float3 scale1, float3 scale2, float3 scale3, float3 fieldScale0, float3 offsetPosition, quaternion offsetRotation, float3 offsetScale, out float3 position, out quaternion rotation, out float3 scale)
        {
            throw null;
        }

        private void LateUpdate()
        {
        }

        public ActorAnimationConstraintTransformBone()
        {
        }
    }
}
