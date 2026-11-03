namespace Campus.Photography
{
    using global::Campus.Common.LookAt;
    using global::UnityEngine;

    public class PhotographyConstraint : CampusLookAtConstraint
    {
        protected override bool IsEnableUpdate()
        {
            return default(bool);
        }

        protected override float GetLookAtEasingMinSpeed()
        {
            return default(float);
        }

        protected override float GetLookAtEasingMaxAngle()
        {
            return default(float);
        }

        protected override float GetLookAtEasingMaxSpeed()
        {
            return default(float);
        }

        protected override AnimationCurve GetLookAtEasingAnimationCurve()
        {
            return null;
        }

        public PhotographyConstraint()
        {
        }
    }
}
