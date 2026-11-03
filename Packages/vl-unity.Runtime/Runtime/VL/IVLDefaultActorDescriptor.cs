namespace VL
{
    using global::VL;

    public interface IVLDefaultActorDescriptor : IVLActorDescriptor
    {
        bool humanoid { get; }

        VLActorColliderType colliderType { get; }

        bool colliderTrigger { get; }
    }
}
