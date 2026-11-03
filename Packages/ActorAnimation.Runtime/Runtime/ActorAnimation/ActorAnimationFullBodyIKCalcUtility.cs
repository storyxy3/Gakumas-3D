namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public static class ActorAnimationFullBodyIKCalcUtility
    {
        public static ActorAnimationIKCorrectionColliderCollisionInfo CalcSphereCollisionInfo(AnimationStream stream, ActorAnimationIKCorrectionJobCollider correctionCollider, Vector3 goalPosition, float goalRadius)
        {
            return default(ActorAnimationIKCorrectionColliderCollisionInfo);
        }

        public static ActorAnimationIKCorrectionColliderCollisionInfo CalcCapsuleCollisionInfo(AnimationStream stream, ActorAnimationIKCorrectionJobCollider correctionCollider, Vector3 goalPosition, float goalRadius)
        {
            return default(ActorAnimationIKCorrectionColliderCollisionInfo);
        }

        public static bool CalcGoalPosition(ref Vector3 resultGaolPosition, ref ActorAnimationIKCorrectionColliderCollisionInfo info, Vector3 goalPosition, float goalRadius, ref float correctionWeight)
        {
            return default(bool);
        }
    }
}
