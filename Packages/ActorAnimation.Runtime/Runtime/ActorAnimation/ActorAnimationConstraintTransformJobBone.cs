namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationConstraintTransformJobBone : IActorAnimationConstraintJobBone
    {
        private bool _isActive;
        public ActorAnimationConstraintExecuteType executeType;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle constraintSourceHandle0;
        public Vector3Property constraintSourceWeightHandle0;
        public ReadOnlyTransformHandle constraintSourceHandle1;
        public Vector3Property constraintSourceWeightHandle1;
        public ReadOnlyTransformHandle constraintSourceHandle2;
        public Vector3Property constraintSourceWeightHandle2;
        public ReadOnlyTransformHandle constraintSourceHandle3;
        public Vector3Property constraintSourceWeightHandle3;
        public TransformSceneHandle fieldConstraintSourceHandle0;
        public Vector3Property fieldConstraintSourceWeightHandle0;
        public float3 offsetPosition;
        public quaternion offsetRotation;
        public float3 offsetScale;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return drivenHandle.IsValid(stream) && (constraintSourceHandle0.IsValid(stream) || fieldConstraintSourceHandle0.IsValid(stream));
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!constraintSourceHandle0.IsResolved(stream))
            {
                constraintSourceHandle0.Resolve(stream);
                if (!constraintSourceHandle0.IsResolved(stream)) return false;
            }
            if (drivenHandle.IsResolved(stream)) return true;
            drivenHandle.Resolve(stream);
            return drivenHandle.IsResolved(stream);
        }

        public void Execute(AnimationStream stream)
        {
            if (executeType != ActorAnimationConstraintExecuteType.ActorAnimationJob && executeType != ActorAnimationConstraintExecuteType.Both) return;
            float3 position0 = float3.zero;
            quaternion rotation0 = quaternion.identity;
            float3 scale0 = float3.zero;
            float3 weight0 = float3.zero;
            if (constraintSourceHandle0.IsValid(stream))
            {
                position0 = constraintSourceHandle0.GetPosition(stream);
                rotation0 = constraintSourceHandle0.GetRotation(stream);
                scale0 = constraintSourceHandle0.GetLocalScale(stream);
                weight0 = constraintSourceWeightHandle0.Get(stream);
            }
            float3 position1 = float3.zero;
            quaternion rotation1 = quaternion.identity;
            float3 scale1 = float3.zero;
            float3 weight1 = float3.zero;
            if (constraintSourceHandle1.IsValid(stream))
            {
                position1 = constraintSourceHandle1.GetPosition(stream);
                rotation1 = constraintSourceHandle1.GetRotation(stream);
                scale1 = constraintSourceHandle1.GetLocalScale(stream);
                weight1 = constraintSourceWeightHandle1.Get(stream);
            }
            float3 position2 = float3.zero;
            quaternion rotation2 = quaternion.identity;
            float3 scale2 = float3.zero;
            float3 weight2 = float3.zero;
            if (constraintSourceHandle2.IsValid(stream))
            {
                position2 = constraintSourceHandle2.GetPosition(stream);
                rotation2 = constraintSourceHandle2.GetRotation(stream);
                scale2 = constraintSourceHandle2.GetLocalScale(stream);
                weight2 = constraintSourceWeightHandle2.Get(stream);
            }
            float3 position3 = float3.zero;
            quaternion rotation3 = quaternion.identity;
            float3 scale3 = float3.zero;
            float3 weight3 = float3.zero;
            if (constraintSourceHandle3.IsValid(stream))
            {
                position3 = constraintSourceHandle3.GetPosition(stream);
                rotation3 = constraintSourceHandle3.GetRotation(stream);
                scale3 = constraintSourceHandle3.GetLocalScale(stream);
                weight3 = constraintSourceWeightHandle3.Get(stream);
            }
            float3 position4 = float3.zero;
            quaternion rotation4 = quaternion.identity;
            float3 scale4 = float3.zero;
            float3 weight4 = float3.zero;
            if (fieldConstraintSourceHandle0.IsValid(stream))
            {
                position4 = fieldConstraintSourceHandle0.GetPosition(stream);
                rotation4 = fieldConstraintSourceHandle0.GetRotation(stream);
                scale4 = fieldConstraintSourceHandle0.GetLocalScale(stream);
                weight4 = fieldConstraintSourceWeightHandle0.Get(stream);
            }
            ActorAnimationConstraintTransformBone.Calc(weight0, weight1, weight2, weight3, weight4, position0, position1, position2, position3, position4, rotation0, rotation1, rotation2, rotation3, rotation4, scale0, scale1, scale2, scale3, scale4, offsetPosition, offsetRotation, offsetScale, out var position, out var rotation, out var scale);
            drivenHandle.SetGlobalTR(stream, position, rotation, false);
            drivenHandle.SetLocalScale(stream, scale);
        }

        public ActorAnimationConstraintTransformJobBone(ActorAnimationConstraintTransformBone bone, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, bone.transform);
            if (bone.constraintSource0 != null)
            {
                constraintSourceHandle0 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource0);
                constraintSourceWeightHandle0 = Vector3Property.Bind(animator, bone, "constraintWeight0");
            }
            else
            {
                constraintSourceHandle0 = default;
                constraintSourceWeightHandle0 = default;
            }
            if (bone.constraintSource1 != null)
            {
                constraintSourceHandle1 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource1);
                constraintSourceWeightHandle1 = Vector3Property.Bind(animator, bone, "constraintWeight1");
            }
            else
            {
                constraintSourceHandle1 = default;
                constraintSourceWeightHandle1 = default;
            }
            if (bone.constraintSource2 != null)
            {
                constraintSourceHandle2 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource2);
                constraintSourceWeightHandle2 = Vector3Property.Bind(animator, bone, "constraintWeight2");
            }
            else
            {
                constraintSourceHandle2 = default;
                constraintSourceWeightHandle2 = default;
            }
            if (bone.constraintSource3 != null)
            {
                constraintSourceHandle3 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource3);
                constraintSourceWeightHandle3 = Vector3Property.Bind(animator, bone, "constraintWeight3");
            }
            else
            {
                constraintSourceHandle3 = default;
                constraintSourceWeightHandle3 = default;
            }
            if (bone.fieldConstraintSource0 != null)
            {
                fieldConstraintSourceHandle0 = animator.BindSceneTransform(bone.fieldConstraintSource0);
                fieldConstraintSourceWeightHandle0 = Vector3Property.Bind(animator, bone, "fieldConstraintWeight0");
            }
            else
            {
                fieldConstraintSourceHandle0 = default;
                fieldConstraintSourceWeightHandle0 = default;
            }
            offsetPosition = bone.offsetPosition;
            offsetRotation = bone.offsetRotation;
            offsetScale = bone.offsetScale;
            executeType = bone.executeType;
        }

        public void Update(ActorAnimationConstraintTransformBone bone)
        {
            _isActive = true;
            offsetPosition = bone.offsetPosition;
            offsetRotation = bone.offsetRotation;
            offsetScale = bone.offsetScale;
            executeType = bone.executeType;
        }

        public void UpdateSource(ActorAnimationConstraintTransformBone bone, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, bone.transform);
            if (bone.constraintSource0 != null)
            {
                constraintSourceHandle0 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource0);
                constraintSourceWeightHandle0 = Vector3Property.Bind(animator, bone, "constraintWeight0");
            }
            else
            {
                constraintSourceHandle0 = default;
                constraintSourceWeightHandle0 = default;
            }
            if (bone.constraintSource1 != null)
            {
                constraintSourceHandle1 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource1);
                constraintSourceWeightHandle1 = Vector3Property.Bind(animator, bone, "constraintWeight1");
            }
            else
            {
                constraintSourceHandle1 = default;
                constraintSourceWeightHandle1 = default;
            }
            if (bone.constraintSource2 != null)
            {
                constraintSourceHandle2 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource2);
                constraintSourceWeightHandle2 = Vector3Property.Bind(animator, bone, "constraintWeight2");
            }
            else
            {
                constraintSourceHandle2 = default;
                constraintSourceWeightHandle2 = default;
            }
            if (bone.constraintSource3 != null)
            {
                constraintSourceHandle3 = ReadOnlyTransformHandle.Bind(animator, bone.constraintSource3);
                constraintSourceWeightHandle3 = Vector3Property.Bind(animator, bone, "constraintWeight3");
            }
            else
            {
                constraintSourceHandle3 = default;
                constraintSourceWeightHandle3 = default;
            }
            if (bone.fieldConstraintSource0 != null)
            {
                fieldConstraintSourceHandle0 = animator.BindSceneTransform(bone.fieldConstraintSource0);
                fieldConstraintSourceWeightHandle0 = Vector3Property.Bind(animator, bone, "fieldConstraintWeight0");
            }
            else
            {
                fieldConstraintSourceHandle0 = default;
                fieldConstraintSourceWeightHandle0 = default;
            }
            offsetPosition = bone.offsetPosition;
            offsetRotation = bone.offsetRotation;
            offsetScale = bone.offsetScale;
            executeType = bone.executeType;
        }
    }
}
