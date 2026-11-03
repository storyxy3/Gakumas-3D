namespace VL.IK
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::VL.IK;

    [BurstCompile]
    public struct FullBodyIKJob : IAnimationJob
    {
        public struct EffectorHandle
        {
            public TransformStreamHandle effector;
        }

        public struct HintEffectorHandle
        {
            public TransformStreamHandle hint;
        }

        public struct LookEffectorHandle
        {
            public TransformStreamHandle lookAt;
            public PropertyStreamHandle eyesWeight;
            public PropertyStreamHandle headWeight;
            public PropertyStreamHandle bodyWeight;
            public PropertySceneHandle customUseWeight;
            public TransformSceneHandle customLookAt;
            public PropertySceneHandle customWeight;
            public PropertySceneHandle customEyesWeight;
            public PropertySceneHandle customHeadWeight;
            public PropertySceneHandle customBodyWeight;
            public PropertySceneHandle useCustomTargetPosition;
            public PropertySceneHandle customTargetPositionX;
            public PropertySceneHandle customTargetPositionY;
            public PropertySceneHandle customTargetPositionZ;
        }

        public struct BodyEffectorHandle
        {
            public TransformStreamHandle body;
        }

        public struct IKLimbHandle
        {
            public TransformStreamHandle top;
            public TransformStreamHandle middle;
            public TransformStreamHandle end;
            public float maximumExtension;
        }

        public struct MoveHandle
        {
            public TransformStreamHandle reference;
            public TransformStreamHandle target;
            public TransformStreamHandle skeleton;
        }

        private struct LimbPart
        {
            public Vector3 localPosition;
            public Vector3 goalPosition;
            public float goalWeight;
            public float goalPullWeight;
            public float maximumExtension;
            public float stiffness;
        }

        public EffectorHandle leftFootEffector;
        public EffectorHandle rightFootEffector;
        public EffectorHandle leftHandEffector;
        public EffectorHandle rightHandEffector;
        public HintEffectorHandle leftKneeHintEffector;
        public HintEffectorHandle rightKneeHintEffector;
        public HintEffectorHandle leftElbowHintEffector;
        public HintEffectorHandle rightElbowHintEffector;
        public LookEffectorHandle lookAtEffector;
        public BodyEffectorHandle bodyEffector;
        public Vector3 bodyPosition;
        public IKLimbHandle leftArm;
        public IKLimbHandle rightArm;
        public IKLimbHandle leftLeg;
        public IKLimbHandle rightLeg;
        public MoveHandle move;
        public PropertySceneHandle lookAtClampWeight;
        public PropertySceneHandle stiffness;
        public PropertySceneHandle maxPullIteration;
        public PropertySceneHandle handDown;
        private Vector3 _moveDelta;
        private EffectorHandle GetEffectorHandle(AvatarIKGoal goal)
        {
            return default(EffectorHandle);
        }

        private IKLimbHandle GetIKLimbHandle(AvatarIKGoal goal)
        {
            return default(IKLimbHandle);
        }

        private void UpdateMoveDelta(AnimationStream stream)
        {
        }

        private void UpdateMove(AnimationStream stream)
        {
        }

        private void SetEffector(AnimationStream stream, AvatarIKGoal goal, ref EffectorHandle handle)
        {
        }

        private void SetHintEffector(AnimationStream stream, AvatarIKHint goal, ref HintEffectorHandle handle)
        {
        }

        private void SetLookAtEffector(AnimationStream stream, ref LookEffectorHandle handle)
        {
        }

        private void SetBodyEffector(AnimationStream stream, ref BodyEffectorHandle handle)
        {
        }

        private void SetMaximumExtension(AnimationStream stream, ref IKLimbHandle handle)
        {
        }

        private void PrepareSolvePull(AnimationStream stream, NativeArray<LimbPart> limbParts)
        {
        }

        private Vector3 SolvePull(AnimationStream stream)
        {
            return default(Vector3);
        }

        private void Solve(AnimationStream stream)
        {
        }

        private void UpdateHipsHorizon(AnimationStream stream)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }

        public void ProcessAnimation(AnimationStream stream)
        {
        }
    }
}
