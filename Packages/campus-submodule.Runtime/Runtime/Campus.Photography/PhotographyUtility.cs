namespace Campus.Photography
{
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::UnityEngine;

    public static class PhotographyUtility
    {
        private static readonly RaycastHit[] FloorHits;
        public static bool TryGetCameraColliderPosY(Vector3 cameraPos, int layer, out float posY)
        {
            throw null;
        }

        public static float GetCameraLimitAngle(float angle, float limitAngle)
        {
            return default(float);
        }

        public static (bool, bool, float) CheckLookTargetLimitAngle(IPhotographyActor photographyActor, bool isForceUseCameraPosition = false)
        {
            return default((bool, bool, float));
        }

        public static bool CanChangeLookTarget(IPhotographyActor photographyActor, bool isForceUseCameraPosition = false)
        {
            return default(bool);
        }

        private static CampusPhotographySceneLayout GetCurrentSceneLayout()
        {
            return null;
        }
    }
}
