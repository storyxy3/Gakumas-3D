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
            position = offsetPosition;
            float positionWeight = weight0[0] + weight1[0] + weight2[0] + weight3[0] + fieldWeight0[0];
            if (positionWeight != 0f)
            {
                position += position0 * (weight0[0] / positionWeight) + position1 * (weight1[0] / positionWeight)
                    + position2 * (weight2[0] / positionWeight) + position3 * (weight3[0] / positionWeight)
                    + fieldPosition0 * (fieldWeight0[0] / positionWeight);
            }
            rotation = offsetRotation;
            float rotationWeight = weight0[1] + weight1[1] + weight2[1] + weight3[1] + fieldWeight0[1];
            if (rotationWeight != 0f)
            {
                rotation = math.slerp((quaternion)Quaternion.identity, rotation0, weight0[1] / rotationWeight);
                rotation = math.mul(rotation, math.slerp((quaternion)Quaternion.identity, rotation1, weight1[1] / rotationWeight));
                rotation = math.mul(rotation, math.slerp((quaternion)Quaternion.identity, rotation2, weight2[1] / rotationWeight));
                rotation = math.mul(rotation, math.slerp((quaternion)Quaternion.identity, rotation3, weight3[1] / rotationWeight));
                rotation = math.mul(rotation, math.slerp((quaternion)Quaternion.identity, fieldRotation0, fieldWeight0[1] / rotationWeight));
                rotation = math.mul(rotation, offsetRotation);
            }
            scale = offsetScale;
            float scaleWeight = weight0[2] + weight1[2] + weight2[2] + weight3[2] + fieldWeight0[2];
            if (scaleWeight != 0f)
            {
                scale *= scale0 * (weight0[2] / scaleWeight) + scale1 * (weight1[2] / scaleWeight)
                    + scale2 * (weight2[2] / scaleWeight) + scale3 * (weight3[2] / scaleWeight)
                    + fieldScale0 * (fieldWeight0[2] / scaleWeight);
            }
        }

        private void LateUpdate()
        {
            if (executeType != ActorAnimationConstraintExecuteType.LateUpdate && executeType != ActorAnimationConstraintExecuteType.Both) return;
            float3 position0 = float3.zero;
            quaternion rotation0 = quaternion.identity;
            float3 scale0 = float3.zero;
            float3 weight0 = float3.zero;
            if (constraintSource0 != null)
            {
                position0 = constraintSource0.position;
                rotation0 = constraintSource0.rotation;
                scale0 = constraintSource0.localScale;
                weight0 = constraintWeight0;
            }
            float3 position1 = float3.zero;
            quaternion rotation1 = quaternion.identity;
            float3 scale1 = float3.zero;
            float3 weight1 = float3.zero;
            if (constraintSource1 != null)
            {
                position1 = constraintSource1.position;
                rotation1 = constraintSource1.rotation;
                scale1 = constraintSource1.localScale;
                weight1 = constraintWeight1;
            }
            float3 position2 = float3.zero;
            quaternion rotation2 = quaternion.identity;
            float3 scale2 = float3.zero;
            float3 weight2 = float3.zero;
            if (constraintSource2 != null)
            {
                position2 = constraintSource2.position;
                rotation2 = constraintSource2.rotation;
                scale2 = constraintSource2.localScale;
                weight2 = constraintWeight2;
            }
            float3 position3 = float3.zero;
            quaternion rotation3 = quaternion.identity;
            float3 scale3 = float3.zero;
            float3 weight3 = float3.zero;
            if (constraintSource3 != null)
            {
                position3 = constraintSource3.position;
                rotation3 = constraintSource3.rotation;
                scale3 = constraintSource3.localScale;
                weight3 = constraintWeight3;
            }
            float3 position4 = float3.zero;
            quaternion rotation4 = quaternion.identity;
            float3 scale4 = float3.zero;
            float3 weight4 = float3.zero;
            if (fieldConstraintSource0 != null)
            {
                position4 = fieldConstraintSource0.position;
                rotation4 = fieldConstraintSource0.rotation;
                scale4 = fieldConstraintSource0.localScale;
                weight4 = fieldConstraintWeight0;
            }
            Calc(weight0, weight1, weight2, weight3, weight4, position0, position1, position2, position3, position4, rotation0, rotation1, rotation2, rotation3, rotation4, scale0, scale1, scale2, scale3, scale4, offsetPosition, offsetRotation, offsetScale, out var position, out var rotation, out var scale);
            transform.SetPositionAndRotation(position, rotation);
            transform.localScale = scale;
        }

        public ActorAnimationConstraintTransformBone()
        {

        }
    }
}
