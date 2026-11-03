namespace Campus.Photography
{
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::Campus.Photography;
    using global::DG.Tweening;
    using global::UnityEngine;

    public class PhotographyActorLookAtController : CampusActorLookAtController
    {
        private IPhotographyActor _photographyActor;
        public void Initialize(IPhotographyActor photographyActor, CampusCustomLookAtEffector customLookAtEffector)
        {
        }

        private void SetEvent()
        {
        }

        protected override float GetLookAtTypeEaseDuration()
        {
            return default(float);
        }

        protected override Ease GetLookAtTypeEaseToBodyEaseType()
        {
            return default(Ease);
        }

        protected override Ease GetLookAtTypeEaseToEyeEaseType()
        {
            return default(Ease);
        }

        protected override (bool, bool, float) CheckLookTargetLimitAngle([Optional] Transform targetTransform)
        {
            return default((bool, bool, float));
        }

        public PhotographyActorLookAtController()
        {
        }
    }
}
