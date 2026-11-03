namespace ActorAnimation
{
    using global::UnityEngine;

    public enum ActorAnimationConstraintExecuteType
    {
        [InspectorName("通常(ActorAnimationJob)")]
        ActorAnimationJob,
        [InspectorName("最終位置(LateUpdate)")]
        LateUpdate,
        [InspectorName("両方")]
        Both
    }
}
