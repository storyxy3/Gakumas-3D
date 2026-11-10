namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    [Serializable]
    public struct ActorAnimationFullBodyIKJobSkeleton
    {
        public ActorAnimationIKBodyEffector bodyEffector;
        public ActorAnimationIKGoalEffector leftFootEffector;
        public ActorAnimationIKGoalEffector rightFootEffector;
        public ActorAnimationIKGoalEffector leftHandEffector;
        public ActorAnimationIKGoalEffector rightHandEffector;
        public ActorAnimationIKHintEffector leftKneeHintEffector;
        public ActorAnimationIKHintEffector rightKneeHintEffector;
        public ActorAnimationIKHintEffector leftElbowHintEffector;
        public ActorAnimationIKHintEffector rightElbowHintEffector;
        public ActorAnimationIKLookAtEffector lookAtEffector;
        public ActorAnimationIKCustomLookAtEffector customLookAtEffector;
        public ActorAnimationFullBodyIKLimbPart rightArmLimb;
        public ActorAnimationFullBodyIKLimbPart leftArmLimb;
        public ActorAnimationFullBodyIKLimbPart rightLegLimb;
        public ActorAnimationFullBodyIKLimbPart leftLegLimb;
        public ActorAnimationFullBodyIKMovePart move;
        public ActorAnimationFullBodyIKPullPart pull;
        public NativeArray<ActorAnimationIKCorrectionJobCollider> correctionColliders;
        public ActorAnimationIKCorrectionJobGoal correctionGoalRightHand;
        public ActorAnimationIKCorrectionJobGoal correctionGoalLeftHand;
        public ActorAnimationNodAdditiveJob nodAdditiveJob;
        public ActorAnimationFullBodyIKWriteBack writeBack;
        public void Execute(AnimationStream stream)
        {
            WriteBack(stream);
            UpdateMoveDelta(stream);
            UpdateHipsHorizon(stream);
            SetMaximumExtension(stream, AvatarIKGoal.LeftHand);
            SetMaximumExtension(stream, AvatarIKGoal.RightHand);
            SetMaximumExtension(stream, AvatarIKGoal.LeftFoot);
            SetMaximumExtension(stream, AvatarIKGoal.RightFoot);
            SetBodyEffector(stream);
            bool hasBodyWeight = HasLookAtBodyWeight(stream);
            if (hasBodyWeight)
            {
                SetLookAtEffector(stream, move.moveDelta, lookAtEffector, customLookAtEffector);
                stream.AsHuman().SolveIK();
            }
            SetGaolEffector(stream, move.moveDelta, leftFootEffector, leftKneeHintEffector);
            SetGaolEffector(stream, move.moveDelta, rightFootEffector, rightKneeHintEffector);
            SetGaolEffector(stream, move.moveDelta, leftHandEffector, leftElbowHintEffector);
            SetGaolEffector(stream, move.moveDelta, rightHandEffector, rightElbowHintEffector);
            SetHintEffector(stream, move.moveDelta, leftKneeHintEffector);
            SetHintEffector(stream, move.moveDelta, rightKneeHintEffector);
            SetHintEffector(stream, move.moveDelta, leftElbowHintEffector);
            SetHintEffector(stream, move.moveDelta, rightElbowHintEffector);
            if (!hasBodyWeight) SetLookAtEffector(stream, move.moveDelta, lookAtEffector, customLookAtEffector);
            Solve(stream);
            NodAdditive(stream);
            UpdateMove(stream);
        }

        private void WriteBack(AnimationStream stream)
        {
            if (!writeBack.headTransformHandle.IsValid(stream)
                || !writeBack.headOriginalPositionXWriteBackPropertyHandle.IsValid(stream)
                || !writeBack.headOriginalPositionYWriteBackPropertyHandle.IsValid(stream)
                || !writeBack.headOriginalPositionZWriteBackPropertyHandle.IsValid(stream)
                || !writeBack.headOriginalRotationXWriteBackPropertyHandle.IsValid(stream)
                || !writeBack.headOriginalRotationYWriteBackPropertyHandle.IsValid(stream)
                || !writeBack.headOriginalRotationZWriteBackPropertyHandle.IsValid(stream)) return;
            var position = writeBack.headTransformHandle.GetPosition(stream);
            writeBack.headOriginalPositionXWriteBackPropertyHandle.SetFloat(stream, position.x);
            writeBack.headOriginalPositionYWriteBackPropertyHandle.SetFloat(stream, position.y);
            writeBack.headOriginalPositionZWriteBackPropertyHandle.SetFloat(stream, position.z);
            var rotation = writeBack.headTransformHandle.GetRotation(stream).eulerAngles;
            writeBack.headOriginalRotationXWriteBackPropertyHandle.SetFloat(stream, rotation.x);
            writeBack.headOriginalRotationYWriteBackPropertyHandle.SetFloat(stream, rotation.y);
            writeBack.headOriginalRotationZWriteBackPropertyHandle.SetFloat(stream, rotation.z);
        }

        private bool HasLookAtBodyWeight(AnimationStream stream)
        {
            float weight = -1f;
            float bodyWeight = 0f;
            if (lookAtEffector.referenceHandle.IsValid(stream))
            {
                float x = lookAtEffector.referenceHandle.GetLocalScale(stream).x;
                if (x > 0.001f)
                {
                    weight = x;
                    bodyWeight = lookAtEffector.bodyWeightHandle.GetFloat(stream);
                }
            }
            if (customLookAtEffector.customUseWeightHandle.IsValid(stream))
            {
                float customWeight = customLookAtEffector.customUseWeightHandle.GetFloat(stream);
                float blend = weight >= 0f ? customWeight : 1f;
                weight = math.lerp(weight, customLookAtEffector.customUseWeightHandle.GetFloat(stream), blend);
                bodyWeight = weight * math.lerp(bodyWeight, customLookAtEffector.bodyWeightHandle.GetFloat(stream), blend);
            }
            return bodyWeight > 0.00000001f;
        }

        private ActorAnimationIKGoalEffector GetEffectorHandle(AvatarIKGoal goal)
        {
            switch (goal)
            {
                case AvatarIKGoal.RightFoot: return rightFootEffector;
                case AvatarIKGoal.LeftHand: return leftHandEffector;
                case AvatarIKGoal.RightHand: return rightHandEffector;
                default: return leftFootEffector;
            }
        }

        private ActorAnimationFullBodyIKLimbPart GetIKLimbHandle(AvatarIKGoal goal)
        {
            switch (goal)
            {
                case AvatarIKGoal.RightFoot: return rightLegLimb;
                case AvatarIKGoal.LeftHand: return leftArmLimb;
                case AvatarIKGoal.RightHand: return rightArmLimb;
                default: return leftLegLimb;
            }
        }

        private void UpdateMoveDelta(AnimationStream stream)
        {
            Vector3 delta = default;
            if (move.referenceHandle.IsValid(stream) && move.targetHandle.IsValid(stream))
            {
                var reference = move.referenceHandle.GetPosition(stream);
                var target = move.targetHandle.GetPosition(stream);
                delta = target - reference;
                delta.y = 0f;
            }
            move.moveDelta = delta;
        }

        private void UpdateMove(AnimationStream stream)
        {
            if (move.referenceHandle.IsValid(stream) && move.targetHandle.IsValid(stream))
                move.targetHandle.SetPosition(stream, move.referenceHandle.GetPosition(stream));
        }

        private void SetGaolEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKGoalEffector goalEffector, ActorAnimationIKHintEffector hintEffector)
        {
            if (!goalEffector.IsValid(stream)) return;
            var human = stream.AsHuman();
            var scale = goalEffector.GetLocalScale(stream);
            float positionWeight = scale.x;
            float rotationWeight = scale.y;
            bool hasWeight = math.max((double)scale.x, (double)scale.y) > 0.00001;
            float correctionWeight = hintEffector.GetLocalScale(stream).y;
            Vector3 position;
            quaternion rotation;
            if ((uint)goalEffector.goal <= 1)
            {
                if (!hasWeight) return;
                position = math.lerp((float3)human.GetGoalPosition(goalEffector.goal), (float3)goalEffector.GetPosition(stream), positionWeight);
                rotation = math.slerp(human.GetGoalRotation(goalEffector.goal), goalEffector.GetRotation(stream), rotationWeight);
            }
            else
            {
                position = goalEffector.GetPosition(stream);
                rotation = goalEffector.GetRotation(stream);
                var correctionGoal = goalEffector.goal == AvatarIKGoal.LeftHand ? correctionGoalLeftHand : correctionGoalRightHand;
                bool enabled = correctionGoal.enableHandle.IsValid(stream) && correctionGoal.enableHandle.GetBool(stream);
                bool validCollider = correctionColliders.IsCreated && correctionColliders.Length > 0 && correctionColliders[0].referenceHandle.IsValid(stream);
                if ((hasWeight || enabled && validCollider) && correctionWeight > 0.00000001f)
                {
                    var endHandle = GetLimbPart(goalEffector.goal).endHandle;
                    float radius = correctionGoal.radiusHandle.GetFloat(stream);
                    var endPosition = endHandle.GetPosition(stream);
                    var endRotation = endHandle.GetRotation(stream);
                    float3 offset = new float3(correctionGoal.offsetXHandle.GetFloat(stream), correctionGoal.offsetYHandle.GetFloat(stream), correctionGoal.offsetZHandle.GetFloat(stream));
                    Vector3 goalPosition = endPosition + (Vector3)math.rotate(endRotation, offset);
                    var nearest = new ActorAnimationIKCorrectionColliderCollisionInfo { Distance = float.MaxValue };
                    foreach (var collider in correctionColliders)
                    {
                        if (collider.radius < 1E-05) continue;
                        ActorAnimationIKCorrectionColliderCollisionInfo info;
                        switch (collider.type)
                        {
                            case ActorAnimationIKCorrectionColliderType.Sphere:
                                info = ActorAnimationFullBodyIKCalcUtility.CalcSphereCollisionInfo(stream, collider, goalPosition, radius);
                                break;
                            case ActorAnimationIKCorrectionColliderType.Capsule:
                                info = ActorAnimationFullBodyIKCalcUtility.CalcCapsuleCollisionInfo(stream, collider, goalPosition, radius);
                                break;
                            default:
                                Debug.LogError("Ik補正コライダー：想定していない形状タイプです。");
                                continue;
                        }
                        if (info.Distance < nearest.Distance) nearest = info;
                    }
                    if (ActorAnimationFullBodyIKCalcUtility.CalcGoalPosition(ref position, ref nearest, goalPosition, radius, ref correctionWeight))
                    {
                        positionWeight = correctionWeight;
                        position -= (Vector3)moveDelta;
                    }
                    else positionWeight = 0f;
                }
            }
            human.SetGoalPosition(goalEffector.goal, position + (Vector3)moveDelta);
            human.SetGoalWeightPosition(goalEffector.goal, positionWeight);
            human.SetGoalRotation(goalEffector.goal, rotation);
            human.SetGoalWeightRotation(goalEffector.goal, rotationWeight);
        }

        private static void SetHintEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKHintEffector hintEffector)
        {
            if (!hintEffector.IsValid(stream)) return;
            float weight = hintEffector.GetLocalScale(stream).x;
            if (weight < 1E-05) return;
            var human = stream.AsHuman();
            float3 position = human.GetHintPosition(hintEffector.hint);
            float3 target = hintEffector.GetPosition(stream);
            human.SetHintPosition(hintEffector.hint, moveDelta + math.lerp(position, target, weight));
            human.SetHintWeightPosition(hintEffector.hint, weight);
        }

        private static void SetLookAtEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKLookAtEffector lookAtEffector, ActorAnimationIKCustomLookAtEffector customLookAtEffector)
        {
            float3 weights = float3.zero;
            Vector3 position = Vector3.zero;
            float weight = -1f;
            if (lookAtEffector.referenceHandle.IsValid(stream))
            {
                float x = lookAtEffector.referenceHandle.GetLocalScale(stream).x;
                if (x > 0.001f)
                {
                    position = lookAtEffector.referenceHandle.GetPosition(stream);
                    weights.x = lookAtEffector.eyesWeightHandle.GetFloat(stream);
                    weights.y = lookAtEffector.headWeightHandle.GetFloat(stream);
                    weights.z = lookAtEffector.bodyWeightHandle.GetFloat(stream);
                    weight = x;
                }
            }
            if (customLookAtEffector.customUseWeightHandle.IsValid(stream))
            {
                float customWeight = customLookAtEffector.customUseWeightHandle.GetFloat(stream);
                Vector3 target;
                if (customLookAtEffector.useCustomTargetPositionHandle.GetBool(stream))
                    target = new Vector3(customLookAtEffector.customTargetPositionXHandle.GetFloat(stream),
                        customLookAtEffector.customTargetPositionYHandle.GetFloat(stream), customLookAtEffector.customTargetPositionZHandle.GetFloat(stream));
                else target = customLookAtEffector.referenceHandle.GetPosition(stream);
                float blend = weight >= 0f ? customWeight : 1f;
                position = Vector3.Lerp(position, target, blend);
                weight = math.lerp(weight, customLookAtEffector.customUseWeightHandle.GetFloat(stream), blend);
                float eyes = customLookAtEffector.eyesWeightHandle.GetFloat(stream);
                float head = customLookAtEffector.headWeightHandle.GetFloat(stream);
                float body = customLookAtEffector.bodyWeightHandle.GetFloat(stream);
                weights.x = weight * math.lerp(weights.x, eyes, blend);
                weights.y = weight * math.lerp(weights.y, head, blend);
                weights.z = weight * math.lerp(weights.z, body, blend);
            }
            if (weight >= 0f)
            {
                var human = stream.AsHuman();
                human.SetLookAtPosition(position + (Vector3)moveDelta);
                human.SetLookAtEyesWeight(weights.x);
                human.SetLookAtHeadWeight(weights.y);
                human.SetLookAtBodyWeight(weights.z);
            }
        }

        private void SetBodyEffector(AnimationStream stream)
        {
            if (!bodyEffector.IsValid(stream)) return;
            float weight = bodyEffector.GetLocalScale(stream).x;
            var human = stream.AsHuman();
            var position = human.bodyPosition;
            var rotation = human.bodyRotation;
            position.y = math.lerp(position.y, bodyEffector.GetPosition(stream).y, weight);
            rotation = math.slerp(rotation, bodyEffector.GetRotation(stream), weight);
            human.bodyPosition = position;
            human.bodyRotation = rotation;
        }

        private void SetMaximumExtension(AnimationStream stream, AvatarIKGoal goalKind)
        {
            var limb = GetLimbPart(goalKind);
            if (limb.maximumExtension == 0f && limb.topHandle.IsValid(stream) && limb.middleHandle.IsValid(stream) && limb.endHandle.IsValid(stream))
            {
                var top = limb.topHandle.GetPosition(stream);
                var middle = limb.middleHandle.GetPosition(stream);
                var end = limb.endHandle.GetPosition(stream);
                limb.maximumExtension = Vector3.Distance(top, middle) + Vector3.Distance(middle, end);
            }
            SetLimbPart(limb, goalKind);
        }

        private void PrepareSolvePull(AnimationStream stream)
        {
            var human = stream.AsHuman();
            var bodyPosition = human.bodyPosition;
            float stiffness = pull.stiffnessHandle.GetFloat(stream);
            PrepareSolvePullUpdateLimbPart(human, stream, bodyPosition, stiffness, AvatarIKGoal.LeftHand);
            PrepareSolvePullUpdateLimbPart(human, stream, bodyPosition, stiffness, AvatarIKGoal.RightHand);
            PrepareSolvePullUpdateLimbPart(human, stream, bodyPosition, stiffness, AvatarIKGoal.LeftFoot);
            PrepareSolvePullUpdateLimbPart(human, stream, bodyPosition, stiffness, AvatarIKGoal.RightFoot);
        }

        private void PrepareSolvePullUpdateLimbPart(AnimationHumanStream humanStream, AnimationStream stream, Vector3 bodyPosition, float stiffnessValue, AvatarIKGoal goalKind)
        {
            var limb = GetLimbPart(goalKind);
            var effector = GetEffectorHandle(goalKind);
            var ikLimb = GetIKLimbHandle(goalKind);
            var position = ikLimb.topHandle.GetPosition(stream);
            limb.maximumExtension = ikLimb.maximumExtension;
            float pullWeight = effector.IsValid(stream) ? effector.GetLocalScale(stream).z : 0f;
            limb.localPosition = position - bodyPosition;
            limb.goalPosition = humanStream.GetGoalPosition(goalKind);
            limb.goalWeight = humanStream.GetGoalWeightPosition(goalKind);
            limb.goalPullWeight = pullWeight;
            limb.stiffness = stiffnessValue;
            SetLimbPart(limb, goalKind);
        }

        private Vector3 SolvePull(AnimationStream stream)
        {
            var human = stream.AsHuman();
            var originalPosition = human.bodyPosition;
            var position = originalPosition;
            PrepareSolvePull(stream);
            int iterations = pull.maxPullIterationHandle.GetInt(stream);
            for (int i = iterations; i > 0; i--)
            {
                Vector3 delta = Vector3.zero;
                delta += GetDeltaBodyPosition(leftArmLimb, position);
                delta += GetDeltaBodyPosition(rightArmLimb, position);
                delta += GetDeltaBodyPosition(leftLegLimb, position);
                delta += GetDeltaBodyPosition(rightLegLimb, position);
                position += delta / i;
            }
            return position - originalPosition;
        }

        private static Vector3 GetDeltaBodyPosition(ActorAnimationFullBodyIKLimbPart limbPart, Vector3 bodyPosition)
        {
            Vector3 difference = (Vector3)limbPart.goalPosition - (bodyPosition + (Vector3)limbPart.localPosition);
            float distance = difference.magnitude;
            Vector3 direction = difference.normalized;
            float extension = math.max((distance - limbPart.maximumExtension) * limbPart.stiffness, 0f);
            return direction * extension * limbPart.goalPullWeight * limbPart.goalWeight;
        }

        private void Solve(AnimationStream stream, bool solvePull = true)
        {
            var human = stream.AsHuman();
            if (solvePull) human.bodyPosition += SolvePull(stream);
            human.SolveIK();
        }

        private void UpdateHipsHorizon(AnimationStream stream)
        {
            if (move.skeletonHandle.IsValid(stream))
            {
                var localPosition = move.skeletonHandle.GetLocalPosition(stream);
                localPosition.x = 0f;
                localPosition.z = 0f;
                move.skeletonHandle.SetLocalPosition(stream, localPosition);
            }
        }

        private void SetLimbPart(ActorAnimationFullBodyIKLimbPart limbPart, AvatarIKGoal goalKind)
        {
            switch (goalKind)
            {
                case AvatarIKGoal.LeftFoot: leftLegLimb = limbPart; break;
                case AvatarIKGoal.LeftHand: leftArmLimb = limbPart; break;
                case AvatarIKGoal.RightHand: rightArmLimb = limbPart; break;
                default: rightLegLimb = limbPart; break;
            }
        }

        private ActorAnimationFullBodyIKLimbPart GetLimbPart(AvatarIKGoal goalKind)
        {
            switch (goalKind)
            {
                case AvatarIKGoal.LeftFoot: return leftLegLimb;
                case AvatarIKGoal.LeftHand: return leftArmLimb;
                case AvatarIKGoal.RightHand: return rightArmLimb;
                default: return rightLegLimb;
            }
        }

        private void NodAdditive(AnimationStream stream)
        {
            if (!nodAdditiveJob.nodAdditiveNeckFrontBackWeight.IsValid(stream)
                || !nodAdditiveJob.nodAdditiveNeckLeftRightWeight.IsValid(stream)
                || !nodAdditiveJob.nodAdditiveNeckRollLeftRightWeight.IsValid(stream)
                || !nodAdditiveJob.nodAdditiveHeadFrontBackWeight.IsValid(stream)
                || !nodAdditiveJob.nodAdditiveHeadLeftRightWeight.IsValid(stream)
                || !nodAdditiveJob.nodAdditiveHeadRollLeftRightWeight.IsValid(stream)) return;
            var human = stream.AsHuman();
            human.SetMuscle(nodAdditiveJob.neckFrontBackMuscleHandle, human.GetMuscle(nodAdditiveJob.neckFrontBackMuscleHandle) + nodAdditiveJob.nodAdditiveNeckFrontBackWeight.GetFloat(stream));
            human.SetMuscle(nodAdditiveJob.neckLeftRightMuscleHandle, human.GetMuscle(nodAdditiveJob.neckLeftRightMuscleHandle) + nodAdditiveJob.nodAdditiveNeckLeftRightWeight.GetFloat(stream));
            human.SetMuscle(nodAdditiveJob.neckRollLeftRightMuscleHandle, human.GetMuscle(nodAdditiveJob.neckRollLeftRightMuscleHandle) + nodAdditiveJob.nodAdditiveNeckRollLeftRightWeight.GetFloat(stream));
            human.SetMuscle(nodAdditiveJob.headFrontBackMuscleHandle, human.GetMuscle(nodAdditiveJob.headFrontBackMuscleHandle) + nodAdditiveJob.nodAdditiveHeadFrontBackWeight.GetFloat(stream));
            human.SetMuscle(nodAdditiveJob.headLeftRightMuscleHandle, human.GetMuscle(nodAdditiveJob.headLeftRightMuscleHandle) + nodAdditiveJob.nodAdditiveHeadLeftRightWeight.GetFloat(stream));
            human.SetMuscle(nodAdditiveJob.headRollLeftRightMuscleHandle, human.GetMuscle(nodAdditiveJob.headRollLeftRightMuscleHandle) + nodAdditiveJob.nodAdditiveHeadRollLeftRightWeight.GetFloat(stream));
        }
    }
}
