namespace Campus.Common
{
    using global::Campus.Common;
    using global::VL;

    public interface ICampusActorDescriptor : IVLDefaultActorDescriptor, IVLActorDescriptor
    {
        string uniqueId { get; }

        bool autoBlinkDisabled { get; }

        bool useADVSettings { get; }

        bool correctSkeletonToCmmnHeight { get; }

        CampusActorAnimationJointLimitSetting jointLimitSetting { get; set; }

        string GetCharacterId();
    }
}
