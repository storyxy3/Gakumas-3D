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
            // TODO(qa-recon): APK full-body IK execution and its pull/correction solver callees remain unreconstructed.
        }

        private void WriteBack(AnimationStream stream)
        {
        }

        private bool HasLookAtBodyWeight(AnimationStream stream)
        {
            return default(bool);
        }

        private ActorAnimationIKGoalEffector GetEffectorHandle(AvatarIKGoal goal)
        {
            return default(ActorAnimationIKGoalEffector);
        }

        private ActorAnimationFullBodyIKLimbPart GetIKLimbHandle(AvatarIKGoal goal)
        {
            return default(ActorAnimationFullBodyIKLimbPart);
        }

        private void UpdateMoveDelta(AnimationStream stream)
        {
        }

        private void UpdateMove(AnimationStream stream)
        {
        }

        private void SetGaolEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKGoalEffector goalEffector, ActorAnimationIKHintEffector hintEffector)
        {
        }

        private static void SetHintEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKHintEffector hintEffector)
        {
        }

        private static void SetLookAtEffector(AnimationStream stream, float3 moveDelta, ActorAnimationIKLookAtEffector lookAtEffector, ActorAnimationIKCustomLookAtEffector customLookAtEffector)
        {
        }

        private void SetBodyEffector(AnimationStream stream)
        {
        }

        private void SetMaximumExtension(AnimationStream stream, AvatarIKGoal goalKind)
        {
        }

        private void PrepareSolvePull(AnimationStream stream)
        {
        }

        private void PrepareSolvePullUpdateLimbPart(AnimationHumanStream humanStream, AnimationStream stream, Vector3 bodyPosition, float stiffnessValue, AvatarIKGoal goalKind)
        {
        }

        private Vector3 SolvePull(AnimationStream stream)
        {
            return default(Vector3);
        }

        private static Vector3 GetDeltaBodyPosition(ActorAnimationFullBodyIKLimbPart limbPart, Vector3 bodyPosition)
        {
            return default(Vector3);
        }

        private void Solve(AnimationStream stream, bool solvePull = true)
        {
        }

        private void UpdateHipsHorizon(AnimationStream stream)
        {
        }

        private void SetLimbPart(ActorAnimationFullBodyIKLimbPart limbPart, AvatarIKGoal goalKind)
        {
        }

        private ActorAnimationFullBodyIKLimbPart GetLimbPart(AvatarIKGoal goalKind)
        {
            return default(ActorAnimationFullBodyIKLimbPart);
        }

        private void NodAdditive(AnimationStream stream)
        {
        }
    }
}
