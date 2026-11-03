namespace VL
{
    using global::UnityEngine;
    using global::VL;

    public interface IVLDefaultActorController<TIDescriptor> : IVLActorController<TIDescriptor>, IVLActorController, IVLTransform where TIDescriptor : IVLDefaultActorDescriptor
    {
        Color color { get; set; }

        Color outlineColor { set; }
    }
}
