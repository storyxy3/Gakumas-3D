// TODO(qa-recon): Selected APK bodies still need reconstruction: Calc, LateUpdate.
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
        public float3 constraintWeight0 = float3.zero;
        public float3 constraintWeight1 = float3.zero;
        public float3 constraintWeight2 = float3.zero;
        public float3 constraintWeight3 = float3.zero;
        public float3 fieldConstraintWeight0 = float3.zero;
        public float3 offsetPosition = float3.zero;
        public quaternion offsetRotation = quaternion.identity;
        public float3 offsetScale = new float3(1f);
        public override ActorAnimationConstraintBoneType GetBoneType()
        {
            return ActorAnimationConstraintBoneType.Transform;
        }

        public void SetSource(Transform source0, float3 weight0, Transform source1, float3 weight1, Transform source2, float3 weight2, Transform source3, float3 weight3, Transform fieldSource0, float3 fieldWeight0)
        {
            ClearSource();
            constraintSource0 = source0;
            constraintWeight0 = weight0;
            constraintSource1 = source1;
            constraintWeight1 = weight1;
            constraintSource2 = source2;
            constraintWeight2 = weight2;
            constraintSource3 = source3;
            constraintWeight3 = weight3;
            fieldConstraintSource0 = fieldSource0;
            fieldConstraintWeight0 = fieldWeight0;
        }

        public void AddSource(Transform source)
        {
            AddSource(source, new float3(0f));
        }

        public void AddSource(Transform source, float3 weight)
        {
            if (constraintSource0 == null)
            {
                constraintSource0 = source;
                constraintWeight0 = weight;
            }
            else if (constraintSource1 == null)
            {
                constraintSource1 = source;
                constraintWeight1 = weight;
            }
            else if (constraintSource2 == null)
            {
                constraintSource2 = source;
                constraintWeight2 = weight;
            }
            else if (constraintSource3 == null)
            {
                constraintSource3 = source;
                constraintWeight3 = weight;
            }
            else if (fieldConstraintSource0 == null)
            {
                fieldConstraintSource0 = source;
                fieldConstraintWeight0 = weight;
            }
        }

        public int GetValidSourceCount()
        {
            int count;
            if (constraintSource0 == null) count = 0;
            else if (constraintSource1 == null) count = 1;
            else if (constraintSource2 == null) count = 2;
            else if (constraintSource3 == null) count = 3;
            else count = 4;
            // APK 0x655bba4 deliberately adds the null-field-source case.
            return count + (fieldConstraintSource0 == null ? 1 : 0);
        }

        public void ClearSource()
        {
            ClearCharacterSource();
            ClearFieldSource();
        }

        public void ClearCharacterSource()
        {
            constraintSource0 = null;
            constraintWeight0 = float3.zero;
            constraintSource1 = null;
            constraintWeight1 = float3.zero;
            constraintSource2 = null;
            constraintWeight2 = float3.zero;
            constraintSource3 = null;
            constraintWeight3 = float3.zero;
        }

        public void ClearFieldSource()
        {
            fieldConstraintSource0 = null;
            fieldConstraintWeight0 = float3.zero;
        }

        public void ClearOffset()
        {
            offsetPosition = float3.zero;
            offsetRotation = quaternion.identity;
            offsetScale = new float3(1f);
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
