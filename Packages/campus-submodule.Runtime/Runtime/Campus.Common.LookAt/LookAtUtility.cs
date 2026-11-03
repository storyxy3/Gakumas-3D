namespace Campus.Common.LookAt
{
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::UnityEngine;

    public static class LookAtUtility
    {
        public static (float, float, float) CalcLookTargetLimitAngle(ICampusActorController actor, LookTargetType actorLookTargetType, Transform actorLookTargetTransform, bool isForceUseCameraPosition = false)
        {
            return default((float, float, float));
        }

        public static (float, float, float, float, float, float, float) CalcLookTargetLimitHorizontalVerticalAngleResult(ICampusActorController actor, LookTargetType actorLookTargetType, Transform actorLookTargetTransform, bool isForceUseCameraPosition = false, float horizontalLookOutAngleOverwrite = -1f, float horizontalLookAgainAngleOverwrite = -1f, float verticalLookOutAngleOverwrite = -1f, float verticalLookAgainAngleOverwrite = -1f)
        {
            return default((float, float, float, float, float, float, float));
        }

        public static (bool, bool, float) CheckLookTargetLimitAngle(ICampusActorController actor, LookTargetType actorLookTargetType, Transform actorLookTargetTransform, bool isForceUseCameraPosition = false)
        {
            return default((bool, bool, float));
        }

        public static (bool, bool, float) CheckLookTargetLimitHorizontalVerticalAngle(ICampusActorController actor, LookTargetType actorLookTargetType, Transform actorLookTargetTransform, bool isForceUseCameraPosition = false, float horizontalLookOutAngleOverwrite = -1f, float horizontalLookAgainAngleOverwrite = -1f, float verticalLookOutAngleOverwrite = -1f, float verticalLookAgainAngleOverwrite = -1f)
        {
            return default((bool, bool, float));
        }

        private static (float, float) CalcLocalLookAngles(Quaternion targetRotation, Vector3 targetDir)
        {
            return default((float, float));
        }
    }
}
