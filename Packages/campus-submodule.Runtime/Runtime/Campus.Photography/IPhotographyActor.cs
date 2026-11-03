namespace Campus.Photography
{
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::UnityEngine;

    public interface IPhotographyActor
    {
        ICampusActorController GetActor();
        LookTargetType GetLookTargetType();
        Transform GetLookTargetTransform();
        void SetConstraintDisable(bool isDisabled)
        {
        }
    }
}
