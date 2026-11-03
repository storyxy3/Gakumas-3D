namespace Common.Live
{
    using global::System;
    using global::Common.Live;
    using global::JetBrains.Annotations;

    [Serializable]
    public class OverrideActorHierarchyTransform
    {
        public int actorIndex;
        [CanBeNull]
        public OverrideHierarchyTransforms[] hierarchyTransforms;
        public OverrideActorHierarchyTransform()
        {
        }
    }
}
